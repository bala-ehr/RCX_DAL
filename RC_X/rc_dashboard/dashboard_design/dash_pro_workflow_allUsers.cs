using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess;
using DevExpress.DashboardCommon;

namespace RC_X.rc_dashboard.dashboard_design
{
    public partial class dash_pro_workflow_allUsers : DevExpress.DashboardCommon.Dashboard
    {
        public dash_pro_workflow_allUsers()
        {
            InitializeComponent();
        }

        private void dash_pro_workflow_allUsers_CustomParameters(object sender, CustomParametersEventArgs e)
        {
            var UserIDParameter = e.Parameters.FirstOrDefault(p => p.Name == "ProjectID");
            if (UserIDParameter != null)
            {
                UserIDParameter.Value = System.Web.HttpContext.Current.Session["ProjectID"].ToString(); ;
            }
        }
    }
}
