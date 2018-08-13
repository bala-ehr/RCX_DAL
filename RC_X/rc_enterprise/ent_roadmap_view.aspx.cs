using DevExpress.DataAccess.ConnectionParameters;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RC_X.rc_enterprise
{
    public partial class ent_roadmap_view : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindProjects();
        }
        protected void dashRoadmap_ConfigureDataConnection(object sender, DevExpress.DashboardWeb.ConfigureDataConnectionWebEventArgs e)
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
        private void BindProjects()
        {
            gridProjects.DataSource = common_services.GetEnterpriseRoadMapProjects();
            gridProjects.DataBind();

           
        }
        public static string GetImageName(object dataValue)
        {
            string val = string.Empty;
            try
            {
                val = (string)dataValue;
            }
            catch { }

            switch (val)
            {
                case "#22EA21":
                    return "~/Content/Images/greenstar.png";
                case "#F2F91D":
                    return "~/Content/Images/yellowstar.png";
                default:
                    return "~/Content/Images/redstar.png";
            }


        }

        protected void sqlChart_Init(object sender, EventArgs e)
        {
            SqlDataSource sqlChart = (SqlDataSource)sender;
            sqlChart.ConnectionString = Session["userConnString"].ToString();
        }
    }
}