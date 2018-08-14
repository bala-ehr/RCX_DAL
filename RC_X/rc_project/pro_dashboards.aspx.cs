using DevExpress.DataAccess.ConnectionParameters;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RC_X.rc_project
{
    public partial class pro_dashboards : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!rc_services.CheckPermission("pro_dashboards")) { Response.Redirect("~/controls/unauthorized.aspx"); }

            if (comboDashboards.Value != null && comboDashboards.SelectedIndex > -1)
            {
                string SelectedReport = comboDashboards.Value.ToString();
                dashViewer.DashboardXmlPath = Server.MapPath("~/rc_dashboard/dashboard_xml/" + SelectedReport + ".xml");
            }
        }

        protected void comboDashboards_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void dashViewer_ConfigureDataConnection(object sender, DevExpress.DashboardWeb.ConfigureDataConnectionWebEventArgs e)
        {
            try
            {
                MsSqlConnectionParameters parameters = e.ConnectionParameters as MsSqlConnectionParameters;
                if (parameters != null)
                {
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder((string)Session["userConnString"]);
                    parameters.AuthorizationType = MsSqlAuthorizationType.SqlServer;
                    parameters.ServerName = builder.DataSource;
                    parameters.DatabaseName = builder.InitialCatalog;
                    parameters.UserName = builder.UserID;
                    parameters.Password = builder.Password;
                }
            }
            catch (Exception ex) { return; }
        }
    }
}