using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using RC_X.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RC_X
{
    public partial class superadmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserEmail"].ToString() != "fcruz@ehr-llc.com" && Session["UserEmail"].ToString() != "bcardone@ehr-llc.com")
            {
                Response.Redirect("~/controls/unauthorized.aspx");
            }
        }

        protected void btCreate_Click(object sender, EventArgs e)
        {
            if (comboEnterprises.SelectedIndex != -1)
            {
                string EnterpriseID;
                string RoleID = "E7CB9526-8E29-406D-BAF8-5BD00B4BC2B4";
                string SandboxID = "01A5AEEC-EEF6-4A75-90F9-B36BEFEBFBF0";
                string ConnString = "";
                string UserID = Guid.NewGuid().ToString();
                string UserName = txUsername.Text.Trim();
                EnterpriseID = comboEnterprises.Value.ToString();

                DataView xEnterprise = (DataView)sqlEnterprises.Select(DataSourceSelectArguments.Empty);
                DataTable EnterpriseTable = xEnterprise.Table;

                //foreach (int i = 0; i <= EnterpriseTable.Rows.Count; i++)
                foreach (DataRow row in EnterpriseTable.Rows)
                {
                    if (row["en_id"].ToString() == EnterpriseID)
                    {
                        ConnString = row["en_connstring"].ToString();
                    }
                }

                sqlSecurity.InsertParameters.Clear();
                sqlSecurity.InsertParameters.Add("entrole_user", UserID);
                sqlSecurity.InsertParameters.Add("entrole_roleID", RoleID);
                sqlSecurity.Insert();

                var password = "ReadyFreddy";
                var manager = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var signInManager = System.Web.HttpContext.Current.GetOwinContext().Get<ApplicationSignInManager>();
                var user = new ApplicationUser() { UserName = UserName, Email = UserName, enterprise = Guid.Parse(EnterpriseID), connstring = ConnString, project = Guid.Parse(SandboxID), EmailConfirmed=true, Id = UserID };
                IdentityResult result = manager.Create(user, password);
                if (result.Succeeded)
                {
                    lbResult.Text = "User " + UserName + " created successfully";
                }
            }
       
        }
    }
}