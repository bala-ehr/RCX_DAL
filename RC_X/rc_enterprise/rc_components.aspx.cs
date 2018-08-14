using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RC_X.rc_enterprise
{
    public partial class rc_components : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            if (!rc_services.CheckPermission("ent_components")) { Response.Redirect("~/controls/unauthorized.aspx"); }
            gridEnterpriseLevel.Columns[8].Visible = rc_services.CheckPermission("ent_components");
            gridProjectLevel.Columns[8].Visible = rc_services.CheckPermission("ent_components");


        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //string currentPage = System.IO.Path.GetFileName(Request.Url.AbsolutePath);
            BindComponents();
            
        }
        public void BindComponents()
        {
            
            gridEnterpriseLevel.DataSource = rc_services.GetComponents();
            gridEnterpriseLevel.DataBind();

            gridProjectLevel.DataSource = rc_services.GetComponents();
            gridProjectLevel.DataBind();
        }

        #region Components
        protected void gridEnterpriseLevel_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            Componets comp = new Componets();

            comp.ComponentName = e.NewValues["ComponentName"].ToString();
            comp.ComponentType = e.NewValues["ComponentType"].ToString();
            comp.ComponentMode = e.NewValues["ComponentMode"].ToString();
            comp.ComponentTest = e.NewValues["ComponentTest"].ToString();
            comp.ComponentLocation = e.NewValues["ComponentLocation"].ToString();
            comp.StartDate = e.NewValues["StartDate"].ToString();
            comp.EndDate = (String)e.NewValues["EndDate"];
            comp.Notes = e.NewValues["Notes"].ToString();
            comp.SerialNumber = e.NewValues["SerialNumber"].ToString();

            rc_services.InsertNewComponent(comp);
            e.Cancel = true;
            gridEnterpriseLevel.CancelEdit();

            gridEnterpriseLevel.DataSource = rc_services.GetComponents();
            gridEnterpriseLevel.DataBind();
        }

        protected void gridEnterpriseLevel_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            var comp = new Componets();
            comp.ComponentId = e.Keys["ComponentId"].ToString();
            comp.ComponentName = e.NewValues["ComponentName"].ToString();
            comp.ComponentType = e.NewValues["ComponentType"].ToString();
            comp.ComponentMode = e.NewValues["ComponentMode"].ToString();
            comp.ComponentTest = e.NewValues["ComponentTest"].ToString();
            comp.ComponentLocation = e.NewValues["ComponentLocation"].ToString();
            comp.StartDate = e.NewValues["StartDate"].ToString();
            comp.EndDate = (String)e.NewValues["EndDate"];
            comp.Notes = e.NewValues["Notes"].ToString();
            comp.SerialNumber = e.NewValues["SerialNumber"].ToString();

            rc_services.UpdateComponentDetails(comp);
            e.Cancel = true;
            gridEnterpriseLevel.CancelEdit();

            gridEnterpriseLevel.DataSource = rc_services.GetComponents();
            gridEnterpriseLevel.DataBind();

            gridProjectLevel.DataSource = rc_services.GetComponents();
            gridProjectLevel.DataBind();
        }

        protected void gridEnterpriseLevel_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            //var comp = new Componets();
            var ComponentId = e.Keys["ComponentId"].ToString();

            rc_services.DeleteComponent(ComponentId);

            e.Cancel = true;
            gridEnterpriseLevel.CancelEdit();

            gridEnterpriseLevel.DataSource = rc_services.GetComponents();
            gridEnterpriseLevel.DataBind();

            gridProjectLevel.DataSource = rc_services.GetComponents();
            gridProjectLevel.DataBind();
        }



       
        #endregion

        #region Component Projects

        protected void gridEnterpriseLevelProjects_BeforePerformDataSelect(object sender, EventArgs e)
        {
            var gridAllProjects = sender as ASPxGridView;
            Session["ComponentId"] = gridAllProjects.GetMasterRowKeyValue();
            string KeyValue = Session["ComponentId"] != null ? Session["ComponentId"].ToString() : string.Empty;

            gridAllProjects.DataSource = rc_services.GetEnterpriseLevelProjects(KeyValue);

            //ASPxGridView gridprojects = (ASPxGridView)gridAllProjects.FindEditFormLayoutItemTemplateControl("gridprojects");
            //gridprojects.DataSource = rc_services.GetProjects(KeyValue);
        }

        protected void gridEnterpriseLevelProjects_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            if (Session["ComponentId"] != null) {
                ASPxGridView gridEnterpriseLevelProjects = (ASPxGridView)sender;
                ASPxGridView gridprojects = (ASPxGridView)gridEnterpriseLevelProjects.FindEditFormLayoutItemTemplateControl("gridprojects");
                List<string> ItemsList = new List<string>();
                for (int i = 0; i <= gridprojects.VisibleRowCount; i = i + 1)
                {
                    if (gridprojects.Selection.IsRowSelected(i) == true)
                    {
                        ItemsList.Add(gridprojects.GetRowValues(i, "pro_ID").ToString());
                    }
                }
                rc_services.InsertComponentProjects(Session["ComponentId"].ToString(), ItemsList);
                e.Cancel = true;
                gridEnterpriseLevelProjects.CancelEdit();
                gridEnterpriseLevelProjects.DataBind();
            }
        }

        protected void gridprojects_BeforePerformDataSelect(object sender, EventArgs e)
        {
            var gridAllProjects = sender as ASPxGridView;
            Session["ComponentId"] = gridAllProjects.GetMasterRowKeyValue();
            string KeyValue = Session["ComponentId"] != null ? Session["ComponentId"].ToString() : string.Empty;

            gridAllProjects.DataSource = rc_services.GetProjects(KeyValue);
        }
        protected void sqlProjects_Init(object sender, EventArgs e)
        {
            SqlDataSource sqlProjects = (SqlDataSource)sender;
            sqlProjects.ConnectionString = Session["userConnString"].ToString();
        }
        
        #endregion

        #region Component BA
        protected void gridComponentArea_BeforePerformDataSelect(object sender, EventArgs e)
        {
            var gridAllAreas = sender as ASPxGridView;
            Session["ComponentId"] = gridAllAreas.GetMasterRowKeyValue();
            string KeyValue = Session["ComponentId"] != null ? Session["ComponentId"].ToString() : string.Empty;

            gridAllAreas.DataSource = rc_services.GetProjectLevelBusinessArea(KeyValue);
        }

        protected void gridComponentArea_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            if (Session["ComponentId"] != null)
            {
                ASPxGridView gridComponentArea = (ASPxGridView)sender;
                ASPxGridView gridArea = (ASPxGridView)gridComponentArea.FindEditFormLayoutItemTemplateControl("gridArea");
                List<string> ItemsList = new List<string>();
                for (int i = 0; i <= gridArea.VisibleRowCount; i = i + 1)
                {
                    if (gridArea.Selection.IsRowSelected(i) == true)
                    {
                        ItemsList.Add(gridArea.GetRowValues(i, "area_id").ToString());
                    }
                }
                rc_services.InsertComponentProjectArea(Session["ComponentId"].ToString(), ItemsList);
                e.Cancel = true;
                gridComponentArea.CancelEdit();
                gridComponentArea.DataBind();
            }
        }
        protected void sqlArea_Init(object sender, EventArgs e)
        {
            SqlDataSource sqlArea = (SqlDataSource)sender;
            sqlArea.ConnectionString = Session["userConnString"].ToString();
        }
       
        #endregion

        #region Component BPM
        protected void gridComponentProcesses_BeforePerformDataSelect(object sender, EventArgs e)
        {
            var gridProcesses = sender as ASPxGridView;
            Session["ComponentId"] = gridProcesses.GetMasterRowKeyValue();
            string KeyValue = Session["ComponentId"] != null ? Session["ComponentId"].ToString() : string.Empty;

            gridProcesses.DataSource = rc_services.GetProjectLevelBusinessProcesses(KeyValue);
        }

        protected void gridComponentProcesses_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            if (Session["ComponentId"] != null)
            {
                ASPxGridView gridComponentProcesses = (ASPxGridView)sender;
                ASPxGridView gridProcesses = (ASPxGridView)gridComponentProcesses.FindEditFormLayoutItemTemplateControl("gridProcesses");
                List<string> ItemsList = new List<string>();
                for (int i = 0; i <= gridProcesses.VisibleRowCount; i = i + 1)
                {
                    if (gridProcesses.Selection.IsRowSelected(i) == true)
                    {
                        ItemsList.Add(gridProcesses.GetRowValues(i, "bp_id").ToString());
                    }
                }
                rc_services.InsertComponentProjectBPM(Session["ComponentId"].ToString(), ItemsList);
                e.Cancel = true;
                gridComponentProcesses.CancelEdit();
                gridComponentProcesses.DataBind();
            }
        }

        protected void sqlProcesses_Init(object sender, EventArgs e)
        {
            SqlDataSource sqlProcesses = (SqlDataSource)sender;
            sqlProcesses.ConnectionString = Session["userConnString"].ToString();
        }
        protected void sqlComponetProcesses_Init(object sender, EventArgs e)
        {
            SqlDataSource sqlComponetProcesses = (SqlDataSource)sender;
            sqlComponetProcesses.ConnectionString = Session["userConnString"].ToString();
        }
        #endregion

        #region Component RTMITem
        protected void gridComponentRTMItem_BeforePerformDataSelect(object sender, EventArgs e)
        {
            var gridComponentRTMItem = sender as ASPxGridView;
            Session["ComponentId"] = gridComponentRTMItem.GetMasterRowKeyValue();
            string KeyValue = Session["ComponentId"] != null ? Session["ComponentId"].ToString() : string.Empty;

            gridComponentRTMItem.DataSource = rc_services.GetProjectLevelRTM(KeyValue);
        }

        protected void gridComponentRTMItem_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            if (Session["ComponentId"] != null)
            {
                ASPxGridView gridComponentRTMItem = (ASPxGridView)sender;
                ASPxGridView gridRTMItem = (ASPxGridView)gridComponentRTMItem.FindEditFormLayoutItemTemplateControl("gridRTMItem");
                List<string> ItemsList = new List<string>();
                for (int i = 0; i <= gridRTMItem.VisibleRowCount; i = i + 1)
                {
                    if (gridRTMItem.Selection.IsRowSelected(i) == true)
                    {
                        ItemsList.Add(gridRTMItem.GetRowValues(i, "src_id").ToString());
                    }
                }
                rc_services.InsertComponentProjectRTMItem(Session["ComponentId"].ToString(), ItemsList);
                e.Cancel = true;
                gridComponentRTMItem.CancelEdit();
                gridComponentRTMItem.DataBind();
            }
        }
        protected void sqlRTM_Init(object sender, EventArgs e)
        {
            SqlDataSource sqlRTM = (SqlDataSource)sender;
            sqlRTM.ConnectionString = Session["userConnString"].ToString();
        }

        
        protected void gridComponentRTMItem_Init(object sender, EventArgs e)
        {
            //ASPxGridView gridRTM = (ASPxGridView)sender;
            
                
        }

        protected void gridProjectLevel_CustomCallback(object sender, EventArgs e)
        {
            gridProjectLevel.DataSource = rc_services.GetComponents();
            gridProjectLevel.DataBind();
        }

        #endregion

        
    }
}