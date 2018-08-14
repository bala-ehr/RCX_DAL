using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RC_X.rc_enterprise
{
    public partial class ent_dashdesigner : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dashDesigner.SetConnectionStringsProvider(new MyDataSourceWizardConnectionStringsProvider());
        }
    }
}