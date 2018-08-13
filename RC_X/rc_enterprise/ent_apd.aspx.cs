using DevExpress.Web;
using DevExpress.Web.ASPxRichEdit;
using DevExpress.Web.ASPxSpreadsheet;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace RC_X.rc_enterprise
{
    public partial class ent_apd : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            if (!rc_services.CheckPermission("ent_apd")) { Response.Redirect("~/controls/unauthorized.aspx"); }
            gridAPD.Columns[0].Visible = rc_services.CheckPermission("ent_apd_edit");
        
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            BindAPD();
        }

        protected void gridAPD_BatchUpdate(object sender, DevExpress.Web.Data.ASPxDataBatchUpdateEventArgs e)
        {
            var listInsert = new List<EnterpriseAPD>();
            foreach (var args in e.InsertValues)
            {
                //InsertNewItem(args.NewValues);
                EnterpriseAPD EntAPD = new EnterpriseAPD();
                EntAPD.APDtype = Convert.ToString(args.NewValues["APDtype"]);
                EntAPD.APDNumber = Convert.ToString(args.NewValues["APDNumber"]);
                EntAPD.APDName = Convert.ToString(args.NewValues["APDName"]);
                EntAPD.Description = Convert.ToString(args.NewValues["Description"]);
                EntAPD.StartDate = Convert.ToDateTime(args.NewValues["StartDate"]);
                EntAPD.EndDate = Convert.ToDateTime(args.NewValues["EndDate"]);
                listInsert.Add(EntAPD);
            }
            if (listInsert.Count > 0)
            {
                rtm_services.InsertNewEnterpriseAPD(listInsert);
            }
            var listUpdates = new List<EnterpriseAPD>();
            foreach (var args in e.UpdateValues)
            {
                EnterpriseAPD Apd = new EnterpriseAPD();
                //Apd.Id = Convert.ToString(args.Keys["Id"]);
                Apd.APDtype = Convert.ToString(args.NewValues["APDtype"]);
                Apd.APDNumber = Convert.ToString(args.NewValues["APDNumber"]);
                Apd.APDName = Convert.ToString(args.NewValues["APDName"]);
                Apd.Description = Convert.ToString(args.NewValues["Description"]);
                Apd.StartDate = Convert.ToDateTime(args.NewValues["StartDate"]);
                Apd.EndDate = Convert.ToDateTime(args.NewValues["EndDate"]);
                
                listUpdates.Add(Apd);
            }
            if (listUpdates.Count > 0)
            {
                rtm_services.UpdateEnterpriseAPD(listUpdates);
            }
            foreach (var args in e.DeleteValues)
                DeleteAPD(args.Keys);
            e.Handled = true;

            BindAPD();
        }

        private void DeleteAPD(OrderedDictionary keys)
        {
            var result = rtm_services.DeleteAPD(keys["Id"].ToString());
            BindAPD();
        }

        public void BindAPD()
        {
            gridAPD.DataSource = rtm_services.GetEnterpriseAPD();
            gridAPD.DataBind();
        }

        #region Artifacts
        protected void gridArtifacts_BeforePerformDataSelect(object sender, EventArgs e)
        {
            
            Session["ItemKey"] = (sender as ASPxGridView).GetMasterRowKeyValue();
            String ItemKey = Session["ItemKey"].ToString();
            ASPxGridView gridArtifacts = (ASPxGridView)sender;
            gridArtifacts.DataSource = rc_services.GetAttachments(Guid.Parse(ItemKey));

        }

        protected void gridArtifacts_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            ASPxGridView gridArtifacts = (ASPxGridView)sender;
            ASPxGridView gridRepository = (ASPxGridView)gridArtifacts.FindEditFormLayoutItemTemplateControl("gridRepository");


            //Use class AttachmentList to create a list of artifacts to be attached
            AttachmentList xMultiAttachment = new AttachmentList();

            //go through grid and create an unit for each selected item
            for (int i = 0; i <= gridRepository.VisibleRowCount; i = i + 1)
            {
                if (gridRepository.Selection.IsRowSelected(i) == true)
                {
                    //get page ref from text box inside cell template
                    ASPxTextBox txPage = (ASPxTextBox)gridRepository.FindRowCellTemplateControl(i, gridRepository.DataColumns[8], "txPage");
                    xMultiAttachment.Add(new Attachment()
                    {
                        ArtifactID = gridRepository.GetRowValues(i, "ArtifactID").ToString(),
                        ProjectID = gridRepository.GetRowValues(i, "ProjectID").ToString(),
                        PageReference = txPage.Text.ToString(),
                        ItemID = Session["ItemKey"].ToString()



                    });

                }
            }
            //If any selected, call the function in rc_services to attach multiple artifacts
            if (xMultiAttachment.Count > 0)
            {
                string xMultiAttachResult = rc_services.AttachArtifact(xMultiAttachment);
                e.Cancel = true;
                gridArtifacts.CancelEdit();
                gridArtifacts.DataBind();
                gridRepository.Selection.UnselectAll();
            }
        }

        protected void gridArtifacts_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            rc_services.DeleteAttachment(Guid.Parse(e.Keys[0].ToString()));
            e.Cancel = true;
            ASPxGridView gridArtifacts = (ASPxGridView)sender;
            String ItemKey = Session["CriteriaId"].ToString();
            gridArtifacts.DataSource = rc_services.GetAttachments(Guid.Parse(ItemKey));
        }

        protected void gridArtifacts_DetailRowExpandedChanged(object sender, DevExpress.Web.ASPxGridViewDetailRowEventArgs e)
        {
            string FileExtn;
            string storageFileName;

            ASPxGridView artifactsGrid = (ASPxGridView)sender;

            FileExtn = "";
            storageFileName = artifactsGrid.GetRowValues(e.VisibleIndex, "filestoragename").ToString();
            string fileName = artifactsGrid.GetRowValues(e.VisibleIndex, "filename").ToString();

            string accountName = "UploadAzureAccount";
            string containerName = Session["enterpriseID"].ToString().ToUpper();
            string url = GetFileUrl(storageFileName, accountName, containerName, ref FileExtn);

            if (e.Expanded)
            {


                //using (var client = new System.Net.WebClient())
                //{
                //    client.DownloadFile(url, Path.GetTempPath() + "\\" + fileName);
                //}
                //Session["fileNameToDownload"] = fileName + "|" + FileExtn;

                Session["fileNameToDownload"] = url + "|" + FileExtn + "|" + fileName + "|" + storageFileName;
            }
            else
            {
                FileExtn = Session["fileNameToDownload"].ToString().Split('|')[1];
                storageFileName = Session["fileNameToDownload"].ToString().Split('|')[3];

                if (FileExtn == ".pdf")
                {

                    if (File.Exists(Server.MapPath("~/TempFiles") + "/" + fileName))
                    {
                        File.Delete(Server.MapPath("~/TempFiles") + "/" + fileName);
                    }
                }
                Session.Remove("fileNameToDownload");

            }
        }

        protected void pageControlDetails_Load(object sender, EventArgs e)
        {
            if (Session["fileNameToDownload"] != null)
            {
                string fileURL = Session["fileNameToDownload"].ToString().Split('|')[0];
                string FileExtn = Session["fileNameToDownload"].ToString().Split('|')[1];
                string fileName = Session["fileNameToDownload"].ToString().Split('|')[2];
                string storageFileName = Session["fileNameToDownload"].ToString().Split('|')[3];

                ASPxPageControl pageControlDetails = (ASPxPageControl)sender;

                //HtmlGenericControl documentDownloadLink = (HtmlGenericControl)pageControlDetails.FindControl("previewNotAvailableText");
                //documentDownloadLink.Visible = true;
                //documentDownloadLink.InnerHtml = "<a href=\"" + fileURL + "\" download=\"" + fileName + "\">Download File</a>";

                if (FileExtn == ".txt")
                {
                    ASPxRichEdit richEditPreview = (ASPxRichEdit)pageControlDetails.FindControl("richDetailsPreview");
                    richEditPreview.Visible = true;
                    //richEditPreview.Open(Path.GetTempPath() + "\\" + fileURL);
                    richEditPreview.Open(Guid.NewGuid().ToString(), DevExpress.XtraRichEdit.DocumentFormat.PlainText, () =>
                    {
                        byte[] fileData = null;
                        using (var wc = new System.Net.WebClient())
                            fileData = wc.DownloadData(fileURL);
                        return new MemoryStream(fileData);
                    });
                }
                else if (FileExtn == ".doc")
                {
                    ASPxRichEdit richEditPreview = (ASPxRichEdit)pageControlDetails.FindControl("richDetailsPreview");
                    richEditPreview.Visible = true;
                    //richEditPreview.Open(Path.GetTempPath() + "\\" + fileURL);
                    richEditPreview.Open(Guid.NewGuid().ToString(), DevExpress.XtraRichEdit.DocumentFormat.Doc, () =>
                    {
                        byte[] fileData = null;
                        using (var wc = new System.Net.WebClient())
                            fileData = wc.DownloadData(fileURL);
                        return new MemoryStream(fileData);
                    });
                }
                else if (FileExtn == ".docx")
                {
                    ASPxRichEdit richEditPreview = (ASPxRichEdit)pageControlDetails.FindControl("richDetailsPreview");
                    richEditPreview.Visible = true;
                    //richEditPreview.Open(Path.GetTempPath() + "\\" + fileURL);
                    richEditPreview.Open(Guid.NewGuid().ToString(), DevExpress.XtraRichEdit.DocumentFormat.OpenXml, () =>
                    {
                        byte[] fileData = null;
                        using (var wc = new System.Net.WebClient())
                            fileData = wc.DownloadData(fileURL);
                        return new MemoryStream(fileData);
                    });
                }
                else if (FileExtn == ".xls")
                {
                    DevExpress.Web.ASPxSpreadsheet.ASPxSpreadsheet spreadSheetPreview = (ASPxSpreadsheet)pageControlDetails.FindControl("spreadSheetPreview");
                    spreadSheetPreview.Visible = true;
                    MemoryStream stream = new MemoryStream();
                    spreadSheetPreview.Open(Guid.NewGuid().ToString(), DevExpress.Spreadsheet.DocumentFormat.Xls, () =>
                    {
                        byte[] fileData = null;
                        using (var wc = new System.Net.WebClient())
                            fileData = wc.DownloadData(fileURL);
                        return new MemoryStream(fileData);
                    });

                    //spreadSheetPreview.
                }
                else if (FileExtn == ".xlsx")
                {
                    DevExpress.Web.ASPxSpreadsheet.ASPxSpreadsheet spreadSheetPreview = (ASPxSpreadsheet)pageControlDetails.FindControl("spreadSheetPreview");
                    spreadSheetPreview.Visible = true;
                    MemoryStream stream = new MemoryStream();
                    spreadSheetPreview.Open(Guid.NewGuid().ToString(), DevExpress.Spreadsheet.DocumentFormat.Xlsx, () =>
                    {
                        byte[] fileData = null;
                        using (var wc = new System.Net.WebClient())
                            fileData = wc.DownloadData(fileURL);
                        return new MemoryStream(fileData);
                    });

                    //spreadSheetPreview.
                }
                else if (FileExtn == ".pdf")
                {
                    HtmlGenericControl pdfPreview = (HtmlGenericControl)pageControlDetails.FindControl("pdfPreview");
                    pdfPreview.Visible = true;
                    using (var client = new System.Net.WebClient())
                    {
                        client.DownloadFile(fileURL, Server.MapPath("~/TempFiles") + "/" + fileName);
                    }

                    //pdfPreview.InnerHtml = "<embed src = \""+ Path.GetTempPath() + "\\" + fileURL+"\" />";
                    pdfPreview.InnerHtml = "<iframe src=\"" + "../TempFiles" + "/" + fileName + "\" style = \"width:100%; height:500px;\" frameborder = \"0\" ></iframe> ";
                    //pdfPreview.InnerHtml = "<iframe src = \"" + fileURL + "\" style = \"width:600px; height:500px;\" frameborder = \"0\"></iframe>";

                }
                else if (FileExtn == ".jpg" || FileExtn == ".jpeg")
                {
                    HtmlGenericControl imgPreview = (HtmlGenericControl)pageControlDetails.FindControl("pdfPreview");
                    imgPreview.Visible = true;
                    imgPreview.InnerHtml = "<img class=\"preview\" src = \"" + fileURL + "\">";
                }
                else
                {
                    HtmlGenericControl previewNotAvailableText = (HtmlGenericControl)pageControlDetails.FindControl("documentDownloadLink");
                    previewNotAvailableText.Visible = true;
                    previewNotAvailableText.InnerHtml = "<h1>Preview Not Available</h1>";
                }
            }
        }
        string GetFileUrl(string fileName, string accountName, string containerName, ref string FileExtn)
        {
            // AzureFileSystemProvider provider = new AzureFileSystemProvider("");
            // provider.AccountName = accountName;
            // provider.ContainerName =containerName.ToLower();

            // //get the storage account.
            // CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
            //     System.Configuration.ConfigurationManager.AppSettings["rcx_AzureStorageConnectionString"]);

            // //blob client now
            // CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            // //the container for this is companystyles
            // CloudBlobContainer container = blobClient.GetContainerReference(containerName);

            // //Create a new container, if it does not exist
            //// container.CreateIfNotExists(); ;



            // FileManagerFile file = new FileManagerFile(provider, fileName);

            // FileExtn = file.Extension;
            // FileManagerFile[] files = new FileManagerFile[] { file };

            // return provider.GetDownloadUrl(files);

            AzureFileSystemProvider provider = new AzureFileSystemProvider("");
            provider.AccountName = accountName;
            provider.ContainerName = containerName.ToLower();
            provider.BlobEndpoint = ConfigurationManager.AppSettings["BlobEndpoint"].ToString();

            FileManagerFile file = new FileManagerFile(provider, fileName);

            FileExtn = file.Extension;
            FileManagerFile[] files = new FileManagerFile[] { file };
            return provider.GetDownloadUrl(files);

        }
        protected void btnDownloadFile_Click(object sender, EventArgs e)
        {
            string fileURL = Session["fileNameToDownload"].ToString().Split('|')[0];
            string fileName = Session["fileNameToDownload"].ToString().Split('|')[2];

            byte[] fileData = null;
            using (var wc = new System.Net.WebClient())
                fileData = wc.DownloadData(fileURL);
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=\"" + fileName + "\"");
            Response.AddHeader("Content-Length", fileData.Length.ToString());
            Response.ContentType = "application/octet-stream";
            Response.BinaryWrite(fileData);
        }

        protected void gridRepository_BeforePerformDataSelect(object sender, EventArgs e)
        {
            ASPxGridView gridRepository = (ASPxGridView)sender;
            gridRepository.DataSource = rc_services.GetRepository("P", false);
        }

        #endregion  
    }
}