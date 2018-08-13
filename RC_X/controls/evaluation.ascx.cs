using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RC_X.controls
{
    public partial class evaluation : System.Web.UI.UserControl
    {
        public string ItemKey
        {
            get { return ViewState["evaluationKey"] as string; }
            set { ViewState["evaluationKey"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)

        {
            if (ItemKey == null)
            {
                return;
            }

            BindEvaluation();

        }
        public void BindEvaluation()
        {
            if (rc_services.CheckPermission("pro_RTM_evaluation_readonly"))
            {
               
                gridEvaluation.DataSource = rc_services.GetEvaluation(ItemKey);
                gridEvaluation.DataBind();
                gridEvaluation.SettingsDataSecurity.AllowEdit = false;

            }else if (rc_services.CheckPermission("pro_RTM_evaluation_read"))
            {
                string user = HttpContext.Current.Session["UserEmail"].ToString();
                gridEvaluation.DataSource = rc_services.GetEvaluation(ItemKey, user);
                gridEvaluation.DataBind();

            }
            else
            {
                gridEvaluation.DataSource = rc_services.GetEvaluation(ItemKey);
                gridEvaluation.DataBind();
            }

        }

        protected void gridEvaluation_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            var user = HttpContext.Current.Session["UserEmail"].ToString();
            ResponseEvaluation re = new ResponseEvaluation();
            
            re.ItemID = Guid.Parse(ItemKey);
            re.ReviwerDate = DateTime.Parse(e.NewValues["eval_date"].ToString());
           
            // re.ReviwerBy = e.NewValues["eval_by"].ToString();
            re.ReviwerBy = user;
            re.ReviwerComments = e.NewValues["eval_description"].ToString();
            re.ReviwerAssessment = e.NewValues["eval_reviewer_assessments"].ToString();

            rc_services.InsertNewEvaluation(re);

            e.Cancel = true;
            gridEvaluation.CancelEdit();


            BindEvaluation();
        }
    }
}