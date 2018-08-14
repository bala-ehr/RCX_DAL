using DevExpress.Web;
using DevExpress.Web.ASPxHtmlEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RC_X.controls
{
    public partial class workflow : System.Web.UI.UserControl
    {
        RootMaster MasterPage;
        ASPxHiddenField rootParameters;
       
        #region properties
        public String ItemKey
        {
            get { if (rootParameters.Contains("xkey")) { return rootParameters["xkey"] as string; } else { return null; } }
            set { rootParameters.Set("xkey", value); }
        }
        public Boolean IsManager
        {
            get { if (rootParameters.Contains("workflowIsManager")) { return (bool)rootParameters["workflowIsManager"] ; } else { return false; } }
            set { rootParameters.Set("workflowIsManager", value); }
        }
        public String CurrentStatus
        {
            get { if (rootParameters.Contains("workflowCurrentStatus")) { return rootParameters["workflowCurrentStatus"] as string; } else { return null; } }
            set { rootParameters.Set("workflowCurrentStatus", value); }
        }
        public int CurrentStatusValue
        {
            get { if (rootParameters.Contains("workflowCurrentWorkerID")) { return (int)rootParameters["workflowCurrentWorkerID"] ; } else { return 0; } }
            set { rootParameters.Set("workflowCurrentWorkerID", value); }
        }
        public String CurrentManagerID
        {
            get { if (rootParameters.Contains("workflowCurrentManagerID")) { return rootParameters["workflowCurrentManagerID"] as string; } else { return null; } }
            set { rootParameters.Set("workflowCurrentManagerID", value); }
        }
        public String CurrentManagerName
        {
            get { if (rootParameters.Contains("workflowCurrentManagerName")) { return rootParameters["workflowCurrentManagerName"] as string; } else { return null; } }
            set { rootParameters.Set("workflowCurrentCurrentManagerName", value); }
        }
        public String CurrentWorkerID
        {
            get { if (rootParameters.Contains("workflowCurrentWorkerID")) { return rootParameters["workflowCurrentWorkerID"] as string; } else { return null; } }
            set { rootParameters.Set("workflowCurrentWorkerID", value); }
        }
        public String CurrentWorkerName
        {
            get { if (rootParameters.Contains("workflowCurrentWorkerName")) { return rootParameters["workflowCurrentWorkerName"] as string; } else { return null; } }
            set { rootParameters.Set("workflowCurrentWorkerName", value); }
        }
#endregion


        protected void Page_Init(object sender, EventArgs e)
        {
            MasterPage = (RootMaster)Page.Master.Master;
            rootParameters = MasterPage.masterParameters;
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {            
            if (ItemKey == null)
            {
                return;
            }
            else if (Session["widgetWorkflowOpen"] != null)
            {
                Guid projectID = Guid.Parse(Session["projectID"].ToString());
                gridWorkflow.DataSource = rc_services.GetWorkflow(Guid.Parse(ItemKey), projectID);
                gridWorkflow.DataBind();
            }
     
        }

        protected void gridWorkflow_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            //ASPxComboBox dropStatus = (ASPxComboBox)gridWorkflow.FindEditFormTemplateControl("dropStatus");
            //ASPxComboBox dropUser =(ASPxComboBox)gridWorkflow.FindEditFormTemplateControl("dropUser");
            //ASPxHtmlEditor txComments = (ASPxHtmlEditor)gridWorkflow.FindEditFormTemplateControl("txComments");
            ASPxComboBox dropStatus = (ASPxComboBox)gridWorkflow.FindEditFormLayoutItemTemplateControl("dropStatus");
            ASPxComboBox dropUser = (ASPxComboBox)gridWorkflow.FindEditFormLayoutItemTemplateControl("dropUser");
            ASPxHtmlEditor txComments = (ASPxHtmlEditor)gridWorkflow.FindEditFormLayoutItemTemplateControl("txComments");
            Workflow NewStatus = new Workflow
            {
                ItemKey = Guid.Parse(ItemKey),
                ProjectID = Guid.Parse(Session["projectID"].ToString()),
                Status = dropStatus.Text,
                StatusValue = Convert.ToInt32(dropStatus.Value.ToString()),
                Comments = txComments.Html,
                WorkerID = (dropUser.Value==null)? Guid.Empty : Guid.Parse(dropUser.Value.ToString()),
                ManagerID = Guid.Parse(rc_services.GetUserID()),
                DueDate=Convert.ToDateTime(e.NewValues[0]),
                StatusDate=DateTime.Now
            };

            var item = rc_services.GetItemName(ItemKey);
            string worker = dropUser.Text.ToString();
            Guid WorkerID = (dropUser.Value == null) ? Guid.Empty : Guid.Parse(dropUser.Value.ToString());
            string manager = HttpContext.Current.Session["UserEmail"].ToString();
            string projectName = HttpContext.Current.Session["ProjectName"].ToString();
            string Status = dropStatus.Text;
            List<string> ListItems = new List<string>();
            rc_services.WorkFlowNotificationEmail( WorkerID, worker, manager, projectName, Status,ListItems, item);

            rc_services.NewWorkflowStatus(NewStatus);
            e.Cancel = true;
            Guid projectID = Guid.Parse(Session["projectID"].ToString());
            gridWorkflow.DataSource = rc_services.GetWorkflow(Guid.Parse(ItemKey), projectID);
            gridWorkflow.DataBind();
            gridWorkflow.CancelEdit();

        }

 
        protected void dropStatus_Init(object sender, EventArgs e)
        {
            ASPxComboBox dropStatus = (ASPxComboBox)sender;
            dropStatus.DataSource = common_services.GetCustomDropDown("workflow");
            dropStatus.DataBind();
        }

        protected void dropUser_Init(object sender, EventArgs e)
        {
            ASPxComboBox dropUser = (ASPxComboBox)sender;
            dropUser.DataSource = rc_services.GetUsers();
            dropUser.DataBind();
        }

  
    }
}