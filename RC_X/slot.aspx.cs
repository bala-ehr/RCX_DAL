using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RC_X
{
    public partial class slot : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            linkGit.NavigateUrl = linkGit.NavigateUrl + ConfigurationManager.AppSettings["rcx_commit"].ToString();
        }

   
        protected void btPostBack_Click(object sender, EventArgs e)
        {
            throw new System.ArgumentException("This is a postback error: " + IsPostBack.ToString());
        }

        protected void ASPxCallbackPanel1_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            throw new System.ArgumentException("This is a callback error: " + IsCallback.ToString());
        }
    }
}