using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RC_X.rc_enterprise
{
    public partial class rc_essaReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void button2_Click(object sender, EventArgs e)
        {
            rep_pro_essa1 report = new rep_pro_essa1();
            rep_pro_essa2 report2 = new rep_pro_essa2();
            rep_pro_essa3 report3 = new rep_pro_essa3();
            rep_pro_essa4 report4 = new rep_pro_essa4();
            report.CreateDocument(false);
            report2.CreateDocument(false);

           //report.DataSource = common_services.GetSourcedReport("rep_pro_essa1");

            MemoryStream reportStream1 = new MemoryStream();
            MemoryStream reportStream2 = new MemoryStream();
            MemoryStream reportStream3 = new MemoryStream();
            MemoryStream reportStream4 = new MemoryStream();
            report.ExportToXlsx(reportStream1, new DevExpress.XtraPrinting.XlsxExportOptions() { SheetName = "BA-Scorecard" });
            report2.ExportToXlsx(reportStream2, new DevExpress.XtraPrinting.XlsxExportOptions() { SheetName = "IA-Scorecard" });
            report3.ExportToXlsx(reportStream3, new DevExpress.XtraPrinting.XlsxExportOptions() { SheetName = "TA-Scorecard" });
            report4.ExportToXlsx(reportStream4, new DevExpress.XtraPrinting.XlsxExportOptions() { SheetName = "S&C Scorecard" });

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
            //workbook.SaveDocument("C:/Users/Mohan Babu/Desktop/ReadycertXLS/Scorecard_Templates_Ohio2015SS-A.xlsx");
            MemoryStream st = new MemoryStream();
            workbook.SaveDocument(st, DocumentFormat.Xlsx);

            Response.Clear();
            Response.ContentType = "application/force-download";
            Response.AddHeader("content-disposition", "attachment; filename=Scorecard_Templates_Ohio2015SS-A.xlsx");
            Response.BinaryWrite(st.ToArray());
            Response.End();
            //System.Diagnostics.Process.Start("C:/Users/Mohan Babu/Desktop/ReadycertXLS/Scorecard_Templates_Ohio2015SS-A.xlsx");
        }
    }
}