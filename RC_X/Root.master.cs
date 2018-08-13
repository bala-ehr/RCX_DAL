using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using DevExpress.Web.ASPxTreeList;
using System.Data;
using System.Web.Security;
using System.Net.Http;


namespace RC_X
{
    public partial class RootMaster : System.Web.UI.MasterPage
    {
        ASPxGridView gridProjects;
        public string currentPage;
        public string Clients { get { return currentPage; } }
        string projects = null;
        //RC_X.controls.evaluation boxEaluation;
        public ASPxHiddenField masterParameters { get { return rootParameters; }}
     
       
        //public ASPxMenu rcMenu { get { return rcMenu; } }

        protected void Page_Init(object sender, EventArgs e)
        {
            
          //  Session.Clear();
            //Check to see if session is dead. If so, sign out user and exit load (code below it needs those session variables)
            if (Session["userConnString"] == null || Session["projectID"] == null )
            {
                if (!Page.AppRelativeVirtualPath.Contains("Login") )
                {
                    common_services.RefreshSession();
                }
                else
                {
                    return;
                }
                if(Session["userConnString"] == null) {
                    return;
                    //Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
                  //  throw new Exception("SessionExpired");
                }                
            }

            //Find All SqlDataSourceControls in ChildPage, and change their connection strings to user's individual conn strinf
            //Page ChildPage = this.Page;
            //rc_services.FindAllDataSources(ref ChildPage);
            //this.Page = ChildPage;

            if (!IsPostBack && !this.Page.IsCallback)
            {
                rc_services.GetActivePermissions();
            }

           

         
           

            if (rootParameters.Contains("xkey") && rootParameters.Get("xkey")!=null)
            {
                Session["score_itemid"] = rootParameters.Get("xkey");
               // WidgetRefresher(((string)rootParameters.Get("xkey")).ToString());                
            }
            else
            {
                // Widgets are set to use cookies to remember what a user was working on. If page has not set xkey parameter, then it doesn't use widgets. Do not load them
                //widgetDesc.ShowOnPageLoad = false;
                //widgetAttach.ShowOnPageLoad = false;
                //widgetEvaluation.ShowOnPageLoad = false;
                //widgetScorecard.ShowOnPageLoad = false;
                //widgetWorkflow.ShowOnPageLoad = false;
            }           
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
           string currentPage = System.IO.Path.GetFileName(Request.Url.AbsolutePath);
            switch (currentPage)
            {
                // Enterprise Tab
                case "ent_dashboards.aspx":
                    pageName.Value = "Enterprise --> Enterprise Dashboards";
                    break;
                case "ent_reports.aspx":
                    pageName.Value = "Enterprise --> Enterprise Reports";
                    break;
                case "ent_apd.aspx":
                    pageName.Value = "Enterprise --> Enterprise APD";
                    break;
                case "ent_rtmplanning.aspx":
                    pageName.Value = "Enterprise --> Enterprise Planning RTM";
                    break;
                case "ent_rtmplanning_reports.aspx":
                    pageName.Value = "Enterprise --> Enterprise Planning RTM Reports";
                    break;
                case "ent_projects.aspx":
                    pageName.Value = "Enterprise --> Enterprise Projects";
                    break;
                case "ent_assessment.aspx":
                    pageName.Value = "Enterprise --> Setting --> Enterprise Assessment Configuration Screen";
                    break;
                case "ent_RTM.aspx":
                    pageName.Value = "Enterprise --> Setting --> Enterprise RTM Configuration Screen";
                    break;
                case "ent_setup.aspx":
                    pageName.Value = "Enterprise --> Setting --> Enterprise Configuration";
                    break;
                case "ent_workflow_multiassign.aspx":
                    pageName.Value = "Enterprise --> Setting --> Enterprise Workflow MultiAssign";
                    break;
                case "ent_security.aspx":
                    pageName.Value = "Enterprise --> Setting --> Enterprise Security Configuration Screen";
                    break;


                // Global Tab

                case "rc_components.aspx":
                    pageName.Value = "Global --> Components Screen";
                    break;
                case "ent_pm.aspx":
                    pageName.Value = "Global --> Project Management Screen";
                    break;
                case "ent_roadmap_view.aspx":
                    pageName.Value = "Global --> Roadmap Screen";
                    break;
                case "ent_IVV.aspx":
                    pageName.Value = "Global --> IV&V Screen";
                    break;
                // Analysis
                case "pro_dashboards.aspx":
                    pageName.Value = "Analysis --> Project Dashboards Screen";
                    break;
                case "pro_reports.aspx":
                    pageName.Value = "Analysis --> Project Reports Screen";
                    break;
                case "ent_roadmap.aspx":
                    pageName.Value = "Analysis --> Tasks, Gaps and Goals Screen";
                    break;
                case "pro_deliverable_schedule.aspx":
                    pageName.Value = "Analysis --> Deliverable Schedule Screen";
                    break;
                // Users Tab
                case "userhome.aspx":
                    pageName.Value = "User --> Personal Dashboard Screen";
                    break;
                case "Manage.aspx":
                    pageName.Value = "User --> Manage Profile Screen";
                    break;
              

            }
           
            
            //Check to see if session is dead. If so, sign out user and exit load (code below it needs those session variables)
            if (Session["userConnString"] == null || Session["projectID"] == null )
            {
                //|| !HttpContext.Current.User.Identity.IsAuthenticated
                if (!Page.AppRelativeVirtualPath.Contains("Login"))
                {
                    common_services.RefreshSession();
                }
                else
                {
                    return;
                }
                if (Session["userConnString"] == null ) {
                    //if (!Page.AppRelativeVirtualPath.Contains("Login"))
                    //{
                    //    menuRC.Visible = false;
                    //    Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
                    //}

                  
                    //
                    //throw new Exception("SessionExpired");
                }
                //Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
                //    menuRC.Visible = false;
                //    rootParameters.Set("TimedOut", "true");
                //  Session.Abandon();

                //hide menu if not authenticated
              

                return;
            }
            else { rootParameters.Remove("TimedOut"); }



            //TODO Disable all objects for which the user has no permission, using rc_services.CheckPermission(string Permission)
            if (!IsPostBack && !this.Page.IsCallback)
            {
                // Enterprise Tab Items
                menuRC.Items[0].Items[0].Enabled = rc_services.CheckPermission("ent_dashboards");
                menuRC.Items[0].Items[1].Enabled = rc_services.CheckPermission("ent_reports");
                menuRC.Items[0].Items[2].Enabled = rc_services.CheckPermission("ent_apd");
                menuRC.Items[0].Items[3].Enabled = rc_services.CheckPermission("ent_RTM_Planning");
                menuRC.Items[0].Items[4].Enabled = rc_services.CheckPermission("ent_RTM_Planning");
                menuRC.Items[0].Items[5].Enabled = rc_services.CheckPermission("ent_projects"); //  view ent_projects

                    // Enteprise tab --> Settings Sub Items
                menuRC.Items[0].Items[6].Items[0].Enabled = rc_services.CheckPermission("ent_assessment");// View Configuration
                menuRC.Items[0].Items[6].Items[1].Enabled = rc_services.CheckPermission("ent_RTM");// View ent_rtm
                menuRC.Items[0].Items[6].Items[2].Enabled = rc_services.CheckPermission("ent_setup");// View Configuration
                if (rc_services.CheckPermission("ent_workflow_manager")) { menuRC.Items[0].Items[6].Items[3].Visible = true; } else { menuRC.Items[0].Items[6].Items[3].Visible = false; }
                menuRC.Items[0].Items[6].Items[4].Enabled = rc_services.CheckPermission("ent_security");// View Security
              
                
               // Global Tab Items
                //menuRC.Items[1].Items[0].Enabled = rc_services.CheckPermission("ent_components");
                //menuRC.Items[1].Items[1].Enabled = rc_services.CheckPermission("ent_pm");
                if (rc_services.CheckPermission("ent_components")) { menuRC.Items[1].Items[0].Visible = true; } else { menuRC.Items[1].Items[0].Visible = false; }
                if (rc_services.CheckPermission("ent_pm")) { menuRC.Items[1].Items[1].Visible = true; } else { menuRC.Items[1].Items[1].Visible = false; }
                if (rc_services.CheckPermission("ent_roadmap")) { menuRC.Items[1].Items[2].Visible = true; } else { menuRC.Items[1].Items[2].Visible = false; }
                if (rc_services.CheckPermission("ent_IVV") && rc_services.CheckPermission("pro_IVV")) { menuRC.Items[1].Items[3].Visible = true; } else { menuRC.Items[1].Items[3].Visible = false; }

                // Repository Item
                if (rc_services.CheckPermission("ent_repository")) { menuRC.Items[2].Enabled = true; }

                //Assessment tab
                menuRC.Items[4].Enabled = rc_services.CheckPermission("ent_Project_assessment");

                //RTM Tab
                menuRC.Items[5].Enabled = rc_services.CheckPermission("ent_Project_RTM");

                // Analysis Tab Itmes
                menuRC.Items[6].Items[0].Enabled = rc_services.CheckPermission("pro_dashboards"); //enterprise roadmap
                menuRC.Items[6].Items[1].Enabled = rc_services.CheckPermission("pro_reports"); //enterprise roadmap
                if (rc_services.CheckPermission("ent_roadmap") ) { menuRC.Items[6].Items[2].Visible = true; }
                if (rc_services.CheckPermission("ent_deliverable") ) { menuRC.Items[6].Items[3].Visible = true; } else { menuRC.Items[6].Items[3].Visible = false; }
                if (rc_services.CheckPermission("ent_tasksgaps")) { menuRC.Items[6].Items[2].Visible = true; } else { menuRC.Items[6].Items[2].Visible = false; }

                //Check view permission by the page name
                //string PageName = System.IO.Path.GetFileName(System.Web.HttpContext.Current.Request.Url.AbsolutePath);
                //PageName = PageName.Replace(".aspx", "");
                //if (rc_services.CheckPermission(PageName) == false && PageName != "unauthorized") {
                //    Response.Redirect("~/controls/unauthorized.aspx");
                //}

                //TODO change this to color DIV bar below menu 
                //if logged in and working on a project, fill in the bottom label with name and color
                if (Session["projectColor"] != null && Session["projectName"] != null)
                {
                    System.Drawing.Color projectColor = System.Drawing.ColorTranslator.FromHtml(Session["projectColor"].ToString());
                    string projectName = Session["projectName"].ToString();
                    menuRC.Items[3].ItemStyle.BackColor = projectColor;
                    menuRC.Items[3].Text = projectName;
                }
            }
        }

        protected void HeadLoginStatus_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }

        //public void WidgetRefresher(string xID)
        //{
        //    string xStringID = xID.Split('|')[0];
         
        //    if (widgetScoreCard.IsVisible() && Session["widgetScoreCardOpen"] != null)      //currentWidget == "scorecard")
        //    {
        //        //controlScorecard.ItemKey = xStringID;
        //        widgetScoreCard.ShowOnPageLoad = true;
        //    }
        //}

        protected void rootCall_Callback(object sender, CallbackEventArgsBase e)
        {
            string[] guids = rootParameters.Get("xkey").ToString().Split('|');
            Guid xID = Guid.Parse(guids[0]);

            //if (e.Parameter.Contains("RefreshScorecard"))
            //{
            //    if (Session["card_id"] != null)
            //    {
            //        if (rootParameters.Contains("SelectedScorecard"))
            //        {
            //            controlScorecard.PrepareScorecard(Session["card_id"].ToString(), xID.ToString(), false);
            //        }
            //    }
            //}
            //WidgetRefresher(xID.ToString());
        }


        protected void gridProjects_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            ASPxGridView grid = (ASPxGridView)sender;
            int selectedIndex = Convert.ToInt32(e.Parameters);
            object value = grid.GetRowValues(selectedIndex, "Id");
            
            DropdownItem NewProject = new DropdownItem();
            NewProject = common_services.GetProjectMilestone(Guid.Parse(value.ToString()));
            HttpContext.Current.Session.Add("projectName", NewProject.Name);
            HttpContext.Current.Session.Add("projectColor", NewProject.Color);
            HttpContext.Current.Session.Add("projectID", NewProject.Id);
            HttpContext.Current.Session.Add("MilestoneID", NewProject.MilestoneID);
            HttpContext.Current.Session.Add("MilestoneName", NewProject.MilestoneName);
            Session["Mode"] = "project";

            //Load current project/enterprise permissions
            rc_services.GetActivePermissions();

            EventLogger.Log(NewProject.Name);

            //reload page to make sure all data controls are drawing from the new project ID
            Response.Redirect(Request.RawUrl);
        }

        protected void menuRC_ItemClick(object source, MenuItemEventArgs e)
        {
            switch (e.Item.Text)
            {
                case "Log Out":
                    EventLogger.Log("Log Out");
                    Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
                    Session.Abandon();
                    Response.Redirect("~/Account/Login.aspx");
                    break;             
            }
        }

        protected void sm_Init(object sender, EventArgs e)
        {

            ScriptManager sm = (ScriptManager)sender;
        }
        protected void gridProjects_Init(object sender, EventArgs e)
        {
            rc_services.GetActivePermissions();
            gridProjects = (ASPxGridView)sender;

            if (!rc_services.CheckPermission("ent_IVV"))
            {
                string project = "IV&V";

                gridProjects.DataSource = common_services.GetMenuProjects(project);
                gridProjects.DataBind();
            }
            else
            {
                string project = "";
                gridProjects.DataSource = common_services.GetMenuProjects(project);
                gridProjects.DataBind();
            }
        }
    }
    
}