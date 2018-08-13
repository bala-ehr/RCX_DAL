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
    public partial class ent_RTM : System.Web.UI.Page
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
            if (!rc_services.CheckPermission("ent_RTM")) { Response.Redirect("~/controls/unauthorized.aspx"); }
            if (!rc_services.CheckPermission("ent_Project_RTM"))
            {
                gridCheckList.Columns[4].Visible = false;
                gridObjectives.Columns[4].Visible = false;
                gridCriteria.Columns[9].Visible = false;
                tabRTM.TabPages[3].Visible = false;

                gridCheckList.SettingsEditing.Mode = GridViewEditingMode.EditForm;
                gridObjectives.SettingsEditing.Mode = GridViewEditingMode.EditForm;
                gridCriteria.SettingsEditing.Mode = GridViewEditingMode.EditForm;
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


            

            if (!IsPostBack)
            {
                Session["UploadedData"] = null;
                gvRtmUpload.DataSource = null;
                gvRtmUpload.Columns.Clear();
                gvRtmUpload.AutoGenerateColumns = true;
                gvRtmUpload.DataBind();
            }
            else
            {
                if (Session["UploadedData"] != null)
                {
                    gvRtmUpload.DataSource = Session["UploadedData"];
                    gvRtmUpload.DataBind();
                }
            }
            
        }

        #region DataBinding Class
        // Data Binding for checklist from database
        public void BindCheckList(string projectId)
        {
            gridCheckList.DataSource = rtm_services.GetCheckList(projectId);
            gridCheckList.DataBind();
        }


        // Data Binding for objectives from database
        public void BindObjectives()
        {
            gridObjectives.DataSource = rtm_services.GetObjectives();
            gridObjectives.DataBind();
        }
        // Data Binding for criteria from database
        public void BindCriteria()
        {
            gridCriteria.DataSource = rtm_services.GetCriteria();
            gridCriteria.DataBind();

            //gridCriteria.ExpandAll();
        }
        // Data Binding for Project dropdown with default index{0} from database



        public void BindDropdown()
        {
            
                ddlProjects.DataSource = common_services.GetProjects();
            ddlProjects.DataBind();
            if (!IsPostBack)
            {
                ddlProjects.SelectedItem = ddlProjects.Items.FindByValue(Session["projectID"].ToString());
            }
            BindCheckList(Convert.ToString(ddlProjects.SelectedItem.Value));
            BindObjectives();
            BindCriteria();
        }

        protected void ddlProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindCheckList(Convert.ToString(ddlProjects.SelectedItem.Value));
        }

        #endregion

        #region Checklist

        protected void Grid_BatchUpdate(object sender, ASPxDataBatchUpdateEventArgs e)
        {
            var listUpdates = new List<RtmProjectChecklist>();
            foreach (var args in e.UpdateValues)
            {
                RtmProjectChecklist checklist = new RtmProjectChecklist();
                checklist.Id = Convert.ToString(args.Keys["Id"]);
                checklist.Title = Convert.ToString(args.NewValues["Title"]);
                checklist.Type = Convert.ToString(args.NewValues["Type"]);
                checklist.Description = Convert.ToString(args.NewValues["Description"]);
                checklist.IsActive = Convert.ToBoolean(args.NewValues["IsActive"]);
                listUpdates.Add(checklist);
            }
            if (listUpdates.Count > 0)
            {
                rtm_services.UpdateCheckListDetails(ddlProjects.SelectedItem.Value.ToString(), listUpdates);
            }
            foreach (var args in e.DeleteValues)
                DeleteItem(args.Keys);
            e.Handled = true;
            BindCheckList(ddlProjects.SelectedItem.Value.ToString());
            BindObjectives();
            BindCriteria();
        }

        private void DeleteItem(OrderedDictionary keys)
        {
            var result = rtm_services.DeleteCheckList(keys["Id"].ToString(), ddlProjects.SelectedItem.Value.ToString());
        }

        #endregion

        #region BusinessObjective

        protected void GridObjective_BatchUpdate(object sender, ASPxDataBatchUpdateEventArgs e)
        {
            var listUpdates = new List<RtmObjectives>();
            foreach (var args in e.UpdateValues)
            {
                RtmObjectives objective = new RtmObjectives();
                objective.Id = Convert.ToString(args.Keys["Id"]);
                objective.UniqueId = Convert.ToString(args.NewValues["UniqueId"]);
                objective.Name = Convert.ToString(args.NewValues["Name"]);

                listUpdates.Add(objective);
            }
            if (listUpdates.Count > 0)
            {
                rtm_services.UpdateObjectivesDetails(listUpdates);
            }

            foreach (var args in e.DeleteValues)
                DeleteObjecyiveItem(args.Keys);
            e.Handled = true;
            BindObjectives();
            BindCriteria();
        }

        private void DeleteObjecyiveItem(OrderedDictionary keys)
        {
            var result = rtm_services.DeleteObjectives(keys["Id"].ToString());
        }

        #endregion

        #region Criteria

        protected void gridCriteria_BatchUpdate(object sender, ASPxDataBatchUpdateEventArgs e)
        {
            var listUpdates = new List<RtmCriteria>();
            foreach (var args in e.UpdateValues)
            {
                RtmCriteria criteria = new RtmCriteria();
                criteria.Id = Convert.ToString(args.Keys["Id"]);
                criteria.Title = Convert.ToString(args.NewValues["Title"]);
                criteria.Name = Convert.ToString(args.NewValues["Name"]);
                criteria.Criteria = Convert.ToString(args.NewValues["Criteria"]);
                criteria.Source = Convert.ToString(args.NewValues["Source"]);
                criteria.Critical = Convert.ToBoolean(args.NewValues["Critical"]);

                listUpdates.Add(criteria);
            }
            if (listUpdates.Count > 0)
            {
                rtm_services.UpdateCriteriatDetails(listUpdates);
            }
            foreach (var args in e.DeleteValues)
                DeleteCriteriaItem(args.Keys);
            e.Handled = true;
            BindCriteria();
        }

        private void DeleteCriteriaItem(OrderedDictionary keys)
        {
            var result = rtm_services.DeleteCriteria(keys["Id"].ToString());
        }

        #endregion

        #region RTM Mass Load

        protected void DocumentsUploadControl_FileUploadComplete(object sender, DevExpress.Web.FileUploadCompleteEventArgs e)
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

            //List<string> errors = new List<string>()

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
                    List<string> errors = Utils.ValidateExcelData(data);

                    if (errors.Count == 0)
                    {
                        //feed list to sp


                        int columnscount = data.Columns.Count;
                       
                        if (columnscount == 12)
                        {
                            data.Columns.Add("IsDataUploaded", typeof(Boolean));
                            var RTMData = rtm_services.UploadExcelData(data, true);

                            Session["UploadedData"] = RTMData;
                            gvRtmUpload.DataSource = RTMData;
                            gvRtmUpload.DataBind();
                            gvRtmUpload.Visible = true;
                        }
                        else
                        {
                            data.Columns.Add("IsDataDuplicate", typeof(Boolean));
                            var dupData = rtm_services.UploadExcelData(data);

                            Session["UploadedData"] = dupData;
                            gvRtmUpload.DataSource = dupData;
                            gvRtmUpload.DataBind();
                            gvRtmUpload.Visible = true;

                        }


                        SubmitButton.Enabled = true;
                    }
                    else
                    {
                        gvRtmUpload.DataSource = errors;
                        gvRtmUpload.DataBind();
                        gvRtmUpload.Visible = true;
                    }

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
        }

        void ValidateInputData()
        {
            bool isInvalid = UploadedFilesTokenBox.Tokens.Count == 0;
            if (isInvalid)
                throw new Exception("Invalid input data");
        }

        protected void gvRtmUpload_PageIndexChanged(object sender, EventArgs e)
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
                    List<string> errors = Utils.ValidateExcelData(data);

                    if (errors.Count == 0)
                    {
                        int columnscount = data.Columns.Count;

                        if (columnscount == 12)
                        {
                            Session["UploadedData"] = data;
                            data.Columns.Add("IsDataUploaded", typeof(Boolean));
                            var RTMData = rtm_services.UploadExcelData(data, true);

                            
                            gvRtmUpload.DataSource = RTMData;
                            gvRtmUpload.DataBind();
                            
                        }
                        else
                        {
                            Session["UploadedData"] = data;
                            data.Columns.Add("IsDataDuplicate", typeof(Boolean));
                            var dupData = rtm_services.UploadExcelData(data);


                            gvRtmUpload.DataSource = dupData;
                            gvRtmUpload.DataBind();
                        }
 
                    }
                    else
                    {
                        gvRtmUpload.DataSource = errors;
                        gvRtmUpload.DataBind();
                    }
                }
            }
        }

        #endregion

        //protected void gvRtmUpload_PageIndexChanged(object sender, EventArgs e)
        //{OnPageIndexChanged="gvRtmUpload_PageIndexChanged"
        //    gvRtmUpload.DataSource = Session["UploadedData"];
        //    gvRtmUpload.DataBind();

        //}
    }
}