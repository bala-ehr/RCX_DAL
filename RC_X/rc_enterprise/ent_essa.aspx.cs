using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RC_X.rc_enterprise
{
    public partial class ent_essa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void comboESSA_ButtonClick(object source, DevExpress.Web.ButtonEditClickEventArgs e)
        {
            if (comboESSA.SelectedItem == null) { return; }
            string xURL = Request.Url.AbsoluteUri;
            xURL = xURL.Replace("/rc_enterprise/ent_essa.aspx", "/Content/eSSAtemp/");
            string fileName = comboESSA.SelectedItem.Value.ToString();
            string fileURL = xURL + fileName ;

            Response.Redirect(fileURL);

            //WebClient webClient = new WebClient();
            //webClient.DownloadFile(new Uri(fileURL), Server.MapPath("~/Content/eSSAtemp/" + fileName));

            //byte[] fileData = null;
            //using (var wc = new System.Net.WebClient())
            //    fileData = wc.DownloadData(fileURL);
            //Response.Clear();
            //Response.AddHeader("Content-Disposition", "attachment; filename=\"" + fileName + "\"");
            //Response.AddHeader("Content-Length", fileData.Length.ToString());
            //Response.ContentType = "application/octet-stream";
            //Response.BinaryWrite(fileData);
        }
    }
}