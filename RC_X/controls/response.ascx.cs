using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RC_X.controls
{
    public partial class response : System.Web.UI.UserControl
    {
        RootMaster MasterPage;
        ASPxHiddenField rootParameters;

        #region properties
        public String ItemKey
        {
            get { if (rootParameters.Contains("xkey")) { return rootParameters["xkey"] as string; } else { return null;}}
            set { rootParameters.Set("xkey", value); }
        }
        public String MilestoneID
        { 
            get { if (rootParameters.Contains("MilestoneID")){ return rootParameters["MilestoneID"] as string; } else { return null;}}
            set { rootParameters.Set("MilestoneID", value); }
        }
        public Boolean IsSaved // must use control with default value of true
        {            
            get { if (rootParameters.Contains("responseIsSaved")) {return (bool)rootParameters["responseIsSaved"]; }  else  { return true;}; }
            set { rootParameters.Set("responseIsSaved", value); }
        }
        public String ResponseID
        {
            get  { if (rootParameters.Contains("ResponseID")) { return (string)rootParameters["ResponseID"]; } else  { return null; } }
            set { rootParameters.Set("ResponseID",value ); }
        }
        public String AssessmentValue
        {
            get { if (rootParameters.Contains("AssessmentValue")) { return (string)rootParameters["AssessmentValue"]; } else { return null; } }
            set { rootParameters.Set("AssessmentValue", value); }
        }
        public Boolean AllowAssessment
        {
            get { if (rootParameters.Contains("AllowAssessment")) { return (bool)rootParameters["AllowAssessment"]; } else { return false; } }
            set { rootParameters.Set("AllowAssessment", value); }
        }
        public Boolean AllowMilestone // DEfault is TRue
        {
            get { if (rootParameters.Contains("responseAllowMilestone")) { return (bool)rootParameters["responseAllowMilestone"]; } else { return true; }; }
            set { rootParameters.Set("responseAllowMilestone", value); }
        }
        public Boolean StaticMilestone // DEfault is True
        {
            get { if (rootParameters.Contains("responseStaticMilestone")) { return (bool)rootParameters["responseStaticMilestone"]; } else { return true; }; }
            set { rootParameters.Set("responseStaticMilestone", value); }
        }
#endregion

        protected void Page_Init(object sender, EventArgs e)
        {
            MasterPage = (RootMaster)Page.Master.Master;
            rootParameters = MasterPage.masterParameters;
            //if (!(rc_services.CheckPermission("pro_RTM_Responses_edit")))
            //{
            //    dropMilestone.ReadOnly = true;
            //    dropAssessment.ReadOnly = true;
            //    txResponse.Settings.AllowHtmlView = false;
            //    txResponse.Settings.AllowPreview = true;
            //    txResponse.Settings.AllowDesignView = false;
            //}
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //If this page requires users to choose an assessment value, make assessment dropdown visible 
            // and user can't have edit security settings, widget will act as Read Only
            if (AllowAssessment == true)
            {
                dropAssessment.Visible = true;
                if (!(rc_services.CheckPermission("pro_RTM_Responses_edit")))
                {
                   
                    dropAssessment.ReadOnly = true;
                    txResponse.Settings.AllowHtmlView = false;
                    txResponse.Settings.AllowPreview = true;
                    txResponse.Settings.AllowDesignView = false;
                    btSave.Visible = false;
                    btCancel.Visible = false;
                }
            }
            else
            {
                dropAssessment.Visible = false;
                if (!(rc_services.CheckPermission("pro_Assessment_Responses_edit")))
                {
                    dropMilestone.ReadOnly = true;
                    txResponse.Settings.AllowHtmlView = false;
                    txResponse.Settings.AllowPreview = true;
                    txResponse.Settings.AllowDesignView = false;
                    btSave.Visible = false;
                    btCancel.Visible = false;
                }
               
            }

            if (ItemKey==null)
            {
                //If no ItemKey is available, widget is not loading, so avoid binding and return out of loading/binding the control
                IsSaved = true;
                return;
            } else if (IsSaved && Session["widgetDescOpen"]!=null)
            {
               

                // IF there is a key, bind it, unless user is editing response (IsSaved==false), because that would overwrite user changes
                BindForm();    
                
            }
        }

        protected void btSave_Click(object sender, EventArgs e)
        {
            //Check if there is a MIlestone is selected, and if so, assign its value
            //if (MilestoneID != null && StaticMilestone == false) { MilestoneID = (string)dropMilestone.SelectedItem.Value; }
            SaveResponse();
        }

        protected void btCancel_Click(object sender, EventArgs e)
        {
            BindForm();
        }

        public void BindForm()
        {
            //bind the dropdown
            if (AllowAssessment == true)
            {
                dropAssessment.DataSource = common_services.GetCustomDropDown("response");
                dropAssessment.DataBind();
            }

     

            //First check to see if MIlestones are allowed/needed in the first place, if not, just set it null
            //If widget is set to static milestones, hide dropdown and set MIlestoneID property based on rootParameter given by Root.Master.
            // If the parameter is not given, then this is a page that does not require milestones
            //If it is fluid, then make the dropdown visible, select the last value selected if available, and set MIlestoneID=dro
            if (AllowMilestone == true)
            {
                if (StaticMilestone == true)
                {
                    dropMilestone.Visible = false;
                    if (Session["MilestoneID"] != null)
                    {
                        MilestoneID = Session["MilestoneID"].ToString();
                    }
                    //else // If it hasn't been set, it means this page does not use MIlestones - set null
                    //{
                    //    MilestoneID = null;
                    //}
                }
                else
                {
                    dropMilestone.DataSource = common_services.GetFluidMilestones();
                    dropMilestone.DataBind();

                    dropMilestone.Visible = true;
                    if (rootParameters.Contains("SelectedMilestone"))
                    {
                        try {
                            dropMilestone.SelectedIndex = Convert.ToInt32(rootParameters["SelectedMilestone"]);
                            MilestoneID = (string)dropMilestone.SelectedItem.Value;
                        }
                        catch { }

                        }
                    else
                    {
                        //at this point we know the page needs a milestone, and it is fluid, yet there is no value.
                        // this means the user has not picked one yet, so we just pick the first milestone because
                        // the Stored Procedure inserts if it select returns null, and we don't want to insert with MIlestoneID=null if MIlestone is required..
                        try
                        {
                            MilestoneID = (string)dropMilestone.Items[0].Value;
                        }
                        catch { }

                    }
                }
            }
            else
            {
                MilestoneID = null;
            }


            //Now bind that response based on milestone

            AssessmentResponse Response = new AssessmentResponse();           
           // Response = rc_services.GetResponse(Guid.Parse(ItemKey), MilestoneID);
                txResponse.Html = Response.Response;
                dropAssessment.Value = Response.Assesment;
            AssessmentValue = Response.Assesment;
                ResponseID = Response.ResponseID.ToString();

            dropMilestone.SelectedItem = dropMilestone.Items.FindByValue(MilestoneID );
            dropAssessment.SelectedItem = dropAssessment.Items.FindByValue(Response.Assesment);

        }

        public void SaveResponse()
        {
            AssessmentResponse Response = new AssessmentResponse();
           // Response = rc_services.GetResponse(Guid.Parse(ItemKey), MilestoneID);
            Guid ResponseID = Guid.Parse(Response.ResponseID.ToString());
            if (AllowAssessment == true)
            {
                if (AssessmentValue == Response.Assesment)
                {
                   // rc_services.SaveResponse(ResponseID, txResponse.Html, AssessmentValue, MilestoneID);
                }
                else
                {
                    //rc_services.InsertNewResponse(ItemKey, txResponse.Html, AssessmentValue, MilestoneID);
                }
            }
            else
            {
                if (Response.ItemKey == Guid.Parse(ItemKey) && Response.MilestoneID == Guid.Parse(MilestoneID))
                {
                    //rc_services.SaveResponse(ResponseID, txResponse.Html, AssessmentValue, MilestoneID);
                }
                else
                {
                   // rc_services.InsertNewResponse(ItemKey, txResponse.Html, AssessmentValue, MilestoneID);
                }
            }
            // AssessmentValue = (string)dropAssessment.SelectedItem.Value;

            BindForm();
            IsSaved = true;
        }
    }
}