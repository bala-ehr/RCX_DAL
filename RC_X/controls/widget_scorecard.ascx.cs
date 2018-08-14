using DevExpress.Web;
using DevExpress.Web.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace RC_X.controls
{


    public partial class widget_scorecard : System.Web.UI.UserControl
    {
        public Scorecard CurrentCard;
        public String ScorecardItemKey
        {
            get { if (paramScorecard.Contains("ScorecardItemKey")) { return paramScorecard["ScorecardItemKey"] as string; } else { return null; } }
            set { paramScorecard.Set("ScorecardItemKey", value); }
        }
        public String ScorecardKey
        {
            get { if (paramScorecard.Contains("ScorecardKey")) { return paramScorecard["ScorecardKey"] as string; } else { return null; } }
            set { paramScorecard.Set("ScorecardKey", value); }
        }
        public Boolean ItemChanged
        {
            get { if (paramScorecard.Contains("ItemChanged")) { return (Boolean)paramScorecard["ItemChanged"]; } else { return false; } }
            set { paramScorecard.Set("ItemChanged", value); }
        }
        public Boolean ScorecardChanged
        {
            get { if (paramScorecard.Contains("ScorecardChanged")) { return (Boolean)paramScorecard["ScorecardChanged"]; } else { return false; } }
            set { paramScorecard.Set("ScorecardChanged", value); }
        }
        public Boolean Rebind
        {
            get { if (paramScorecard.Contains("Rebind")) { return (Boolean)paramScorecard["Rebind"]; } else { return false; } }
            set { paramScorecard.Set("Rebind", value); }
        }
        //public Scorecard CurrentCard
        //{
        //    get { if (paramScorecard.Contains("CurrentCard")) { return paramScorecard["CurrentCard"] as Scorecard; } else { return null; } }
        //    set { paramScorecard.Set("CurrentCard", value); }
        //}

        protected void Page_Init(object sender, EventArgs e)
        {
            BindDropDown();
            BindCard();
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
      
        }

        public void BindDropDown()
        {
             CurrentCard= null;
                   

            //add visibility check
            if (!Page.IsCallback && !IsPostBack)
            {
                gridScorecardWidget.Visible = false;                
            }

            if (ItemChanged == true)
            {
                //rebind cards dropdown
               
                List<Scorecard> ItemScoreCards = rc_services.GetScorecards(ScorecardItemKey);
                comboCards.DataSource = ItemScoreCards;
                comboCards.DataBind();

                //Get all of the scorecardinfo through by finfing the scorecard object in the list
                foreach (Scorecard x in ItemScoreCards)
                {
                    if (x.CardId == ScorecardKey)
                    {
                        CurrentCard = x;
                    }
                }


                //check to see if previous scorecard is also available for the new item, if so, select that one in dropdown and set ScorecardKey
                //if (CurrentCard != null)
                //{
                //    for (int i = 0; i == comboCards.Items.Count - 1; i++)
                //    {
                //        if (comboCards.Items[i].Value.ToString() == CurrentCard.CardId) { comboCards.Value = CurrentCard.CardId; }
                //    }
                //}

                if (CurrentCard==null && comboCards.Items.Count > 0 && comboCards.Items[0].Text != String.Empty)
                {
                    comboCards.SelectedIndex = 0;
                    ScorecardKey = comboCards.Value.ToString();
                    foreach (Scorecard x in ItemScoreCards)
                    {
                        if (x.CardId == ScorecardKey)
                        {
                            CurrentCard = x;
                        }
                    }
                }              
               if (CurrentCard != null)
                {
                    comboCards.Text = CurrentCard.CardName;
                    paramScorecard.Set("CardName", CurrentCard.CardName);
                }
                //ItemChanged = false;
                ScorecardChanged = true;
            }      

           


        }

        public void BindCard()
        {
            if (ScorecardChanged == true && CurrentCard != null)//
            {
                //Bind Grid
                gridScorecardWidget.Visible = true;
                gridScorecardWidget.DataSource = rc_services.GetScores((String)Session["ProjectID"], ScorecardItemKey, ScorecardKey);
                gridScorecardWidget.DataBind();
                //Get ScoreCard Info

                //Prep the COlumns
                //Get the Score COlumns
                GridViewColumn Score1 = gridScorecardWidget.Columns["ScoreCol1"];
                GridViewColumn Score2 = gridScorecardWidget.Columns["ScoreCol2"];
                GridViewColumn Score3 = gridScorecardWidget.Columns["ScoreCol3"];
                GridViewColumn Score4 = gridScorecardWidget.Columns["ScoreCol4"];
                GridViewColumn Score5 = gridScorecardWidget.Columns["ScoreCol5"];

                //now check which score columns are enabled, and set their visibility                
                Score1.Visible = CurrentCard.EnabledCol1; //ComboHeader1.Visible = Col1Visible;
                Score2.Visible = CurrentCard.EnabledCol2; //ComboHeader2.Visible = Col2Visible;
                Score3.Visible = CurrentCard.EnabledCol3; //ComboHeader3.Visible = Col3Visible;
                Score4.Visible = CurrentCard.EnabledCol4; //ComboHeader4.Visible = Col4Visible;
                Score5.Visible = CurrentCard.EnabledCol5; //ComboHeader5.Visible = Col5Visible;

                     
                //Set Their captions
                Score1.Caption = CurrentCard.CardCol1;
                Score2.Caption = CurrentCard.CardCol2;
                Score3.Caption = CurrentCard.CardCol3;
                Score4.Caption = CurrentCard.CardCol4;
                Score5.Caption = CurrentCard.CardCol5;

                //Check if measure are enabled, if so, set their visibility and captions (if that score column is visible)

                //Get Measure Columns
                GridViewColumn Measure1 = gridScorecardWidget.Columns["Measure1"];
                GridViewColumn Measure2 = gridScorecardWidget.Columns["Measure2"];
                GridViewColumn Measure3 = gridScorecardWidget.Columns["Measure3"];
                GridViewColumn Measure4 = gridScorecardWidget.Columns["Measure4"];
                GridViewColumn Measure5 = gridScorecardWidget.Columns["Measure5"];

                if (CurrentCard.MeasuredEnabled == true)
                {
                    Measure1.Visible = CurrentCard.EnabledCol1;
                    Measure2.Visible = CurrentCard.EnabledCol2;
                    Measure3.Visible = CurrentCard.EnabledCol3;
                    Measure4.Visible = CurrentCard.EnabledCol4;
                    Measure5.Visible = CurrentCard.EnabledCol5;
                }
                else
                {
                    Measure1.Visible = false;
                    Measure2.Visible = false;
                    Measure3.Visible = false;
                    Measure4.Visible = false;
                    Measure5.Visible = false;
                }

                //ScorecardChanged = false;
               // Save the score values for each standard on a hidden field
                // they will be used client side when gridScorecard starts batch edit, to load dropdowns
                for (int i = 0; i < gridScorecardWidget.VisibleRowCount; i++)
                    {
                        //Get the Id of each standard to get potential score values for each row
                        String StandardId = gridScorecardWidget.GetRowValues(i, "StandardId").ToString();
                    //Taking ScoreID to be index in the table loaded in the client side - easier for JS because it is key row
                    String ScoreId = gridScorecardWidget.GetRowValues(i, "ScoreId").ToString();
                    DataTable dt = rc_services.GetStandardValues(StandardId);

                        //add a column which will have a pattern of value_score + " - " + value_scoretext
                        //for using as textfield of quick score dropdowns
                        dt.Columns.Add("score_display_text");

                        //See how many values there are per standard, this will be used to limit the client side loop that loads 
                        paramScorecard.Set(ScoreId + "_" + "Max", dt.Rows.Count);

                        // Save the Score Value and Score Text for each for each potential calue in each standard on the grid
                        // These will be used cleint side to load the dropdowns
                        for (int z = 0; z < dt.Rows.Count; z++)
                        {
                            paramScorecard.Set(ScoreId + "_" + z, dt.Rows[z]["value_score"].ToString() + "_" + dt.Rows[z]["value_scoretext"].ToString());

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
                ScorecardChanged = false;
            }
        }

        protected void gridScorecard_DataBound(object sender, EventArgs e)
        {
           
        }

        protected void Grid_CellEditorInitialize(object sender, DevExpress.Web.ASPxGridViewEditorEventArgs e)
        {
            //if (e.Column.FieldName == "ScoreCol1")
            //{
            //    GridViewColumn Score1 = gridScorecardWidget.Columns["ScoreCol1"];


            //    ASPxComboBox ComboHeader1 = new ASPxComboBox();
            //    ComboHeader1.ValueType = typeof(System.Int32);
            //    ComboHeader1.ID = "ComboHeader1";
            //    ComboHeader1.ClientEnabled = true;
            //    ComboHeader1.EnableClientSideAPI = true;
            //    ComboHeader1.ClientInstanceName = "ComboHeader1";
            //    ComboHeader1.ClientSideEvents.SelectedIndexChanged = "ScoreCol1";
            //    ComboHeader1.DropDownStyle = DropDownStyle.DropDown;
            //    //for (int z=0; z==5)
            //    //List<Int32> ds = new List<int>();

            //    //for (int i = 0; i <= 5; i++)
            //    //{
            //    //    ListEditItem ScoreItem = new ListEditItem(i.ToString(), i);
            //    //    ComboHeader1.Items.Insert(i, ScoreItem);
            //    //}
            //    List<Int32> ds = new List<int>();
            //    for (int i = 0; i < 5; i++)
            //    {
            //        ds.Add(i);
            //    }
            //    //ComboHeader1.DataBind();
            //    //ComboHeader1.Value = 1;

            //    GridViewFilterCellTemplateContainer ContainerScore1 = new GridViewFilterCellTemplateContainer(Score1);
            //    ContainerScore1.Controls.Add(ComboHeader1);
            //}
         
        }

        protected void gridScorecard_BatchUpdate(object sender, DevExpress.Web.Data.ASPxDataBatchUpdateEventArgs e)
        {
            ScoreStandardsList NewScores = new ScoreStandardsList();
            
            foreach (ASPxDataUpdateValues x in e.UpdateValues)
            {

                NewScores.Add(new ScoreStandards
                {
                    ScoreId = (String)x.Keys["ScoreId"],
                    //ProjectID = (String)Session["ProjectID"],
                    //StandardID = (String)x.NewValues["StandardID"],
                    //CardID = (String)x.NewValues["CardID"],
                    //ItemID = (String)x.NewValues["ItemID"],
                    ScoreCol1 = x.NewValues["ScoreCol1"] != null ? (int)x.NewValues["ScoreCol1"] : 0,
                    ScoreCol2 = x.NewValues["ScoreCol2"] != null ? (int)x.NewValues["ScoreCol2"] : 0,
                    ScoreCol3 = x.NewValues["ScoreCol3"] != null ? (int)x.NewValues["ScoreCol3"] : 0,
                    ScoreCol4 = x.NewValues["ScoreCol4"] != null ? (int)x.NewValues["ScoreCol4"] : 0,
                    ScoreCol5 = x.NewValues["ScoreCol5"] != null ? (int)x.NewValues["ScoreCol5"] : 0,
                    Measure1 = (String)x.NewValues["Measure1"] ,
                    Measure2 = (String)x.NewValues["Measure2"],
                    Measure3 = (String)x.NewValues["Measure3"],
                    Measure4 = (String)x.NewValues["Measure4"],
                    Measure5 = (String)x.NewValues["Measure5"]
                });
            }

            rc_services.SaveScores(NewScores);
            e.Handled = true;
            ScorecardChanged = true;
            ItemChanged = true;
            BindDropDown();
            BindCard();
        }

        protected void gridScorecard_RowUpdated(object sender, DevExpress.Web.Data.ASPxDataUpdatedEventArgs e)
        {

        }

        protected void callScorecard_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            //BindCard();
           
        }

        protected void comboCards_DataBound(object sender, EventArgs e)
        {
            //if (comboCards.Items.Count == 0) { comboCards.Items.Add(String.Empty, String.Empty); comboCards.SelectedIndex = 0; }
        }
    }
}