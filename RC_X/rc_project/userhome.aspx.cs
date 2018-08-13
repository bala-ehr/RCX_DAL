using DevExpress.DataAccess.ConnectionParameters;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RC_X
{
	public partial class UserHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            //dashWorkflow.SetConnectionStringsProvider(new MyDataSourceWizardConnectionStringsProvider());
        }

        protected void dashWorkflow_ConfigureDataConnection(object sender, DevExpress.DashboardWeb.ConfigureDataConnectionWebEventArgs e)
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

        //protected void dashWorkflow_DashboardLoading(object sender, DevExpress.DashboardWeb.DashboardLoadingWebEventArgs e)
        //{

        //    if (ReportObject.Parameters["ProjectID"] != null) { ReportObject.Parameters["ProjectID"].Value = System.Web.HttpContext.Current.Session["projectID"].ToString(); }
        //    if (ReportObject.Parameters["ProjectColor"] != null) { ReportObject.Parameters["ProjectColor"].Value = System.Web.HttpContext.Current.Session["projectColor"].ToString(); }
        //    if (ReportObject.Parameters["ProjectName"] != null) { ReportObject.Parameters["ProjectName"].Value = System.Web.HttpContext.Current.Session["projectName"].ToString(); }
        //    if (ReportObject.Parameters["EnterpriseName"] != null) { ReportObject.Parameters["EnterpriseName"].Value = System.Web.HttpContext.Current.Session["EnterpriseName"].ToString(); }
        //    if (ReportObject.Parameters["EnterpriseID"] != null) { ReportObject.Parameters["EnterpriseID"].Value = System.Web.HttpContext.Current.Session["enterpriseID"].ToString(); }
        //    if (ReportObject.Parameters["MilestoneID"] != null) { ReportObject.Parameters["MilestoneID"].Value = System.Web.HttpContext.Current.Session["MilestoneID"].ToString(); }
        //    if (ReportObject.Parameters["MilestoneName"] != null) { ReportObject.Parameters["MilestoneName"].Value = System.Web.HttpContext.Current.Session["MilestoneName"].ToString(); }
        //    if (ReportObject.Parameters["UserEmail"] != null) { ReportObject.Parameters["UserEmail"].Value = System.Web.HttpContext.Current.Session["UserEmail"].ToString(); }
        //    if (ReportObject.Parameters["UserID"] != null) { ReportObject.Parameters["UserID"].Value = System.Web.HttpContext.Current.Session["UserID"].ToString(); }

        //}

        protected void dashWorkflow_CustomParameters(object sender, DevExpress.DashboardWeb.CustomParametersWebEventArgs e)
        {
            var UserIDParameter = e.Parameters.FirstOrDefault(p => p.Name == "UserEmail");
            if (UserIDParameter != null)
            {
                UserIDParameter.Value = System.Web.HttpContext.Current.Session["UserEmail"].ToString(); ;
            }
            
        }
    }
}