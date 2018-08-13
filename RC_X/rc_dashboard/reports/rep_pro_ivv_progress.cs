using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for rep_pro_ivv_progress
/// </summary>
public class rep_pro_ivv_progress : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private XRLabel xrLabel31;
    private XRLabel xrLabel30;
    private XRLabel xrLabel29;
    private XRLabel xrLabel28;
    private XRLabel xrLabel27;
    private XRLabel xrLabel26;
    private XRLabel xrLabel23;
    private XRLabel xrLabel22;
    private XRLabel xrLabel21;
    private XRLabel xrLabel20;
    private XRLabel xrLabel19;
    private XRLabel xrLabel18;
    private XRLabel xrLabel17;
    private XRLabel xrLabel16;
    private XRLabel xrLabel15;
    private XRLabel xrLabel14;
    private XRLabel xrLabel13;
    private XRLabel xrLabel12;
    private XRLabel xrLabel11;
    private XRLabel xrLabel10;
    private XRLabel xrLabel9;
    private XRLabel xrLabel8;
    private XRLabel xrLabel7;
    private XRLabel xrLabel6;
    private XRLabel xrLabel5;
    private XRLabel xrLabel4;
    private XRLabel xrLabel3;
    private XRLabel xrLabel2;
    private XRRichText xrRichText1;
    private XRLabel xrLabel1;
    private XRRichText xrRichText3;
    private XRRichText xrRichText2;
    private XRLabel xrLabel24;
    private XRRichText xrRichText4;
    private XRLabel xrLabel42;
    private XRLabel xrLabel41;
    private XRLabel xrLabel40;
    private XRLabel xrLabel39;
    private XRLabel xrLabel38;
    private XRLabel xrLabel37;
    private XRLabel xrLabel36;
    private XRLabel xrLabel35;
    private XRLabel xrLabel34;
    private XRLabel xrLabel33;
    private XRLabel xrLabel25;
    private XRRichText xrRichText5;
    private XRLabel xrLabel32;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell15;
    private XRLabel xrLabel43;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private XRLabel xrLabel51;
    private XRLabel xrLabel50;
    private XRLabel xrLabel49;
    private XRLabel xrLabel48;
    private XRLabel xrLabel47;
    private XRLabel xrLabel46;
    private XRLabel xrLabel45;
    private XRLabel xrLabel44;
    private XRRichText xrRichText6;
    private XRLabel xrLabel52;
    private XRLabel xrLabel67;
    private XRLabel xrLabel66;
    private XRLabel xrLabel65;
    private XRLabel xrLabel60;
    private XRLabel xrLabel61;
    private XRLabel xrLabel62;
    private XRLabel xrLabel63;
    private XRLabel xrLabel64;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell24;
    private XRRichText xrRichText7;
    private XRLabel xrLabel53;
    private XRLabel xrLabel59;
    private XRLabel xrLabel58;
    private XRLabel xrLabel57;
    private XRLabel xrLabel56;
    private XRLabel xrLabel55;
    private XRRichText xrRichText8;
    private XRLabel xrLabel54;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private CalculatedField RiskScore;
    private DetailBand Detail5;
    private DetailReportBand DetailReport4;
    private DetailBand Detail4;
    private DetailReportBand DetailReport3;
    private GroupHeaderBand GroupHeader3;
    private DetailBand Detail3;
    private DetailReportBand DetailReport2;
    private GroupHeaderBand GroupHeader2;
    private DetailBand Detail2;
    private DetailReportBand DetailReport1;
    private GroupHeaderBand GroupHeader1;
    private DetailBand Detail1;
    private DetailReportBand DetailReport;
    private DetailReportBand DetailReport5;
    private DetailBand Detail6;
    private XRTable xrTable4;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell27;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell29;
    private CalculatedField calculatedField1;
    private GroupHeaderBand GroupHeader4;
    private DetailReportBand DetailReport6;
    private DetailBand Detail7;
    private GroupHeaderBand GroupHeader5;
    private DevExpress.XtraReports.Parameters.Parameter SrtateProject;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public rep_pro_ivv_progress()
    {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
    }

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rep_pro_ivv_progress));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery5 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText2 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText3 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText4 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText5 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel45 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel46 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel47 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel48 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel49 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel50 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel51 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel52 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText6 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel53 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText7 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel54 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText8 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel55 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel56 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel57 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel58 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel59 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel60 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel61 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel62 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel63 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel64 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel65 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel66 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel67 = new DevExpress.XtraReports.UI.XRLabel();
            this.RiskScore = new DevExpress.XtraReports.UI.CalculatedField();
            this.Detail5 = new DevExpress.XtraReports.UI.DetailBand();
            this.DetailReport4 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.GroupHeader4 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.Detail4 = new DevExpress.XtraReports.UI.DetailBand();
            this.DetailReport3 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.GroupHeader3 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.DetailReport6 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail7 = new DevExpress.XtraReports.UI.DetailBand();
            this.GroupHeader5 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.Detail3 = new DevExpress.XtraReports.UI.DetailBand();
            this.DetailReport2 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.Detail2 = new DevExpress.XtraReports.UI.DetailBand();
            this.DetailReport1 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.DetailReport5 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail6 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.calculatedField1 = new DevExpress.XtraReports.UI.CalculatedField();
            this.SrtateProject = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DevDB";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "GeneralInformation";
            queryParameter1.Name = "IVVStateID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.SrtateProject]", typeof(System.Guid));
            customSqlQuery1.Parameters.Add(queryParameter1);
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            customSqlQuery2.Name = "Risks";
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            customSqlQuery3.Name = "LifeCycleStatus1";
            customSqlQuery3.Sql = resources.GetString("customSqlQuery3.Sql");
            customSqlQuery4.Name = "LifeCycleStatus2";
            customSqlQuery4.Sql = resources.GetString("customSqlQuery4.Sql");
            customSqlQuery5.Name = "Recommendations";
            customSqlQuery5.Sql = resources.GetString("customSqlQuery5.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            customSqlQuery2,
            customSqlQuery3,
            customSqlQuery4,
            customSqlQuery5});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // Detail
            // 
            this.Detail.Expanded = false;
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 1.041667F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 31.95826F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.xrLabel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(1600F, 36.54167F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "General Information";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrRichText1
            // 
            this.xrRichText1.BackColor = System.Drawing.Color.Honeydew;
            this.xrRichText1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(4.768372E-05F, 36.54167F);
            this.xrRichText1.Name = "xrRichText1";
            this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
            this.xrRichText1.SizeF = new System.Drawing.SizeF(1600F, 46.16669F);
            this.xrRichText1.StylePriority.UseBackColor = false;
            this.xrRichText1.StylePriority.UseFont = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(150F, 24.04165F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "State";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ivv_state]")});
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(150F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(251.0417F, 24.04165F);
            this.xrLabel3.Text = "xrLabel3";
            // 
            // xrLabel4
            // 
            this.xrLabel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(401.0417F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(150F, 24.04165F);
            this.xrLabel4.StylePriority.UseBackColor = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "State Primary POC";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel5
            // 
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ivv_state_primary_poc]")});
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(551.0417F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(297.9167F, 24.04165F);
            this.xrLabel5.Text = "xrLabel5";
            // 
            // xrLabel6
            // 
            this.xrLabel6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(848.9586F, 1.041667F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(152.0834F, 23F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Submitter Email";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel7
            // 
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ivv_submitter_email]")});
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(1001.042F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(202.0829F, 23F);
            this.xrLabel7.Text = "xrLabel7";
            // 
            // xrLabel8
            // 
            this.xrLabel8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(1203.125F, 1.041667F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(220.8331F, 23F);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Target or Actual Date IV&V on Board";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel9
            // 
            this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ivv_onboard_date]")});
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(1423.958F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(176.0416F, 23F);
            this.xrLabel9.Text = "xrLabel9";
            this.xrLabel9.TextFormatString = "{0:MM/dd/yyyy}";
            // 
            // xrLabel10
            // 
            this.xrLabel10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 24.04165F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(150F, 23F);
            this.xrLabel10.StylePriority.UseBackColor = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Project Name";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel11
            // 
            this.xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ivv_project_name]")});
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(150F, 24.04165F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(251.0417F, 23F);
            this.xrLabel11.Text = "xrLabel11";
            // 
            // xrLabel12
            // 
            this.xrLabel12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(401.0417F, 24.04162F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(150.0001F, 23.00001F);
            this.xrLabel12.StylePriority.UseBackColor = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "State Primary POC Email";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel13
            // 
            this.xrLabel13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ivv_state_primary_poc_email]")});
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(551.0418F, 24.04165F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(297.9167F, 23F);
            this.xrLabel13.Text = "xrLabel13";
            // 
            // xrLabel14
            // 
            this.xrLabel14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(848.9586F, 24.04165F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(152.0834F, 23F);
            this.xrLabel14.StylePriority.UseBackColor = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "Submitter Phone";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel15
            // 
            this.xrLabel15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ivv_submitter_phone]")});
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(1001.042F, 24.04165F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(202.0829F, 23F);
            this.xrLabel15.Text = "xrLabel15";
            // 
            // xrLabel16
            // 
            this.xrLabel16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(1203.125F, 24.04165F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(220.833F, 23F);
            this.xrLabel16.StylePriority.UseBackColor = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "Next Progress Report Date";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel17
            // 
            this.xrLabel17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ivv_progress_report_date]")});
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(1423.958F, 24.04165F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(176.0415F, 23F);
            this.xrLabel17.Text = "xrLabel17";
            this.xrLabel17.TextFormatString = "{0:MM/dd/yyyy}";
            // 
            // xrLabel18
            // 
            this.xrLabel18.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(4.768372E-05F, 47.04164F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(150F, 23F);
            this.xrLabel18.StylePriority.UseBackColor = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "Program Name";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel19
            // 
            this.xrLabel19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ivv_program_name]")});
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(150F, 47.04164F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(251.0417F, 23F);
            this.xrLabel19.Text = "xrLabel19";
            // 
            // xrLabel20
            // 
            this.xrLabel20.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(401.0417F, 47.04164F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(150.0001F, 23F);
            this.xrLabel20.StylePriority.UseBackColor = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "Submitter Name";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel21
            // 
            this.xrLabel21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ivv_submitter_name]")});
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(551.0417F, 47.04164F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(297.9167F, 23F);
            this.xrLabel21.Text = "xrLabel21";
            // 
            // xrLabel22
            // 
            this.xrLabel22.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(848.9586F, 47.04167F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(152.0834F, 23F);
            this.xrLabel22.StylePriority.UseBackColor = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "Activity 1 Consult Date";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel23
            // 
            this.xrLabel23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ivv_activity_1_consult_date]")});
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(1001.042F, 47.04167F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(202.0829F, 23F);
            this.xrLabel23.Text = "xrLabel23";
            this.xrLabel23.TextFormatString = "{0:MM/dd/yyyy}";
            // 
            // xrLabel26
            // 
            this.xrLabel26.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(0F, 70.04166F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(150F, 38F);
            this.xrLabel26.StylePriority.UseBackColor = false;
            this.xrLabel26.StylePriority.UseTextAlignment = false;
            this.xrLabel26.Text = "Progress report Date";
            this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel27
            // 
            this.xrLabel27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ivv_progress_report_date]")});
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(150F, 70.04166F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(251.0417F, 37.58335F);
            this.xrLabel27.Text = "xrLabel27";
            this.xrLabel27.TextFormatString = "{0:MM/dd/yyyy}";
            // 
            // xrLabel28
            // 
            this.xrLabel28.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(401.0417F, 70.04166F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(150F, 37.58335F);
            this.xrLabel28.StylePriority.UseBackColor = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.Text = "Submitter Title/Role";
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel29
            // 
            this.xrLabel29.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ivv_submitter_role]")});
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(551.0419F, 70.04166F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(297.9167F, 37.58335F);
            this.xrLabel29.Text = "xrLabel29";
            // 
            // xrLabel30
            // 
            this.xrLabel30.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(848.9586F, 70.04166F);
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(152.0834F, 38F);
            this.xrLabel30.StylePriority.UseBackColor = false;
            this.xrLabel30.StylePriority.UseTextAlignment = false;
            this.xrLabel30.Text = "Target or Actual IV&V RFP Release Date";
            this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel31
            // 
            this.xrLabel31.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ivv_rfp_release_date]")});
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(1001.042F, 70.04166F);
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(202.0829F, 37.58335F);
            this.xrLabel31.Text = "xrLabel31";
            this.xrLabel31.TextFormatString = "{0:MM/dd/yyyy}";
            // 
            // xrLabel24
            // 
            this.xrLabel24.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.xrLabel24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(1600F, 33.41668F);
            this.xrLabel24.StylePriority.UseBackColor = false;
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            this.xrLabel24.Text = "Executive Sumamry";
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrRichText2
            // 
            this.xrRichText2.BackColor = System.Drawing.Color.Honeydew;
            this.xrRichText2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText2.LocationFloat = new DevExpress.Utils.PointFloat(4.768372E-05F, 33.41668F);
            this.xrRichText2.Name = "xrRichText2";
            this.xrRichText2.SerializableRtfString = resources.GetString("xrRichText2.SerializableRtfString");
            this.xrRichText2.SizeF = new System.Drawing.SizeF(1600F, 34.45838F);
            this.xrRichText2.StylePriority.UseBackColor = false;
            this.xrRichText2.StylePriority.UseFont = false;
            // 
            // xrRichText3
            // 
            this.xrRichText3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Rtf", "[ivv_executive_summary]")});
            this.xrRichText3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText3.LocationFloat = new DevExpress.Utils.PointFloat(4.768372E-05F, 0F);
            this.xrRichText3.Name = "xrRichText3";
            this.xrRichText3.SerializableRtfString = resources.GetString("xrRichText3.SerializableRtfString");
            this.xrRichText3.SizeF = new System.Drawing.SizeF(1600F, 53.125F);
            // 
            // xrLabel25
            // 
            this.xrLabel25.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.xrLabel25.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(4.768372E-05F, 0F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(1600F, 38.62502F);
            this.xrLabel25.StylePriority.UseBackColor = false;
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.Text = "Project Management Office Status";
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel33
            // 
            this.xrLabel33.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(0F, 73.08337F);
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(150F, 37.29165F);
            this.xrLabel33.StylePriority.UseBackColor = false;
            this.xrLabel33.Text = "Total Budget";
            // 
            // xrLabel34
            // 
            this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(150F, 73.08337F);
            this.xrLabel34.Name = "xrLabel34";
            this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel34.SizeF = new System.Drawing.SizeF(251.0417F, 37.29165F);
            // 
            // xrLabel35
            // 
            this.xrLabel35.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(401.0415F, 73.08337F);
            this.xrLabel35.Name = "xrLabel35";
            this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel35.SizeF = new System.Drawing.SizeF(150.0002F, 37.29165F);
            this.xrLabel35.StylePriority.UseBackColor = false;
            this.xrLabel35.Text = "Earned Value";
            // 
            // xrLabel36
            // 
            this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(551.0417F, 73.08337F);
            this.xrLabel36.Name = "xrLabel36";
            this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel36.SizeF = new System.Drawing.SizeF(297.9167F, 37.29165F);
            // 
            // xrLabel37
            // 
            this.xrLabel37.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(848.9586F, 73.08337F);
            this.xrLabel37.Name = "xrLabel37";
            this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel37.SizeF = new System.Drawing.SizeF(152.0833F, 37.29165F);
            this.xrLabel37.StylePriority.UseBackColor = false;
            this.xrLabel37.Text = "Budget Variance (%)";
            // 
            // xrLabel38
            // 
            this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(1001.042F, 73.08337F);
            this.xrLabel38.Name = "xrLabel38";
            this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel38.SizeF = new System.Drawing.SizeF(202.0829F, 37.29165F);
            // 
            // xrLabel39
            // 
            this.xrLabel39.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(1203.125F, 73.08337F);
            this.xrLabel39.Name = "xrLabel39";
            this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel39.SizeF = new System.Drawing.SizeF(220.8331F, 37.29165F);
            this.xrLabel39.StylePriority.UseBackColor = false;
            this.xrLabel39.Text = "Schedule Variance (%)";
            // 
            // xrLabel40
            // 
            this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(1423.958F, 73.08337F);
            this.xrLabel40.Name = "xrLabel40";
            this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel40.SizeF = new System.Drawing.SizeF(176.0415F, 37.29165F);
            // 
            // xrLabel41
            // 
            this.xrLabel41.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(0F, 110.375F);
            this.xrLabel41.Name = "xrLabel41";
            this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel41.SizeF = new System.Drawing.SizeF(150F, 41.70831F);
            this.xrLabel41.StylePriority.UseBackColor = false;
            this.xrLabel41.Text = "Other (if not using EV)";
            // 
            // xrLabel42
            // 
            this.xrLabel42.LocationFloat = new DevExpress.Utils.PointFloat(150F, 110.375F);
            this.xrLabel42.Name = "xrLabel42";
            this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel42.SizeF = new System.Drawing.SizeF(251.0417F, 41.70831F);
            // 
            // xrRichText4
            // 
            this.xrRichText4.BackColor = System.Drawing.Color.Honeydew;
            this.xrRichText4.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Italic);
            this.xrRichText4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 38.62502F);
            this.xrRichText4.Name = "xrRichText4";
            this.xrRichText4.SerializableRtfString = resources.GetString("xrRichText4.SerializableRtfString");
            this.xrRichText4.SizeF = new System.Drawing.SizeF(1600F, 34.45835F);
            this.xrRichText4.StylePriority.UseBackColor = false;
            this.xrRichText4.StylePriority.UseFont = false;
            // 
            // xrLabel32
            // 
            this.xrLabel32.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.xrLabel32.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(1600F, 40.70835F);
            this.xrLabel32.StylePriority.UseBackColor = false;
            this.xrLabel32.StylePriority.UseFont = false;
            this.xrLabel32.StylePriority.UseTextAlignment = false;
            this.xrLabel32.Text = "Life Cycle Status and Schedule ";
            this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrRichText5
            // 
            this.xrRichText5.BackColor = System.Drawing.Color.Honeydew;
            this.xrRichText5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrRichText5.LocationFloat = new DevExpress.Utils.PointFloat(4.768372E-05F, 40.70835F);
            this.xrRichText5.Name = "xrRichText5";
            this.xrRichText5.SerializableRtfString = resources.GetString("xrRichText5.SerializableRtfString");
            this.xrRichText5.SizeF = new System.Drawing.SizeF(1600F, 107.625F);
            this.xrRichText5.StylePriority.UseBackColor = false;
            this.xrRichText5.StylePriority.UseFont = false;
            // 
            // xrLabel44
            // 
            this.xrLabel44.BackColor = System.Drawing.Color.Honeydew;
            this.xrLabel44.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(4.768372E-05F, 213.4583F);
            this.xrLabel44.Name = "xrLabel44";
            this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel44.SizeF = new System.Drawing.SizeF(1600F, 28.62505F);
            this.xrLabel44.StylePriority.UseBackColor = false;
            this.xrLabel44.StylePriority.UseFont = false;
            this.xrLabel44.StylePriority.UseTextAlignment = false;
            this.xrLabel44.Text = "MITA Business-Aligned Modules";
            this.xrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel45
            // 
            this.xrLabel45.BackColor = System.Drawing.Color.Honeydew;
            this.xrLabel45.LocationFloat = new DevExpress.Utils.PointFloat(202.0833F, 148.3334F);
            this.xrLabel45.Name = "xrLabel45";
            this.xrLabel45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel45.SizeF = new System.Drawing.SizeF(198.9583F, 65.12495F);
            this.xrLabel45.StylePriority.UseBackColor = false;
            this.xrLabel45.Text = "Life Cycle Status";
            // 
            // xrLabel46
            // 
            this.xrLabel46.BackColor = System.Drawing.Color.Honeydew;
            this.xrLabel46.LocationFloat = new DevExpress.Utils.PointFloat(401.0417F, 148.3334F);
            this.xrLabel46.Name = "xrLabel46";
            this.xrLabel46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel46.SizeF = new System.Drawing.SizeF(200F, 65.12495F);
            this.xrLabel46.StylePriority.UseBackColor = false;
            this.xrLabel46.Text = "Target or Actual IAPD Approval Date";
            // 
            // xrLabel47
            // 
            this.xrLabel47.BackColor = System.Drawing.Color.Honeydew;
            this.xrLabel47.LocationFloat = new DevExpress.Utils.PointFloat(601.0417F, 148.3334F);
            this.xrLabel47.Name = "xrLabel47";
            this.xrLabel47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel47.SizeF = new System.Drawing.SizeF(197.9166F, 65.12495F);
            this.xrLabel47.StylePriority.UseBackColor = false;
            this.xrLabel47.Text = "Target or Actual Development Start Date";
            // 
            // xrLabel48
            // 
            this.xrLabel48.BackColor = System.Drawing.Color.Honeydew;
            this.xrLabel48.LocationFloat = new DevExpress.Utils.PointFloat(798.9583F, 148.3334F);
            this.xrLabel48.Name = "xrLabel48";
            this.xrLabel48.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel48.SizeF = new System.Drawing.SizeF(202.0835F, 65.12494F);
            this.xrLabel48.StylePriority.UseBackColor = false;
            this.xrLabel48.Text = "Target or Actual Date for R1";
            // 
            // xrLabel49
            // 
            this.xrLabel49.BackColor = System.Drawing.Color.Honeydew;
            this.xrLabel49.LocationFloat = new DevExpress.Utils.PointFloat(1002.083F, 148.3334F);
            this.xrLabel49.Name = "xrLabel49";
            this.xrLabel49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel49.SizeF = new System.Drawing.SizeF(201.0416F, 65.12495F);
            this.xrLabel49.StylePriority.UseBackColor = false;
            this.xrLabel49.Text = "Target or Actual Date for R2";
            // 
            // xrLabel50
            // 
            this.xrLabel50.BackColor = System.Drawing.Color.Honeydew;
            this.xrLabel50.LocationFloat = new DevExpress.Utils.PointFloat(1203.125F, 148.3334F);
            this.xrLabel50.Name = "xrLabel50";
            this.xrLabel50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel50.SizeF = new System.Drawing.SizeF(170.8331F, 65.12494F);
            this.xrLabel50.StylePriority.UseBackColor = false;
            this.xrLabel50.Text = "Target or Actual Go-Live Date";
            // 
            // xrLabel51
            // 
            this.xrLabel51.BackColor = System.Drawing.Color.Honeydew;
            this.xrLabel51.LocationFloat = new DevExpress.Utils.PointFloat(1373.958F, 148.3334F);
            this.xrLabel51.Name = "xrLabel51";
            this.xrLabel51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel51.SizeF = new System.Drawing.SizeF(226.0415F, 65.12495F);
            this.xrLabel51.StylePriority.UseBackColor = false;
            this.xrLabel51.Text = "Target or Actual Date for R3";
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(1600F, 25F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LifeCycleStatus1].[lifecycle_status_projectname]")});
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseBackColor = false;
            this.xrTableCell1.Weight = 2.0208332824707034D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LifeCycleStatus1].[lifecycle_status_project_status]")});
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Weight = 1.9895832824707032D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LifeCycleStatus1].[lifecycle_status_iapd_approval_date]")});
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.TextFormatString = "{0:MM/dd/yyyy}";
            this.xrTableCell3.Weight = 2.0000003051757811D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LifeCycleStatus1].[lifecycle_status_devp_start_date]")});
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.TextFormatString = "{0:MM/dd/yyyy}";
            this.xrTableCell4.Weight = 1.9791662597656252D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LifeCycleStatus1].[lifecycle_status_r1_date]")});
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.TextFormatString = "{0:MM/dd/yyyy}";
            this.xrTableCell5.Weight = 2.03125D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LifeCycleStatus1].[lifecycle_status_r2_date]")});
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.TextFormatString = "{0:MM/dd/yyyy}";
            this.xrTableCell6.Weight = 2.0104168701171874D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LifeCycleStatus1].[lifecycle_status_live_date]")});
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.TextFormatString = "{0:MM/dd/yyyy}";
            this.xrTableCell7.Weight = 1.7083349609375D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LifeCycleStatus1].[lifecycle_status-r3_date]")});
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.TextFormatString = "{0:MM/dd/yyyy}";
            this.xrTableCell8.Weight = 2.2604150390625D;
            // 
            // xrLabel43
            // 
            this.xrLabel43.BackColor = System.Drawing.Color.Honeydew;
            this.xrLabel43.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel43.LocationFloat = new DevExpress.Utils.PointFloat(4.768372E-05F, 0F);
            this.xrLabel43.Name = "xrLabel43";
            this.xrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel43.SizeF = new System.Drawing.SizeF(1600F, 23F);
            this.xrLabel43.StylePriority.UseBackColor = false;
            this.xrLabel43.StylePriority.UseFont = false;
            this.xrLabel43.StylePriority.UseTextAlignment = false;
            this.xrLabel43.Text = "MMIS Functional Modules";
            this.xrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTable2
            // 
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(4.768372E-05F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(1600F, 25F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell16,
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell12,
            this.xrTableCell13,
            this.xrTableCell14,
            this.xrTableCell15});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xrTableCell16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LifeCycleStatus2].[lifecycle_status_projectname]")});
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.StylePriority.UseBackColor = false;
            this.xrTableCell16.Weight = 2.043198454301256D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LifeCycleStatus2].[lifecycle_status_project_status]")});
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Weight = 2.0116030563502552D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LifeCycleStatus2].[lifecycle_status_iapd_approval_date]")});
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.TextFormatString = "{0:MM/dd/yyyy}";
            this.xrTableCell10.Weight = 2.0221353996798266D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LifeCycleStatus2].[lifecycle_status_devp_start_date]")});
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.TextFormatString = "{0:MM/dd/yyyy}";
            this.xrTableCell11.Weight = 2.0010689074176407D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LifeCycleStatus2].[lifecycle_status_r1_date]")});
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.TextFormatString = "{0:MM/dd/yyyy}";
            this.xrTableCell12.Weight = 2.0432025360691353D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LifeCycleStatus2].[lifecycle_status_r2_date]")});
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.TextFormatString = "{0:MM/dd/yyyy}";
            this.xrTableCell13.Weight = 2.043196291787313D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LifeCycleStatus2].[lifecycle_status_live_date]")});
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.TextFormatString = "{0:MM/dd/yyyy}";
            this.xrTableCell14.Weight = 1.7522607399587795D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LifeCycleStatus2].[lifecycle_status-r3_date]")});
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.TextFormatString = "{0:MM/dd/yyyy}";
            this.xrTableCell15.Weight = 2.2604153343042119D;
            // 
            // xrLabel52
            // 
            this.xrLabel52.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xrLabel52.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel52.LocationFloat = new DevExpress.Utils.PointFloat(0F, 53.20835F);
            this.xrLabel52.Name = "xrLabel52";
            this.xrLabel52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel52.SizeF = new System.Drawing.SizeF(202.0833F, 74.91666F);
            this.xrLabel52.StylePriority.UseBackColor = false;
            this.xrLabel52.StylePriority.UseFont = false;
            this.xrLabel52.StylePriority.UseTextAlignment = false;
            this.xrLabel52.Text = "Comments";
            this.xrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrRichText6
            // 
            this.xrRichText6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Rtf", "[LifeCycleStatus2].[comments]")});
            this.xrRichText6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText6.LocationFloat = new DevExpress.Utils.PointFloat(202.0834F, 53.20835F);
            this.xrRichText6.Name = "xrRichText6";
            this.xrRichText6.SerializableRtfString = resources.GetString("xrRichText6.SerializableRtfString");
            this.xrRichText6.SizeF = new System.Drawing.SizeF(1397.917F, 74.91666F);
            // 
            // xrLabel53
            // 
            this.xrLabel53.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.xrLabel53.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel53.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel53.Name = "xrLabel53";
            this.xrLabel53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel53.SizeF = new System.Drawing.SizeF(1600F, 40.70835F);
            this.xrLabel53.StylePriority.UseBackColor = false;
            this.xrLabel53.StylePriority.UseFont = false;
            this.xrLabel53.StylePriority.UseTextAlignment = false;
            this.xrLabel53.Text = "Risks";
            this.xrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrRichText7
            // 
            this.xrRichText7.BackColor = System.Drawing.Color.Honeydew;
            this.xrRichText7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrRichText7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 40.70835F);
            this.xrRichText7.Name = "xrRichText7";
            this.xrRichText7.SerializableRtfString = resources.GetString("xrRichText7.SerializableRtfString");
            this.xrRichText7.SizeF = new System.Drawing.SizeF(1600F, 53.45834F);
            this.xrRichText7.StylePriority.UseBackColor = false;
            this.xrRichText7.StylePriority.UseFont = false;
            // 
            // xrTable3
            // 
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(4.768372E-05F, 0F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.SizeF = new System.Drawing.SizeF(1600F, 35F);
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell17,
            this.xrTableCell18,
            this.xrTableCell19,
            this.xrTableCell20,
            this.xrTableCell21,
            this.xrTableCell22,
            this.xrTableCell23,
            this.xrTableCell24});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ivv_risks_uniqueid]")});
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.Text = "Risk ID #";
            this.xrTableCell17.Weight = 2.0208332824707034D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ivv_risks_title]")});
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.Text = "Risk Title";
            this.xrTableCell18.Weight = 1.9895832824707032D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ivv_risks_description]")});
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.Text = "Description";
            this.xrTableCell19.Weight = 2.1041665649414063D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[probability]")});
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.Text = "Probability";
            this.xrTableCell20.Weight = 1.8749981689453126D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[impact]")});
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.Text = "Impact";
            this.xrTableCell21.Weight = 2.0312518310546874D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[calculatedField1]")});
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.Text = "Risk Score";
            this.xrTableCell22.Weight = 2.0104144287109378D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ivv_risks_resolution_date]")});
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.Text = "Target or Actual Resolution Date";
            this.xrTableCell23.TextFormatString = "{0:MM/dd/yyyy}";
            this.xrTableCell23.Weight = 1.9791687011718748D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ivvRisksStatus]")});
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.Text = "Status";
            this.xrTableCell24.Weight = 1.9895837402343748D;
            // 
            // xrLabel54
            // 
            this.xrLabel54.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.xrLabel54.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel54.LocationFloat = new DevExpress.Utils.PointFloat(4.768372E-05F, 0F);
            this.xrLabel54.Name = "xrLabel54";
            this.xrLabel54.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel54.SizeF = new System.Drawing.SizeF(1600F, 40.70835F);
            this.xrLabel54.StylePriority.UseBackColor = false;
            this.xrLabel54.StylePriority.UseFont = false;
            this.xrLabel54.StylePriority.UseTextAlignment = false;
            this.xrLabel54.Text = "Recommendations";
            this.xrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrRichText8
            // 
            this.xrRichText8.BackColor = System.Drawing.Color.Honeydew;
            this.xrRichText8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrRichText8.LocationFloat = new DevExpress.Utils.PointFloat(4.768372E-05F, 40.70835F);
            this.xrRichText8.Name = "xrRichText8";
            this.xrRichText8.SerializableRtfString = resources.GetString("xrRichText8.SerializableRtfString");
            this.xrRichText8.SizeF = new System.Drawing.SizeF(1600F, 51.37495F);
            this.xrRichText8.StylePriority.UseBackColor = false;
            this.xrRichText8.StylePriority.UseFont = false;
            // 
            // xrLabel55
            // 
            this.xrLabel55.BackColor = System.Drawing.Color.Honeydew;
            this.xrLabel55.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel55.LocationFloat = new DevExpress.Utils.PointFloat(0F, 92.0833F);
            this.xrLabel55.Name = "xrLabel55";
            this.xrLabel55.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel55.SizeF = new System.Drawing.SizeF(249.0032F, 37.08331F);
            this.xrLabel55.StylePriority.UseBackColor = false;
            this.xrLabel55.StylePriority.UseFont = false;
            this.xrLabel55.StylePriority.UseTextAlignment = false;
            this.xrLabel55.Text = "Recommendation #";
            this.xrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel56
            // 
            this.xrLabel56.BackColor = System.Drawing.Color.Honeydew;
            this.xrLabel56.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel56.LocationFloat = new DevExpress.Utils.PointFloat(249.0032F, 92.0833F);
            this.xrLabel56.Name = "xrLabel56";
            this.xrLabel56.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel56.SizeF = new System.Drawing.SizeF(302.0385F, 36.45839F);
            this.xrLabel56.StylePriority.UseBackColor = false;
            this.xrLabel56.StylePriority.UseFont = false;
            this.xrLabel56.StylePriority.UseTextAlignment = false;
            this.xrLabel56.Text = "Date of recommendation";
            this.xrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel57
            // 
            this.xrLabel57.BackColor = System.Drawing.Color.Honeydew;
            this.xrLabel57.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel57.LocationFloat = new DevExpress.Utils.PointFloat(551.0419F, 92.0833F);
            this.xrLabel57.Name = "xrLabel57";
            this.xrLabel57.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel57.SizeF = new System.Drawing.SizeF(349.9205F, 36.45839F);
            this.xrLabel57.StylePriority.UseBackColor = false;
            this.xrLabel57.StylePriority.UseFont = false;
            this.xrLabel57.StylePriority.UseTextAlignment = false;
            this.xrLabel57.Text = "Recommendation";
            this.xrLabel57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel58
            // 
            this.xrLabel58.BackColor = System.Drawing.Color.Honeydew;
            this.xrLabel58.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel58.LocationFloat = new DevExpress.Utils.PointFloat(900.9623F, 92.0833F);
            this.xrLabel58.Name = "xrLabel58";
            this.xrLabel58.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel58.SizeF = new System.Drawing.SizeF(246.3968F, 37.08331F);
            this.xrLabel58.StylePriority.UseBackColor = false;
            this.xrLabel58.StylePriority.UseFont = false;
            this.xrLabel58.StylePriority.UseTextAlignment = false;
            this.xrLabel58.Text = "Resolved?";
            this.xrLabel58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel59
            // 
            this.xrLabel59.BackColor = System.Drawing.Color.Honeydew;
            this.xrLabel59.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel59.LocationFloat = new DevExpress.Utils.PointFloat(1147.359F, 92.0833F);
            this.xrLabel59.Name = "xrLabel59";
            this.xrLabel59.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel59.SizeF = new System.Drawing.SizeF(451.5199F, 36.45839F);
            this.xrLabel59.StylePriority.UseBackColor = false;
            this.xrLabel59.StylePriority.UseFont = false;
            this.xrLabel59.StylePriority.UseTextAlignment = false;
            this.xrLabel59.Text = "Comments/Resolution";
            this.xrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel60
            // 
            this.xrLabel60.BackColor = System.Drawing.Color.Honeydew;
            this.xrLabel60.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel60.LocationFloat = new DevExpress.Utils.PointFloat(0F, 94.16669F);
            this.xrLabel60.Name = "xrLabel60";
            this.xrLabel60.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel60.SizeF = new System.Drawing.SizeF(202.0834F, 37.08331F);
            this.xrLabel60.StylePriority.UseBackColor = false;
            this.xrLabel60.StylePriority.UseFont = false;
            this.xrLabel60.StylePriority.UseTextAlignment = false;
            this.xrLabel60.Text = "Risk ID #";
            this.xrLabel60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel61
            // 
            this.xrLabel61.BackColor = System.Drawing.Color.Honeydew;
            this.xrLabel61.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel61.LocationFloat = new DevExpress.Utils.PointFloat(202.0833F, 94.16669F);
            this.xrLabel61.Name = "xrLabel61";
            this.xrLabel61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel61.SizeF = new System.Drawing.SizeF(198.9583F, 37.08331F);
            this.xrLabel61.StylePriority.UseBackColor = false;
            this.xrLabel61.StylePriority.UseFont = false;
            this.xrLabel61.StylePriority.UseTextAlignment = false;
            this.xrLabel61.Text = "Risk Title";
            this.xrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel62
            // 
            this.xrLabel62.BackColor = System.Drawing.Color.Honeydew;
            this.xrLabel62.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel62.LocationFloat = new DevExpress.Utils.PointFloat(401.0417F, 94.16669F);
            this.xrLabel62.Name = "xrLabel62";
            this.xrLabel62.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel62.SizeF = new System.Drawing.SizeF(210.4167F, 37.08331F);
            this.xrLabel62.StylePriority.UseBackColor = false;
            this.xrLabel62.StylePriority.UseFont = false;
            this.xrLabel62.StylePriority.UseTextAlignment = false;
            this.xrLabel62.Text = "Description";
            this.xrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel63
            // 
            this.xrLabel63.BackColor = System.Drawing.Color.Honeydew;
            this.xrLabel63.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel63.LocationFloat = new DevExpress.Utils.PointFloat(611.4583F, 94.16669F);
            this.xrLabel63.Name = "xrLabel63";
            this.xrLabel63.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel63.SizeF = new System.Drawing.SizeF(187.4999F, 37.08331F);
            this.xrLabel63.StylePriority.UseBackColor = false;
            this.xrLabel63.StylePriority.UseFont = false;
            this.xrLabel63.StylePriority.UseTextAlignment = false;
            this.xrLabel63.Text = "Probability";
            this.xrLabel63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel64
            // 
            this.xrLabel64.BackColor = System.Drawing.Color.Honeydew;
            this.xrLabel64.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel64.LocationFloat = new DevExpress.Utils.PointFloat(798.9581F, 94.16669F);
            this.xrLabel64.Name = "xrLabel64";
            this.xrLabel64.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel64.SizeF = new System.Drawing.SizeF(202.0837F, 37.08331F);
            this.xrLabel64.StylePriority.UseBackColor = false;
            this.xrLabel64.StylePriority.UseFont = false;
            this.xrLabel64.StylePriority.UseTextAlignment = false;
            this.xrLabel64.Text = "Impact";
            this.xrLabel64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel65
            // 
            this.xrLabel65.BackColor = System.Drawing.Color.Honeydew;
            this.xrLabel65.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel65.LocationFloat = new DevExpress.Utils.PointFloat(1002.083F, 94.16669F);
            this.xrLabel65.Name = "xrLabel65";
            this.xrLabel65.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel65.SizeF = new System.Drawing.SizeF(201.0414F, 37.08331F);
            this.xrLabel65.StylePriority.UseBackColor = false;
            this.xrLabel65.StylePriority.UseFont = false;
            this.xrLabel65.StylePriority.UseTextAlignment = false;
            this.xrLabel65.Text = "Risk Score";
            this.xrLabel65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel66
            // 
            this.xrLabel66.BackColor = System.Drawing.Color.Honeydew;
            this.xrLabel66.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel66.LocationFloat = new DevExpress.Utils.PointFloat(1203.125F, 94.16669F);
            this.xrLabel66.Name = "xrLabel66";
            this.xrLabel66.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel66.SizeF = new System.Drawing.SizeF(197.9166F, 37.08331F);
            this.xrLabel66.StylePriority.UseBackColor = false;
            this.xrLabel66.StylePriority.UseFont = false;
            this.xrLabel66.StylePriority.UseTextAlignment = false;
            this.xrLabel66.Text = "Targget of Actual Resolution Date";
            this.xrLabel66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel67
            // 
            this.xrLabel67.BackColor = System.Drawing.Color.Honeydew;
            this.xrLabel67.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel67.LocationFloat = new DevExpress.Utils.PointFloat(1401.042F, 94.16669F);
            this.xrLabel67.Name = "xrLabel67";
            this.xrLabel67.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel67.SizeF = new System.Drawing.SizeF(198.9585F, 37.08331F);
            this.xrLabel67.StylePriority.UseBackColor = false;
            this.xrLabel67.StylePriority.UseFont = false;
            this.xrLabel67.StylePriority.UseTextAlignment = false;
            this.xrLabel67.Text = "Status";
            this.xrLabel67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // RiskScore
            // 
            this.RiskScore.DataMember = "Query_1";
            this.RiskScore.Expression = "[ivv_risks_probability]-[ivv_risks_impact]";
            this.RiskScore.Name = "RiskScore";
            // 
            // Detail5
            // 
            this.Detail5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
            this.Detail5.HeightF = 35F;
            this.Detail5.Name = "Detail5";
            // 
            // DetailReport4
            // 
            this.DetailReport4.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail5,
            this.GroupHeader4});
            this.DetailReport4.DataMember = "Risks";
            this.DetailReport4.DataSource = this.sqlDataSource1;
            this.DetailReport4.Level = 4;
            this.DetailReport4.Name = "DetailReport4";
            this.DetailReport4.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            // 
            // GroupHeader4
            // 
            this.GroupHeader4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel67,
            this.xrLabel66,
            this.xrLabel65,
            this.xrLabel64,
            this.xrLabel63,
            this.xrLabel62,
            this.xrLabel61,
            this.xrLabel60,
            this.xrRichText7,
            this.xrLabel53});
            this.GroupHeader4.HeightF = 131.25F;
            this.GroupHeader4.Name = "GroupHeader4";
            // 
            // Detail4
            // 
            this.Detail4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail4.HeightF = 25F;
            this.Detail4.Name = "Detail4";
            this.Detail4.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            // 
            // DetailReport3
            // 
            this.DetailReport3.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail4,
            this.GroupHeader3,
            this.DetailReport6});
            this.DetailReport3.DataSource = this.sqlDataSource1;
            this.DetailReport3.Level = 3;
            this.DetailReport3.Name = "DetailReport3";
            this.DetailReport3.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            // 
            // GroupHeader3
            // 
            this.GroupHeader3.BackColor = System.Drawing.Color.SlateGray;
            this.GroupHeader3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel51,
            this.xrLabel50,
            this.xrLabel49,
            this.xrLabel48,
            this.xrLabel47,
            this.xrLabel46,
            this.xrLabel45,
            this.xrLabel44,
            this.xrRichText5,
            this.xrLabel32});
            this.GroupHeader3.HeightF = 242.0834F;
            this.GroupHeader3.Name = "GroupHeader3";
            this.GroupHeader3.StylePriority.UseBackColor = false;
            // 
            // DetailReport6
            // 
            this.DetailReport6.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail7,
            this.GroupHeader5});
            this.DetailReport6.Level = 0;
            this.DetailReport6.Name = "DetailReport6";
            // 
            // Detail7
            // 
            this.Detail7.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText6,
            this.xrLabel52,
            this.xrTable2});
            this.Detail7.HeightF = 128.125F;
            this.Detail7.Name = "Detail7";
            this.Detail7.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            // 
            // GroupHeader5
            // 
            this.GroupHeader5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel43});
            this.GroupHeader5.HeightF = 23.95833F;
            this.GroupHeader5.Name = "GroupHeader5";
            // 
            // Detail3
            // 
            this.Detail3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText4,
            this.xrLabel42,
            this.xrLabel41,
            this.xrLabel40,
            this.xrLabel39,
            this.xrLabel38,
            this.xrLabel37,
            this.xrLabel36,
            this.xrLabel35,
            this.xrLabel34,
            this.xrLabel33,
            this.xrLabel25});
            this.Detail3.HeightF = 153.125F;
            this.Detail3.Name = "Detail3";
            // 
            // DetailReport2
            // 
            this.DetailReport2.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail3});
            this.DetailReport2.DataSource = this.sqlDataSource1;
            this.DetailReport2.Level = 2;
            this.DetailReport2.Name = "DetailReport2";
            this.DetailReport2.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText2,
            this.xrLabel24});
            this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ivv_state", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader2.HeightF = 67.87506F;
            this.GroupHeader2.Name = "GroupHeader2";
            // 
            // Detail2
            // 
            this.Detail2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText3});
            this.Detail2.HeightF = 53.125F;
            this.Detail2.Name = "Detail2";
            // 
            // DetailReport1
            // 
            this.DetailReport1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail2,
            this.GroupHeader2});
            this.DetailReport1.DataMember = "GeneralInformation";
            this.DetailReport1.DataSource = this.sqlDataSource1;
            this.DetailReport1.Level = 1;
            this.DetailReport1.Name = "DetailReport1";
            this.DetailReport1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText1,
            this.xrLabel1});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ivv_state", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 82.70836F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel31,
            this.xrLabel30,
            this.xrLabel29,
            this.xrLabel28,
            this.xrLabel27,
            this.xrLabel26,
            this.xrLabel23,
            this.xrLabel22,
            this.xrLabel21,
            this.xrLabel20,
            this.xrLabel19,
            this.xrLabel18,
            this.xrLabel17,
            this.xrLabel16,
            this.xrLabel15,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2});
            this.Detail1.HeightF = 113.75F;
            this.Detail1.Name = "Detail1";
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.GroupHeader1});
            this.DetailReport.DataMember = "GeneralInformation";
            this.DetailReport.DataSource = this.sqlDataSource1;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            this.DetailReport.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            // 
            // DetailReport5
            // 
            this.DetailReport5.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail6});
            this.DetailReport5.Level = 5;
            this.DetailReport5.Name = "DetailReport5";
            this.DetailReport5.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            // 
            // Detail6
            // 
            this.Detail6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable4,
            this.xrLabel59,
            this.xrLabel58,
            this.xrLabel57,
            this.xrLabel56,
            this.xrLabel55,
            this.xrRichText8,
            this.xrLabel54});
            this.Detail6.HeightF = 159.375F;
            this.Detail6.Name = "Detail6";
            // 
            // xrTable4
            // 
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(4.768372E-05F, 129.1665F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
            this.xrTable4.SizeF = new System.Drawing.SizeF(1598.879F, 30F);
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell25,
            this.xrTableCell26,
            this.xrTableCell27,
            this.xrTableCell28,
            this.xrTableCell29});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Recommendations].[ivv_recm_uniqueid]")});
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.Weight = 2.4643603846359223D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Recommendations].[ivv_recm_date]")});
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.TextFormatString = "{0:MM/dd/yyyy}";
            this.xrTableCell26.Weight = 2.9892485913942828D;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Recommendations].[ivv_recm_recommendation]")});
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.Weight = 3.4631306408561016D;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Recommendations].[ivvRecmResolved]")});
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.Weight = 2.4385670555277814D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Recommendations].[ivv_recm_description]")});
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.Weight = 4.4686470305535577D;
            // 
            // calculatedField1
            // 
            this.calculatedField1.DataMember = "Risks";
            this.calculatedField1.DisplayName = "RiskScore";
            this.calculatedField1.Expression = "[probability]-[impact]";
            this.calculatedField1.Name = "calculatedField1";
            // 
            // SrtateProject
            // 
            this.SrtateProject.Description = "SrtateProject";
            this.SrtateProject.Name = "SrtateProject";
            this.SrtateProject.Type = typeof(System.Guid);
            this.SrtateProject.ValueInfo = "00000000-0000-0000-0000-000000000000";
            this.SrtateProject.Visible = false;
            // 
            // rep_pro_ivv_progress
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.DetailReport,
            this.DetailReport1,
            this.DetailReport2,
            this.DetailReport3,
            this.DetailReport4,
            this.DetailReport5});
            this.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.RiskScore,
            this.calculatedField1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataSource = this.sqlDataSource1;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 1, 32);
            this.PageHeight = 1269;
            this.PageWidth = 1600;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.SrtateProject});
            this.Version = "17.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
