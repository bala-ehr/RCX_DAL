using DevExpress.Spreadsheet;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace RC_X.rc_enterprise
{
    public partial class ent_reports : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            if (!rc_services.CheckPermission("ent_reports")) { Response.Redirect("~/controls/unauthorized.aspx"); }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void comboReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedReport = comboReports.Value.ToString();

            if (SelectedReport == "rep_pro_ivv_progress")
            {
                OptionsFormLayout.Visible = false;
                comboProject1.Visible = false;
                comboProject1.Value = null;
                comboProject2.Visible = false;
                comboProject2.Value = null;
                comboIVV.DataSource = common_services.GetGeneralInfo();
                comboIVV.DataBind();
                comboIVV.Visible = true;

                

            }
            else if (SelectedReport == "rep_ent_compare_scores")
            {
                OptionsFormLayout.Visible = true;
                comboProject1.DataSource = common_services.GetProjects();
                comboProject1.DataBind();
                comboProject1.Visible = true;


            }
            else
            {
              
                OptionsFormLayout.Visible = false;
                comboProject1.Visible = false;
                comboIVV.Visible = false;
                comboIVV.Value = null;
                comboProject1.Value = null;
                comboProject2.Value = null;
                XtraReport ReportObject = common_services.GetSourcedReport(SelectedReport, null, null,null, Page.Request);
                reportViewer.OpenReport(ReportObject);
            }
           
            
        }

        protected void comboIVV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedReport = comboReports.Value.ToString();
            if (SelectedReport == "rep_pro_ivv_progress")
            {

                string SelectedID = comboIVV.Value.ToString();
                string SelecteChecklist = comboIVV.Text.ToString();
                string StateProject = SelectedID;



                MemoryStream reportStream1 = new MemoryStream();
                MemoryStream reportStream2 = new MemoryStream();

                XtraReport ReportObject1 = common_services.GetSourcedReport("rep_pro_ivv_progress", StateProject);
                ReportObject1.ExportToXlsx(reportStream1, new DevExpress.XtraPrinting.XlsxExportOptions() { SheetName = "IV&V" });

                XtraReport ReportObject2 = common_services.GetSourcedReport("rep_pro_ivv_checklist_rtm");
                ReportObject2.ExportToXlsx(reportStream2, new DevExpress.XtraPrinting.XlsxExportOptions() { SheetName = "Programmatic" });

                Workbook workbook = new DevExpress.Spreadsheet.Workbook();
                workbook.LoadDocument(reportStream1);

                Workbook workbook2 = new DevExpress.Spreadsheet.Workbook();
                workbook2.LoadDocument(reportStream2);

                var path = Server.MapPath(@"~/Content/SpreadSheetTemplate/IVV CMS Response.xlsx");
                Workbook workbook3 = new DevExpress.Spreadsheet.Workbook();
                workbook3.LoadDocument(path);



                workbook.Worksheets.Insert(1, "Programmatic");
                workbook.Worksheets.Insert(2, "CMS Response");

                workbook.Worksheets[1].CopyFrom(workbook2.Worksheets[0]);
                workbook.Worksheets[2].CopyFrom(workbook3.Worksheets[0]);


                MemoryStream st = new MemoryStream();
                workbook.SaveDocument(st, DocumentFormat.Xlsx);
                var state = System.Web.HttpContext.Current.Session["EnterpriseName"].ToString();
                string filename = " 05 MECT 2_2 Appendix D_MMIS IVV Progress Report Template.xlsx";
                Response.Clear();
                Response.ContentType = "application/force-download";
                Response.AddHeader("content-disposition", "attachment; filename=" + filename);
                Response.BinaryWrite(st.ToArray());


                Response.End();

                reportViewer.OpenReport(ReportObject1);
            }
           
            else
            {
                comboIVV.Visible = false;
                comboIVV.Value = null;
            }
        }
        
        protected void comboProject1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedReport = comboReports.Value.ToString();
            if (SelectedReport == "rep_ent_compare_scores")
            {
                string SelectedProjectID = comboProject1.Value.ToString();
                string SelectedProject = comboProject1.Text.ToString();
                comboProject2.DataSource = common_services.GetProjects(SelectedProjectID);
                comboProject2.DataBind();
                comboProject2.Visible = true;
            }
            else
            {
                comboProject1.Visible = false;
                comboProject1.Value = null;
                comboProject2.Visible = false;
                comboProject2.Value = null;
            }


        }

        protected void comboProject2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedReport = comboReports.Value.ToString();
            if (SelectedReport == "rep_ent_compare_scores")
            {
                string SelectedProjectID = comboProject1.Value.ToString();
            string SelectedProject = comboProject1.Text.ToString();
            string SelectedProjectID2 = comboProject2.Value.ToString();
            string SelectedProject2 = comboProject2.Text.ToString();
            string Parameter = null;
            XtraReport ReportObject = common_services.GetSourcedReport("rep_ent_compare_scores", Parameter, SelectedProjectID, SelectedProjectID2);

            reportViewer.OpenReport(ReportObject);
            }
            else
            {
                comboProject1.Visible = false;
                comboProject1.Value = null;
                comboProject2.Visible = false;
                comboProject2.Value = null;
            }
        }
    }
}