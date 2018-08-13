using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RC_X.rc_project
{
    public partial class pro_deliverable_schedule : System.Web.UI.Page
    {

        protected void Page_Init(object sender, EventArgs e)
        {
            if (!rc_services.CheckPermission("pro_deliverable"))
            {
                Response.Redirect("~/controls/unauthorized.aspx");
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
           
                BindGrids();
            
           
        }
        public void BindGrids()
        {
            
            bool deliverablescreen = true;
            gridTasks.DataSource = rc_services.GetProjectTasks(deliverablescreen);
            gridTasks.DataBind();


        }
        protected void sqlGapandGoals_Init(object sender, EventArgs e)
        {
            SqlDataSource sqlGapandGoals = (SqlDataSource)sender;
            sqlGapandGoals.ConnectionString = Session["userConnString"].ToString();
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

        protected void gridAssociatedGapsGoals_BeforePerformDataSelect(object sender, EventArgs e)
        {

        }

        protected void workflow_BeforePerformDataSelect(object sender, EventArgs e)
        {
            Session["TaskID"] = (sender as ASPxGridView).GetMasterRowKeyValue();

            ASPxGridView workflow = sender as ASPxGridView;
            string ItemKey = Session["TaskID"].ToString();
            Guid projectID = Guid.Parse(System.Web.HttpContext.Current.Session["projectID"].ToString());
            workflow.DataSource = rc_services.GetWorkflow(Guid.Parse(ItemKey), projectID);

        }
    }
}