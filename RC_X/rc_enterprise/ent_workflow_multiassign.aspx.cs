using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RC_X.rc_enterprise
{
    public partial class ent_workflow_multiassign : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlProjects.DataSource = common_services.GetProjects();
                ddlProjects.DataBind();

                cmbUser.DataSource = rc_services.GetUsers();
                cmbUser.DataBind();

                dropStatus.DataSource = common_services.GetCustomDropDown("workflow");
                dropStatus.DataBind();


            }
        }

        
       
        protected void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userId = cmbUser.Value.ToString();
            string Area = cmbArea.Value.ToString();
            string projectId = ddlProjects.Value.ToString();
            gridMultiAssign.DataSource = rc_services.GetMultiAssignWorkflowItems(userId, projectId, Area);
            gridMultiAssign.DataBind();


        }

       
       

        protected void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var userId = dropUser.Value.ToString();
            //var userId = "EEC5EE08-9BF8-4D45-8CEB-442F4C446C2A";
            //var projectID = ddlProjects.Value.ToString();
            //gridMultiAssign.DataSource = rc_services.GetWorkflow(Guid.Parse(userId), Guid.Parse(projectID));
            //gridMultiAssign.DataBind();

        }

        protected void gridMultiAssign_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            ASPxGridView gridMultiAssign = (ASPxGridView)sender;
            ASPxGridView gridAssessItems = (ASPxGridView)gridMultiAssign.FindEditFormLayoutItemTemplateControl("gridAssessItems");

            List<MultiAssignWorkflow> ItemsList = new List<MultiAssignWorkflow>();
            for (int i = 0; i <= gridAssessItems.VisibleRowCount; i = i + 1)
            {
                if (gridAssessItems.Selection.IsRowSelected(i) == true)
                {
                    ItemsList.Add(new MultiAssignWorkflow { ID = gridAssessItems.GetRowValues(i, "ID").ToString() });
                    
                }
            }
            var projectId = ddlProjects.Value.ToString();
            Workflow NewStatus = new Workflow
            {
                
                ProjectID = Guid.Parse(projectId),
                Status = dropStatus.Text,
                StatusValue = Convert.ToInt32(dropStatus.Value.ToString()),
                Comments = "",
                WorkerID = (cmbUser.Value == null) ? Guid.Empty : Guid.Parse(cmbUser.Value.ToString()),
                ManagerID = Guid.Parse(rc_services.GetUserID()),
                DueDate = Convert.ToDateTime(dateEdit.Value),
                StatusDate = DateTime.Now
            };
            rc_services.NewMultiWorkflowStatus(ItemsList, NewStatus);

            List<string> ListItems = new List<string>();
            for (int i = 0; i <= gridAssessItems.VisibleRowCount; i = i + 1)
            {
                if (gridAssessItems.Selection.IsRowSelected(i) == true)
                {
                    
                    ListItems.Add( gridAssessItems.GetRowValues(i, "Identifier").ToString() );
                    
                }
            }


            string worker = cmbUser.Text.ToString();
            Guid WorkerID = (cmbUser.Value == null) ? Guid.Empty : Guid.Parse(cmbUser.Value.ToString());
            string manager = HttpContext.Current.Session["UserEmail"].ToString();
            string projectName = HttpContext.Current.Session["ProjectName"].ToString();
            string Status = dropStatus.Text;
            var item = "";
            rc_services.WorkFlowNotificationEmail( WorkerID, worker, manager, projectName, Status, ListItems, item);
            
            e.Cancel = true;
            gridMultiAssign.CancelEdit();

            string userId = cmbUser.Value.ToString();
            string Area = cmbArea.Value.ToString();
            
            gridMultiAssign.DataSource = rc_services.GetMultiAssignWorkflowItems(userId, projectId, Area);
            gridMultiAssign.DataBind();

        }

        

        protected void gridAssessItems_Init1(object sender, EventArgs e)
        {
            ASPxGridView gridAssessItems = (ASPxGridView)sender;
            string Area = cmbArea.Value.ToString();
            var projectId = ddlProjects.Value.ToString();
            gridAssessItems.DataSource = rc_services.GetWorkflowItem(Area, projectId);
            gridAssessItems.DataBind();
        }

        protected void gridMultiAssign_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            string projectId = ddlProjects.Value.ToString();
            var Key = e.Keys["Id"].ToString();
            rc_services.DeleteMultiAssignWorkflowItems(Key, projectId);
            string userId = cmbUser.Value.ToString();
            string Area = cmbArea.Value.ToString();
            
            //gridMultiAssign.DataSource = rc_services.GetMultiAssignWorkflowItems(userId, projectId, Area);
            //gridMultiAssign.DataBind();

        }
    }
}