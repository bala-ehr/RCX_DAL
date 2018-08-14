using DevExpress.Spreadsheet;
using DevExpress.Web;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.ASPxRichEdit;
using DevExpress.XtraRichEdit;
using DevExpress.Web.ASPxSpreadsheet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Linq;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Configuration;

namespace RC_X
{
    public partial class pro_rtm : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            if (rc_services.CheckPermission("pro_rtm_view") || !rc_services.CheckPermission("ent_Project_RTM_edit"))
            {
                if (rc_services.CheckPermission("ent_IVV") && rc_services.CheckPermission("pro_IVV"))
                {
                    gridIVVRTM.Columns[6].Visible = false;
                    gridIVVRTM.Columns[7].Visible = false;
                    gridIVVRTM.Columns[8].Visible = false;
                }
                else
                {
                    gridRTM.Columns[6].Visible = false;
                    gridRTM.Columns[7].Visible = false;
                    gridRTM.Columns[8].Visible = false;
                    gridRTM.Columns[9].Visible = false;
                }
                
               

            }


        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            BindMainGrids();
        }
        public void BindMainGrids()
        {
            var projectId = Session["projectID"].ToString();
            var milestoneId = Session["MilestoneID"].ToString();

            if (rc_services.CheckPermission("pro_RTM_CSF"))
            {
                
                if (rc_services.CheckPermission("pro_RTM_edit"))
                {
                    var AssessmentAutorized = true;
                    var CSF = false;
                    if (rc_services.CheckPermission("ent_IVV") && rc_services.CheckPermission("pro_IVV"))
                    {

                        gridIVVRTM.DataSource = rtm_services.GetProjectResponses(projectId, milestoneId, AssessmentAutorized, CSF);
                        gridIVVRTM.DataBind();
                        gridIVVRTM.Visible = true;
                        gridRTM.Visible = false;
                    }
                    else
                    {

                        var data = rtm_services.GetProjectResponses(projectId, milestoneId, AssessmentAutorized, CSF);
                        gridRTM.DataSource = data;
                        gridRTM.DataBind();
                        gridRTM.Visible = true;
                        gridIVVRTM.Visible = false;
                    }
                }
                else
                {
                    var CSF = false;
                    if (rc_services.CheckPermission("ent_IVV") && rc_services.CheckPermission("pro_IVV"))
                    {

                        gridIVVRTM.DataSource = rtm_services.GetProjectResponses(projectId, milestoneId, CSF);
                        gridIVVRTM.DataBind();
                        gridIVVRTM.Visible = true;
                        gridRTM.Visible = false;
                    }
                    else
                    {

                        var data = rtm_services.GetProjectResponses(projectId, milestoneId, CSF);
                        gridRTM.DataSource = data;
                        gridRTM.DataBind();
                        gridRTM.Visible = true;
                        gridIVVRTM.Visible = false;
                    }
                }
            }
            else
            {
                if (rc_services.CheckPermission("pro_RTM_edit"))
                {
                    var AssessmentAutorized = true;
                    if (rc_services.CheckPermission("ent_IVV") && rc_services.CheckPermission("pro_IVV"))
                    {

                        gridIVVRTM.DataSource = rtm_services.GetProjectResponses(projectId, milestoneId, AssessmentAutorized);
                        gridIVVRTM.DataBind();
                        gridIVVRTM.Visible = true;
                        gridRTM.Visible = false;
                    }
                    else
                    {

                        var data = rtm_services.GetProjectResponses(projectId, milestoneId, AssessmentAutorized);
                        gridRTM.DataSource = data;
                        gridRTM.DataBind();
                        gridRTM.Visible = true;
                        gridIVVRTM.Visible = false;
                    }
                }
                else
                {
                    if (rc_services.CheckPermission("ent_IVV") && rc_services.CheckPermission("pro_IVV"))
                    {

                        gridIVVRTM.DataSource = rtm_services.GetProjectResponses(projectId, milestoneId);
                        gridIVVRTM.DataBind();
                        gridIVVRTM.Visible = true;
                        gridRTM.Visible = false;
                    }
                    else
                    {

                        var data = rtm_services.GetProjectResponses(projectId, milestoneId);
                        gridRTM.DataSource = data;
                        gridRTM.DataBind();
                        gridRTM.Visible = true;
                        gridIVVRTM.Visible = false;
                    }
                }
            }

        }

        #region Workflow
        protected void gridWorkflow_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            String ItemKey = Session["CriteriaId"].ToString();
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
            gridWorkflow.DataSource = rc_services.GetWorkflow(Guid.Parse(ItemKey), projectID);  //need to write
            gridWorkflow.DataBind();
            gridWorkflow.CancelEdit();
        }

        protected void gridWorkflow_BeforePerformDataSelect(object sender, EventArgs e)
        {
            Session["CriteriaId"] = (sender as ASPxGridView).GetMasterRowKeyValue();
            Guid projectID = Guid.Parse(Session["projectID"].ToString());
            String ItemKey = Session["CriteriaId"].ToString();
            ASPxGridView gridWorkflow = (ASPxGridView)sender;
            gridWorkflow.DataSource = rc_services.GetWorkflow(Guid.Parse(ItemKey), projectID);   //need to write
            //gridWorkflow.DataBind();
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
            dropUser.DataSource = rc_services.GetUsers();   ////  need to parse it as true or false in rc_services file.
            dropUser.DataBind();
        }
        #endregion

        #region Response
        protected void gridResponse_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            String MilestoneID = Session["MilestoneID"].ToString();
            String ItemID = Session["CriteriaId"].ToString();
            ASPxGridView gridResponse = (ASPxGridView)sender;
            //ASPxComboBox AssessmentValue = (ASPxComboBox)gridResponse.FindEditFormLayoutItemTemplateControl("dropAssessment");
            ASPxHtmlEditor txResponse = (ASPxHtmlEditor)gridResponse.FindEditFormLayoutItemTemplateControl("txResponse");

            AssessmentResponse NewResponse = new AssessmentResponse
            {
                MilestoneID = Guid.Parse(Session["MilestoneID"].ToString()),
                ItemKey = Guid.Parse(ItemID),
                Assesment = e.NewValues["Assesment"].ToString(),
                Response = txResponse.Html
            };
          
            rc_services.InsertNewResponse(NewResponse);
            e.Cancel = true;
            gridResponse.DataSource = rc_services.GetResponse(Guid.Parse(ItemID), MilestoneID);
            gridResponse.DataBind();
            gridResponse.CancelEdit();
           
        }

        protected void gridResponse_BeforePerformDataSelect(object sender, EventArgs e)
        {
            
            Guid projectID = Guid.Parse(Session["projectID"].ToString());
            String ItemKey = Session["CriteriaId"].ToString();
            String MilestoneID = Session["MilestoneID"].ToString();
            ASPxGridView gridResponse = (ASPxGridView)sender;
            gridResponse.DataSource = rc_services.GetResponse(Guid.Parse(ItemKey), MilestoneID);
        }

        protected void gridResponse_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            String MilestoneID = Session["MilestoneID"].ToString();
            String ItemID = Session["CriteriaId"].ToString();
            ASPxGridView gridResponse = (ASPxGridView)sender;
          
            ASPxHtmlEditor txResponse = (ASPxHtmlEditor)gridResponse.FindEditFormLayoutItemTemplateControl("txResponse");

            AssessmentResponse UpdateResponse = new AssessmentResponse
            {
                ResponseID = Guid.Parse(e.Keys["ResponseID"].ToString()),
                MilestoneID = Guid.Parse(Session["MilestoneID"].ToString()),
                ItemKey = Guid.Parse(ItemID),
                Assesment = e.NewValues["Assesment"].ToString(),
                Response = txResponse.Html
            };

            rc_services.SaveResponse(UpdateResponse);
            e.Cancel = true;
            gridResponse.DataSource = rc_services.GetResponse(Guid.Parse(ItemID));
            gridResponse.DataBind();
            gridResponse.CancelEdit();
           
        }

        protected void gridResponse_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e)
        {
            if (e.Column.FieldName == "Assesment")
            {
                ASPxComboBox cmb = e.Editor as ASPxComboBox;
                cmb.DataSource = common_services.GetCustomDropDown("response");
                cmb.ValueField = "Name";
                cmb.ValueType = typeof(String);
                cmb.TextField = "Name";
                cmb.DataBindItems();
            }
        }
        #endregion

        #region Evaluation
        protected void gridEvaluation_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            ASPxGridView gridEvaluation = (ASPxGridView)sender;
            var user = HttpContext.Current.Session["UserEmail"].ToString();
            String ItemID = Session["CriteriaId"].ToString();
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

        protected void gridEvaluation_BeforePerformDataSelect(object sender, EventArgs e)
        {
            String ItemID = Session["CriteriaId"].ToString();
            
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
        #endregion

        #region Arifacts

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
                        ItemID = Session["CriteriaId"].ToString()


                       
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

        protected void gridRepository_BeforePerformDataSelect(object sender, EventArgs e)
        {
            ASPxGridView gridRepository = (ASPxGridView)sender;
            gridRepository.DataSource = rc_services.GetRepository("P", false);
        }

        protected void gridArtifacts_BeforePerformDataSelect(object sender, EventArgs e)
        {
            ASPxGridView gridArtifacts = (ASPxGridView)sender;
            String ItemKey = Session["CriteriaId"].ToString();
            gridArtifacts.DataSource = rc_services.GetAttachments(Guid.Parse(ItemKey));
        }

        protected void gridArtifacts_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            rc_services.DeleteAttachment(Guid.Parse(e.Keys[0].ToString()));
            e.Cancel = true;
            ASPxGridView gridArtifacts = (ASPxGridView)sender;
            String ItemKey = Session["CriteriaId"].ToString();
            gridArtifacts.DataSource = rc_services.GetAttachments(Guid.Parse(ItemKey));
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
        #endregion

        protected void gridRTM_DetailRowExpandedChanged(object sender, ASPxGridViewDetailRowEventArgs e)
        {
            Session["CriteriaId"] = (sender as ASPxGridView).GetMasterRowKeyValue();

            
        }
    }
}