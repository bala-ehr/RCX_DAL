using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RC_X.rc_enterprise
{
    public partial class ent_projects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindProjects();
        }

        private void BindProjects()
        {
            gridProjects.DataSource = common_services.GetEnterpriseProjects(); 
            gridProjects.DataBind();
        }

        protected void gridProjects_CellEditorInitialize(object sender, DevExpress.Web.ASPxGridViewEditorEventArgs e)
        {
            if (e.Column.FieldName == "MilestoneName")
            {
                ASPxComboBox cmb = e.Editor as ASPxComboBox;
                cmb.DataSource = common_services.GetMilestone();
                cmb.ValueField = "Name";
                cmb.ValueType = typeof(String);
                cmb.TextField = "Name";
                cmb.DataBindItems();
            }

        }

        protected void gridProjects_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            Projects project = new Projects();

            project.ProjectName = (String)e.NewValues["ProjectName"];
            project.ProjectColor = (String)e.NewValues["ProjectColor"];
            project.Description = (String)e.NewValues["Description"];
            project.MilestoneName = (String)e.NewValues["MilestoneName"];
            project.StartDate = (String)e.NewValues["StartDate"];
            project.EstimatedEndDate = (String)e.NewValues["EstimatedEndDate"];
            project.TargetDate1 = (String)e.NewValues["TargetDate1"];
            project.TargetDate2 = (String)e.NewValues["TargetDate2"];
            project.TargetDate3 = (String)e.NewValues["TargetDate3"];
            project.ActualEndDate = (String)e.NewValues["ActualEndDate"];
            project.CertificationDate = (String)e.NewValues["CertificationDate"];
            project.PMName = (String)e.NewValues["PMName"];
            if (e.NewValues["Roadmap"] == null) { project.Roadmap = false; } else { project.Roadmap = (bool)e.NewValues["Roadmap"]; };
            //project.Roadmap = (bool)e.NewValues["Roadmap"];
            project.Status = (String)e.NewValues["Status"];

            common_services.InsertNewProject(project);
            e.Cancel = true;
            gridProjects.CancelEdit();
            BindProjects();


        }

        protected void gridProjects_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            Projects project = new Projects();

            project.ProjectID = (String)e.Keys["ProjectID"];
            project.ProjectName = (String)e.NewValues["ProjectName"];
            project.ProjectColor = (String)e.NewValues["ProjectColor"];
            project.Description = (String)e.NewValues["Description"];
            project.MilestoneName = (String)e.NewValues["MilestoneName"];
            project.StartDate = (String)e.NewValues["StartDate"];
            project.EstimatedEndDate = (String)e.NewValues["EstimatedEndDate"];
            project.TargetDate1 = (String)e.NewValues["TargetDate1"];
            project.TargetDate2 = (String)e.NewValues["TargetDate2"];
            project.TargetDate3 = (String)e.NewValues["TargetDate3"];
            project.ActualEndDate = (String)e.NewValues["ActualEndDate"];
            project.CertificationDate = (String)e.NewValues["CertificationDate"];
            project.PMName = (String)e.NewValues["PMName"];
            if (e.NewValues["Roadmap"] == null) { project.Roadmap = false; } else { project.Roadmap = (bool)e.NewValues["Roadmap"]; };
            //project.Roadmap = (Boolean)e.NewValues["Roadmap"];
            project.Status = (String)e.NewValues["Status"];


            common_services.UpdateProjects(project);
            e.Cancel = true;
            gridProjects.CancelEdit();
            
            BindProjects();
        }

        protected void gridProjects_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            Projects project = new Projects();

            project.ProjectID = (String)e.Keys["ProjectID"];
          


            common_services.DeleteProjects(project);
            e.Cancel = true;
            gridProjects.CancelEdit();
            BindProjects();

        }
    }
}