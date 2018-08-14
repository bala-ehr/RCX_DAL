using DevExpress.Web;
using DevExpress.Web.Data;
using DevExpress.WebUtils;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Data;
using RC_X;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OfficeOpenXml;

namespace RC_X.rc_enterprise
{
    public partial class ent_assessment : System.Web.UI.Page
    {
        protected string SubmissionID
        {
            get
            {
                return hdbSubmissionID.Get("SubmissionID").ToString();
            }
            set
            {
                hdbSubmissionID.Set("SubmissionID", value);
            }
        }

        UploadedFilesStorage UploadedFilesStorage
        {
            get { return UploadControlHelper.GetUploadedFilesStorageByKey(SubmissionID); }
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            UploadControlHelper.RemoveOldStorages();
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            if (!rc_services.CheckPermission("ent_assessment")) { Response.Redirect("~/controls/unauthorized.aspx"); }
           
            if (!rc_services.CheckPermission("ent_assessment_edit"))
            {
                gridArea.Columns[6].Visible = false;
                gridCategory.Columns[7].Visible = false;
                gridProcess.Columns[9].Visible = false;

                //With column hiddens, disableing batch edit prevents any edits by the uyser
                gridArea.SettingsEditing.Mode = GridViewEditingMode.EditForm;
                gridCategory.SettingsEditing.Mode = GridViewEditingMode.EditForm;
                gridProcess.SettingsEditing.Mode = GridViewEditingMode.EditForm;
            }
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (!IsPostBack)
            {
                BindDropdown();
                SubmissionID = UploadControlHelper.GenerateUploadedFilesStorageKey();
                UploadControlHelper.AddUploadedFilesStorage(SubmissionID);
            }
            else if (gridProcess.IsCallback)
            {
                BindProcess(ddlProjects.SelectedItem.Value.ToString());
            }

            BindArea();
            BindCategory();

            if (!IsPostBack)
            {
                Session["UploadedData"] = null;
                gvAssesmentUpload.DataSource = null;
                gvAssesmentUpload.Columns.Clear();
                gvAssesmentUpload.AutoGenerateColumns = true;
                gvAssesmentUpload.DataBind();
            }
            else
            {
                if (Session["UploadedData"] != null)
                {
                    gvAssesmentUpload.DataSource = Session["UploadedData"];
                    gvAssesmentUpload.DataBind();
                }
            }
        }

        #region BindingMethods
        public void BindArea()
        {
            gridArea.DataSource = rtm_services.GetBusinessArea();
            gridArea.DataBind();
        }

        public void BindCategory()
        {
            gridCategory.DataSource = rtm_services.GetBusinessCategories();
            gridCategory.DataBind();
        }

        public void BindProcess(string projectId)
        {
            gridProcess.DataSource = rtm_services.GetBusinessProcess(projectId);
            gridProcess.DataBind();
        }

        public void BindDropdown()
        {
            ddlProjects.DataSource = common_services.GetProjects();
            ddlProjects.DataBind();
            if (!IsPostBack)
            {
                ddlProjects.SelectedItem = ddlProjects.Items.FindByValue(Session["projectID"].ToString());
            }
            BindProcess(Convert.ToString(ddlProjects.SelectedItem.Value));
        }

        protected void ddlProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindProcess(Convert.ToString(ddlProjects.SelectedItem.Value));
        }

        #endregion
        // Method for  grid update for GridArea
        protected void GridArea_BatchUpdate(object sender, ASPxDataBatchUpdateEventArgs e)
        {
            var listInsert = new List<BusinessArea>();
            foreach (var args in e.InsertValues)
            {
                //InsertNewItem(args.NewValues);
                BusinessArea Area = new BusinessArea();
                Area.AreaTitle = Convert.ToString(args.NewValues["AreaTitle"]);
                Area.UniqueID = Convert.ToString(args.NewValues["UniqueID"]);
                Area.Description = Convert.ToString(args.NewValues["Description"]);
                Area.Source = Convert.ToString(args.NewValues["Source"]);
                Area.Date = Convert.ToDateTime(args.NewValues["Date"]);
                listInsert.Add(Area);
            }
            if (listInsert.Count > 0)
            {
                rtm_services.InsertNewBusinessArea(listInsert);
            }
            var listUpdates = new List<BusinessArea>();
            foreach (var args in e.UpdateValues)
            {
                BusinessArea Area = new BusinessArea();
                Area.Id = Convert.ToString(args.Keys["Id"]);
                Area.AreaTitle = Convert.ToString(args.NewValues["AreaTitle"]);
                Area.UniqueID = Convert.ToString(args.NewValues["UniqueID"]);
                Area.Description = Convert.ToString(args.NewValues["Description"]);
                Area.Source = Convert.ToString(args.NewValues["Source"]);
                Area.Date = Convert.ToDateTime(args.NewValues["Date"]);
                listUpdates.Add(Area);
            }
            if (listUpdates.Count > 0)
            {
                rtm_services.UpdateBusinessArea(listUpdates);
            }
            foreach (var args in e.DeleteValues)
                DeleteArea(args.Keys);
            e.Handled = true;

            BindArea();
            BindCategory();
            BindProcess(ddlProjects.SelectedItem.Value.ToString());
        }

        private void DeleteArea(OrderedDictionary keys)
        {
            var result = rtm_services.DeleteArea(keys["Id"].ToString());
        }

        // Method for  grid update for GridCategory
        protected void GridCategory_BatchUpdate(object sender, ASPxDataBatchUpdateEventArgs e)
        {
            var listInsert = new List<BusinessCategory>();
            foreach (var args in e.InsertValues)
            {
                //InsertNewItem(args.NewValues);
                BusinessCategory category = new BusinessCategory();
                category.AreaID = Convert.ToString(args.NewValues["AreaID"]);
                category.UniqueID = Convert.ToString(args.NewValues["UniqueID"]);
                category.CategoryTitle = Convert.ToString(args.NewValues["CategoryTitle"]);
                category.Description = Convert.ToString(args.NewValues["Description"]);
                category.Source = Convert.ToString(args.NewValues["Source"]);
                category.Date = Convert.ToDateTime(args.NewValues["Date"]);
                listInsert.Add(category);
            }
            if (listInsert.Count > 0)
            {
                rtm_services.InsertNewBusinessCategory(listInsert);
            }
            var listUpdates = new List<BusinessCategory>();
            foreach (var args in e.UpdateValues)
            {
                BusinessCategory category = new BusinessCategory();
                category.Id = Convert.ToString(args.Keys["Id"]);
                category.UniqueID = Convert.ToString(args.NewValues["UniqueID"]);
                category.CategoryTitle = Convert.ToString(args.NewValues["CategoryTitle"]);
                category.Description = Convert.ToString(args.NewValues["Description"]);
                category.Source = Convert.ToString(args.NewValues["Source"]);
                category.Date = Convert.ToDateTime(args.NewValues["Date"]);

                listUpdates.Add(category);
            }
            if (listUpdates.Count > 0)
            {
                rtm_services.UpdateBusinessCategory(listUpdates);
            }

            foreach (var args in e.DeleteValues)
                DeleteCategoryItem(args.Keys);
            e.Handled = true;
            BindCategory();
            BindProcess(ddlProjects.SelectedItem.Value.ToString());
        }
        private void DeleteCategoryItem(OrderedDictionary keys)
        {
            var result = rtm_services.DeleteCategory(keys["Id"].ToString());
        }

        // Method for  grid update for GridProcess
        protected void GridProcess_BatchUpdate(object sender, ASPxDataBatchUpdateEventArgs e)
        {


            var listInsert = new List<BusinessProcess>();
            foreach (var args in e.InsertValues)
            {
                //InsertNewItem(args.NewValues);
                BusinessProcess process = new BusinessProcess();
                process.CategoryId = Convert.ToString(args.NewValues["CategoryId"]);
                process.UniqueID = Convert.ToString(args.NewValues["UniqueID"]);
                process.ProcessTitle = Convert.ToString(args.NewValues["ProcessTitle"]);
                process.Description = Convert.ToString(args.NewValues["Description"]);
                process.Source = Convert.ToString(args.NewValues["Source"]);
                process.Date = Convert.ToDateTime(args.NewValues["Date"]);
                listInsert.Add(process);
            }
            if (listInsert.Count > 0)
            {
                rtm_services.InsertNewBusinessProcesses(listInsert);
            }
            var listUpdates = new List<BusinessProcess>();
            foreach (var args in e.UpdateValues)
            {
                BusinessProcess process = new BusinessProcess();
                process.Id = Convert.ToString(args.Keys["Id"]);
                process.UniqueID = Convert.ToString(args.NewValues["UniqueID"]);
                process.ProcessTitle = Convert.ToString(args.NewValues["ProcessTitle"]);
                process.Description = Convert.ToString(args.NewValues["Description"]);
                process.Source = Convert.ToString(args.NewValues["Source"]);
                process.Date = Convert.ToDateTime(args.NewValues["Date"]);
                process.IsActive = Convert.ToBoolean(args.NewValues["IsActive"]);
                listUpdates.Add(process);
            }
            if (listUpdates.Count > 0)
            {
                rtm_services.UpdateProcessDetails(ddlProjects.SelectedItem.Value.ToString(), listUpdates);
            }
            foreach (var args in e.DeleteValues)
                DeleteProcessItem(args.Keys);
            e.Handled = true;
            BindProcess(ddlProjects.SelectedItem.Value.ToString());

        }
        private void DeleteProcessItem(OrderedDictionary keys)
        {
            var result = rtm_services.DeleteProcess(keys["Id"].ToString(), ddlProjects.SelectedItem.Value.ToString());
        }

        protected void DocumentsUploadControl_FileUploadComplete(object sender, FileUploadCompleteEventArgs e)
        {
            bool isSubmissionExpired = false;
            if (UploadedFilesStorage == null)
            {
                isSubmissionExpired = true;
                UploadControlHelper.AddUploadedFilesStorage(SubmissionID);
            }
            UploadedFileInfo tempFileInfo = UploadControlHelper.AddUploadedFileInfo(SubmissionID, e.UploadedFile.FileName);

            e.UploadedFile.SaveAs(tempFileInfo.FilePath);

            if (e.IsValid)
                e.CallbackData = tempFileInfo.UniqueFileName + "|" + isSubmissionExpired;
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            ValidateInputData();

            List<UploadedFileInfo> resultFileInfos = new List<UploadedFileInfo>();
            DataTable data = null;

          
            bool allFilesExist = true;

            if (UploadedFilesStorage == null)
                UploadedFilesTokenBox.Tokens = new TokenCollection();

            if (UploadedFilesTokenBox.Tokens.Count > 0)
            {
                foreach (var UploadedFile in UploadedFilesTokenBox.Tokens)
                {
                    UploadedFileInfo demoFileInfo = UploadControlHelper.GetDemoFileInfo(SubmissionID, UploadedFile);
                    FileInfo fileInfo = new FileInfo(demoFileInfo.FilePath);

                    if (fileInfo.Exists)
                    {
                        demoFileInfo.FileSize = Utils.FormatSize(fileInfo.Length);
                        resultFileInfos.Add(demoFileInfo);

                        var excel = new ExcelPackage(new FileInfo(demoFileInfo.FilePath));

                        if (data == null)
                            data = Utils.ToDataTable(excel);
                        else
                            data.Merge(Utils.ToDataTable(excel));
                    }
                }
                if (resultFileInfos.Count() > 0)
                {
                    //List<string> errors = Utils.ValidateExcelData(data);

                    //if (errors.Count == 0)
                    //{
                        //feed list to sp


                        int columnscount = data.Columns.Count;

                        if (columnscount == 13)
                        {
                            data.Columns.Add("IsDataUploaded", typeof(Boolean));
                            var AssessmentData = rtm_services.UploadAssessmentExcelData(data, true);

                            Session["UploadedData"] = AssessmentData;
                            gvAssesmentUpload.DataSource = AssessmentData;
                            gvAssesmentUpload.DataBind();
                            gvAssesmentUpload.Visible = true;
                        }
                        else
                        {
                            data.Columns.Add("IsDataDuplicate", typeof(Boolean));
                            var dupData = rtm_services.UploadAssessmentExcelData(data);

                            Session["UploadedData"] = dupData;
                            gvAssesmentUpload.DataSource = dupData;
                            gvAssesmentUpload.DataBind();
                            gvAssesmentUpload.Visible = true;

                        }


                        SubmitButton.Enabled = true;
                    //}
                    //else
                    //{
                    //    gvAssesmentUpload.DataSource = errors;
                    //    gvAssesmentUpload.DataBind();
                    //    gvAssesmentUpload.Visible = true;
                    //}

                }
                else
                    allFilesExist = false;
            }

            if (allFilesExist && resultFileInfos.Count > 0)
            {
                UploadControlHelper.RemoveUploadedFilesStorage(SubmissionID);

                ASPxEdit.ClearEditorsInContainer(FormLayout, true);
            }
            else
            {
                UploadedFilesTokenBox.ErrorText = "Submit failed.";
                UploadedFilesTokenBox.IsValid = false;
            }

            void ValidateInputData()
            {
                bool isInvalid = UploadedFilesTokenBox.Tokens.Count == 0;
                if (isInvalid)
                    throw new Exception("Invalid input data");
            }
            
        }
        protected void gvAssesmentUpload_PageIndexChanged(object sender, EventArgs e)
        {
            List<UploadedFileInfo> resultFileInfos = new List<UploadedFileInfo>();
            DataTable data = null;

            if (UploadedFilesStorage == null)
                UploadedFilesTokenBox.Tokens = new TokenCollection();

            if (UploadedFilesTokenBox.Tokens.Count > 0)
            {
                foreach (var UploadedFile in UploadedFilesTokenBox.Tokens)
                {
                    UploadedFileInfo demoFileInfo = UploadControlHelper.GetDemoFileInfo(SubmissionID, UploadedFile);
                    FileInfo fileInfo = new FileInfo(demoFileInfo.FilePath);

                    if (fileInfo.Exists)
                    {
                        demoFileInfo.FileSize = Utils.FormatSize(fileInfo.Length);
                        resultFileInfos.Add(demoFileInfo);
                        var excel = new ExcelPackage(new FileInfo(demoFileInfo.FilePath));
                        if (data == null)
                            data = Utils.ToDataTable(excel);
                        else
                            data.Merge(Utils.ToDataTable(excel));
                    }
                }
                if (resultFileInfos.Count() > 0)
                {
                    //List<string> errors = Utils.ValidateExcelData(data);

                    //if (errors.Count == 0)
                    //{
                        int columnscount = data.Columns.Count;

                        if (columnscount == 13)
                        {
                            Session["UploadedData"] = data;
                            data.Columns.Add("IsDataUploaded", typeof(Boolean));
                            var AssessmentData = rtm_services.UploadAssessmentExcelData(data, true);


                            gvAssesmentUpload.DataSource = AssessmentData;
                            gvAssesmentUpload.DataBind();

                        }
                        else
                        {
                            Session["UploadedData"] = data;
                            data.Columns.Add("IsDataDuplicate", typeof(Boolean));
                            var dupData = rtm_services.UploadAssessmentExcelData(data);


                            gvAssesmentUpload.DataSource = dupData;
                            gvAssesmentUpload.DataBind();
                        }

                    //}
                    //else
                    //{
                    //    gvAssesmentUpload.DataSource = errors;
                    //    gvAssesmentUpload.DataBind();
                    //}
                }
            }
        }

        protected void sqlArea_Init(object sender, EventArgs e)
        {
            SqlDataSource sqlArea = (SqlDataSource)sender;
            sqlArea.ConnectionString = Session["userConnString"].ToString();
        }

        protected void SqlCategory_Init(object sender, EventArgs e)
        {
            SqlDataSource SqlCategory = (SqlDataSource)sender;
            SqlCategory.ConnectionString = Session["userConnString"].ToString();
        }
    }
}