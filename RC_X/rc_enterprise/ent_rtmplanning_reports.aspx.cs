using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Export;
using DevExpress.Utils;
using DevExpress.Web.ASPxPivotGrid;
using DevExpress.XtraPrinting;

namespace RC_X.rc_enterprise
{
    public partial class ent_rtmplanning_reports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       

     public  void Export(bool saveAs)
     {
            foreach (PivotGridField field in pivotGrid.Fields)
            {

            }
            const string fileName = "RtmPlaningProjects";
            XlsxExportOptionsEx options;
            switch (listExportFormat.SelectedIndex)
            {
                 
                case 0:
                    options = new XlsxExportOptionsEx() { ExportType = ExportType.WYSIWYG };
                    ASPxPivotGridExporter1.ExportXlsxToResponse(fileName, options, saveAs);
                    break;

            }



        }

        protected void ASPxButton3_Click1(object sender, EventArgs e)
        {
            Export(true);
        }

       
    }
}