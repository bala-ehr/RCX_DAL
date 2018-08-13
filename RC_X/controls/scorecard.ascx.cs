using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RC_X.controls
{
    public partial class scorecard : System.Web.UI.UserControl
    {
        RootMaster MasterPage;
        ASPxHiddenField rootParameters;

        public String ItemKey
        {
            get { if (rootParameters.Contains("xkey")) { return rootParameters["xkey"] as string; } else { return null; } }
            set { rootParameters.Set("xkey", value); }
        }
        public String SelectedScorecard
        {
            get { if (rootParameters.Contains("SelectedScorecard")) { return rootParameters["SelectedScorecard"].ToString(); } else { return null; } }
            set { rootParameters.Set("SelectedScorecard", value); }
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            MasterPage = (RootMaster)Page.Master.Master;
            rootParameters = MasterPage.masterParameters;

            //TODO temporarily disabled, fills the quick scores. currently hardwired to 0-5
            PrepareDropdown();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            pageScore.Visible = false;
            if (ItemKey == null || SelectedScorecard == null)
            {
                pageScore.Visible = false;
                return;
            }
            else if (!rootParameters.Contains("ScorecardNeedsSave"))
            {
                pageScore.Visible = true;
                PrepareScorecard(SelectedScorecard, ItemKey, false);
                //Save Session values for refresh
                Session["card_id"] = SelectedScorecard;
                Session["score_itemid"] = ItemKey;
                //SelectedScorecard = e.Parameter;
            }
            //BindForm();

        }

        public void PrepareScorecard(string card_id, string score_itemid, Boolean Isupdating)
        {

            dropScorecard.DataBind();
            ListEditItem Item = dropScorecard.Items.FindByValue(card_id);
            if (Item == null) { return; }

            pageScore.Visible = true;
            btQuickSave.Visible = true;

            //Get the Socre COlumns
            GridViewColumn Score1 = gridScorecard.Columns["score_col1"];
            GridViewColumn Score2 = gridScorecard.Columns["score_col2"];
            GridViewColumn Score3 = gridScorecard.Columns["score_col3"];
            GridViewColumn Score4 = gridScorecard.Columns["score_col4"];
            GridViewColumn Score5 = gridScorecard.Columns["score_col5"];

            //TRyParse to booleans for what should be visible, set it so
            bool Col1Visible;
            bool Col2Visible;
            bool Col3Visible;
            bool Col4Visible;
            bool Col5Visible;


            Boolean.TryParse(Item.GetFieldValue("card_colenabled1").ToString(), out Col1Visible);
            Boolean.TryParse(Item.GetFieldValue("card_colenabled2").ToString(), out Col2Visible);
            Boolean.TryParse(Item.GetFieldValue("card_colenabled3").ToString(), out Col3Visible);
            Boolean.TryParse(Item.GetFieldValue("card_colenabled4").ToString(), out Col4Visible);
            Boolean.TryParse(Item.GetFieldValue("card_colenabled5").ToString(), out Col5Visible);

            gridScorecard.Columns["score_col1"].Visible = Col1Visible; ComboHeader1.Visible = Col1Visible;
            gridScorecard.Columns["score_col2"].Visible = Col2Visible; ComboHeader2.Visible = Col2Visible;
            gridScorecard.Columns["score_col3"].Visible = Col3Visible; ComboHeader3.Visible = Col3Visible;
            gridScorecard.Columns["score_col4"].Visible = Col4Visible; ComboHeader4.Visible = Col4Visible;
            gridScorecard.Columns["score_col5"].Visible = Col5Visible; ComboHeader5.Visible = Col5Visible;

            //Set Their captions
            Score1.Caption = (string)Item.GetFieldValue("card_col1").ToString();
            Score2.Caption = (string)Item.GetFieldValue("card_col2").ToString();
            Score3.Caption = (string)Item.GetFieldValue("card_col3").ToString();
            Score4.Caption = (string)Item.GetFieldValue("card_col4").ToString();
            Score5.Caption = (string)Item.GetFieldValue("card_col5").ToString();

            //Clear previous values from quick score
            //ComboHeader1.Items.Clear();
            //ComboHeader2.Items.Clear();
            //ComboHeader3.Items.Clear();
            //ComboHeader4.Items.Clear();
            //ComboHeader5.Items.Clear();

      

            // Give the quick score dropdowns the name of the value columns
            ComboHeader1.Caption = (string)Item.GetFieldValue("card_col1").ToString();
            ComboHeader2.Caption = (string)Item.GetFieldValue("card_col2").ToString();
            ComboHeader3.Caption = (string)Item.GetFieldValue("card_col3").ToString();
            ComboHeader4.Caption = (string)Item.GetFieldValue("card_col4").ToString();
            ComboHeader5.Caption = (string)Item.GetFieldValue("card_col5").ToString();

            //Now set their visibility
            ComboHeader1.Visible = Col1Visible;
            ComboHeader2.Visible = Col2Visible;
            ComboHeader3.Visible = Col3Visible;
            ComboHeader4.Visible = Col4Visible;
            ComboHeader5.Visible = Col5Visible;


            if (Item.GetFieldValue("card_measure") != DBNull.Value && (Boolean)Item.GetFieldValue("card_measure") == true)
            {
                gridScorecard.Columns["score_colmeasure1"].Visible = Item.GetFieldValue("card_colenabled1") == DBNull.Value ? false : (Boolean)Item.GetFieldValue("card_colenabled1");
                gridScorecard.Columns["score_colmeasure2"].Visible = Item.GetFieldValue("card_colenabled2") == DBNull.Value ? false : (Boolean)Item.GetFieldValue("card_colenabled2");
                gridScorecard.Columns["score_colmeasure3"].Visible = Item.GetFieldValue("card_colenabled3") == DBNull.Value ? false : (Boolean)Item.GetFieldValue("card_colenabled3");
                gridScorecard.Columns["score_colmeasure4"].Visible = Item.GetFieldValue("card_colenabled4") == DBNull.Value ? false : (Boolean)Item.GetFieldValue("card_colenabled4");
                gridScorecard.Columns["score_colmeasure5"].Visible = Item.GetFieldValue("card_colenabled5") == DBNull.Value ? false : (Boolean)Item.GetFieldValue("card_colenabled5");

                gridScorecard.Columns["score_colmeasure1"].Caption = Item.GetFieldValue("card_measure1") == DBNull.Value ? string.Empty : (string)Item.GetFieldValue("card_measure1");
                gridScorecard.Columns["score_colmeasure2"].Caption = Item.GetFieldValue("card_measure2") == DBNull.Value ? string.Empty : (string)Item.GetFieldValue("card_measure2");
                gridScorecard.Columns["score_colmeasure3"].Caption = Item.GetFieldValue("card_measure3") == DBNull.Value ? string.Empty : (string)Item.GetFieldValue("card_measure3");
                gridScorecard.Columns["score_colmeasure4"].Caption = Item.GetFieldValue("card_measure4") == DBNull.Value ? string.Empty : (string)Item.GetFieldValue("card_measure4");
                gridScorecard.Columns["score_colmeasure5"].Caption = Item.GetFieldValue("card_measure5") == DBNull.Value ? string.Empty : (string)Item.GetFieldValue("card_measure5");
            }
            else
            {
                gridScorecard.Columns["score_colmeasure1"].Visible = false;
                gridScorecard.Columns["score_colmeasure2"].Visible = false;
                gridScorecard.Columns["score_colmeasure3"].Visible = false;
                gridScorecard.Columns["score_colmeasure4"].Visible = false;
                gridScorecard.Columns["score_colmeasure5"].Visible = false;
            }


            //prepare select parameters for score 
            sqlScores.SelectParameters.Clear();
            sqlScores.SelectParameters.Add("score_projectid", Session["projectID"].ToString());
            sqlScores.SelectParameters.Add("score_itemid", score_itemid);
            sqlScores.SelectParameters.Add("card_id", card_id);

            ////prepare select parameters for values

            //sqlValues.SelectParameters.Clear();
            //sqlValues.SelectParameters.Add("stan_id", score_itemid);

            //Execute stored procedure for filling in records if they don't exist
            

            //show and bind datagrid, only skip binding if this was called from rowupdating event
            gridScorecard.Visible = true;
            if (Isupdating == false) { gridScorecard.DataBind(); }

            
            ////Create dropdown array
            //for (int i=0; i<gridScorecard.VisibleRowCount; i++){

            //}

        }

        protected void gridScorecard_RowUpdated(object sender, DevExpress.Web.Data.ASPxDataUpdatedEventArgs e)
        {
            //PrepareScorecard((string)Session["card_id"], (string)Session["score_itemid"],true );
            rootParameters.Remove("ScorecardNeedsSave");
        }


        //public class StandardScoreValues
        //{
        //    public string StandardId { get; set; }
        //    public string Score { get; set; }
        //    public string Description { get; set; }
          
        //}
        protected void gridScorecard_DataBound(object sender, EventArgs e)
        {           
            var grid = sender as ASPxGridView;
            if (grid == null) return;
            foreach (var column in grid.Columns.OfType<GridViewDataColumn>().Where(c => c.Caption != "Standard"))
            {
                column.Width = System.Web.UI.WebControls.Unit.Point(column.FieldName.Length * 6);
            }


            //TODO temporarily disabled, fills the quick scores. currently hardwired to 0-5
            PrepareDropdown();
        }

        //TODO temporarily disabled, fills the quick scores. currently hardwired to 0-5
        //function that loads the default standards score values for each 
        public void PrepareDropdown()
        {
            //Save the score values for each standard on a hidden field
            // they will be used client side when gridScorecard starts batch edit, to load dropdowns
            for (int i = 0; i < gridScorecard.VisibleRowCount; i++)
                {
                    //Get the Id of each standard to get potential score values for each row
                    String StandardId = gridScorecard.GetRowValues(i, "stan_id").ToString();
                    DataTable dt = rc_services.GetStandardValues(StandardId);

                    //add a column which will have a pattern of value_score + " - " + value_scoretext
                    //for using as textfield of quick score dropdowns
                    dt.Columns.Add("score_display_text");

                    //See how many values there are per standard, this will be used to limit the client side loop that loads 
                    paramScore.Set(StandardId + "|" + "Max", dt.Rows.Count);

                    // Save the Score Value and Score Text for each for each potential calue in each standard on the grid
                    // These will be used cleint side to load the dropdowns
                    for (int z = 0; z < dt.Rows.Count; z++)
                    {
                        paramScore.Set(StandardId + "|" + z, dt.Rows[z]["value_score"].ToString() + "|" + dt.Rows[z]["value_scoretext"].ToString());

                        //Now populate the score_display_text column (for GridScorecard dropdowns, this is already assembled on client side)
                        dt.Rows[z]["score_display_text"] = dt.Rows[z]["value_score"].ToString() + " - " + dt.Rows[z]["value_scoretext"].ToString();
                    }

                    //Now bind the quick score dropdowns
                    //if (ComboHeader1.Visible && i == 0) { ComboHeader1.DataSource = dt; ComboHeader1.DataBind(); }
                    //if (ComboHeader2.Visible && i == 1) { ComboHeader2.DataSource = dt; ComboHeader2.DataBind(); }
                    //if (ComboHeader3.Visible && i == 2) { ComboHeader3.DataSource = dt; ComboHeader3.DataBind(); }
                    //if (ComboHeader4.Visible && i == 3) { ComboHeader4.DataSource = dt; ComboHeader4.DataBind(); }
                    //if (ComboHeader5.Visible && i == 4) { ComboHeader5.DataSource = dt; ComboHeader5.DataBind(); }
                }
        }

        protected void dropScorecard_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedScorecard = dropScorecard.Value.ToString();
            PrepareScorecard(SelectedScorecard, ItemKey, false);
            //Save Session values for refresh
            Session["card_id"] = SelectedScorecard;
            Session["score_itemid"] = ItemKey;
        }

        protected void gridScorecard_BatchUpdate(object sender, DevExpress.Web.Data.ASPxDataBatchUpdateEventArgs e)
        {
            rootParameters.Remove("ScorecardNeedsSave");           
        }

        protected void pageScore_ActiveTabChanged(object source, TabControlEventArgs e)
        {

        }

        protected void btCancel_Click(object sender, EventArgs e)
        {

        }

        protected void btSave_Click(object sender, EventArgs e)
        {
            var scoreDescription = txScoreDescription.Html;
            string card_id = Session["card_id"].ToString();
            string score_projectid = Session["projectID"].ToString();
            string score_itemid = Session["score_itemid"].ToString();
            rc_services.SaveScoreDescription(card_id, score_itemid, score_projectid, scoreDescription);         
        }

        //protected void btCancel_Click(object sender, EventArgs e)
        //{
        ////    BindForm();
        //}

        //public void BindForm()
        //{

        //    txScoreDescription.Html = "rc_services.SaveScoreDescription( card_id, score_itemid, score_projectid, scoreDescription);"; //service call
        //}

        protected void Grid_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e)
        {
            if (e.Column.FieldName == "score_col1" ||
                e.Column.FieldName == "score_col2" 
                //e.Column.FieldName == "score_col3" 
                //e.Column.FieldName == "score_col4" ||
                //e.Column.FieldName == "score_col5"
                )
            {
                ASPxComboBox combo = e.Editor as ASPxComboBox;
                combo.Callback += combo_Callback;
            }
        }

        void combo_Callback(object sender, CallbackEventArgsBase e)
        {
            ASPxComboBox combo = sender as ASPxComboBox;

            combo.DataSource = rc_services.GetStandardValues(e.Parameter);
            combo.DataBind();
        }

        protected void paramScore_CustomCallback(object sender, CallbackEventArgsBase e)
        {
            //TODO temporarily disabled, fills the quick scores. currently hardwired to 0-5
            PrepareDropdown();
        }
    }
}