using DevExpress.Pdf;
using DevExpress.Web;
using DevExpress.Web.ASPxRichEdit;
using DevExpress.Web.ASPxSpreadsheet;
using DevExpress.XtraRichEdit;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace RC_X.project
{
    public partial class pro_repository : System.Web.UI.Page
    {

        protected void Page_Init(object sender, EventArgs e)
        {
            if (!rc_services.CheckPermission("ent_repository")) { Response.Redirect("~/controls/unauthorized.aspx"); }
           


        }
        protected void Page_Load(object sender, EventArgs e)
        {

            BindRepository();
        }
        private void BindRepository()
        {
            string EnterpriseAuthorized = null;
            if (rc_services.CheckPermission("pro_repository_enterprise") && rc_services.CheckPermission("pro_repository") && rc_services.CheckPermission("pro_repository_global"))
            { // Can user view enterprise items?
                EnterpriseAuthorized = "All";
                ArtifactsGrid.DataSource = rc_services.GetArtifacts(EnterpriseAuthorized);
                ArtifactsGrid.DataBind();
            }
            else if (rc_services.CheckPermission("pro_repository_enterprise") && rc_services.CheckPermission("pro_repository_edit"))
            {
                EnterpriseAuthorized = "EP";
                ArtifactsGrid.DataSource = rc_services.GetArtifacts(EnterpriseAuthorized);
                ArtifactsGrid.DataBind();
            }
            else if (rc_services.CheckPermission("pro_repository_global") && rc_services.CheckPermission("pro_repository_edit"))
            {
                EnterpriseAuthorized = "GP";
                ArtifactsGrid.DataSource = rc_services.GetArtifacts(EnterpriseAuthorized);
                ArtifactsGrid.DataBind();
            }
            else if (rc_services.CheckPermission("pro_repository_global") && rc_services.CheckPermission("pro_repository_enterprise"))
            {
                EnterpriseAuthorized = "GE";
                ArtifactsGrid.DataSource = rc_services.GetArtifacts(EnterpriseAuthorized);
                ArtifactsGrid.DataBind();
            }
            else if (rc_services.CheckPermission("pro_repository_edit"))
            {
                EnterpriseAuthorized = "P";
                ArtifactsGrid.DataSource = rc_services.GetArtifacts(EnterpriseAuthorized);
                ArtifactsGrid.DataBind();
            }
            else { Response.Redirect("~/controls/unauthorized.aspx"); }
        }

        protected void ArtifactsGrid_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            String projectID, lib_title, lib_type, lib_home, lib_filename, lib_storagename, lib_desc, lib_textsearch;
            String lib_uploadedby;
            ASPxGridView artifactsGrid = sender as ASPxGridView;
            projectID = Session["projectID"].ToString();
            lib_title = (string)e.NewValues["Title"];
            lib_type = (string)e.NewValues["Type"];
            lib_home = (string)e.NewValues["Home"];
            lib_filename = (string)hiddenFileName.Get("filename");//File.FileName;
            lib_storagename = (string)hiddenFileName.Get("filestoragename");
            lib_desc = (string)e.NewValues["Description"];
            lib_textsearch = (string)hiddenFileName.Get("filetext"); // needs solution
            lib_uploadedby = Session["UserID"].ToString();

            rc_services.NewArtifact(projectID, lib_title, lib_type, lib_home, lib_filename, lib_storagename, lib_desc, lib_textsearch, lib_uploadedby);

            hiddenFileName.Clear();

            e.Cancel = true;
            ArtifactsGrid.CancelEdit();
            BindRepository();
        }

        protected void ArifactsGrid_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            Artifact updateArtifacts = new Artifact();
            updateArtifacts.ArtifactID = Guid.Parse(e.Keys["ArtifactID"].ToString());
            updateArtifacts.Title = e.NewValues["Title"].ToString();
            updateArtifacts.Type = e.NewValues["Type"].ToString();
            updateArtifacts.Description = e.NewValues["Description"].ToString();
            updateArtifacts.Home = e.NewValues["Home"].ToString();
            if (hiddenFileName.Contains("filename"))
            {
                updateArtifacts.filename = (string)hiddenFileName.Get("filename");//File.FileName;
                updateArtifacts.filestoragename = (string)hiddenFileName.Get("filestoragename");
                updateArtifacts.filetext = (string)hiddenFileName.Get("filetext");
                updateArtifacts.UploadedBy = Session["UserID"].ToString();
                updateArtifacts.DateUploaded = DateTime.Now.ToString();
            }
            if ((string)e.NewValues["Home"] == "P")
            {
                updateArtifacts.ProjectID = Session["projectID"].ToString();
            }
            else
            {
                updateArtifacts.ProjectID = DBNull.Value.ToString();
            }

            updateArtifacts.UploadedBy = Session["UserID"].ToString();
            updateArtifacts.DateUploaded = DateTime.Now.ToString();
            updateArtifacts.ChangedBy = Session["UserID"].ToString();
            hiddenFileName.Clear();

            rc_services.UpdateRepository(updateArtifacts);

            e.Cancel = true;
            ArtifactsGrid.CancelEdit();
            BindRepository();

        }

        protected void ArtifactsGrid_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            string RowKey = e.Keys[0].ToString();
            rc_services.DeleteRepository(RowKey);
            e.Cancel = true;
            BindRepository();
        }

        protected void ArtifactsGrid_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e)
        {
            if (e.Column.FieldName == "Type")
            {
                ASPxComboBox cmb = e.Editor as ASPxComboBox;
                cmb.DataSource = common_services.GetCustomDropDown("artifact");
                cmb.ValueField = "Name";
                cmb.ValueType = typeof(String);
                cmb.TextField = "Description";
                cmb.DataBindItems();
            }
        }

        protected void ArtifactUploader_FileUploadComplete(object sender, FileUploadCompleteEventArgs e)
        {
            string FileExtn = "", plainText = "";

            ASPxUploadControl ArtifactUploader = (ASPxUploadControl)sender;
            string accountName = ArtifactUploader.AzureSettings.AccountName;
            //string containerName =ArtifactUploader.AzureSettings.ContainerName; --does not work, even though blob is uploded to proper container
            string containerName = Session["enterpriseID"].ToString().ToLower();
            string url = GetFileUrl(e.UploadedFile.FileNameInStorage, accountName, containerName, ref FileExtn);
            if (FileExtn == ".txt" || FileExtn == ".doc" || FileExtn == ".docx")
            {
                using (var client = new System.Net.WebClient())
                {
                    client.DownloadFile(url, Path.GetTempPath() + "\\" + e.UploadedFile.FileName);
                }
                //ASPxRichEdit richEdit = new ASPxRichEdit();
                //richEdit.Open("~\\App_Data\\" + e.UploadedFile.FileName);
                //MemoryStream ms = new MemoryStream();
                //richEdit.SaveCopy(ms, DocumentFormat.PlainText);
                //ms.Seek(0, SeekOrigin.Begin);
                //plainText = new StreamReader(ms).ReadToEnd();
                RichEditDocumentServer richEditDocument = new RichEditDocumentServer();
                richEditDocument.LoadDocument(Path.GetTempPath() + "\\" + e.UploadedFile.FileName);
                plainText = richEditDocument.Text;
            }
            else if (FileExtn == ".pdf")
            {
                using (var client = new System.Net.WebClient())
                {
                    client.DownloadFile(url, Path.GetTempPath() + "\\" + e.UploadedFile.FileName);
                }

                using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor())
                {
                    documentProcessor.LoadDocument(Path.GetTempPath() + "\\" + e.UploadedFile.FileName);
                    plainText = documentProcessor.Text;
                }
            }
            e.CallbackData = e.UploadedFile.FileName + "|" + e.UploadedFile.FileNameInStorage + "|" + plainText;
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

        protected void ArtifactHistory_BeforePerformDataSelect(object sender, EventArgs e)
        {
            var attachmentHistoryGrid = sender as ASPxGridView;
            Session["SelectedArtifactDetail"] = attachmentHistoryGrid.GetMasterRowKeyValue();
            string KeyValue = Session["SelectedArtifactDetail"] != null ? Session["SelectedArtifactDetail"].ToString() : string.Empty;
            //bool EnterpriseAuthorized = rc_services.CheckPermission("ent_roadmap");
            attachmentHistoryGrid.DataSource = rc_services.GetRepositoryAttachmentsHistory(KeyValue);
        }

        protected void ArtifactAttachment_BeforePerformDataSelect(object sender, EventArgs e)
        {
            var attachmentGrid = sender as ASPxGridView;
            Session["ArtifactID"] = attachmentGrid.GetMasterRowKeyValue();
            string KeyValue = Session["ArtifactID"] != null ? Session["ArtifactID"].ToString() : string.Empty;
            //bool EnterpriseAuthorized = rc_services.CheckPermission("ent_roadmap");
            attachmentGrid.DataSource = rc_services.GetRepositoryAttachments(KeyValue);
        }
        protected void ArtifactUploader_Init(object sender, EventArgs e)
        {
            //    ASPxUploadControl uploader = (ASPxUploadControl)sender;
            //    uploader.AzureSettings.ContainerName = "ehr";
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
                    richEditPreview.Open(Guid.NewGuid().ToString(), DocumentFormat.PlainText, () =>
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
                    richEditPreview.Open(Guid.NewGuid().ToString(), DocumentFormat.Doc, () =>
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
                    richEditPreview.Open(Guid.NewGuid().ToString(), DocumentFormat.OpenXml, () =>
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

        protected void ArtifactsGrid_DetailRowExpandedChanged(object sender, ASPxGridViewDetailRowEventArgs e)
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

        protected void ArtifactsGrid_HtmlEditFormCreated(object sender, ASPxGridViewEditFormEventArgs e)
        {
            ASPxGridView gridView = (ASPxGridView)sender;
            ASPxUploadControl uploader = (ASPxUploadControl)gridView.FindEditFormLayoutItemTemplateControl("ArtifactUploader");
            uploader.AzureSettings.ContainerName = Session["enterpriseID"].ToString().ToLower();
        }

        [WebMethod(EnableSession = true)]
        public static string GetDuplicateFileUploadNames(string fileName)
        {
            if (HttpContext.Current.Session == null)
                return "NaN";
            var progress = rc_services.CheckExistingFileName(fileName);
            return progress.ToString();
        }




        protected void gridAttachements_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e)
        {

        }



    }
}