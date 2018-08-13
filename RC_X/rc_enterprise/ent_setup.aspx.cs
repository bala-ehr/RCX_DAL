using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static RC_X.rtm_services;

namespace RC_X
{
    public partial class ent_setup : System.Web.UI.Page
    {
        ASPxGridView gridStandards;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!rc_services.CheckPermission("ent_setup")) { Response.Redirect("~/controls/unauthorized.aspx"); }

            BindMilestones();
            if (gvMilestone.IsCallback)
            {
                BindMilestones();
                return;
            }
            gridTypes.Columns[0].Visible = rc_services.CheckPermission("ent_setup_edit");
            gridScorecards.Columns[0].Visible = rc_services.CheckPermission("ent_setup_edit");
           // gridProjects.Columns["Edit"].Visible = rc_services.CheckPermission("ent_projects");

            //if (!gridProjects.IsEditing)
            //{
            //    ((GridViewDataComboBoxColumn)gridProjects.Columns["ChooseMilestone"]).PropertiesComboBox.DataSource = common_services.GetStaticMilestones();
            //}




        }

        protected void gridStandards_BeforePerformDataSelect(object sender, EventArgs e)
        {
            Session["card_id"] = (sender as ASPxGridView).GetMasterRowKeyValue();
        }

        protected void gridValues_BeforePerformDataSelect(object sender, EventArgs e)
        {
            hdnStandardID.Value = ((sender as ASPxGridView).GetMasterRowKeyValue()).ToString();
            Session["stand_id"] = ((sender as ASPxGridView).GetMasterRowKeyValue()).ToString();
        }

        private void BindMilestones()
        {


           
            gvMilestone.DataSource = common_services.GetMilestone(); ; // common_services.GetMilestone();
            gvMilestone.DataBind();
        }

        protected void gridScorecards_ParseValue(object sender, DevExpress.Web.Data.ASPxParseValueEventArgs e)
        {
            //if (e.Value.GetType() == Type.GetType("bool"))
            //{
            //    if (e.Value == null)
            //    {
            //        e.Value = 0;
            //    }
            //}          
        }

        protected void gridStandards_Init(object sender, EventArgs e)
        {
            gridStandards = (ASPxGridView)sender;
            gridStandards.Columns[0].Visible = rc_services.CheckPermission("ent_setup_edit");
            gridStandards.DataBind();
        }

        protected void gridValues_Init(object sender, EventArgs e)
        {
            ASPxGridView gridValues = (ASPxGridView)sender;
            gridValues.Columns[0].Visible = rc_services.CheckPermission("ent_setup_edit");
        }

        protected void gvMilestone_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            var mil = new Milestone();
            mil.Name = e.NewValues["Name"].ToString();
            mil.MilestoneType = e.NewValues["MilestoneType"].ToString();
            mil.Description = e.NewValues["Description"].ToString();
            mil.Date = DateTime.Parse(e.NewValues["Date"].ToString());
            mil.IsStatic = e.NewValues["IsStatic"] == null ? false : Convert.ToBoolean(e.NewValues["IsStatic"]);
            common_services.InsertNewMilestone(mil);
            e.Cancel = true;
            gvMilestone.CancelEdit();
            BindMilestones();
        }

        protected void gvMilestone_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            var mil = new Milestone();
            mil.Id = e.Keys["Id"].ToString();
            mil.Name = e.NewValues["Name"].ToString();
            mil.MilestoneType = e.NewValues["MilestoneType"].ToString();
            mil.Description = e.NewValues["Description"].ToString();
            mil.Date = DateTime.Parse(e.NewValues["Date"].ToString());
            mil.IsStatic = e.NewValues["IsStatic"] == null ? false : Convert.ToBoolean(e.NewValues["IsStatic"]);
            common_services.UpdateMilestones(mil);
            e.Cancel = true;
            gvMilestone.CancelEdit();
            BindMilestones();
        }



        protected void gridScorecards_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {

        }



        protected void gridMatrix_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            ASPxGridView gridMatrix = (ASPxGridView)sender;
            ASPxGridView gridAssessItems = (ASPxGridView)gridMatrix.FindEditFormLayoutItemTemplateControl("gridAssessItems");

            //ASPxGridLookup dropMatrix = (ASPxGridLookup)gridScorecards.FindEditFormLayoutItemTemplateControl("dropMatrix");
            List<UniversalAssessmentItem> ItemsList = new List<UniversalAssessmentItem>();
            for (int i = 0; i <= gridAssessItems.VisibleRowCount; i = i + 1)
            {
                if (gridAssessItems.Selection.IsRowSelected(i) == true)
                {
                    ItemsList.Add(new UniversalAssessmentItem { Id = gridAssessItems.GetRowValues(i, "id").ToString() });
                }
            }
            rc_services.SaveCardAsMatrix(Session["card_id"].ToString(), ItemsList);
            string xResult = rc_services.FillScorecard();
            e.Cancel = true;
            gridMatrix.CancelEdit();
            gridMatrix.DataBind();
        }

        protected void gridValues_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            var stand_id = ((sender as ASPxGridView).GetMasterRowKeyValue()).ToString();
            ScoreStandardValues std = new ScoreStandardValues();
            std.StandardId = stand_id;

            if (e.NewValues["value_score"] != null)
                std.ValueScore = int.Parse(e.NewValues["value_score"].ToString());
            else
                throw new Exception("Specify Score value");

            std.ValueScoreText = e.NewValues["value_scoretext"].ToString();

            rc_services.InsertNewStandardValues(std);
            e.Cancel = true;
            var grid = (sender as ASPxGridView);
            grid.CancelEdit();
            grid.DataBind();
        }

        protected void sqlStandards_Init(object sender, EventArgs e)
        {
            SqlDataSource sqlStandards = (SqlDataSource)sender;
            sqlStandards.ConnectionString = Session["userConnString"].ToString();
        }

        protected void sqlValues_Init(object sender, EventArgs e)
        {
            SqlDataSource sqlValues = (SqlDataSource)sender;
            sqlValues.ConnectionString = Session["userConnString"].ToString();
        }

        protected void sqlAllAssess_Init(object sender, EventArgs e)
        {
            SqlDataSource sqlAllAssess = (SqlDataSource)sender;
            sqlAllAssess.ConnectionString = Session["userConnString"].ToString();
        }

        protected void gridMatrix_Init(object sender, EventArgs e)
        {

        }

        protected void sqlMatrix_Init(object sender, EventArgs e)
        {
            SqlDataSource sqlMatrix = (SqlDataSource)sender;
            sqlMatrix.ConnectionString = Session["userConnString"].ToString();
        }

        protected void gridScorecards_RowInserted(object sender, DevExpress.Web.Data.ASPxDataInsertedEventArgs e)
        {
            string xResult = rc_services.FillScorecard();
        }

        protected void gridStandards_RowInserted(object sender, DevExpress.Web.Data.ASPxDataInsertedEventArgs e)
        {
            string xResult = rc_services.FillScorecard();
        }

        protected void sqlScorecards_Init(object sender, EventArgs e)
        {
            SqlDataSource sqlScorecards = (SqlDataSource)sender;
            sqlScorecards.ConnectionString = Session["userConnString"].ToString();
        }

        protected void sqlGlobalTypes_Init(object sender, EventArgs e)
        {
            SqlDataSource sqlGlobalTypes = (SqlDataSource)sender;
            sqlGlobalTypes.ConnectionString = Session["userConnString"].ToString();
        }
    }
}