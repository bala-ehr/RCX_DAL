using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RC_X.controls
{
    public partial class rc_error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ASPxFormLayout1_E3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/rc_project/userhome.aspx");
        }
    }
}