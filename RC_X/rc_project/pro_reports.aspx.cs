using DevExpress.Spreadsheet;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RC_X.rc_project
{
    public partial class pro_reports : System.Web.UI.Page
    {
        string SelectedReport = null;
        protected void Page_Init(object sender, EventArgs e)
        {
            if (!rc_services.CheckPermission("pro_reports")) { Response.Redirect("~/controls/unauthorized.aspx"); }
          
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void comboReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            var SelectedReport = comboReports.Value.ToString();

            if (SelectedReport == "rep_pro_essa")
            {
                MemoryStream reportStream1 = new MemoryStream();
                MemoryStream reportStream2 = new MemoryStream();
                MemoryStream reportStream3 = new MemoryStream();
                MemoryStream reportStream4 = new MemoryStream();

                XtraReport ReportObject1 = common_services.GetSourcedReport("rep_pro_essa1");
                ReportObject1.ExportToXlsx(reportStream1, new DevExpress.XtraPrinting.XlsxExportOptions() { SheetName = "BA-Scorecard" });

                XtraReport ReportObject2 = common_services.GetSourcedReport("rep_pro_essa2");
                ReportObject2.ExportToXlsx(reportStream2, new DevExpress.XtraPrinting.XlsxExportOptions() { SheetName = "IA-Scorecard" });

                XtraReport ReportObject3 = common_services.GetSourcedReport("rep_pro_essa3");
                ReportObject3.ExportToXlsx(reportStream3, new DevExpress.XtraPrinting.XlsxExportOptions() { SheetName = "TA-Scorecard" });

                XtraReport ReportObject4 = common_services.GetSourcedReport("rep_pro_essa4");
                ReportObject4.ExportToXlsx(reportStream4, new DevExpress.XtraPrinting.XlsxExportOptions() { SheetName = "S&C Scorecard" });

                Workbook workbook = new DevExpress.Spreadsheet.Workbook();
                workbook.LoadDocument(reportStream1);

                Workbook workbook2 = new DevExpress.Spreadsheet.Workbook();
                workbook2.LoadDocument(reportStream2);

                Workbook workbook3 = new DevExpress.Spreadsheet.Workbook();
                workbook3.LoadDocument(reportStream3);

                Workbook workbook4 = new DevExpress.Spreadsheet.Workbook();
                workbook4.LoadDocument(reportStream4);

                workbook.Worksheets.Insert(1, "IA-Scorecard");
                workbook.Worksheets.Insert(2, "TA-Scorecard");
                workbook.Worksheets.Insert(3, "S&C Scorecard");
                workbook.Worksheets[1].CopyFrom(workbook2.Worksheets[0]);
                workbook.Worksheets[2].CopyFrom(workbook3.Worksheets[0]);
                workbook.Worksheets[3].CopyFrom(workbook4.Worksheets[0]);

                MemoryStream st = new MemoryStream();
                workbook.SaveDocument(st, DocumentFormat.Xlsx);

                Response.Clear();
                Response.ContentType = "application/force-download";
                Response.AddHeader("content-disposition", "attachment; filename=Scorecard_Templates_Ohio2015SS-A.xlsx");
                Response.BinaryWrite(st.ToArray());
                Response.End();

                reportViewer.OpenReport(ReportObject1);

            }
            else if (SelectedReport == "rep_pro_cms_checlist")
            {
                var projectId = System.Web.HttpContext.Current.Session["projectID"].ToString();
               
                comboChecklistName.DataSource = rtm_services.GetRTMCheckList(projectId);
                comboChecklistName.DataBind();
                comboChecklistName.Visible = true;
            }
            

            else
            {

                comboChecklistName.Visible = false;
                comboChecklistName.Value = null;
                XtraReport ReportObject = common_services.GetSourcedReport(SelectedReport,null,null, null, Page.Request);

                reportViewer.OpenReport(ReportObject);
                
            }
            
        }

     

        protected void comboChecklistName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = null;
            string guidancepath = null;
            string MITApath = null;
            string report = comboReports.SelectedItem.ToString();
            string reportname = comboReports.Value.ToString();
            if (reportname == "rep_pro_cms_checlist")
            {
                string SelectedChecklisID = comboChecklistName.Value.ToString();
                string SelecteChecklist = comboChecklistName.Text.ToString();
                string checklist = SelectedChecklisID;
                MemoryStream reportStream5 = new MemoryStream();
                MemoryStream reportStream6 = new MemoryStream();
                //MemoryStream reportStream7 = new MemoryStream();
                //MemoryStream reportStream8 = new MemoryStream();

                XtraReport ReportObject1 = common_services.GetSourcedReport("rep_pro_cms_checlist", checklist);
                ReportObject1.ExportToXlsx(reportStream5, new DevExpress.XtraPrinting.XlsxExportOptions() { SheetName = SelecteChecklist });

                XtraReport ReportObject2 = common_services.GetSourcedReport("rep_pro_cms_checklist_criticalsuccessfactors", checklist);
                ReportObject2.ExportToXlsx(reportStream6, new DevExpress.XtraPrinting.XlsxExportOptions() { SheetName = "Critical Success Factor" });

                Workbook workbook = new DevExpress.Spreadsheet.Workbook();
                Workbook workbook2 = new DevExpress.Spreadsheet.Workbook();
                Workbook workbook3 = new DevExpress.Spreadsheet.Workbook();
                Workbook workbook4 = new DevExpress.Spreadsheet.Workbook();
                Workbook workbook5 = new DevExpress.Spreadsheet.Workbook();
               
                switch (SelecteChecklist)
                {
                    case "Provider Management":
                        path = Server.MapPath(@"~/Content/SpreadSheetTemplate/Provider Management Checklist.xlsx");
                        
                        workbook.LoadDocument(path);
                        workbook2.LoadDocument(reportStream5);
                        workbook3.LoadDocument(reportStream6);
                        workbook.Worksheets.Insert(1, SelecteChecklist);
                        workbook.Worksheets.Insert(2, "Critical Success Factor");

                        workbook.Worksheets[1].CopyFrom(workbook2.Worksheets[0]);
                        workbook.Worksheets[2].CopyFrom(workbook3.Worksheets[0]);

                        break;
                    case "2.2 Standards and Conditions":
                        path = Server.MapPath(@"~/Content/SpreadSheetTemplate/Standards and Conditions.xlsx");
                        guidancepath = Server.MapPath("~/Content/SpreadSheetTemplate/Guidance Standards and Conditions.xlsx");
                        MITApath = Server.MapPath("~/Content/SpreadSheetTemplate/MITA Business Process Access and Delivery.xlsx");
                       
                        workbook.LoadDocument(path);
                        workbook2.LoadDocument(reportStream5);
                        workbook3.LoadDocument(guidancepath);
                        workbook4.LoadDocument(MITApath);
                        workbook.Worksheets.Insert(1, SelecteChecklist);
                        workbook.Worksheets.Insert(2, "MITA Business Processes");
                        workbook.Worksheets.Insert(3, "Guidance");

                        workbook.Worksheets[1].CopyFrom(workbook2.Worksheets[0]);
                        workbook.Worksheets[2].CopyFrom(workbook3.Worksheets[0]);
                        workbook.Worksheets[3].CopyFrom(workbook4.Worksheets[0]);

                        break;
                    case "Integration and Utility":
                        path = Server.MapPath(@"~/Content/SpreadSheetTemplate/Integration and Utility.xlsx");
                        guidancepath = Server.MapPath("~/Content/SpreadSheetTemplate/Guidance Integration and Utility.xlsx");
                        MITApath = Server.MapPath("~/Content/SpreadSheetTemplate/MITA Business Process Access and Delivery.xlsx");
                        workbook.LoadDocument(path);
                        workbook2.LoadDocument(reportStream5);
                        workbook3.LoadDocument(guidancepath);
                        workbook4.LoadDocument(MITApath);
                        workbook.Worksheets.Insert(1, SelecteChecklist);
                        workbook.Worksheets.Insert(2, "MITA Business Processes");
                        workbook.Worksheets.Insert(3, "Guidance");

                        workbook.Worksheets[1].CopyFrom(workbook2.Worksheets[0]);
                        workbook.Worksheets[2].CopyFrom(workbook3.Worksheets[0]);
                        workbook.Worksheets[3].CopyFrom(workbook4.Worksheets[0]);
                        break;
                    case "Plan Management":
                        path = Server.MapPath(@"~/Content/SpreadSheetTemplate/Plan Management.xlsx");
                       
                        workbook.LoadDocument(path);
                        workbook2.LoadDocument(reportStream5);
                        workbook3.LoadDocument(reportStream6);
                        workbook.Worksheets.Insert(1, SelecteChecklist);
                        workbook.Worksheets.Insert(2, "Critical Success Factor");

                        workbook.Worksheets[1].CopyFrom(workbook2.Worksheets[0]);
                        workbook.Worksheets[2].CopyFrom(workbook3.Worksheets[0]);

                        break;
                    case "Information Architecture":
                        path = Server.MapPath(@"~/Content/SpreadSheetTemplate/Information Architure Checklist.xlsx");
                        guidancepath = Server.MapPath("~/Content/SpreadSheetTemplate/Guidance Inforamtion Achitecture.xlsx");
                        MITApath = Server.MapPath("~/Content/SpreadSheetTemplate/MITA Business Process Access and Delivery.xlsx");
                        workbook.LoadDocument(path);
                        workbook2.LoadDocument(reportStream5);
                        workbook3.LoadDocument(guidancepath);
                        workbook4.LoadDocument(MITApath);
                        workbook.Worksheets.Insert(1, SelecteChecklist);
                        workbook.Worksheets.Insert(2, "MITA Business Processes");
                        workbook.Worksheets.Insert(3, "Guidance");

                        workbook.Worksheets[1].CopyFrom(workbook2.Worksheets[0]);
                        workbook.Worksheets[2].CopyFrom(workbook3.Worksheets[0]);
                        workbook.Worksheets[3].CopyFrom(workbook4.Worksheets[0]);

                        break;
                    case "Contractor Management":
                        path = Server.MapPath(@"~/Content/SpreadSheetTemplate/Contractor Management Checklist.xlsx");
                        workbook.LoadDocument(path);
                        workbook2.LoadDocument(reportStream5);
                        workbook3.LoadDocument(reportStream6);
                        workbook.Worksheets.Insert(1, SelecteChecklist);
                        workbook.Worksheets.Insert(2, "Critical Success Factor");

                        workbook.Worksheets[1].CopyFrom(workbook2.Worksheets[0]);
                        workbook.Worksheets[2].CopyFrom(workbook3.Worksheets[0]);

                        break;
                    case "Member Management":
                        path = Server.MapPath(@"~/Content/SpreadSheetTemplate/Member Management.xlsx");
                        workbook.LoadDocument(path);
                        workbook2.LoadDocument(reportStream5);
                        workbook3.LoadDocument(reportStream6);
                        workbook.Worksheets.Insert(1, SelecteChecklist);
                        workbook.Worksheets.Insert(2, "Critical Success Factor");

                        workbook.Worksheets[1].CopyFrom(workbook2.Worksheets[0]);
                        workbook.Worksheets[2].CopyFrom(workbook3.Worksheets[0]);

                        break;
                    case "Care Management":
                         path = Server.MapPath(@"~/Content/SpreadSheetTemplate/CMS_CareManagement.xlsx");
                        workbook.LoadDocument(path);
                        workbook2.LoadDocument(reportStream5);
                        workbook3.LoadDocument(reportStream6);
                        workbook.Worksheets.Insert(1, SelecteChecklist);
                        workbook.Worksheets.Insert(2, "Critical Success Factor");

                        workbook.Worksheets[1].CopyFrom(workbook2.Worksheets[0]);
                        workbook.Worksheets[2].CopyFrom(workbook3.Worksheets[0]);

                        break;
                    case "Operations Management":
                        path = Server.MapPath(@"~/Content/SpreadSheetTemplate/Operations Management.xlsx");
                        workbook.LoadDocument(path);
                        workbook2.LoadDocument(reportStream5);
                        workbook3.LoadDocument(reportStream6);
                        workbook.Worksheets.Insert(1, SelecteChecklist);
                        workbook.Worksheets.Insert(2, "Critical Success Factor");

                        workbook.Worksheets[1].CopyFrom(workbook2.Worksheets[0]);
                        workbook.Worksheets[2].CopyFrom(workbook3.Worksheets[0]);

                        break;
                    case "Financial Management":
                        path = Server.MapPath(@"~/Content/SpreadSheetTemplate/Financial Management Checklist.xlsx");
                        workbook.LoadDocument(path);
                        workbook2.LoadDocument(reportStream5);
                        workbook3.LoadDocument(reportStream6);
                        workbook.Worksheets.Insert(1, SelecteChecklist);
                        workbook.Worksheets.Insert(2, "Critical Success Factor");

                        workbook.Worksheets[1].CopyFrom(workbook2.Worksheets[0]);
                        workbook.Worksheets[2].CopyFrom(workbook3.Worksheets[0]);

                        break;
                    case "Access and Delivery":
                        path = Server.MapPath(@"~/Content/SpreadSheetTemplate/Access and Delivery Checklist.xlsx");
                        guidancepath = Server.MapPath("~/Content/SpreadSheetTemplate/Guidance Access and Delivery.xlsx");
                        MITApath = Server.MapPath("~/Content/SpreadSheetTemplate/MITA Business Process Access and Delivery.xlsx");
                        workbook.LoadDocument(path);
                        workbook2.LoadDocument(reportStream5);
                        workbook3.LoadDocument(guidancepath);
                        workbook4.LoadDocument(MITApath);
                        workbook.Worksheets.Insert(1, SelecteChecklist);
                        workbook.Worksheets.Insert(2, "MITA Business Processes");
                        workbook.Worksheets.Insert(3, "Guidance");

                        workbook.Worksheets[1].CopyFrom(workbook2.Worksheets[0]);
                        workbook.Worksheets[2].CopyFrom(workbook3.Worksheets[0]);
                        workbook.Worksheets[3].CopyFrom(workbook4.Worksheets[0]);
                        break;
                    case "Intermediary and Interface":
                        path = Server.MapPath(@"~/Content/SpreadSheetTemplate/Intermediary and Interface.xlsx");
                        guidancepath = Server.MapPath("~/Content/SpreadSheetTemplate/Guidance Intermediary and Interface.xlsx");
                        MITApath = Server.MapPath("~/Content/SpreadSheetTemplate/MITA Business Process Access and Delivery.xlsx");
                        workbook.LoadDocument(path);
                        workbook2.LoadDocument(reportStream5);
                        workbook3.LoadDocument(guidancepath);
                        workbook4.LoadDocument(MITApath);
                        workbook.Worksheets.Insert(1, SelecteChecklist);
                        workbook.Worksheets.Insert(2, "MITA Business Processes");
                        workbook.Worksheets.Insert(3, "Guidance");

                        workbook.Worksheets[1].CopyFrom(workbook2.Worksheets[0]);
                        workbook.Worksheets[2].CopyFrom(workbook3.Worksheets[0]);
                        workbook.Worksheets[3].CopyFrom(workbook4.Worksheets[0]);
                        break;
                    case "Performance Management":
                        path = Server.MapPath(@"~/Content/SpreadSheetTemplate/Performance Management.xlsx");
                        workbook.LoadDocument(path);
                        workbook2.LoadDocument(reportStream5);
                        workbook3.LoadDocument(reportStream6);
                        workbook.Worksheets.Insert(1, SelecteChecklist);
                        workbook.Worksheets.Insert(2, "Critical Success Factor");

                        workbook.Worksheets[1].CopyFrom(workbook2.Worksheets[0]);
                        workbook.Worksheets[2].CopyFrom(workbook3.Worksheets[0]);

                        break;
                    case "Standards and Conditions":
                        path = Server.MapPath(@"~/Content/SpreadSheetTemplate/Standards and Conditions.xlsx");
                        guidancepath = Server.MapPath("~/Content/SpreadSheetTemplate/Guidance Standards and Conditions.xlsx");
                        MITApath = Server.MapPath("~/Content/SpreadSheetTemplate/MITA Business Process Access and Delivery.xlsx");
                        workbook.LoadDocument(path);
                        workbook2.LoadDocument(reportStream5);
                        workbook3.LoadDocument(guidancepath);
                        workbook4.LoadDocument(MITApath);
                        workbook.Worksheets.Insert(1, SelecteChecklist);
                        workbook.Worksheets.Insert(2, "MITA Business Processes");
                        workbook.Worksheets.Insert(3, "Guidance");

                        workbook.Worksheets[1].CopyFrom(workbook2.Worksheets[0]);
                        workbook.Worksheets[2].CopyFrom(workbook3.Worksheets[0]);
                        workbook.Worksheets[3].CopyFrom(workbook4.Worksheets[0]);

                        break;
                    case "Eligibility and Enrollment":
                        path = Server.MapPath(@"~/Content/SpreadSheetTemplate/Eligibility and Enrollment Management.xlsx");
                        workbook.LoadDocument(path);
                        workbook2.LoadDocument(reportStream5);
                        workbook3.LoadDocument(reportStream6);
                        workbook.Worksheets.Insert(1, SelecteChecklist);
                        workbook.Worksheets.Insert(2, "Critical Success Factor");

                        workbook.Worksheets[1].CopyFrom(workbook2.Worksheets[0]);
                        workbook.Worksheets[2].CopyFrom(workbook3.Worksheets[0]);
                        break;
                    case "Business Relationship Management":
                        path = Server.MapPath(@"~/Content/SpreadSheetTemplate/Eligibility and Enrollment Management.xlsx");
                        workbook.LoadDocument(path);
                        workbook2.LoadDocument(reportStream5);
                        workbook3.LoadDocument(reportStream6);
                        workbook.Worksheets.Insert(1, SelecteChecklist);
                        workbook.Worksheets.Insert(2, "Critical Success Factor");

                        workbook.Worksheets[1].CopyFrom(workbook2.Worksheets[0]);
                        workbook.Worksheets[2].CopyFrom(workbook3.Worksheets[0]);


                        break;


                }

                

                MemoryStream st = new MemoryStream();
                workbook.SaveDocument(st, DocumentFormat.Xlsx);
                var state = System.Web.HttpContext.Current.Session["EnterpriseName"].ToString();
                string filename = SelecteChecklist + " Checklist (MITA Module)" + state +".xlsx";
                Response.Clear();
                Response.ContentType = "application/force-download";
                Response.AddHeader("content-disposition", "attachment; filename=" + filename);
                Response.BinaryWrite(st.ToArray());

                
                Response.End();
                reportViewer.OpenReport(ReportObject1);
            }
            else
            {

                comboChecklistName.Visible = false;
                comboChecklistName.Value = null;
            }
                
                           
            
        }
    }
}