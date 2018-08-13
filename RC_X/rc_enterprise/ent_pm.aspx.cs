using DevExpress.Web;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.ASPxRichEdit;
using DevExpress.Web.ASPxSpreadsheet;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using static RC_X.rtm_services;

namespace RC_X.rc_enterprise
{
    public partial class ent_pm : System.Web.UI.Page
    {
        public void BindGrid() {
            // Can user view enterprise items?
            bool EnterpriseAuthorized = rc_services.CheckPermission("ent_pm");
            gridPM.DataSource = rc_services.GetPMitems(EnterpriseAuthorized);
            gridPM.DataBind();
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            if (!rc_services.CheckPermission("ent_pm")) { Response.Redirect("~/controls/unauthorized.aspx"); }
            gridPM.Columns[0].Visible = rc_services.CheckPermission("ent_pm_edit");       
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            gridPM.KeyFieldName = "Id";
                BindGrid();
                 
        }

        protected void gridPM_CellEditorInitialize(object sender, DevExpress.Web.ASPxGridViewEditorEventArgs e)
        {
           if (e.Column.FieldName == "Type")
            {
                ASPxComboBox cmb = e.Editor as ASPxComboBox;
                cmb.DataSource = common_services.GetCustomDropDown("pm_type");
                cmb.ValueField = "Name";
                cmb.ValueType = typeof(String);
                cmb.TextField = "Description";
                cmb.DataBindItems();
              }
            if (e.Column.FieldName == "Priority")
            {
                ASPxComboBox cmb = e.Editor as ASPxComboBox;
                cmb.DataSource = common_services.GetCustomDropDown("pm_priority");
                cmb.ValueField = "Name";
                cmb.ValueType = typeof(String);
                cmb.TextField = "Description";
                cmb.DataBindItems();
            }
            if (e.Column.FieldName == "Status")
            {
                ASPxComboBox cmb = e.Editor as ASPxComboBox;
                cmb.DataSource = common_services.GetCustomDropDown("pm_status");
                cmb.ValueField = "Name";
                cmb.ValueType = typeof(String);
                cmb.TextField = "Description";
                cmb.DataBindItems();
            }
            if (e.Column.FieldName == "Area")
            {
                ASPxComboBox cmb = e.Editor as ASPxComboBox;
                cmb.DataSource = common_services.GetCustomDropDown("pm_area");
                cmb.ValueField = "Name";
                cmb.ValueType = typeof(String);
                cmb.TextField = "Description";
                cmb.DataBindItems();
            }
        }

        protected void gridPM_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            ProjectManagement NewPM = new ProjectManagement();
            NewPM.Description = (string)e.NewValues["Description"];
            NewPM.Solution = (string)e.NewValues["Solution"];
            NewPM.Priority = (string)e.NewValues["Priority"];
            NewPM.Status = (string)e.NewValues["Status"];
            NewPM.Title = (string)e.NewValues["Title"];
            NewPM.UniqueID = (string)e.NewValues["UniqueID"];
            NewPM.Type = (string)e.NewValues["Type"];
            NewPM.Area = (string)e.NewValues["Area"];
            NewPM.CreatedBy = rc_services.GetUserEmail();
            //Check if user has enterprise level permission. If so, allow their choice of Home, if not, force project level
            bool EnterpriseAuthorized = rc_services.CheckPermission("ent_pm");
            if (EnterpriseAuthorized)
            {
                NewPM.Home = (String)e.NewValues["Home"];
            }
            else
            {
                NewPM.Home = "P";
            }

            rc_services.InsertPMitem(NewPM);

            gridPM.DataSource = rc_services.GetPMitems(EnterpriseAuthorized);
            e.Cancel = true;
            gridPM.CancelEdit();
            gridPM.DataBind();
        }

        protected void gridPM_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            //ASPxHtmlEditor txDescription = gridPM.FindEditFormTemplateControl("txDescription") as ASPxHtmlEditor;
            //ASPxHtmlEditor txSolution = gridPM.FindEditFormTemplateControl("txSolution") as ASPxHtmlEditor;
            ProjectManagement NewPM = new ProjectManagement();
            NewPM.Id = (string)e.Keys [0];
            NewPM.Description = (string)e.NewValues["Description"];
            NewPM.Solution = (string)e.NewValues["Solution"];
            NewPM.Priority = (string)e.NewValues["Priority"];
            NewPM.Status = (string)e.NewValues["Status"];
            NewPM.Title = (string)e.NewValues["Title"];
            NewPM.UniqueID = (string)e.NewValues["UniqueID"];
            NewPM.Type = (string)e.NewValues["Type"];
            NewPM.Area = (string)e.NewValues["Area"];
            NewPM.Home = (string)e.NewValues["Home"];


            rc_services.UpdatePMitem(NewPM);

            bool EnterpriseAuthorized = rc_services.CheckPermission("ent_pm");
            gridPM.DataSource = rc_services.GetPMitems(EnterpriseAuthorized);
            e.Cancel = true;
            gridPM.CancelEdit();
            gridPM.DataBind();
        }

        protected void gridPM_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            string RowKey = e.Keys[0].ToString();
            rc_services.DeletePMitem(RowKey);
            e.Cancel = true;
            BindGrid();
        }

        protected void gridMatrix_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            ASPxGridView gridMatrix = (ASPxGridView)sender;
            ASPxGridView gridAssessItems = (ASPxGridView)gridMatrix.FindEditFormLayoutItemTemplateControl("gridAssessItems");

            //ASPxGridLookup dropMatrix = (ASPxGridLookup)gridScorecards.FindEditFormLayoutItemTemplateControl("dropMatrix");
            List<UniversalAssessmentItem> ItemsList = new List<UniversalAssessmentItem>();
            for (int i = 0; i <= gridAssessItems.VisibleRowCount; i = i + 1)
            {
                if (gridAssessItems.Selection.IsRowSelected(i) == true)
                {
                    ItemsList.Add(new UniversalAssessmentItem { Id = gridAssessItems.GetRowValues(i, "id").ToString() });
                }
            }
            common_services.SaveXref(Session["xref_referenceid"].ToString(), ItemsList);
            e.Cancel = true;
            gridMatrix.CancelEdit();
            gridMatrix.DataBind();
        }

        protected void gridMatrix_BeforePerformDataSelect(object sender, EventArgs e)
        {
            Session["xref_referenceid"] = (sender as ASPxGridView).GetMasterRowKeyValue();
        }

        protected void sqlMatrix_Init(object sender, EventArgs e)
        {
            SqlDataSource sqlMatrix = (SqlDataSource)sender;
            sqlMatrix.ConnectionString = Session["userConnString"].ToString();
        }

        protected void sqlAllAssess_Init(object sender, EventArgs e)
        {
            SqlDataSource sqlAllAssess = (SqlDataSource)sender;
            sqlAllAssess.ConnectionString = Session["userConnString"].ToString();
        }

        #region Workflow
        protected void gridWorkflow_BeforePerformDataSelect(object sender, EventArgs e)
        {
            Session["ItemKey"] = (sender as ASPxGridView).GetMasterRowKeyValue();
            Guid projectID = Guid.Parse(Session["projectID"].ToString());
            String ItemKey = Session["ItemKey"].ToString();
            ASPxGridView gridWorkflow = (ASPxGridView)sender;
            gridWorkflow.DataSource = rc_services.GetWorkflow(Guid.Parse(ItemKey), projectID);
        }

        protected void gridWorkflow_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            String ItemKey = Session["ItemKey"].ToString();
            ASPxGridView gridWorkflow = (ASPxGridView)sender;
            ASPxComboBox dropStatus = (ASPxComboBox)gridWorkflow.FindEditFormLayoutItemTemplateControl("workflowDropStatus");
            ASPxComboBox dropUser = (ASPxComboBox)gridWorkflow.FindEditFormLayoutItemTemplateControl("workflowdropUser");
            ASPxHtmlEditor txComments = (ASPxHtmlEditor)gridWorkflow.FindEditFormLayoutItemTemplateControl("txComments");

            Workflow NewStatus = new Workflow
            {
                ItemKey = Guid.Parse(ItemKey),
                ProjectID = Guid.Parse(Session["projectID"].ToString()),
                Status = dropStatus.Text,
                StatusValue = Convert.ToInt32(dropStatus.Value.ToString()),
                Comments = txComments.Html,
                WorkerID = (dropUser.Value == null) ? Guid.Empty : Guid.Parse(dropUser.Value.ToString()),
                ManagerID = Guid.Parse(rc_services.GetUserID()),
                DueDate = Convert.ToDateTime(e.NewValues[0]),
                StatusDate = DateTime.Now
            };

            var item = rc_services.GetItemName(ItemKey);
            string worker = dropUser.Text.ToString();
            Guid WorkerID = (dropUser.Value == null) ? Guid.Empty : Guid.Parse(dropUser.Value.ToString());
            string manager = HttpContext.Current.Session["UserEmail"].ToString();
            string projectName = HttpContext.Current.Session["ProjectName"].ToString();
            string Status = dropStatus.Text;
            List<string> ListItems = new List<string>();
            rc_services.WorkFlowNotificationEmail(WorkerID, worker, manager, projectName, Status, ListItems, item);

            rc_services.NewWorkflowStatus(NewStatus);
            e.Cancel = true;
            Guid projectID = Guid.Parse(Session["projectID"].ToString());
            gridWorkflow.DataSource = rc_services.GetWorkflow(Guid.Parse(ItemKey), projectID);
            gridWorkflow.DataBind();
            gridWorkflow.CancelEdit();
        }

        protected void workflowDropStatus_Init(object sender, EventArgs e)
        {
            ASPxComboBox dropStatus = (ASPxComboBox)sender;
            dropStatus.DataSource = common_services.GetCustomDropDown("workflow");
            dropStatus.DataBind();
        }

        protected void workflowdropUser_Init(object sender, EventArgs e)
        {
            ASPxComboBox dropUser = (ASPxComboBox)sender;
            dropUser.DataSource = rc_services.GetUsers();
            dropUser.DataBind();
        }
        #endregion

        #region Artifacts
        protected void gridArtifacts_BeforePerformDataSelect(object sender, EventArgs e)
        {
            ASPxGridView gridArtifacts = (ASPxGridView)sender;
            String ItemKey = Session["ItemKey"].ToString();
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

        protected void gridArtifacts_DetailRowExpandedChanged(object sender, ASPxGridViewDetailRowEventArgs e)
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

        protected void gridRepository_BeforePerformDataSelect(object sender, EventArgs e)
        {
            ASPxGridView gridRepository = (ASPxGridView)sender;
            gridRepository.DataSource = rc_services.GetRepository("P", false);
        }
        #endregion
    }
}