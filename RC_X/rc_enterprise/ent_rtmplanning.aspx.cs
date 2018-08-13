using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;


namespace RC_X.rc_enterprise
{
    public partial class ent_rtmplanning : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            if (!rc_services.CheckPermission("ent_rtmplanning")) { Response.Redirect("~/controls/unauthorized.aspx"); }
        }

        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack || gridRTMPlaning.IsCallback)
            {
                BindGridView();
            }
        }

        private void BindGridView()
        {
            try
            {
                dt = rtm_services.GetRtmPlanningProjects();
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataTable pivotedTable = PivotTable(dt);

                    gridRTMPlaning.DataSource = null;
                    gridRTMPlaning.DataBind();

                    gridRTMPlaning.DataSource = pivotedTable;
                    gridRTMPlaning.DataBind();

                    gridRTMPlaning.Columns["ch_id"].Visible = false;
                    gridRTMPlaning.Columns["src_id"].Visible = false;
                    gridRTMPlaning.Columns["Projectname"].Visible = false;
                    



                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Fetch Error:";
                msg += ex.Message;
                throw new Exception(msg);
            }
        }

        private DataTable PivotTable(DataTable origTable)
        {

            DataTable newTable = new DataTable();
            DataRow dr = null;

            ///Get Distinct projects 
            ///Add one column for each project
            ///update row value for each row of project 
            newTable.Columns.Add(new DataColumn("Projectname", typeof(string)));
            var lstPorjects = dt.Rows.OfType<DataRow>()
                                .Select(r => r.Field<string>("Projectname")).Distinct().ToList();

            newTable.Columns.Add(new DataColumn("ch_id", typeof(string)));
            newTable.Columns.Add(new DataColumn("ChecklistType", typeof(string)));
            newTable.Columns.Add(new DataColumn("src_id", typeof(string)));
            newTable.Columns.Add(new DataColumn("SRCTitle", typeof(string)));
            newTable.Columns.Add(new DataColumn("Criteria", typeof(string)));

            foreach (var prj in lstPorjects)
            {
                newTable.Columns.Add(new DataColumn(prj, typeof(bool)));
            }

            //newTable.Columns.Add(new DataColumn("Score", typeof(string)));

            foreach (var prj in lstPorjects)
            {
                var PrjRows = dt.AsEnumerable().Where(r => r.Field<string>("Projectname") == prj).ToList();

                foreach (var srcRow in PrjRows)
                {
                    var existingRow = newTable.AsEnumerable()
                                            .Where(r => r.Field<string>("ch_id").ToString() == srcRow["ch_id"].ToString() &&
                                                        r.Field<string>("src_id").ToString() == srcRow["src_id"].ToString())
                                            .FirstOrDefault();
                    if (existingRow == null)
                    {

                        dr = newTable.NewRow();
                        dr["ch_id"] = srcRow["ch_id"];
                        dr["ChecklistType"] = srcRow["ChecklistType"];
                        dr["src_id"] = srcRow["src_id"];
                        dr["SRCTitle"] = srcRow["SRCTitle"];
                        dr["Criteria"] = srcRow["Criteria"];
                        dr[prj] = srcRow["score"];
                        //dr["Score"] = 0; //need to calculate after populating table
                        newTable.Rows.Add(dr);
                    }
                    else
                    {
                        existingRow[prj] = srcRow["score"];
                    }
                }
            }

            return newTable;
        }

        protected void gridRTMPlaning_DataBound(object sender, EventArgs e)
        {
            gridRTMPlaning.Columns["ch_id"].Visible = false;
            gridRTMPlaning.Columns["src_id"].Visible = false;
            //gridRTMPlaning.Columns["ch_title"].Caption = "Checklist Type";
           
        }

        protected void btCreate_Click(object sender, EventArgs e)
        {
            var ProjectName = tbProjectname.Text;
            rtm_services.SavePrePlanProjects(ProjectName);
            BindGridView();
        }

        protected void gridRTMPlaning_BatchUpdate(object sender, DevExpress.Web.Data.ASPxDataBatchUpdateEventArgs e)
        {
            var listUpdates = new List<RtmPlanningProjectDetails>();
            foreach (var args in e.UpdateValues)
            {               
                foreach (System.Collections.DictionaryEntry val in args.NewValues)
                {
                    if (val.Key.ToString() != "Criteria" &&
                        val.Key.ToString() != "Score" &&
                        val.Key.ToString() != "SRCTitle" &&
                        val.Key.ToString() != "ChecklistType" && 
                        val.Value != null)
                    {
                        RtmPlanningProjectDetails checklist = new RtmPlanningProjectDetails();
                        checklist.CriteriaId = Convert.ToString(args.Keys["src_id"]);
                        checklist.ProjectName = val.Key.ToString();
                        checklist.IsActive = bool.Parse(val.Value.ToString());
                        listUpdates.Add(checklist);
                    }
                }
                
            }
            if (listUpdates.Count > 0)
            {
                rtm_services.UpdateRTMPlanningDetails(listUpdates);
            }
            e.Handled = true;
        }
    }
}
