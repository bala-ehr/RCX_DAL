using DevExpress.Web;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.ASPxRichEdit;
using DevExpress.Web.ASPxSpreadsheet;
using DevExpress.Web.ASPxTreeList;
using DevExpress.Web.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace RC_X
{
    public partial class Assessment : System.Web.UI.Page
    {
        public Scorecard CurrentCard;
        
        public String ScorecardKey
        {
            get { if (paramScorecard.Contains("ScorecardKey")) { return paramScorecard["ScorecardKey"] as string; } else { return null; } }
            set { paramScorecard.Set("ScorecardKey", value); }
        }
       
        protected void Page_Init(object sender, EventArgs e)
        {
            if (rc_services.CheckPermission("pro_assessment_view") || !rc_services.CheckPermission("ent_Project_assessment_edit"))
            {

            }


        }
        //Guid nodeKey;
        protected void Page_Load(object sender, EventArgs e)
        {
            BindMainGrids();
        }

        public void BindMainGrids()
        {
            var projectId = Session["projectID"].ToString();
            var milestoneId = Session["MilestoneID"].ToString();

            if (rc_services.CheckPermission("pro_assessment_evaluate"))
            {
                bool AssessmentAutorized = true;
                var dataArea = rtm_services.GetAssessmentArea(projectId, AssessmentAutorized);
                gridArea.DataSource = dataArea;
                gridArea.DataBind();

                var dataCategory = rtm_services.GetAssessmentCategory(projectId, AssessmentAutorized);
                gridCategory.DataSource = dataCategory;
                gridCategory.DataBind();

                var dataProcesses = rtm_services.GetAssessmentProcesses(projectId, AssessmentAutorized);
                gridProcesses.DataSource = dataProcesses;
                gridProcesses.DataBind();


            }
            else
            {
                var dataArea = rtm_services.GetAssessmentArea(projectId);
                gridArea.DataSource = dataArea;
                gridArea.DataBind();

                var dataCategory = rtm_services.GetAssessmentCategory(projectId);
                gridCategory.DataSource = dataCategory;
                gridCategory.DataBind();

                var dataProcesses = rtm_services.GetAssessmentProcesses(projectId);
                gridProcesses.DataSource = dataProcesses;
                gridProcesses.DataBind();

            }
            var frontMatter = rtm_services.GetFrontMatter(projectId);
            gridFrontMatter.DataSource = frontMatter;
            gridFrontMatter.DataBind();
        }

        #region FrontMatter
        protected void gridFrontMatter_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            ASPxHtmlEditor txtDescription = (ASPxHtmlEditor)gridFrontMatter.FindEditFormLayoutItemTemplateControl("txtDescription");
            FrontMatter NewFrontMatter = new FrontMatter();
            NewFrontMatter.ProjectID = Guid.Parse(Session["projectID"].ToString());
            NewFrontMatter.Name = e.NewValues["Name"].ToString();
            NewFrontMatter.Description = txtDescription.Html;



            rtm_services.NewFrontMatter(NewFrontMatter);
            e.Cancel = true;
            var projectId = Session["projectID"].ToString();
            gridFrontMatter.DataSource = rtm_services.GetFrontMatter(projectId);
            gridFrontMatter.DataBind();
            gridFrontMatter.CancelEdit();
        }

        protected void gridFrontMatter_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            ASPxHtmlEditor txtDescription = (ASPxHtmlEditor)gridFrontMatter.FindEditFormLayoutItemTemplateControl("txtDescription");
            FrontMatter EditFrontMatter = new FrontMatter();
            EditFrontMatter.FrontMatterID = e.Keys["FrontMatterID"].ToString();
            EditFrontMatter.Name = e.NewValues["Name"].ToString();
            EditFrontMatter.Description = txtDescription.Html;



            rtm_services.UpdateFrontMatter(EditFrontMatter);
            e.Cancel = true;
            var projectId = Session["projectID"].ToString();
            gridFrontMatter.DataSource = rtm_services.GetFrontMatter(projectId);
            gridFrontMatter.DataBind();
            gridFrontMatter.CancelEdit();
        }

        protected void gridFrontMatter_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            FrontMatter DeleteFrontMatter = new FrontMatter();
            DeleteFrontMatter.FrontMatterID = e.Keys["FrontMatterID"].ToString();
            rtm_services.DeleteFrontMatter(DeleteFrontMatter);
            e.Cancel = true;
            var projectId = Session["projectID"].ToString();
            gridFrontMatter.DataSource = rtm_services.GetFrontMatter(projectId);
            gridFrontMatter.DataBind();


        }

        #endregion

        #region Workflow
        protected void gridWorkflow_BeforePerformDataSelect(object sender, EventArgs e)
        {
            ASPxPageControl pc = gridArea.FindControl("ASPxPageControlArea") as ASPxPageControl;
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
            String ItemKey = Session["ItemKey"].ToString();
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

        #region Responses
        protected void gridResponse_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e)
        {
            if (e.Column.FieldName == "MilestoneName")
            {
                ASPxComboBox cmb = e.Editor as ASPxComboBox;
                cmb.DataSource = common_services.GetFluidMilestones();
                cmb.ValueField = "Id";
                cmb.ValueType = typeof(String);
                cmb.TextField = "Name";
                cmb.DataBindItems();
            }
        }

        protected void gridResponse_BeforePerformDataSelect(object sender, EventArgs e)
        {
            Guid projectID = Guid.Parse(Session["projectID"].ToString());
            String ItemKey = Session["ItemKey"].ToString();
            ASPxGridView gridResponse = (ASPxGridView)sender;
            gridResponse.DataSource = rc_services.GetResponse(Guid.Parse(ItemKey));
        }

        protected void gridResponse_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {

            String ItemID = Session["ItemKey"].ToString();
            ASPxGridView gridResponse = (ASPxGridView)sender;
            ASPxHtmlEditor txResponse = (ASPxHtmlEditor)gridResponse.FindEditFormLayoutItemTemplateControl("txResponse");
            Guid Milestoneid = Guid.Parse(e.NewValues["MilestoneName"].ToString());
            
            AssessmentResponse NewResponse = new AssessmentResponse
            {
               
            MilestoneID = Guid.Parse(e.NewValues["MilestoneName"].ToString()),
                ItemKey = Guid.Parse(ItemID),

                Response = txResponse.Html
            };

            rc_services.InsertNewResponse(NewResponse);
            e.Cancel = true;
            gridResponse.DataSource = rc_services.GetResponse(Guid.Parse(ItemID));
            gridResponse.DataBind();
            gridResponse.CancelEdit();

            BindMainGrids();

        }

        protected void gridResponse_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            // String MilestoneID = Session["MilestoneID"].ToString();
            String ItemID = Session["ItemKey"].ToString();
            ASPxGridView gridResponse = (ASPxGridView)sender;

            ASPxHtmlEditor txResponse = (ASPxHtmlEditor)gridResponse.FindEditFormLayoutItemTemplateControl("txResponse");

            AssessmentResponse UpdateResponse = new AssessmentResponse
            {
                ResponseID = Guid.Parse(e.Keys["ResponseID"].ToString()),
                MilestoneName = e.NewValues["MilestoneName"].ToString(),
                ItemKey = Guid.Parse(ItemID),
               // MilestoneID = Guid.Parse(""),

                Response = txResponse.Html
            };
            rc_services.SaveResponse(UpdateResponse);

            e.Cancel = true;
            gridResponse.DataSource = rc_services.GetResponse(Guid.Parse(ItemID));
            gridResponse.DataBind();
            gridResponse.CancelEdit();

            BindMainGrids();
        }
        #endregion

        #region ScoreCard
        protected void gridScorecard_BeforePerformDataSelect(object sender, EventArgs e)
        {

            ASPxPageControl pc = gridArea.FindControl("ASPxPageControlArea") as ASPxPageControl;
            ASPxComboBox cb = gridArea.FindDetailRowTemplateControl(3, "ddlScorecard") as ASPxComboBox;
            ASPxGridView gridScorecard = (ASPxGridView)sender;
         
            
            String ItemKey = Session["ItemKey"].ToString();
           
            Guid projectID = Guid.Parse(Session["projectID"].ToString());


            if (CurrentCard != null)
            {

                //Bind Grid

                gridScorecard.DataSource = rc_services.GetScores((String)Session["ProjectID"], ItemKey, ScorecardKey);

                //Get ScoreCard Info

                //Prep the COlumns
                //Get the Score COlumns
                GridViewColumn Score1 = gridScorecard.Columns["ScoreCol1"];
                GridViewColumn Score2 = gridScorecard.Columns["ScoreCol2"];
                GridViewColumn Score3 = gridScorecard.Columns["ScoreCol3"];
                GridViewColumn Score4 = gridScorecard.Columns["ScoreCol4"];
                GridViewColumn Score5 = gridScorecard.Columns["ScoreCol5"];

                ////now check which score columns are enabled, and set their visibility                
                Score1.Visible = CurrentCard.EnabledCol1; //ComboHeader1.Visible = Col1Visible;
                Score2.Visible = CurrentCard.EnabledCol2; //ComboHeader2.Visible = Col2Visible;
                Score3.Visible = CurrentCard.EnabledCol3; //ComboHeader3.Visible = Col3Visible;
                Score4.Visible = CurrentCard.EnabledCol4; //ComboHeader4.Visible = Col4Visible;
                Score5.Visible = CurrentCard.EnabledCol5; //ComboHeader5.Visible = Col5Visible;


                ////Set Their captions
                Score1.Caption = CurrentCard.CardCol1;
                Score2.Caption = CurrentCard.CardCol2;
                Score3.Caption = CurrentCard.CardCol3;
                Score4.Caption = CurrentCard.CardCol4;
                Score5.Caption = CurrentCard.CardCol5;

                ////Check if measure are enabled, if so, set their visibility and captions (if that score column is visible)

                ////Get Measure Columns
                GridViewColumn Measure1 = gridScorecard.Columns["Measure1"];
                GridViewColumn Measure2 = gridScorecard.Columns["Measure2"];
                GridViewColumn Measure3 = gridScorecard.Columns["Measure3"];
                GridViewColumn Measure4 = gridScorecard.Columns["Measure4"];
                GridViewColumn Measure5 = gridScorecard.Columns["Measure5"];

                if (CurrentCard.MeasuredEnabled == true)
                {
                    Measure1.Visible = CurrentCard.EnabledCol1;
                    Measure2.Visible = CurrentCard.EnabledCol2;
                    Measure3.Visible = CurrentCard.EnabledCol3;
                    Measure4.Visible = CurrentCard.EnabledCol4;
                    Measure5.Visible = CurrentCard.EnabledCol5;
                }
                else
                {
                    Measure1.Visible = false;
                    Measure2.Visible = false;
                    Measure3.Visible = false;
                    Measure4.Visible = false;
                    Measure5.Visible = false;
                }

            }
            
           


        }

        protected void ddlScorecard_Init(object sender, EventArgs e)
        {
            
            ASPxComboBox ddlScorecard = (ASPxComboBox)sender;
            String ItemKey = Session["Key"].ToString();
            CurrentCard = null;

           
            //rebind cards dropdown

            List<Scorecard> ItemScoreCards = rc_services.GetScorecards(ItemKey);
            ddlScorecard.DataSource = ItemScoreCards;
            ddlScorecard.DataBind();

            ////Get all of the scorecardinfo through by finfing the scorecard object in the list
            foreach (Scorecard x in ItemScoreCards)
            {
                if (x.CardId == ScorecardKey)
                {
                    CurrentCard = x;
                }
            }

           
            if (CurrentCard == null && ddlScorecard.Items.Count > 0 && ddlScorecard.Items[0].Text != String.Empty)
            {
                ddlScorecard.SelectedIndex = 0;
                ScorecardKey = ddlScorecard.Value.ToString();
                foreach (Scorecard x in ItemScoreCards)
                {
                    if (x.CardId == ScorecardKey)
                    {
                        CurrentCard = x;
                    }
                }
            }
            if (CurrentCard != null)
            {
                ddlScorecard.Text = CurrentCard.CardName;
                paramScorecard.Set("CardName", CurrentCard.CardName);
            }




        }

        protected void gridArea_DetailRowExpandedChanged(object sender, ASPxGridViewDetailRowEventArgs e)
        {
            String AreaID = gridArea.GetRowValues(e.VisibleIndex, "area_id").ToString();
            Session["Key"] = AreaID;
            String ItemKey = Session["Key"].ToString();

            

            //ASPxPageControl pc = .FindControl("ASPxPageControlArea") as ASPxPageControl;
            //ASPxComboBox cb = pc.FindControl("ddlScorecard") as ASPxComboBox;

        }

        protected void gridProcesses_DetailRowExpandedChanged(object sender, ASPxGridViewDetailRowEventArgs e)
        {
            String ProcessessID = gridProcesses.GetRowValues(e.VisibleIndex, "bp_id").ToString();
            Session["Key"] = ProcessessID;
            
        }

        protected void gridCategory_DetailRowExpandedChanged(object sender, ASPxGridViewDetailRowEventArgs e)
        {
            String CategoryID = gridCategory.GetRowValues(e.VisibleIndex, "cat_id").ToString();
            Session["Key"] = CategoryID;
        }

        protected void gridScorecard_BatchUpdate(object sender, DevExpress.Web.Data.ASPxDataBatchUpdateEventArgs e)
        {
            ScoreStandardsList NewScores = new ScoreStandardsList();

            foreach (ASPxDataUpdateValues x in e.UpdateValues)
            {

                NewScores.Add(new ScoreStandards
                {
                    ScoreId = (String)x.Keys["ScoreId"],
                    //ProjectID = (String)Session["ProjectID"],
                    //StandardID = (String)x.NewValues["StandardID"],
                    //CardID = (String)x.NewValues["CardID"],
                    //ItemID = (String)x.NewValues["ItemID"],
                    ScoreCol1 = x.NewValues["ScoreCol1"] != null ? (int)x.NewValues["ScoreCol1"] : 0,
                    ScoreCol2 = x.NewValues["ScoreCol2"] != null ? (int)x.NewValues["ScoreCol2"] : 0,
                    ScoreCol3 = x.NewValues["ScoreCol3"] != null ? (int)x.NewValues["ScoreCol3"] : 0,
                    ScoreCol4 = x.NewValues["ScoreCol4"] != null ? (int)x.NewValues["ScoreCol4"] : 0,
                    ScoreCol5 = x.NewValues["ScoreCol5"] != null ? (int)x.NewValues["ScoreCol5"] : 0,
                    Measure1 = (String)x.NewValues["Measure1"],
                    Measure2 = (String)x.NewValues["Measure2"],
                    Measure3 = (String)x.NewValues["Measure3"],
                    Measure4 = (String)x.NewValues["Measure4"],
                    Measure5 = (String)x.NewValues["Measure5"]
                });
            }

            rc_services.SaveScores(NewScores);
            e.Handled = true;
           
          
        }

        #endregion

        #region Evaluation
        protected void gridEvaluation_BeforePerformDataSelect(object sender, EventArgs e)
        {
            Session["ItemKey"] = (sender as ASPxGridView).GetMasterRowKeyValue();
            String ItemID = Session["ItemKey"].ToString();

            ASPxGridView gridEvaluation = (ASPxGridView)sender;
            if (rc_services.CheckPermission("pro_RTM_evaluation_readonly"))
            {
                gridEvaluation.DataSource = rc_services.GetEvaluation(ItemID);
                gridEvaluation.SettingsDataSecurity.AllowEdit = false;

            }
            else if (rc_services.CheckPermission("pro_RTM_evaluation_read"))
            {
                string user = HttpContext.Current.Session["UserEmail"].ToString();
                gridEvaluation.DataSource = rc_services.GetEvaluation(ItemID, user);
            }
            else
            {
                gridEvaluation.DataSource = rc_services.GetEvaluation(ItemID);

            }
        }

        protected void gridEvaluation_RowInserting(object sender, ASPxDataInsertingEventArgs e)
        {
            ASPxGridView gridEvaluation = (ASPxGridView)sender;
            var user = HttpContext.Current.Session["UserEmail"].ToString();
            String ItemID = Session["ItemKey"].ToString();
            ResponseEvaluation re = new ResponseEvaluation();

            re.ItemID = Guid.Parse(ItemID);
            re.ReviwerDate = DateTime.Parse(e.NewValues["eval_date"].ToString());

            // re.ReviwerBy = e.NewValues["eval_by"].ToString();
            re.ReviwerBy = user;
            re.ReviwerComments = e.NewValues["eval_description"].ToString();
            re.ReviwerAssessment = e.NewValues["eval_reviewer_assessments"].ToString();

            rc_services.InsertNewEvaluation(re);

            e.Cancel = true;
            gridEvaluation.CancelEdit();
        }

        #endregion

        protected void sqlScorecard_Init(object sender, EventArgs e)
        {
            SqlDataSource sqlScorecard = (SqlDataSource)sender;
            sqlScorecard.ConnectionString = Session["userConnString"].ToString();
        }

        protected void ddlScorecard_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

      

        
    }
}