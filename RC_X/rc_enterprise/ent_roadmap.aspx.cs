using DevExpress.Web;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.ASPxRichEdit;
using DevExpress.Web.ASPxSpreadsheet;
using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace RC_X.rc_enterprise
{
    public partial class ent_roadmap : System.Web.UI.Page
    {
        
        //ASPxGridView gridAssociatedItems;
        
        //ASPxGridView gvTasksAttachments;
        //private readonly object gridGapandGoals;

        protected void Page_Load(object sender, EventArgs e)
        {
           
            

            BindGrids();

        }
        public void BindGrids()
        {
            //Can user edit at all?
            //Fetch Gaps, Fetch Goals, then merge them to get full list of both for grid where they are associated with RoadMap Projects
            List<GapGoal> Gaps =  rc_services.GetGapGoals();
          
            gridGaps.DataSource = Gaps;
            gridGaps.DataBind();
            bool deliverablescreen = false;
            gridTasks.DataSource = rc_services.GetProjectTasks(deliverablescreen);
            gridTasks.DataBind();

            
        }

        protected void gridGaps_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {

            bool EnterpriseAuthorized = rc_services.CheckPermission("ent_roadmap");
            GapGoal NewGap = new GapGoal();
            NewGap.Title = (String)e.NewValues["Title"];
            NewGap.Type = (String)e.NewValues["Type"];
            if (e.NewValues["Open"] == null) { NewGap.Open = false; } else { NewGap.Open = (bool)e.NewValues["Open"]; };
            NewGap.Description = (String)e.NewValues["Description"];

         
            NewGap.OpenDate = (String)e.NewValues["OpenDate"];
            NewGap.CloseDate = (String)e.NewValues["CloseDate"];

           
            

            rc_services.NewGapGoal(NewGap);

          
            gridGaps.DataSource = rc_services.GetGapGoals();
            
            e.Cancel = true;
            gridGaps.CancelEdit();
            gridGaps.DataBind();
        }

        protected void gridGaps_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            GapGoal NewGap = new GapGoal();
            NewGap.Id = (String)e.Keys["Id"];
            NewGap.Title = (String)e.NewValues["Title"];
            if (e.NewValues["Open"] == null) { NewGap.Open = false; } else { NewGap.Open = (bool)e.NewValues["Open"]; };
            NewGap.Description = (String)e.NewValues["Description"];
            NewGap.OpenDate = (String)e.NewValues["OpenDate"];
            NewGap.CloseDate = (String)e.NewValues["CloseDate"];

            rc_services.EditGapGoal(NewGap);

            bool EnterpriseAuthorized = rc_services.CheckPermission("ent_roadmap");
            gridGaps.DataSource = rc_services.GetGapGoals();
            e.Cancel = true;
            gridGaps.CancelEdit();
            gridGaps.DataBind();

        }

        protected void gridGaps_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            String GapID = e.Keys[0].ToString();
            rc_services.DeleteGapGoal(GapID);
            bool EnterpriseAuthorized = rc_services.CheckPermission("ent_roadmap");
            gridGaps.DataSource = rc_services.GetGapGoals();
            e.Cancel = true;
            gridGaps.CancelEdit();
            gridGaps.DataBind();
        }


        protected void gridTasks_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            String RoadmapID = e.Keys[0].ToString();
            rc_services.DeleteProjectTasks(RoadmapID);
            bool EnterpriseAuthorized = rc_services.CheckPermission("ent_roadmap");
            bool deliverablescreen = false;
            gridTasks.DataSource = rc_services.GetProjectTasks(deliverablescreen);
            e.Cancel = true;
            gridTasks.CancelEdit();
            gridTasks.DataBind();
        }

        protected void gridTasks_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            ProjectTasks Project = new ProjectTasks();
            Project.Title = (String)e.NewValues["Title"];
            Project.Description = (String)e.NewValues["Description"];
            Project.CMStextReview = (String)e.NewValues["CMStextReview"];
            Project.StartDate = (String)e.NewValues["StartDate"];
            Project.EstimatedEndDate = (String)e.NewValues["EstimatedEndDate"];
            Project.TargetDate1 = (String)e.NewValues["TargetDate1"];
            Project.TargetDate2 = (String)e.NewValues["TargetDate2"];
            Project.TargetDate3 = (String)e.NewValues["TargetDate3"];
            Project.Status = (String)e.NewValues["Status"];
            Project.ActualEndDate = (String)e.NewValues["ActualEndDate"];
            Project.CMSreviewDate = (String)e.NewValues["CMSreviewDate"];
           
            //Project.Roadmap = (Boolean)e.NewValues["Roadmap"];
            if (e.NewValues["Roadmap"] == null) { Project.Roadmap = false; } else { Project.Roadmap = (bool)e.NewValues["Roadmap"]; };
            //Check if user has enterprise level permission. If so, allow their choice of Home, if not, force project level


            rc_services.NewProjectTasks(Project);
            bool deliverablescreen = false;
            gridTasks.DataSource = rc_services.GetProjectTasks(deliverablescreen);
            e.Cancel = true;
            gridTasks.CancelEdit();
            gridTasks.DataBind();
        }

        protected void gridTasks_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            ProjectTasks Project = new ProjectTasks();
            Project.Id = (String)e.Keys["Id"];
            Project.Title = (String)e.NewValues["Title"];
            Project.Description = (String)e.NewValues["Description"];
            Project.CMStextReview = (String)e.NewValues["CMStextReview"];
            Project.StartDate = (String)e.NewValues["StartDate"];
            Project.EstimatedEndDate = (String)e.NewValues["EstimatedEndDate"];
            Project.TargetDate1 = (String)e.NewValues["TargetDate1"];
            Project.TargetDate2 = (String)e.NewValues["TargetDate2"];
            Project.TargetDate3 = (String)e.NewValues["TargetDate3"];
            Project.Status = (String)e.NewValues["Status"];
            Project.ActualEndDate = (String)e.NewValues["ActualEndDate"];
            Project.CMSreviewDate = (String)e.NewValues["CMSreviewDate"];

            if (e.NewValues["Roadmap"] == null) { Project.Roadmap = false; } else { Project.Roadmap = (bool)e.NewValues["Roadmap"]; };

            rc_services.EditProjectTasks(Project);

            bool EnterpriseAuthorized = rc_services.CheckPermission("ent_roadmap");
            bool deliverablescreen = false;
            gridTasks.DataSource = rc_services.GetProjectTasks(deliverablescreen);
            e.Cancel = true;
            gridTasks.CancelEdit();
            gridTasks.DataBind();
      
        }

        
       

        protected void gridAssociatedGapsGoals_BeforePerformDataSelect(object sender, EventArgs e)
        {
            Session["TaskID"] = (sender as ASPxGridView).GetMasterRowKeyValue();
            //String KeyValue = (String)gridAssociatedItems.GetMasterRowKeyValue();
            //int ExpandedRowIndex = gridTasks.FindVisibleIndexByKeyValue(KeyValue);
            //if (gridTasks.IsRowExpanded(ExpandedRowIndex)) { 
            //bool EnterpriseAuthorized = rc_services.CheckPermission("ent_roadmap");
            //gridAssociatedItems.DataSource = rc_services.GetRoadmapAttachments(KeyValue);
            //}  
            //RC_X.controls.attacher RoadmapArtifacts;
            //RoadmapArtifacts = (RC_X.controls.attacher)gridRoadmap.FindDetailRowTemplateControl(ExpandedRowIndex, "RoadmapArtifacts");
            //RoadmapArtifacts.ItemKey = KeyValue;

        }

        

        protected void sqlGapandGoals_Init(object sender, EventArgs e)
        {
            SqlDataSource sqlGapandGoals = (SqlDataSource)sender;
            sqlGapandGoals.ConnectionString = Session["userConnString"].ToString();
        }

        protected void gridAssociatedGapsGoals_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            if (Session["TaskID"] != null)
            {
                ASPxGridView gridAssociatedGapsGoals = (ASPxGridView)sender;
                ASPxGridView gridGapandGoals = (ASPxGridView)gridAssociatedGapsGoals.FindEditFormLayoutItemTemplateControl("gridGapandGoals");
                List<string> ItemsList = new List<string>();
                for (int i = 0; i <= gridGapandGoals.VisibleRowCount; i = i + 1)
                {
                    if (gridGapandGoals.Selection.IsRowSelected(i) == true)
                    {
                        ItemsList.Add(gridGapandGoals.GetRowValues(i, "gap_id").ToString());
                    }
                }
                rc_services.InsertAssociatedGapsandGoals(Session["TaskID"].ToString(), ItemsList);
                e.Cancel = true;
                gridAssociatedGapsGoals.CancelEdit();
                gridAssociatedGapsGoals.DataBind();
            }
        }

        protected void sqlAssociatedGapandGoals_Init(object sender, EventArgs e)
        {
            SqlDataSource sqlAssociatedGapandGoals = (SqlDataSource)sender;
            sqlAssociatedGapandGoals.ConnectionString = Session["userConnString"].ToString();
        }

        protected void gvTasksAttachments_BeforePerformDataSelect(object sender, EventArgs e)
        {
            Session["TaskID"] = (sender as ASPxGridView).GetMasterRowKeyValue();
           // Session["ProjectID"] = Guid.Parse(System.Web.HttpContext.Current.Session["projectID"].ToString());
            

            //String ItemKey = Session["TaskID"].ToString();


            //gvTasksAttachments.DataSource = rc_services.GetAttachments(Guid.Parse(ItemKey));
            //gvTasksAttachments.DataBind();
        }

        protected void SqlTasksAttachments_Init(object sender, EventArgs e)
        {
            SqlDataSource SqlTasksAttachments = (SqlDataSource)sender;
            SqlTasksAttachments.ConnectionString = Session["userConnString"].ToString();
        }

        protected void gridAssociatedGapsGoals_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e)
        {

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