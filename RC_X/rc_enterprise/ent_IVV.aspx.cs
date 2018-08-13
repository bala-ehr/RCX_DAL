using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RC_X.rc_enterprise
{
    public partial class ent_IVV : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrids();
        }

        protected void BindGrids()
        {
            gridGeneralInfo.DataSource = common_services.GetGeneralInfo();
            gridGeneralInfo.DataBind();

            gridLifeCycle.DataSource = common_services.GetLifeCyclestatus();
            gridLifeCycle.DataBind();

            gridRisks.DataSource = common_services.GetIVVRisks();
            gridRisks.DataBind();

            gridRecommendations.DataSource = common_services.GetIVVRecmmendations();
            gridRecommendations.DataBind();
        }

        protected void gridGeneralInfo_CellEditorInitialize(object sender, DevExpress.Web.ASPxGridViewEditorEventArgs e)
        {
            
        }

        protected void gridGeneralInfo_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            GeneralInfo generalInfo = new GeneralInfo();

            generalInfo.StateName = e.NewValues["StateName"].ToString();
            generalInfo.ProjectName = e.NewValues["ProjectName"].ToString();
            generalInfo.ProgramName = e.NewValues["ProgramName"].ToString();
            generalInfo.ProgressReportDate = e.NewValues["ProgressReportDate"].ToString();
            generalInfo.StatePrimaryPOC = e.NewValues["StatePrimaryPOC"].ToString();
            generalInfo.StatePrimaryPOCEmail = e.NewValues["StatePrimaryPOCEmail"].ToString();
            generalInfo.SubmitterName = e.NewValues["SubmitterName"].ToString();
            generalInfo.SubmitterEmail = e.NewValues["SubmitterEmail"].ToString();
            generalInfo.SubmitterRole = e.NewValues["SubmitterRole"].ToString();
            generalInfo.SubmitterPhone = e.NewValues["SubmitterPhone"].ToString();
            generalInfo.ConsultDate = e.NewValues["ConsultDate"].ToString();
            generalInfo.RFPReleaseDate = e.NewValues["RFPReleaseDate"].ToString();
            generalInfo.OnBoardDate = e.NewValues["OnBoardDate"].ToString();
            generalInfo.NextProgressDate = e.NewValues["NextProgressDate"].ToString();

            generalInfo.ExecutiveSummary = e.NewValues["ExecutiveSummary"].ToString();


            common_services.NewGeneralInfo(generalInfo);
            e.Cancel = true;
            gridGeneralInfo.CancelEdit();
            gridGeneralInfo.DataSource = common_services.GetGeneralInfo();
            gridGeneralInfo.DataBind();
        }

        protected void gridGeneralInfo_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            GeneralInfo generalInfo = new GeneralInfo();

            generalInfo.GeneralInfoID = e.Keys["GeneralInfoID"].ToString();
            generalInfo.StateName = e.NewValues["StateName"].ToString();
            generalInfo.ProjectName = e.NewValues["ProjectName"].ToString();
            generalInfo.ProgramName = e.NewValues["ProgramName"].ToString();
            generalInfo.ProgressReportDate = e.NewValues["ProgressReportDate"].ToString();
            generalInfo.StatePrimaryPOC = e.NewValues["StatePrimaryPOC"].ToString();
            generalInfo.StatePrimaryPOCEmail = e.NewValues["StatePrimaryPOCEmail"].ToString();
            generalInfo.SubmitterName = e.NewValues["SubmitterName"].ToString();
            generalInfo.SubmitterEmail = e.NewValues["SubmitterEmail"].ToString();
            generalInfo.SubmitterRole = e.NewValues["SubmitterRole"].ToString();
            generalInfo.SubmitterPhone = e.NewValues["SubmitterPhone"].ToString();
            generalInfo.ConsultDate = e.NewValues["ConsultDate"].ToString();
            generalInfo.RFPReleaseDate = e.NewValues["RFPReleaseDate"].ToString();
            generalInfo.OnBoardDate = e.NewValues["OnBoardDate"].ToString();
            generalInfo.NextProgressDate = e.NewValues["NextProgressDate"].ToString();

            generalInfo.ExecutiveSummary = e.NewValues["ExecutiveSummary"].ToString();

            common_services.UpdateGeneralInfo(generalInfo);
            e.Cancel = true;
            gridGeneralInfo.CancelEdit();
            gridGeneralInfo.DataSource = common_services.GetGeneralInfo();
            gridGeneralInfo.DataBind();
        }

        protected void gridGeneralInfo_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            string GeneralInfoID = e.Keys["GeneralInfoID"].ToString();

            common_services.DeleteGeneralInfo(GeneralInfoID);
            e.Cancel = true;
            gridGeneralInfo.CancelEdit();
            gridGeneralInfo.DataSource = common_services.GetGeneralInfo();
            gridGeneralInfo.DataBind();
        }

        protected void gridLifeCycle_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            LifeCycleStatus lifeCycle = new LifeCycleStatus();

            lifeCycle.Module = e.NewValues["Module"].ToString();
            lifeCycle.ProjectName = e.NewValues["ProjectName"].ToString();
            lifeCycle.Status = e.NewValues["Status"].ToString();
            lifeCycle.IAPDApprovalDate = e.NewValues["IAPDApprovalDate"].ToString();
            lifeCycle.Project = e.NewValues["Project"].ToString();
            

            common_services.NewLifeCycleStatus(lifeCycle);
            e.Cancel = true;
            gridLifeCycle.CancelEdit();
            gridLifeCycle.DataSource = common_services.GetLifeCyclestatus();
            gridLifeCycle.DataBind();
        }

        protected void gridLifeCycle_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            LifeCycleStatus lifeCycle = new LifeCycleStatus();
            lifeCycle.LifeCycleStatusID = e.Keys["LifeCycleStatusID"].ToString();
            lifeCycle.Module = e.NewValues["Module"].ToString();
            lifeCycle.ProjectName = e.NewValues["ProjectName"].ToString();
            lifeCycle.Status = e.NewValues["Status"].ToString();
            lifeCycle.IAPDApprovalDate = e.NewValues["IAPDApprovalDate"].ToString();
            lifeCycle.Project = e.NewValues["Project"].ToString();
            


            common_services.UpdateLifeCycleStatus(lifeCycle);
            e.Cancel = true;
            gridLifeCycle.CancelEdit();
            gridLifeCycle.DataSource = common_services.GetLifeCyclestatus();
            gridLifeCycle.DataBind();
        }

        protected void gridLifeCycle_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            string LifeCycleStatusID = e.Keys["LifeCycleStatusID"].ToString();
            common_services.DeleteLifeCycleStatus(LifeCycleStatusID);
            e.Cancel = true;
            gridLifeCycle.CancelEdit();
            gridLifeCycle.DataSource = common_services.GetLifeCyclestatus();
            gridLifeCycle.DataBind();
        }

        #region IV&V Risks
        protected void gridRisks_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            IVVRisks risks = new IVVRisks();

            risks.UniqueID = e.NewValues["UniqueID"].ToString();
            risks.Title = e.NewValues["Title"].ToString();
            risks.Probability = e.NewValues["Probability"].ToString();
            risks.Impact = e.NewValues["Impact"].ToString();
            risks.ResolutionDate = e.NewValues["ResolutionDate"].ToString();
            risks.Status = (Boolean)e.NewValues["Status"];
            risks.Description = e.NewValues["Description"].ToString();


            common_services.NewIVVRisks(risks);
            e.Cancel = true;
            gridRisks.CancelEdit();
            gridRisks.DataSource = common_services.GetIVVRisks();
            gridRisks.DataBind();
        }

        protected void gridRisks_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            IVVRisks updaterisks = new IVVRisks();
            updaterisks.RisksID = e.Keys["RisksID"].ToString();
            updaterisks.UniqueID = e.NewValues["UniqueID"].ToString();
            updaterisks.Title = e.NewValues["Title"].ToString();
            updaterisks.Probability = e.NewValues["Probability"].ToString();
            updaterisks.Impact = e.NewValues["Impact"].ToString();
            updaterisks.ResolutionDate = e.NewValues["ResolutionDate"].ToString();
            updaterisks.Status = (Boolean)e.NewValues["Status"];
            updaterisks.Description = e.NewValues["Description"].ToString();


            common_services.UpdateIVVRisks(updaterisks);
            e.Cancel = true;
            gridRisks.CancelEdit();
            gridRisks.DataSource = common_services.GetIVVRisks();
            gridRisks.DataBind();
        }

        protected void gridRisks_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            string IVVRisksID = e.Keys["RisksID"].ToString();
            common_services.DeleteIVVRisks(IVVRisksID);
            e.Cancel = true;
            gridRisks.CancelEdit();
            gridRisks.DataSource = common_services.GetIVVRisks();
            gridRisks.DataBind();
        }
        #endregion

        #region Recommendations
        protected void gridRecommendations_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            IVVRecommendations recommendations = new IVVRecommendations();

            recommendations.RecommendationId = e.NewValues["RecommendationId"].ToString();
            recommendations.RecommendationDate = e.NewValues["RecommendationDate"].ToString();
            recommendations.Recommendation = e.NewValues["Recommendation"].ToString();
            recommendations.Resolved = (Boolean)e.NewValues["Resolved"];
            recommendations.Comments = e.NewValues["Comments"].ToString();

            common_services.NewIVVRecmmendations(recommendations);
            e.Cancel = true;
            gridRecommendations.CancelEdit();
            gridRecommendations.DataSource = common_services.GetIVVRecmmendations();
            gridRecommendations.DataBind();
        }

        protected void gridRecommendations_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            IVVRecommendations recommendations = new IVVRecommendations();
            recommendations.RecommendationID = e.Keys["RecommendationID"].ToString();
            recommendations.RecommendationId = e.NewValues["RecommendationId"].ToString();
            recommendations.RecommendationDate = e.NewValues["RecommendationDate"].ToString();
            recommendations.Recommendation = e.NewValues["Recommendation"].ToString();
            recommendations.Resolved = (Boolean)e.NewValues["Resolved"];
            recommendations.Comments = e.NewValues["Comments"].ToString();

            common_services.UpdateIVVRecmmendations(recommendations);
            e.Cancel = true;
            gridRecommendations.CancelEdit();
            gridRecommendations.DataSource = common_services.GetIVVRecmmendations();
            gridRecommendations.DataBind();
        }

        protected void gridRecommendations_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            string RecommendationID = e.Keys["RecommendationID"].ToString();

            common_services.DeleteIVVRecommendations(RecommendationID);
            e.Cancel = true;
            gridRecommendations.CancelEdit();
            gridRecommendations.DataSource = common_services.GetIVVRecmmendations();
            gridRecommendations.DataBind();
        }
        #endregion

        protected void gridLifeCycle_CellEditorInitialize(object sender, DevExpress.Web.ASPxGridViewEditorEventArgs e)
        {
            if (e.Column.FieldName == "Project")
            {
                ASPxComboBox cmb = e.Editor as ASPxComboBox;
                cmb.DataSource = common_services.GetEnterpriseProjects();
                cmb.ValueField = "ProjectName";
                cmb.ValueType = typeof(String);
                cmb.TextField = "ProjectName";
                cmb.DataBindItems();
            }
        }
    }
}