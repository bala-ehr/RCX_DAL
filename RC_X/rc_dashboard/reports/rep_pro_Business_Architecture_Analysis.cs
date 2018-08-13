using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for rep_pro_Business_Architecture_Analysis
/// </summary>
public class rep_pro_Business_Architecture_Analysis : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private PageHeaderBand PageHeader;
    private PageFooterBand PageFooter;
    private XRPageInfo xrPageInfo1;
    private XRLabel xrLabel7;
    private XRPageInfo xrPageInfo2;
    private XRLabel xrLabel8;
    private XRLabel xrLabel12;
    private XRLabel xrLabel1;
    private XRLabel xrLabel3;
    private ReportHeaderBand ReportHeader;
    private XRTable xrTable5;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell58;
    private XRTable xrTable6;
    private XRTableRow xrTableRow16;
    private XRTableCell xrTableCell75;
    private XRTableCell xrTableCell113;
    private XRTableCell xrTableCell114;
    private XRTableCell xrTableCell115;
    private XRTableCell xrTableCell116;
    private XRTableCell xrTableCell117;
    private DetailReportBand BCM_Quality_Tables;
    private DetailBand Detail3;
    private XRPanel xrPanel1;
    private XRLabel xrLabel14;
    private XRLabel xrLabel13;
    private XRRichText xrRichText1;
    private XRLabel xrLabel10;
    private GroupHeaderBand GroupHeader3;
    private XRLabel xrLabel11;
    private XRLabel xrLabel6;
    private XRLabel xrLabel5;
    private XRLabel xrLabel9;
    private XRPanel xrPanel4;
    private XRRichText xrRichText2;
    private XRPanel xrPanel3;
    private XRLabel xrLabel2;
    private XRLabel xrLabel4;
    private XRPanel xrPanel2;
    private XRLabel xrLabel17;
    private XRLabel xrLabel18;
    private XRLabel xrLabel15;
    private XRChart xrChart1;
    private DetailReportBand DetailReport;
    private DetailBand Detail1;
    private XRTable xrTable3;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell119;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell69;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell79;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell89;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell99;
    private XRTableCell xrTableCell16;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell120;
    private XRTableCell xrTableCell59;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell70;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell80;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell90;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell100;
    private XRTableCell xrTableCell22;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell121;
    private XRTableCell xrTableCell60;
    private XRTableCell xrTableCell43;
    private XRTableCell xrTableCell71;
    private XRTableCell xrTableCell44;
    private XRTableCell xrTableCell81;
    private XRTableCell xrTableCell45;
    private XRTableCell xrTableCell91;
    private XRTableCell xrTableCell46;
    private XRTableCell xrTableCell101;
    private XRTableCell xrTableCell47;
    private XRTableRow xrTableRow13;
    private XRTableCell xrTableCell122;
    private XRTableCell xrTableCell61;
    private XRTableCell xrTableCell53;
    private XRTableCell xrTableCell72;
    private XRTableCell xrTableCell54;
    private XRTableCell xrTableCell82;
    private XRTableCell xrTableCell55;
    private XRTableCell xrTableCell92;
    private XRTableCell xrTableCell56;
    private XRTableCell xrTableCell102;
    private XRTableCell xrTableCell57;
    private XRTableRow xrTableRow10;
    private XRTableCell xrTableCell123;
    private XRTableCell xrTableCell63;
    private XRTableCell xrTableCell38;
    private XRTableCell xrTableCell73;
    private XRTableCell xrTableCell39;
    private XRTableCell xrTableCell83;
    private XRTableCell xrTableCell40;
    private XRTableCell xrTableCell93;
    private XRTableCell xrTableCell41;
    private XRTableCell xrTableCell103;
    private XRTableCell xrTableCell42;
    private XRTableRow xrTableRow12;
    private XRTableCell xrTableCell124;
    private XRTableCell xrTableCell64;
    private XRTableCell xrTableCell48;
    private XRTableCell xrTableCell74;
    private XRTableCell xrTableCell49;
    private XRTableCell xrTableCell84;
    private XRTableCell xrTableCell50;
    private XRTableCell xrTableCell94;
    private XRTableCell xrTableCell51;
    private XRTableCell xrTableCell104;
    private XRTableCell xrTableCell52;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell125;
    private XRTableCell xrTableCell65;
    private XRTableCell xrTableCell33;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell34;
    private XRTableCell xrTableCell85;
    private XRTableCell xrTableCell35;
    private XRTableCell xrTableCell95;
    private XRTableCell xrTableCell36;
    private XRTableCell xrTableCell105;
    private XRTableCell xrTableCell37;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell126;
    private XRTableCell xrTableCell66;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell76;
    private XRTableCell xrTableCell29;
    private XRTableCell xrTableCell86;
    private XRTableCell xrTableCell30;
    private XRTableCell xrTableCell96;
    private XRTableCell xrTableCell31;
    private XRTableCell xrTableCell106;
    private XRTableCell xrTableCell32;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell127;
    private XRTableCell xrTableCell67;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell77;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell87;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell97;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell107;
    private XRTableCell xrTableCell27;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell128;
    private XRTableCell xrTableCell68;
    private XRTableCell xrTableCell62;
    private XRTableCell xrTableCell78;
    private XRTableCell xrTableCell88;
    private XRTableCell xrTableCell98;
    private XRTableCell xrTableCell108;
    private XRTableCell xrTableCell109;
    private XRTableCell xrTableCell110;
    private XRTableCell xrTableCell111;
    private XRTableCell xrTableCell112;
    private GroupHeaderBand GroupHeader1;
    private XRTable xrTable1;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell129;
    private XRTableCell xrTableCell130;
    private XRTableCell xrTableCell131;
    private XRTableCell xrTableCell132;
    private XRTableCell xrTableCell133;
    private XRTableCell xrTableCell134;
    private XRPanel xrPanel5;
    private XRRichText xrRichText4;
    private XRLabel xrLabel22;
    private XRLabel xrLabel23;
    private XRLabel xrLabel24;
    private XRLabel xrLabel30;
    private GroupHeaderBand GroupHeader2;
    private XRLabel xrLabel27;
    private XRLabel xrLabel26;
    private XRLabel xrLabel21;
    private XRTable xrTable2;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell6;
    private XRTableRow xrTableRow17;
    private XRTableCell xrTableCell138;
    private XRTableCell xrTableCell139;
    private XRTableCell xrTableCell140;
    private XRTableRow xrTableRow20;
    private XRTableCell xrTableCell147;
    private XRTableCell xrTableCell148;
    private XRTableCell xrTableCell149;
    private XRTableRow xrTableRow21;
    private XRTableCell xrTableCell150;
    private XRTableCell xrTableCell151;
    private XRTableCell xrTableCell152;
    private XRTableRow xrTableRow19;
    private XRTableCell xrTableCell144;
    private XRTableCell xrTableCell145;
    private XRTableCell xrTableCell146;
    private XRTableRow xrTableRow18;
    private XRTableCell xrTableCell141;
    private XRTableCell xrTableCell142;
    private XRTableCell xrTableCell143;
    private XRTableRow xrTableRow15;
    private XRTableCell xrTableCell135;
    private XRTableCell xrTableCell136;
    private XRTableCell xrTableCell137;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell118;
    private XRLabel xrLabel20;
    private XRLabel xrLabel19;
    private XRRichText xrRichText3;
    private XRLabel xrLabel16;
    private XRLabel xrLabel28;
    private XRLabel xrLabel25;
    private XRLabel xrLabel29;
    private XRLabel xrLabel31;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private CalculatedField count_of_area_names;
    private CalculatedField count_of_bp_name;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public rep_pro_Business_Architecture_Analysis()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rep_pro_Business_Architecture_Analysis));
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table5 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column14 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression14 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column15 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression15 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column16 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression16 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table6 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column17 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression17 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table7 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column18 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression18 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column19 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression19 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column20 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression20 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join3 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo3 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join4 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo4 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Table table8 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Join join5 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo5 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join6 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo6 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join7 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo7 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel4 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrRichText2 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrPanel3 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrChart1 = new DevExpress.XtraReports.UI.XRChart();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell75 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell113 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell114 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell115 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell116 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell117 = new DevExpress.XtraReports.UI.XRTableCell();
            this.BCM_Quality_Tables = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail3 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPanel5 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText4 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader3 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell138 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell139 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell140 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow20 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell147 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell148 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell149 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow21 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell150 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell151 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell152 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow19 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell144 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell145 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell146 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow18 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell141 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell142 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell143 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell135 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell136 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell137 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell118 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText3 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell119 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell79 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell89 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell99 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell120 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell59 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell70 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell80 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell90 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell100 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell121 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell60 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell71 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell81 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell91 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell101 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell122 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell72 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell82 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell55 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell92 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell56 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell102 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell57 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell123 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell73 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell83 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell93 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell103 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell124 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell74 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell84 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell94 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell104 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell125 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell85 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell95 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell105 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell126 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell76 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell86 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell96 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell106 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell127 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell77 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell87 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell97 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell107 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell128 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell78 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell88 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell98 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell108 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell109 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell110 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell111 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell112 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell129 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell130 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell131 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell132 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell133 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell134 = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.count_of_area_names = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.count_of_bp_name = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 100F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 25F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 25F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.PageHeader.HeightF = 40.03378F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.xrLabel1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(1046.727F, 40.03378F);
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "PROJECT NAME FIELD";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.xrLabel7,
            this.xrPageInfo2,
            this.xrLabel8,
            this.xrLabel12});
            this.PageFooter.HeightF = 100F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(962.6459F, 48.69791F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(58.85419F, 35.50002F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(1.272771F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(197.2917F, 23.09373F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Generated by ReadyCert® for";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(1.272771F, 63.45831F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(269.2708F, 36.54169F);
            this.xrPageInfo2.StylePriority.UseFont = false;
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(834F, 48.69791F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(128.6458F, 35.50002F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "page";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel8.TextTrimming = System.Drawing.StringTrimming.None;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(1.272771F, 23.09373F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(424.7499F, 40.36459F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "CLIENT NAME";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 57.25121F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(498.6487F, 50.13517F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "Business Architecture Analysis";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel9,
            this.xrPanel4,
            this.xrPanel3,
            this.xrPanel2,
            this.xrLabel18,
            this.xrLabel15,
            this.xrChart1,
            this.xrLabel3});
            this.ReportHeader.HeightF = 607.2121F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            // 
            // xrLabel9
            // 
            this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[pro_name]")});
            this.xrLabel9.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(0.9998811F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(498.6487F, 50.13517F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = "Project Name Field";
            // 
            // xrPanel4
            // 
            this.xrPanel4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText2});
            this.xrPanel4.LocationFloat = new DevExpress.Utils.PointFloat(0.9998745F, 107.3864F);
            this.xrPanel4.Name = "xrPanel4";
            this.xrPanel4.SizeF = new System.Drawing.SizeF(497.6488F, 499.8257F);
            // 
            // xrRichText2
            // 
            this.xrRichText2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Rtf", "[pro_description]")});
            this.xrRichText2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.xrRichText2.LocationFloat = new DevExpress.Utils.PointFloat(9.000129F, 10.00002F);
            this.xrRichText2.Name = "xrRichText2";
            this.xrRichText2.SerializableRtfString = resources.GetString("xrRichText2.SerializableRtfString");
            this.xrRichText2.SizeF = new System.Drawing.SizeF(478.6487F, 475.8259F);
            // 
            // xrPanel3
            // 
            this.xrPanel3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel29,
            this.xrLabel2,
            this.xrLabel4});
            this.xrPanel3.LocationFloat = new DevExpress.Utils.PointFloat(569.8748F, 403.6706F);
            this.xrPanel3.Name = "xrPanel3";
            this.xrPanel3.SizeF = new System.Drawing.SizeF(239.3979F, 203.5415F);
            // 
            // xrLabel2
            // 
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(10.00006F, 46.54171F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(219.3979F, 23.00001F);
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "# of Business Areas in Project";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(9.999997F, 10.00006F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(220.0001F, 36.54165F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Business Areas";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrPanel2
            // 
            this.xrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel31,
            this.xrLabel11,
            this.xrLabel17});
            this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(809.2727F, 403.6706F);
            this.xrPanel2.Name = "xrPanel2";
            this.xrPanel2.SizeF = new System.Drawing.SizeF(238.7274F, 203.5415F);
            // 
            // xrLabel11
            // 
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(10.0001F, 46.54172F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(219.9999F, 22.99999F);
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "# of Business Processes in Project";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel17
            // 
            this.xrLabel17.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(10.00006F, 9.999997F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(220F, 36.54168F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Business Processes";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel18
            // 
            this.xrLabel18.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(569.8748F, 0F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(478.1251F, 36.54169F);
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "Business Capability Qualities";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel15
            // 
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(569.8748F, 342.7917F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(479.1253F, 60.87881F);
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "DELETEME: Pie chart = count all business capabilities, sum; level 1-5 scores repr" +
    "esented as % of whole.";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrChart1
            // 
            this.xrChart1.BorderColor = System.Drawing.Color.Black;
            this.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrChart1.Legend.Name = "Default Legend";
            this.xrChart1.LocationFloat = new DevExpress.Utils.PointFloat(569.8748F, 36.54168F);
            this.xrChart1.Name = "xrChart1";
            series1.Name = "Series 1";
            series1.View = pieSeriesView1;
            this.xrChart1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.xrChart1.SizeF = new System.Drawing.SizeF(478.125F, 306.25F);
            // 
            // xrTable5
            // 
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(0.9998786F, 0F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable5.SizeF = new System.Drawing.SizeF(1048F, 23.48144F);
            this.xrTable5.StylePriority.UseTextAlignment = false;
            this.xrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell9,
            this.xrTableCell11,
            this.xrTableCell58});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseBackColor = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "BUSINESS PROCESS NAME";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell3.Weight = 1D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrTableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseBackColor = false;
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "Level 1";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell4.Weight = 1D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrTableCell5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseBackColor = false;
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "Level 2";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell5.Weight = 1D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrTableCell9.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.StylePriority.UseBackColor = false;
            this.xrTableCell9.StylePriority.UseBorders = false;
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.StylePriority.UseTextAlignment = false;
            this.xrTableCell9.Text = "Level 3";
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell9.Weight = 1D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrTableCell11.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StylePriority.UseBackColor = false;
            this.xrTableCell11.StylePriority.UseBorders = false;
            this.xrTableCell11.StylePriority.UseFont = false;
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            this.xrTableCell11.Text = "Level 4";
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell11.Weight = 1D;
            // 
            // xrTableCell58
            // 
            this.xrTableCell58.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrTableCell58.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell58.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell58.Name = "xrTableCell58";
            this.xrTableCell58.StylePriority.UseBackColor = false;
            this.xrTableCell58.StylePriority.UseBorders = false;
            this.xrTableCell58.StylePriority.UseFont = false;
            this.xrTableCell58.StylePriority.UseTextAlignment = false;
            this.xrTableCell58.Text = "Level 5";
            this.xrTableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell58.Weight = 1D;
            // 
            // xrTable6
            // 
            this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(0.9998786F, 0F);
            this.xrTable6.Name = "xrTable6";
            this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow16});
            this.xrTable6.SizeF = new System.Drawing.SizeF(1048F, 254.2506F);
            this.xrTable6.StylePriority.UseTextAlignment = false;
            this.xrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow16
            // 
            this.xrTableRow16.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell75,
            this.xrTableCell113,
            this.xrTableCell114,
            this.xrTableCell115,
            this.xrTableCell116,
            this.xrTableCell117});
            this.xrTableRow16.Name = "xrTableRow16";
            this.xrTableRow16.StylePriority.UseBorders = false;
            this.xrTableRow16.Weight = 1D;
            // 
            // xrTableCell75
            // 
            this.xrTableCell75.BackColor = System.Drawing.Color.AliceBlue;
            this.xrTableCell75.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell75.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell75.Multiline = true;
            this.xrTableCell75.Name = "xrTableCell75";
            this.xrTableCell75.StylePriority.UseBackColor = false;
            this.xrTableCell75.StylePriority.UseBorderColor = false;
            this.xrTableCell75.StylePriority.UseBorders = false;
            this.xrTableCell75.Text = "CAPABILITY\r\nQUALITY\r\nSTANDARD\r\nTITLE\r\nFIELD";
            this.xrTableCell75.Weight = 1D;
            // 
            // xrTableCell113
            // 
            this.xrTableCell113.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell113.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell113.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell113.Multiline = true;
            this.xrTableCell113.Name = "xrTableCell113";
            this.xrTableCell113.StylePriority.UseBackColor = false;
            this.xrTableCell113.StylePriority.UseBorderColor = false;
            this.xrTableCell113.StylePriority.UseBorders = false;
            this.xrTableCell113.Text = "CAPABILITY\r\nDESCRIPTION\r\nFIELD";
            this.xrTableCell113.Weight = 1D;
            // 
            // xrTableCell114
            // 
            this.xrTableCell114.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell114.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell114.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell114.Multiline = true;
            this.xrTableCell114.Name = "xrTableCell114";
            this.xrTableCell114.StylePriority.UseBackColor = false;
            this.xrTableCell114.StylePriority.UseBorderColor = false;
            this.xrTableCell114.StylePriority.UseBorders = false;
            this.xrTableCell114.Text = "CAPABILITY\r\nDESCRIPTION\r\nFIELD";
            this.xrTableCell114.Weight = 1D;
            // 
            // xrTableCell115
            // 
            this.xrTableCell115.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell115.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell115.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell115.Multiline = true;
            this.xrTableCell115.Name = "xrTableCell115";
            this.xrTableCell115.StylePriority.UseBackColor = false;
            this.xrTableCell115.StylePriority.UseBorderColor = false;
            this.xrTableCell115.StylePriority.UseBorders = false;
            this.xrTableCell115.Text = "CAPABILITY\r\nDESCRIPTION\r\nFIELD";
            this.xrTableCell115.Weight = 1D;
            // 
            // xrTableCell116
            // 
            this.xrTableCell116.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell116.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell116.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell116.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.xrTableCell116.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell116.Multiline = true;
            this.xrTableCell116.Name = "xrTableCell116";
            this.xrTableCell116.StylePriority.UseBackColor = false;
            this.xrTableCell116.StylePriority.UseBorderColor = false;
            this.xrTableCell116.StylePriority.UseBorders = false;
            this.xrTableCell116.StylePriority.UseFont = false;
            this.xrTableCell116.StylePriority.UseForeColor = false;
            this.xrTableCell116.Text = "CAPABILITY\r\nDESCRIPTION\r\nFIELD";
            this.xrTableCell116.Weight = 1D;
            // 
            // xrTableCell117
            // 
            this.xrTableCell117.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell117.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell117.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell117.Multiline = true;
            this.xrTableCell117.Name = "xrTableCell117";
            this.xrTableCell117.StylePriority.UseBackColor = false;
            this.xrTableCell117.StylePriority.UseBorderColor = false;
            this.xrTableCell117.StylePriority.UseBorders = false;
            this.xrTableCell117.Text = "CAPABILITY\r\nDESCRIPTION\r\nFIELD";
            this.xrTableCell117.Weight = 1D;
            // 
            // BCM_Quality_Tables
            // 
            this.BCM_Quality_Tables.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail3,
            this.GroupHeader3,
            this.GroupHeader2});
            this.BCM_Quality_Tables.DataSource = this.sqlDataSource1;
            this.BCM_Quality_Tables.Level = 0;
            this.BCM_Quality_Tables.Name = "BCM_Quality_Tables";
            this.BCM_Quality_Tables.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            // 
            // Detail3
            // 
            this.Detail3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel5,
            this.xrTable6,
            this.xrPanel1});
            this.Detail3.HeightF = 491.0159F;
            this.Detail3.Name = "Detail3";
            // 
            // xrPanel5
            // 
            this.xrPanel5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel25,
            this.xrRichText4,
            this.xrLabel22,
            this.xrLabel23,
            this.xrLabel24,
            this.xrLabel30});
            this.xrPanel5.LocationFloat = new DevExpress.Utils.PointFloat(1.272768F, 266.7249F);
            this.xrPanel5.Name = "xrPanel5";
            this.xrPanel5.SizeF = new System.Drawing.SizeF(498.6486F, 224.291F);
            this.xrPanel5.StylePriority.UseBackColor = false;
            this.xrPanel5.StylePriority.UseBorders = false;
            // 
            // xrLabel25
            // 
            this.xrLabel25.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(12.36975F, 153.5409F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(163.2969F, 44.33301F);
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UsePadding = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.Text = "Level 2";
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrRichText4
            // 
            this.xrRichText4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrRichText4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrRichText4.LocationFloat = new DevExpress.Utils.PointFloat(175.6666F, 9.999974F);
            this.xrRichText4.Name = "xrRichText4";
            this.xrRichText4.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 8, 8, 8, 100F);
            this.xrRichText4.SerializableRtfString = resources.GetString("xrRichText4.SerializableRtfString");
            this.xrRichText4.SizeF = new System.Drawing.SizeF(312.7092F, 200.1448F);
            this.xrRichText4.StylePriority.UseBorders = false;
            this.xrRichText4.StylePriority.UseFont = false;
            this.xrRichText4.StylePriority.UsePadding = false;
            // 
            // xrLabel22
            // 
            this.xrLabel22.BackColor = System.Drawing.Color.LightCyan;
            this.xrLabel22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(11.99981F, 61.1249F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(163.6668F, 24.04148F);
            this.xrLabel22.StylePriority.UseBackColor = false;
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UsePadding = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "Milestone";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel23
            // 
            this.xrLabel23.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(11.99981F, 85.1664F);
            this.xrLabel23.Multiline = true;
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(163.6668F, 44.33302F);
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UsePadding = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.Text = "MILESTONE x > Title";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel24
            // 
            this.xrLabel24.BackColor = System.Drawing.Color.LightCyan;
            this.xrLabel24.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(11.99982F, 129.4994F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(163.6668F, 24.04147F);
            this.xrLabel24.StylePriority.UseBackColor = false;
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.StylePriority.UsePadding = false;
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            this.xrLabel24.Text = "Assessment";
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel30
            // 
            this.xrLabel30.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(11.99975F, 10.00002F);
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(163.6668F, 51.12489F);
            this.xrLabel30.StylePriority.UseFont = false;
            this.xrLabel30.StylePriority.UsePadding = false;
            this.xrLabel30.StylePriority.UseTextAlignment = false;
            this.xrLabel30.Text = "Capability Assessment Description:";
            this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrPanel1
            // 
            this.xrPanel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel14,
            this.xrLabel13,
            this.xrRichText1,
            this.xrLabel10});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(549.0781F, 266.7249F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(497.6488F, 224.291F);
            this.xrPanel1.StylePriority.UseBorders = false;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(9.999984F, 153.5409F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(164.9395F, 44.33299F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Level 2";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BackColor = System.Drawing.Color.LightCyan;
            this.xrLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(9.999984F, 129.4994F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(164.9395F, 24.04146F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Assessment";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(9.999984F, 85.16634F);
            this.xrLabel14.Multiline = true;
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(164.9395F, 44.33298F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UsePadding = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "MILESTONE y > Title";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel13
            // 
            this.xrLabel13.BackColor = System.Drawing.Color.LightCyan;
            this.xrLabel13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(9.999984F, 61.12485F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(164.9395F, 24.0415F);
            this.xrLabel13.StylePriority.UseBackColor = false;
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UsePadding = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "Milestone";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrRichText1
            // 
            this.xrRichText1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrRichText1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(174.9395F, 9.999974F);
            this.xrRichText1.Name = "xrRichText1";
            this.xrRichText1.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 8, 8, 8, 100F);
            this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
            this.xrRichText1.SizeF = new System.Drawing.SizeF(312.7093F, 199.2334F);
            this.xrRichText1.StylePriority.UseBorders = false;
            this.xrRichText1.StylePriority.UsePadding = false;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(9.999984F, 9.999984F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(164.9395F, 51.12486F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UsePadding = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Capability Assessment Description:";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // GroupHeader3
            // 
            this.GroupHeader3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable5});
            this.GroupHeader3.HeightF = 23.48144F;
            this.GroupHeader3.Name = "GroupHeader3";
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel28,
            this.xrLabel27,
            this.xrLabel26,
            this.xrLabel21,
            this.xrTable2,
            this.xrLabel20,
            this.xrLabel19,
            this.xrRichText3,
            this.xrLabel16});
            this.GroupHeader2.Expanded = false;
            this.GroupHeader2.HeightF = 462.724F;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            this.GroupHeader2.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            // 
            // xrLabel28
            // 
            this.xrLabel28.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel28.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(13.64252F, 0F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 8, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(124.5864F, 50.12659F);
            this.xrLabel28.StylePriority.UseBackColor = false;
            this.xrLabel28.StylePriority.UseBorders = false;
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UsePadding = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.Text = "BA Uniq ID";
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel27
            // 
            this.xrLabel27.BackColor = System.Drawing.Color.AliceBlue;
            this.xrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel27.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(725.8002F, 219.3631F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(291.6056F, 30.12352F);
            this.xrLabel27.StylePriority.UseBackColor = false;
            this.xrLabel27.StylePriority.UseBorders = false;
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UsePadding = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            this.xrLabel27.Text = "Artifact Reference";
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel26
            // 
            this.xrLabel26.BackColor = System.Drawing.Color.AliceBlue;
            this.xrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel26.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(433.1945F, 219.3631F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(291.6056F, 30.12352F);
            this.xrLabel26.StylePriority.UseBackColor = false;
            this.xrLabel26.StylePriority.UseBorders = false;
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.StylePriority.UsePadding = false;
            this.xrLabel26.StylePriority.UseTextAlignment = false;
            this.xrLabel26.Text = "Artifact Categorization";
            this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel21
            // 
            this.xrLabel21.BackColor = System.Drawing.Color.AliceBlue;
            this.xrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(141.5889F, 219.3631F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(291.6056F, 30.12352F);
            this.xrLabel21.StylePriority.UseBackColor = false;
            this.xrLabel21.StylePriority.UseBorders = false;
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UsePadding = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "Associated Artifacts";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrTable2
            // 
            this.xrTable2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(141.5889F, 249.4866F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow17,
            this.xrTableRow20,
            this.xrTableRow21,
            this.xrTableRow19,
            this.xrTableRow18,
            this.xrTableRow15,
            this.xrTableRow14});
            this.xrTable2.SizeF = new System.Drawing.SizeF(874.8169F, 213.2374F);
            this.xrTable2.StylePriority.UseFont = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell6});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "ARTIFACT NAME";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell1.Weight = 1D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "ARTIFACT TYPE/CATEGORY";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell2.Weight = 1D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.Text = "PAGE REF";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell6.Weight = 1D;
            // 
            // xrTableRow17
            // 
            this.xrTableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell138,
            this.xrTableCell139,
            this.xrTableCell140});
            this.xrTableRow17.Name = "xrTableRow17";
            this.xrTableRow17.Weight = 1D;
            // 
            // xrTableCell138
            // 
            this.xrTableCell138.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell138.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell138.Name = "xrTableCell138";
            this.xrTableCell138.StylePriority.UseBorders = false;
            this.xrTableCell138.StylePriority.UseFont = false;
            this.xrTableCell138.StylePriority.UseTextAlignment = false;
            this.xrTableCell138.Text = "  ";
            this.xrTableCell138.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell138.Weight = 1D;
            // 
            // xrTableCell139
            // 
            this.xrTableCell139.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell139.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell139.Name = "xrTableCell139";
            this.xrTableCell139.StylePriority.UseBorders = false;
            this.xrTableCell139.StylePriority.UseFont = false;
            this.xrTableCell139.StylePriority.UseTextAlignment = false;
            this.xrTableCell139.Text = " ";
            this.xrTableCell139.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell139.Weight = 1D;
            // 
            // xrTableCell140
            // 
            this.xrTableCell140.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell140.Name = "xrTableCell140";
            this.xrTableCell140.StylePriority.UseFont = false;
            this.xrTableCell140.StylePriority.UseTextAlignment = false;
            this.xrTableCell140.Text = " ";
            this.xrTableCell140.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell140.Weight = 1D;
            // 
            // xrTableRow20
            // 
            this.xrTableRow20.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell147,
            this.xrTableCell148,
            this.xrTableCell149});
            this.xrTableRow20.Name = "xrTableRow20";
            this.xrTableRow20.Weight = 1D;
            // 
            // xrTableCell147
            // 
            this.xrTableCell147.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell147.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell147.Name = "xrTableCell147";
            this.xrTableCell147.StylePriority.UseBorders = false;
            this.xrTableCell147.StylePriority.UseFont = false;
            this.xrTableCell147.StylePriority.UseTextAlignment = false;
            this.xrTableCell147.Text = " ";
            this.xrTableCell147.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell147.Weight = 1D;
            // 
            // xrTableCell148
            // 
            this.xrTableCell148.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell148.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell148.Name = "xrTableCell148";
            this.xrTableCell148.StylePriority.UseBorders = false;
            this.xrTableCell148.StylePriority.UseFont = false;
            this.xrTableCell148.StylePriority.UseTextAlignment = false;
            this.xrTableCell148.Text = " ";
            this.xrTableCell148.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell148.Weight = 1D;
            // 
            // xrTableCell149
            // 
            this.xrTableCell149.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell149.Name = "xrTableCell149";
            this.xrTableCell149.StylePriority.UseFont = false;
            this.xrTableCell149.StylePriority.UseTextAlignment = false;
            this.xrTableCell149.Text = " ";
            this.xrTableCell149.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell149.Weight = 1D;
            // 
            // xrTableRow21
            // 
            this.xrTableRow21.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell150,
            this.xrTableCell151,
            this.xrTableCell152});
            this.xrTableRow21.Name = "xrTableRow21";
            this.xrTableRow21.Weight = 1D;
            // 
            // xrTableCell150
            // 
            this.xrTableCell150.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell150.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell150.Name = "xrTableCell150";
            this.xrTableCell150.StylePriority.UseBorders = false;
            this.xrTableCell150.StylePriority.UseFont = false;
            this.xrTableCell150.StylePriority.UseTextAlignment = false;
            this.xrTableCell150.Text = " ";
            this.xrTableCell150.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell150.Weight = 1D;
            // 
            // xrTableCell151
            // 
            this.xrTableCell151.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell151.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell151.Name = "xrTableCell151";
            this.xrTableCell151.StylePriority.UseBorders = false;
            this.xrTableCell151.StylePriority.UseFont = false;
            this.xrTableCell151.StylePriority.UseTextAlignment = false;
            this.xrTableCell151.Text = " ";
            this.xrTableCell151.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell151.Weight = 1D;
            // 
            // xrTableCell152
            // 
            this.xrTableCell152.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell152.Name = "xrTableCell152";
            this.xrTableCell152.StylePriority.UseFont = false;
            this.xrTableCell152.StylePriority.UseTextAlignment = false;
            this.xrTableCell152.Text = " ";
            this.xrTableCell152.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell152.Weight = 1D;
            // 
            // xrTableRow19
            // 
            this.xrTableRow19.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell144,
            this.xrTableCell145,
            this.xrTableCell146});
            this.xrTableRow19.Name = "xrTableRow19";
            this.xrTableRow19.Weight = 1D;
            // 
            // xrTableCell144
            // 
            this.xrTableCell144.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell144.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell144.Name = "xrTableCell144";
            this.xrTableCell144.StylePriority.UseBorders = false;
            this.xrTableCell144.StylePriority.UseFont = false;
            this.xrTableCell144.StylePriority.UseTextAlignment = false;
            this.xrTableCell144.Text = " ";
            this.xrTableCell144.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell144.Weight = 1D;
            // 
            // xrTableCell145
            // 
            this.xrTableCell145.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell145.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell145.Name = "xrTableCell145";
            this.xrTableCell145.StylePriority.UseBorders = false;
            this.xrTableCell145.StylePriority.UseFont = false;
            this.xrTableCell145.StylePriority.UseTextAlignment = false;
            this.xrTableCell145.Text = " ";
            this.xrTableCell145.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell145.Weight = 1D;
            // 
            // xrTableCell146
            // 
            this.xrTableCell146.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell146.Name = "xrTableCell146";
            this.xrTableCell146.StylePriority.UseFont = false;
            this.xrTableCell146.StylePriority.UseTextAlignment = false;
            this.xrTableCell146.Text = " ";
            this.xrTableCell146.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell146.Weight = 1D;
            // 
            // xrTableRow18
            // 
            this.xrTableRow18.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell141,
            this.xrTableCell142,
            this.xrTableCell143});
            this.xrTableRow18.Name = "xrTableRow18";
            this.xrTableRow18.Weight = 1D;
            // 
            // xrTableCell141
            // 
            this.xrTableCell141.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell141.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell141.Name = "xrTableCell141";
            this.xrTableCell141.StylePriority.UseBorders = false;
            this.xrTableCell141.StylePriority.UseFont = false;
            this.xrTableCell141.StylePriority.UseTextAlignment = false;
            this.xrTableCell141.Text = " ";
            this.xrTableCell141.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell141.Weight = 1D;
            // 
            // xrTableCell142
            // 
            this.xrTableCell142.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell142.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell142.Name = "xrTableCell142";
            this.xrTableCell142.StylePriority.UseBorders = false;
            this.xrTableCell142.StylePriority.UseFont = false;
            this.xrTableCell142.StylePriority.UseTextAlignment = false;
            this.xrTableCell142.Text = " ";
            this.xrTableCell142.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell142.Weight = 1D;
            // 
            // xrTableCell143
            // 
            this.xrTableCell143.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell143.Name = "xrTableCell143";
            this.xrTableCell143.StylePriority.UseFont = false;
            this.xrTableCell143.StylePriority.UseTextAlignment = false;
            this.xrTableCell143.Text = " ";
            this.xrTableCell143.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell143.Weight = 1D;
            // 
            // xrTableRow15
            // 
            this.xrTableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell135,
            this.xrTableCell136,
            this.xrTableCell137});
            this.xrTableRow15.Name = "xrTableRow15";
            this.xrTableRow15.Weight = 1D;
            // 
            // xrTableCell135
            // 
            this.xrTableCell135.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell135.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell135.Name = "xrTableCell135";
            this.xrTableCell135.StylePriority.UseBorders = false;
            this.xrTableCell135.StylePriority.UseFont = false;
            this.xrTableCell135.StylePriority.UseTextAlignment = false;
            this.xrTableCell135.Text = " ";
            this.xrTableCell135.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell135.Weight = 1D;
            // 
            // xrTableCell136
            // 
            this.xrTableCell136.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell136.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell136.Name = "xrTableCell136";
            this.xrTableCell136.StylePriority.UseBorders = false;
            this.xrTableCell136.StylePriority.UseFont = false;
            this.xrTableCell136.StylePriority.UseTextAlignment = false;
            this.xrTableCell136.Text = " ";
            this.xrTableCell136.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell136.Weight = 1D;
            // 
            // xrTableCell137
            // 
            this.xrTableCell137.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell137.Name = "xrTableCell137";
            this.xrTableCell137.StylePriority.UseFont = false;
            this.xrTableCell137.StylePriority.UseTextAlignment = false;
            this.xrTableCell137.Text = " ";
            this.xrTableCell137.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell137.Weight = 1D;
            // 
            // xrTableRow14
            // 
            this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell118});
            this.xrTableRow14.Name = "xrTableRow14";
            this.xrTableRow14.Weight = 1D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseBorders = false;
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = " ";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell7.Weight = 1D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseBorders = false;
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.Text = " ";
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell8.Weight = 1D;
            // 
            // xrTableCell118
            // 
            this.xrTableCell118.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrTableCell118.Name = "xrTableCell118";
            this.xrTableCell118.StylePriority.UseFont = false;
            this.xrTableCell118.StylePriority.UseTextAlignment = false;
            this.xrTableCell118.Text = " ";
            this.xrTableCell118.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell118.Weight = 1D;
            // 
            // xrLabel20
            // 
            this.xrLabel20.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrLabel20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(1.177377E-05F, 249.4866F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 8, 3, 3, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(141.5889F, 83.43289F);
            this.xrLabel20.StylePriority.UseBackColor = false;
            this.xrLabel20.StylePriority.UseBorders = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UsePadding = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "List of Associated Artifacts";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel19
            // 
            this.xrLabel19.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrLabel19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(0F, 88.72536F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 8, 3, 3, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(141.5889F, 86.9365F);
            this.xrLabel19.StylePriority.UseBackColor = false;
            this.xrLabel19.StylePriority.UseBorders = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UsePadding = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Business Area Description";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrRichText3
            // 
            this.xrRichText3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.xrRichText3.LocationFloat = new DevExpress.Utils.PointFloat(142.589F, 88.72536F);
            this.xrRichText3.Name = "xrRichText3";
            this.xrRichText3.Padding = new DevExpress.XtraPrinting.PaddingInfo(12, 0, 6, 0, 100F);
            this.xrRichText3.SerializableRtfString = resources.GetString("xrRichText3.SerializableRtfString");
            this.xrRichText3.SizeF = new System.Drawing.SizeF(874.8169F, 130.6377F);
            this.xrRichText3.StylePriority.UsePadding = false;
            // 
            // xrLabel16
            // 
            this.xrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.xrLabel16.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(138.2289F, 0F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(901.0439F, 50.12657F);
            this.xrLabel16.StylePriority.UseBackColor = false;
            this.xrLabel16.StylePriority.UseBorders = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UsePadding = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "BA NAME";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.GroupHeader1});
            this.DetailReport.DataSource = this.sqlDataSource1;
            this.DetailReport.Level = 1;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
            this.Detail1.HeightF = 459.1734F;
            this.Detail1.Name = "Detail1";
            // 
            // xrTable3
            // 
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(1.272771F, 0F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4,
            this.xrTableRow6,
            this.xrTableRow11,
            this.xrTableRow13,
            this.xrTableRow10,
            this.xrTableRow12,
            this.xrTableRow9,
            this.xrTableRow8,
            this.xrTableRow7,
            this.xrTableRow5});
            this.xrTable3.SizeF = new System.Drawing.SizeF(1047.727F, 459.1734F);
            this.xrTable3.StylePriority.UseTextAlignment = false;
            this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell119,
            this.xrTableCell10,
            this.xrTableCell12,
            this.xrTableCell69,
            this.xrTableCell13,
            this.xrTableCell79,
            this.xrTableCell14,
            this.xrTableCell89,
            this.xrTableCell15,
            this.xrTableCell99,
            this.xrTableCell16});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.StylePriority.UseBorders = false;
            this.xrTableRow4.Weight = 1D;
            // 
            // xrTableCell119
            // 
            this.xrTableCell119.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell119.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell119.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell119.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.xrTableCell119.Multiline = true;
            this.xrTableCell119.Name = "xrTableCell119";
            this.xrTableCell119.StylePriority.UseBackColor = false;
            this.xrTableCell119.StylePriority.UseBorderColor = false;
            this.xrTableCell119.StylePriority.UseBorders = false;
            this.xrTableCell119.StylePriority.UseFont = false;
            this.xrTableCell119.Text = "Capability Quality - Title / Definition";
            this.xrTableCell119.Weight = 0.90247813953908973D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell10.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell10.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseBackColor = false;
            this.xrTableCell10.StylePriority.UseBorderColor = false;
            this.xrTableCell10.StylePriority.UseBorders = false;
            this.xrTableCell10.Text = " ";
            this.xrTableCell10.Weight = 0.47254745850764412D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell12.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell12.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.StylePriority.UseBackColor = false;
            this.xrTableCell12.StylePriority.UseBorderColor = false;
            this.xrTableCell12.StylePriority.UseBorders = false;
            this.xrTableCell12.Text = " ";
            this.xrTableCell12.Weight = 0.45835886234442075D;
            // 
            // xrTableCell69
            // 
            this.xrTableCell69.BackColor = System.Drawing.Color.LightCyan;
            this.xrTableCell69.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell69.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell69.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell69.Multiline = true;
            this.xrTableCell69.Name = "xrTableCell69";
            this.xrTableCell69.StylePriority.UseBackColor = false;
            this.xrTableCell69.StylePriority.UseBorderColor = false;
            this.xrTableCell69.StylePriority.UseBorders = false;
            this.xrTableCell69.StylePriority.UseFont = false;
            this.xrTableCell69.Text = "Milestone\r\nAs-Is";
            this.xrTableCell69.Weight = 0.4583588420035617D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell13.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell13.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.StylePriority.UseBackColor = false;
            this.xrTableCell13.StylePriority.UseBorderColor = false;
            this.xrTableCell13.StylePriority.UseBorders = false;
            this.xrTableCell13.Text = " ";
            this.xrTableCell13.Weight = 0.45835884200356181D;
            // 
            // xrTableCell79
            // 
            this.xrTableCell79.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell79.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell79.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell79.Name = "xrTableCell79";
            this.xrTableCell79.StylePriority.UseBackColor = false;
            this.xrTableCell79.StylePriority.UseBorderColor = false;
            this.xrTableCell79.StylePriority.UseBorders = false;
            this.xrTableCell79.Text = " ";
            this.xrTableCell79.Weight = 0.45835886234442191D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell14.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell14.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.StylePriority.UseBackColor = false;
            this.xrTableCell14.StylePriority.UseBorderColor = false;
            this.xrTableCell14.StylePriority.UseBorders = false;
            this.xrTableCell14.Text = " ";
            this.xrTableCell14.Weight = 0.45835886234442064D;
            // 
            // xrTableCell89
            // 
            this.xrTableCell89.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell89.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell89.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell89.Name = "xrTableCell89";
            this.xrTableCell89.StylePriority.UseBackColor = false;
            this.xrTableCell89.StylePriority.UseBorderColor = false;
            this.xrTableCell89.StylePriority.UseBorders = false;
            this.xrTableCell89.Text = " ";
            this.xrTableCell89.Weight = 0.45835886234442069D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.BackColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell15.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell15.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell15.ForeColor = System.Drawing.Color.White;
            this.xrTableCell15.Multiline = true;
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.StylePriority.UseBackColor = false;
            this.xrTableCell15.StylePriority.UseBorderColor = false;
            this.xrTableCell15.StylePriority.UseBorders = false;
            this.xrTableCell15.StylePriority.UseFont = false;
            this.xrTableCell15.StylePriority.UseForeColor = false;
            this.xrTableCell15.Text = "Milestone \r\nTo-Be";
            this.xrTableCell15.Weight = 0.45835886234442069D;
            // 
            // xrTableCell99
            // 
            this.xrTableCell99.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell99.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell99.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell99.Name = "xrTableCell99";
            this.xrTableCell99.StylePriority.UseBackColor = false;
            this.xrTableCell99.StylePriority.UseBorderColor = false;
            this.xrTableCell99.StylePriority.UseBorders = false;
            this.xrTableCell99.Text = " ";
            this.xrTableCell99.Weight = 0.45835884200356114D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell16.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell16.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.StylePriority.UseBackColor = false;
            this.xrTableCell16.StylePriority.UseBorderColor = false;
            this.xrTableCell16.StylePriority.UseBorders = false;
            this.xrTableCell16.Text = " ";
            this.xrTableCell16.Weight = 0.45835888268533936D;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell120,
            this.xrTableCell59,
            this.xrTableCell18,
            this.xrTableCell70,
            this.xrTableCell19,
            this.xrTableCell80,
            this.xrTableCell20,
            this.xrTableCell90,
            this.xrTableCell21,
            this.xrTableCell100,
            this.xrTableCell22});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.StylePriority.UseBorders = false;
            this.xrTableRow6.Weight = 1D;
            // 
            // xrTableCell120
            // 
            this.xrTableCell120.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell120.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell120.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell120.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.xrTableCell120.Name = "xrTableCell120";
            this.xrTableCell120.StylePriority.UseBackColor = false;
            this.xrTableCell120.StylePriority.UseBorderColor = false;
            this.xrTableCell120.StylePriority.UseBorders = false;
            this.xrTableCell120.StylePriority.UseFont = false;
            this.xrTableCell120.Text = "Capability Quality - Title / Definition";
            this.xrTableCell120.Weight = 0.90247813953908973D;
            // 
            // xrTableCell59
            // 
            this.xrTableCell59.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell59.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell59.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell59.Name = "xrTableCell59";
            this.xrTableCell59.StylePriority.UseBackColor = false;
            this.xrTableCell59.StylePriority.UseBorderColor = false;
            this.xrTableCell59.StylePriority.UseBorders = false;
            this.xrTableCell59.Text = " ";
            this.xrTableCell59.Weight = 0.47254742152427814D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell18.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell18.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.StylePriority.UseBackColor = false;
            this.xrTableCell18.StylePriority.UseBorderColor = false;
            this.xrTableCell18.StylePriority.UseBorders = false;
            this.xrTableCell18.Text = " ";
            this.xrTableCell18.Weight = 0.45835884385278358D;
            // 
            // xrTableCell70
            // 
            this.xrTableCell70.BackColor = System.Drawing.Color.LightCyan;
            this.xrTableCell70.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell70.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell70.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell70.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell70.Multiline = true;
            this.xrTableCell70.Name = "xrTableCell70";
            this.xrTableCell70.StylePriority.UseBackColor = false;
            this.xrTableCell70.StylePriority.UseBorderColor = false;
            this.xrTableCell70.StylePriority.UseBorders = false;
            this.xrTableCell70.StylePriority.UseFont = false;
            this.xrTableCell70.StylePriority.UseForeColor = false;
            this.xrTableCell70.Text = "Milestone\r\nAs-Is";
            this.xrTableCell70.Weight = 0.45835884385278364D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell19.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell19.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.StylePriority.UseBackColor = false;
            this.xrTableCell19.StylePriority.UseBorderColor = false;
            this.xrTableCell19.StylePriority.UseBorders = false;
            this.xrTableCell19.Text = " ";
            this.xrTableCell19.Weight = 0.45835884385278358D;
            // 
            // xrTableCell80
            // 
            this.xrTableCell80.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell80.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell80.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell80.Name = "xrTableCell80";
            this.xrTableCell80.StylePriority.UseBackColor = false;
            this.xrTableCell80.StylePriority.UseBorderColor = false;
            this.xrTableCell80.StylePriority.UseBorders = false;
            this.xrTableCell80.Text = " ";
            this.xrTableCell80.Weight = 0.45835884385278358D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.BackColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell20.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell20.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell20.ForeColor = System.Drawing.Color.White;
            this.xrTableCell20.Multiline = true;
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.StylePriority.UseBackColor = false;
            this.xrTableCell20.StylePriority.UseBorderColor = false;
            this.xrTableCell20.StylePriority.UseBorders = false;
            this.xrTableCell20.StylePriority.UseFont = false;
            this.xrTableCell20.StylePriority.UseForeColor = false;
            this.xrTableCell20.Text = "Milestone \r\nTo-Be";
            this.xrTableCell20.Weight = 0.45835884385278364D;
            // 
            // xrTableCell90
            // 
            this.xrTableCell90.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell90.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell90.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell90.Name = "xrTableCell90";
            this.xrTableCell90.StylePriority.UseBackColor = false;
            this.xrTableCell90.StylePriority.UseBorderColor = false;
            this.xrTableCell90.StylePriority.UseBorders = false;
            this.xrTableCell90.Text = " ";
            this.xrTableCell90.Weight = 0.45835884385278358D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell21.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell21.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.StylePriority.UseBackColor = false;
            this.xrTableCell21.StylePriority.UseBorderColor = false;
            this.xrTableCell21.StylePriority.UseBorders = false;
            this.xrTableCell21.Text = " ";
            this.xrTableCell21.Weight = 0.45835884385278358D;
            // 
            // xrTableCell100
            // 
            this.xrTableCell100.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell100.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell100.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell100.Name = "xrTableCell100";
            this.xrTableCell100.StylePriority.UseBackColor = false;
            this.xrTableCell100.StylePriority.UseBorderColor = false;
            this.xrTableCell100.StylePriority.UseBorders = false;
            this.xrTableCell100.Text = " ";
            this.xrTableCell100.Weight = 0.45835884385278358D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell22.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell22.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.StylePriority.UseBackColor = false;
            this.xrTableCell22.StylePriority.UseBorderColor = false;
            this.xrTableCell22.StylePriority.UseBorders = false;
            this.xrTableCell22.Text = " ";
            this.xrTableCell22.Weight = 0.45835900657922568D;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell121,
            this.xrTableCell60,
            this.xrTableCell43,
            this.xrTableCell71,
            this.xrTableCell44,
            this.xrTableCell81,
            this.xrTableCell45,
            this.xrTableCell91,
            this.xrTableCell46,
            this.xrTableCell101,
            this.xrTableCell47});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.StylePriority.UseBorders = false;
            this.xrTableRow11.Weight = 1D;
            // 
            // xrTableCell121
            // 
            this.xrTableCell121.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell121.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell121.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell121.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.xrTableCell121.Name = "xrTableCell121";
            this.xrTableCell121.StylePriority.UseBackColor = false;
            this.xrTableCell121.StylePriority.UseBorderColor = false;
            this.xrTableCell121.StylePriority.UseBorders = false;
            this.xrTableCell121.StylePriority.UseFont = false;
            this.xrTableCell121.Text = "Capability Quality - Title / Definition";
            this.xrTableCell121.Weight = 0.90247813953908973D;
            // 
            // xrTableCell60
            // 
            this.xrTableCell60.BackColor = System.Drawing.Color.LightCyan;
            this.xrTableCell60.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell60.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell60.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell60.Multiline = true;
            this.xrTableCell60.Name = "xrTableCell60";
            this.xrTableCell60.StylePriority.UseBackColor = false;
            this.xrTableCell60.StylePriority.UseBorderColor = false;
            this.xrTableCell60.StylePriority.UseBorders = false;
            this.xrTableCell60.StylePriority.UseFont = false;
            this.xrTableCell60.Text = "Milestone\r\nAs-Is";
            this.xrTableCell60.Weight = 0.47254742152427814D;
            // 
            // xrTableCell43
            // 
            this.xrTableCell43.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell43.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell43.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell43.Name = "xrTableCell43";
            this.xrTableCell43.StylePriority.UseBackColor = false;
            this.xrTableCell43.StylePriority.UseBorderColor = false;
            this.xrTableCell43.StylePriority.UseBorders = false;
            this.xrTableCell43.Text = " ";
            this.xrTableCell43.Weight = 0.45835884385278358D;
            // 
            // xrTableCell71
            // 
            this.xrTableCell71.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell71.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell71.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell71.Name = "xrTableCell71";
            this.xrTableCell71.StylePriority.UseBackColor = false;
            this.xrTableCell71.StylePriority.UseBorderColor = false;
            this.xrTableCell71.StylePriority.UseBorders = false;
            this.xrTableCell71.Text = " ";
            this.xrTableCell71.Weight = 0.45835884385278364D;
            // 
            // xrTableCell44
            // 
            this.xrTableCell44.BackColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell44.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell44.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell44.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell44.ForeColor = System.Drawing.Color.White;
            this.xrTableCell44.Multiline = true;
            this.xrTableCell44.Name = "xrTableCell44";
            this.xrTableCell44.StylePriority.UseBackColor = false;
            this.xrTableCell44.StylePriority.UseBorderColor = false;
            this.xrTableCell44.StylePriority.UseBorders = false;
            this.xrTableCell44.StylePriority.UseFont = false;
            this.xrTableCell44.StylePriority.UseForeColor = false;
            this.xrTableCell44.Text = "Milestone \r\nTo-Be";
            this.xrTableCell44.Weight = 0.45835884385278358D;
            // 
            // xrTableCell81
            // 
            this.xrTableCell81.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell81.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell81.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell81.Name = "xrTableCell81";
            this.xrTableCell81.StylePriority.UseBackColor = false;
            this.xrTableCell81.StylePriority.UseBorderColor = false;
            this.xrTableCell81.StylePriority.UseBorders = false;
            this.xrTableCell81.Text = " ";
            this.xrTableCell81.Weight = 0.45835884385278358D;
            // 
            // xrTableCell45
            // 
            this.xrTableCell45.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell45.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell45.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell45.Name = "xrTableCell45";
            this.xrTableCell45.StylePriority.UseBackColor = false;
            this.xrTableCell45.StylePriority.UseBorderColor = false;
            this.xrTableCell45.StylePriority.UseBorders = false;
            this.xrTableCell45.Text = " ";
            this.xrTableCell45.Weight = 0.45835884385278364D;
            // 
            // xrTableCell91
            // 
            this.xrTableCell91.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell91.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell91.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell91.Name = "xrTableCell91";
            this.xrTableCell91.StylePriority.UseBackColor = false;
            this.xrTableCell91.StylePriority.UseBorderColor = false;
            this.xrTableCell91.StylePriority.UseBorders = false;
            this.xrTableCell91.Text = " ";
            this.xrTableCell91.Weight = 0.45835884385278358D;
            // 
            // xrTableCell46
            // 
            this.xrTableCell46.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell46.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell46.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell46.Name = "xrTableCell46";
            this.xrTableCell46.StylePriority.UseBackColor = false;
            this.xrTableCell46.StylePriority.UseBorderColor = false;
            this.xrTableCell46.StylePriority.UseBorders = false;
            this.xrTableCell46.Text = " ";
            this.xrTableCell46.Weight = 0.45835884385278358D;
            // 
            // xrTableCell101
            // 
            this.xrTableCell101.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell101.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell101.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell101.Name = "xrTableCell101";
            this.xrTableCell101.StylePriority.UseBackColor = false;
            this.xrTableCell101.StylePriority.UseBorderColor = false;
            this.xrTableCell101.StylePriority.UseBorders = false;
            this.xrTableCell101.Text = " ";
            this.xrTableCell101.Weight = 0.45835884385278358D;
            // 
            // xrTableCell47
            // 
            this.xrTableCell47.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell47.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell47.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell47.Name = "xrTableCell47";
            this.xrTableCell47.StylePriority.UseBackColor = false;
            this.xrTableCell47.StylePriority.UseBorderColor = false;
            this.xrTableCell47.StylePriority.UseBorders = false;
            this.xrTableCell47.Text = " ";
            this.xrTableCell47.Weight = 0.45835900657922568D;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell122,
            this.xrTableCell61,
            this.xrTableCell53,
            this.xrTableCell72,
            this.xrTableCell54,
            this.xrTableCell82,
            this.xrTableCell55,
            this.xrTableCell92,
            this.xrTableCell56,
            this.xrTableCell102,
            this.xrTableCell57});
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.StylePriority.UseBorders = false;
            this.xrTableRow13.Weight = 1D;
            // 
            // xrTableCell122
            // 
            this.xrTableCell122.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell122.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell122.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell122.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.xrTableCell122.Name = "xrTableCell122";
            this.xrTableCell122.StylePriority.UseBackColor = false;
            this.xrTableCell122.StylePriority.UseBorderColor = false;
            this.xrTableCell122.StylePriority.UseBorders = false;
            this.xrTableCell122.StylePriority.UseFont = false;
            this.xrTableCell122.Text = "Capability Quality - Title / Definition";
            this.xrTableCell122.Weight = 0.90247813953908973D;
            // 
            // xrTableCell61
            // 
            this.xrTableCell61.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell61.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell61.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell61.Name = "xrTableCell61";
            this.xrTableCell61.StylePriority.UseBackColor = false;
            this.xrTableCell61.StylePriority.UseBorderColor = false;
            this.xrTableCell61.StylePriority.UseBorders = false;
            this.xrTableCell61.Text = " ";
            this.xrTableCell61.Weight = 0.47254742152427814D;
            // 
            // xrTableCell53
            // 
            this.xrTableCell53.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell53.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell53.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell53.Name = "xrTableCell53";
            this.xrTableCell53.StylePriority.UseBackColor = false;
            this.xrTableCell53.StylePriority.UseBorderColor = false;
            this.xrTableCell53.StylePriority.UseBorders = false;
            this.xrTableCell53.Text = " ";
            this.xrTableCell53.Weight = 0.45835884385278358D;
            // 
            // xrTableCell72
            // 
            this.xrTableCell72.BackColor = System.Drawing.Color.LightCyan;
            this.xrTableCell72.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell72.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell72.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell72.Multiline = true;
            this.xrTableCell72.Name = "xrTableCell72";
            this.xrTableCell72.StylePriority.UseBackColor = false;
            this.xrTableCell72.StylePriority.UseBorderColor = false;
            this.xrTableCell72.StylePriority.UseBorders = false;
            this.xrTableCell72.StylePriority.UseFont = false;
            this.xrTableCell72.Text = "Milestone\r\nAs-Is";
            this.xrTableCell72.Weight = 0.45835884385278364D;
            // 
            // xrTableCell54
            // 
            this.xrTableCell54.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell54.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell54.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell54.Name = "xrTableCell54";
            this.xrTableCell54.StylePriority.UseBackColor = false;
            this.xrTableCell54.StylePriority.UseBorderColor = false;
            this.xrTableCell54.StylePriority.UseBorders = false;
            this.xrTableCell54.Text = " ";
            this.xrTableCell54.Weight = 0.45835884385278358D;
            // 
            // xrTableCell82
            // 
            this.xrTableCell82.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell82.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell82.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell82.Name = "xrTableCell82";
            this.xrTableCell82.StylePriority.UseBackColor = false;
            this.xrTableCell82.StylePriority.UseBorderColor = false;
            this.xrTableCell82.StylePriority.UseBorders = false;
            this.xrTableCell82.Text = " ";
            this.xrTableCell82.Weight = 0.45835884385278358D;
            // 
            // xrTableCell55
            // 
            this.xrTableCell55.BackColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell55.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell55.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell55.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell55.ForeColor = System.Drawing.Color.White;
            this.xrTableCell55.Multiline = true;
            this.xrTableCell55.Name = "xrTableCell55";
            this.xrTableCell55.StylePriority.UseBackColor = false;
            this.xrTableCell55.StylePriority.UseBorderColor = false;
            this.xrTableCell55.StylePriority.UseBorders = false;
            this.xrTableCell55.StylePriority.UseFont = false;
            this.xrTableCell55.StylePriority.UseForeColor = false;
            this.xrTableCell55.Text = "Milestone \r\nTo-Be";
            this.xrTableCell55.Weight = 0.45835884385278364D;
            // 
            // xrTableCell92
            // 
            this.xrTableCell92.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell92.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell92.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell92.Name = "xrTableCell92";
            this.xrTableCell92.StylePriority.UseBackColor = false;
            this.xrTableCell92.StylePriority.UseBorderColor = false;
            this.xrTableCell92.StylePriority.UseBorders = false;
            this.xrTableCell92.Text = " ";
            this.xrTableCell92.Weight = 0.45835884385278358D;
            // 
            // xrTableCell56
            // 
            this.xrTableCell56.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell56.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell56.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell56.Name = "xrTableCell56";
            this.xrTableCell56.StylePriority.UseBackColor = false;
            this.xrTableCell56.StylePriority.UseBorderColor = false;
            this.xrTableCell56.StylePriority.UseBorders = false;
            this.xrTableCell56.Text = " ";
            this.xrTableCell56.Weight = 0.45835884385278358D;
            // 
            // xrTableCell102
            // 
            this.xrTableCell102.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell102.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell102.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell102.Name = "xrTableCell102";
            this.xrTableCell102.StylePriority.UseBackColor = false;
            this.xrTableCell102.StylePriority.UseBorderColor = false;
            this.xrTableCell102.StylePriority.UseBorders = false;
            this.xrTableCell102.Text = " ";
            this.xrTableCell102.Weight = 0.45835884385278358D;
            // 
            // xrTableCell57
            // 
            this.xrTableCell57.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell57.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell57.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell57.Name = "xrTableCell57";
            this.xrTableCell57.StylePriority.UseBackColor = false;
            this.xrTableCell57.StylePriority.UseBorderColor = false;
            this.xrTableCell57.StylePriority.UseBorders = false;
            this.xrTableCell57.Text = " ";
            this.xrTableCell57.Weight = 0.45835900657922568D;
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell123,
            this.xrTableCell63,
            this.xrTableCell38,
            this.xrTableCell73,
            this.xrTableCell39,
            this.xrTableCell83,
            this.xrTableCell40,
            this.xrTableCell93,
            this.xrTableCell41,
            this.xrTableCell103,
            this.xrTableCell42});
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.StylePriority.UseBorders = false;
            this.xrTableRow10.Weight = 1D;
            // 
            // xrTableCell123
            // 
            this.xrTableCell123.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell123.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell123.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell123.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.xrTableCell123.Name = "xrTableCell123";
            this.xrTableCell123.StylePriority.UseBackColor = false;
            this.xrTableCell123.StylePriority.UseBorderColor = false;
            this.xrTableCell123.StylePriority.UseBorders = false;
            this.xrTableCell123.StylePriority.UseFont = false;
            this.xrTableCell123.Text = "Capability Quality - Title / Definition";
            this.xrTableCell123.Weight = 0.90247813953908973D;
            // 
            // xrTableCell63
            // 
            this.xrTableCell63.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell63.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell63.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell63.Name = "xrTableCell63";
            this.xrTableCell63.StylePriority.UseBackColor = false;
            this.xrTableCell63.StylePriority.UseBorderColor = false;
            this.xrTableCell63.StylePriority.UseBorders = false;
            this.xrTableCell63.Text = " ";
            this.xrTableCell63.Weight = 0.47254742152427814D;
            // 
            // xrTableCell38
            // 
            this.xrTableCell38.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell38.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell38.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell38.Name = "xrTableCell38";
            this.xrTableCell38.StylePriority.UseBackColor = false;
            this.xrTableCell38.StylePriority.UseBorderColor = false;
            this.xrTableCell38.StylePriority.UseBorders = false;
            this.xrTableCell38.Text = " ";
            this.xrTableCell38.Weight = 0.45835884385278358D;
            // 
            // xrTableCell73
            // 
            this.xrTableCell73.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell73.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell73.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell73.Name = "xrTableCell73";
            this.xrTableCell73.StylePriority.UseBackColor = false;
            this.xrTableCell73.StylePriority.UseBorderColor = false;
            this.xrTableCell73.StylePriority.UseBorders = false;
            this.xrTableCell73.Text = " ";
            this.xrTableCell73.Weight = 0.45835884385278364D;
            // 
            // xrTableCell39
            // 
            this.xrTableCell39.BackColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell39.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell39.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell39.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell39.ForeColor = System.Drawing.Color.White;
            this.xrTableCell39.Multiline = true;
            this.xrTableCell39.Name = "xrTableCell39";
            this.xrTableCell39.StylePriority.UseBackColor = false;
            this.xrTableCell39.StylePriority.UseBorderColor = false;
            this.xrTableCell39.StylePriority.UseBorders = false;
            this.xrTableCell39.StylePriority.UseFont = false;
            this.xrTableCell39.StylePriority.UseForeColor = false;
            this.xrTableCell39.Text = "Milestone \r\nTo-Be";
            this.xrTableCell39.Weight = 0.45835884385278358D;
            // 
            // xrTableCell83
            // 
            this.xrTableCell83.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell83.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell83.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell83.Name = "xrTableCell83";
            this.xrTableCell83.StylePriority.UseBackColor = false;
            this.xrTableCell83.StylePriority.UseBorderColor = false;
            this.xrTableCell83.StylePriority.UseBorders = false;
            this.xrTableCell83.Text = " ";
            this.xrTableCell83.Weight = 0.45835884385278358D;
            // 
            // xrTableCell40
            // 
            this.xrTableCell40.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell40.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell40.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell40.Name = "xrTableCell40";
            this.xrTableCell40.StylePriority.UseBackColor = false;
            this.xrTableCell40.StylePriority.UseBorderColor = false;
            this.xrTableCell40.StylePriority.UseBorders = false;
            this.xrTableCell40.Text = " ";
            this.xrTableCell40.Weight = 0.45835884385278364D;
            // 
            // xrTableCell93
            // 
            this.xrTableCell93.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell93.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell93.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell93.Name = "xrTableCell93";
            this.xrTableCell93.StylePriority.UseBackColor = false;
            this.xrTableCell93.StylePriority.UseBorderColor = false;
            this.xrTableCell93.StylePriority.UseBorders = false;
            this.xrTableCell93.Text = " ";
            this.xrTableCell93.Weight = 0.45835884385278358D;
            // 
            // xrTableCell41
            // 
            this.xrTableCell41.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell41.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell41.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell41.Name = "xrTableCell41";
            this.xrTableCell41.StylePriority.UseBackColor = false;
            this.xrTableCell41.StylePriority.UseBorderColor = false;
            this.xrTableCell41.StylePriority.UseBorders = false;
            this.xrTableCell41.Text = " ";
            this.xrTableCell41.Weight = 0.45835884385278358D;
            // 
            // xrTableCell103
            // 
            this.xrTableCell103.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell103.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell103.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell103.Name = "xrTableCell103";
            this.xrTableCell103.StylePriority.UseBackColor = false;
            this.xrTableCell103.StylePriority.UseBorderColor = false;
            this.xrTableCell103.StylePriority.UseBorders = false;
            this.xrTableCell103.Text = " ";
            this.xrTableCell103.Weight = 0.45835884385278358D;
            // 
            // xrTableCell42
            // 
            this.xrTableCell42.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell42.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell42.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell42.Name = "xrTableCell42";
            this.xrTableCell42.StylePriority.UseBackColor = false;
            this.xrTableCell42.StylePriority.UseBorderColor = false;
            this.xrTableCell42.StylePriority.UseBorders = false;
            this.xrTableCell42.Text = " ";
            this.xrTableCell42.Weight = 0.45835900657922568D;
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell124,
            this.xrTableCell64,
            this.xrTableCell48,
            this.xrTableCell74,
            this.xrTableCell49,
            this.xrTableCell84,
            this.xrTableCell50,
            this.xrTableCell94,
            this.xrTableCell51,
            this.xrTableCell104,
            this.xrTableCell52});
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.StylePriority.UseBorders = false;
            this.xrTableRow12.Weight = 1D;
            // 
            // xrTableCell124
            // 
            this.xrTableCell124.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell124.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell124.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell124.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.xrTableCell124.Name = "xrTableCell124";
            this.xrTableCell124.StylePriority.UseBackColor = false;
            this.xrTableCell124.StylePriority.UseBorderColor = false;
            this.xrTableCell124.StylePriority.UseBorders = false;
            this.xrTableCell124.StylePriority.UseFont = false;
            this.xrTableCell124.Text = "Capability Quality - Title / Definition";
            this.xrTableCell124.Weight = 0.90247813953908973D;
            // 
            // xrTableCell64
            // 
            this.xrTableCell64.BackColor = System.Drawing.Color.LightCyan;
            this.xrTableCell64.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell64.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell64.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell64.Multiline = true;
            this.xrTableCell64.Name = "xrTableCell64";
            this.xrTableCell64.StylePriority.UseBackColor = false;
            this.xrTableCell64.StylePriority.UseBorderColor = false;
            this.xrTableCell64.StylePriority.UseBorders = false;
            this.xrTableCell64.StylePriority.UseFont = false;
            this.xrTableCell64.Text = "Milestone\r\nAs-Is";
            this.xrTableCell64.Weight = 0.47254753155137186D;
            // 
            // xrTableCell48
            // 
            this.xrTableCell48.BackColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell48.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell48.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell48.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell48.ForeColor = System.Drawing.Color.White;
            this.xrTableCell48.Multiline = true;
            this.xrTableCell48.Name = "xrTableCell48";
            this.xrTableCell48.StylePriority.UseBackColor = false;
            this.xrTableCell48.StylePriority.UseBorderColor = false;
            this.xrTableCell48.StylePriority.UseBorders = false;
            this.xrTableCell48.StylePriority.UseFont = false;
            this.xrTableCell48.StylePriority.UseForeColor = false;
            this.xrTableCell48.Text = "Milestone \r\nTo-Be";
            this.xrTableCell48.Weight = 0.45835891751643704D;
            // 
            // xrTableCell74
            // 
            this.xrTableCell74.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell74.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell74.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell74.Name = "xrTableCell74";
            this.xrTableCell74.StylePriority.UseBackColor = false;
            this.xrTableCell74.StylePriority.UseBorderColor = false;
            this.xrTableCell74.StylePriority.UseBorders = false;
            this.xrTableCell74.Text = " ";
            this.xrTableCell74.Weight = 0.45835891751643709D;
            // 
            // xrTableCell49
            // 
            this.xrTableCell49.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell49.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell49.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell49.Name = "xrTableCell49";
            this.xrTableCell49.StylePriority.UseBackColor = false;
            this.xrTableCell49.StylePriority.UseBorderColor = false;
            this.xrTableCell49.StylePriority.UseBorders = false;
            this.xrTableCell49.Text = " ";
            this.xrTableCell49.Weight = 0.45835893785730003D;
            // 
            // xrTableCell84
            // 
            this.xrTableCell84.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell84.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell84.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell84.Name = "xrTableCell84";
            this.xrTableCell84.StylePriority.UseBackColor = false;
            this.xrTableCell84.StylePriority.UseBorderColor = false;
            this.xrTableCell84.StylePriority.UseBorders = false;
            this.xrTableCell84.Text = " ";
            this.xrTableCell84.Weight = 0.45835893785730009D;
            // 
            // xrTableCell50
            // 
            this.xrTableCell50.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell50.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell50.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell50.Name = "xrTableCell50";
            this.xrTableCell50.StylePriority.UseBackColor = false;
            this.xrTableCell50.StylePriority.UseBorderColor = false;
            this.xrTableCell50.StylePriority.UseBorders = false;
            this.xrTableCell50.Text = " ";
            this.xrTableCell50.Weight = 0.45835893785730009D;
            // 
            // xrTableCell94
            // 
            this.xrTableCell94.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell94.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell94.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell94.Name = "xrTableCell94";
            this.xrTableCell94.StylePriority.UseBackColor = false;
            this.xrTableCell94.StylePriority.UseBorderColor = false;
            this.xrTableCell94.StylePriority.UseBorders = false;
            this.xrTableCell94.Text = " ";
            this.xrTableCell94.Weight = 0.45835893785730009D;
            // 
            // xrTableCell51
            // 
            this.xrTableCell51.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell51.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell51.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell51.Name = "xrTableCell51";
            this.xrTableCell51.StylePriority.UseBackColor = false;
            this.xrTableCell51.StylePriority.UseBorderColor = false;
            this.xrTableCell51.StylePriority.UseBorders = false;
            this.xrTableCell51.Text = " ";
            this.xrTableCell51.Weight = 0.45835891751643704D;
            // 
            // xrTableCell104
            // 
            this.xrTableCell104.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell104.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell104.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell104.Name = "xrTableCell104";
            this.xrTableCell104.StylePriority.UseBackColor = false;
            this.xrTableCell104.StylePriority.UseBorderColor = false;
            this.xrTableCell104.StylePriority.UseBorders = false;
            this.xrTableCell104.Text = " ";
            this.xrTableCell104.Weight = 0.45835891751643709D;
            // 
            // xrTableCell52
            // 
            this.xrTableCell52.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell52.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell52.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell52.Name = "xrTableCell52";
            this.xrTableCell52.StylePriority.UseBackColor = false;
            this.xrTableCell52.StylePriority.UseBorderColor = false;
            this.xrTableCell52.StylePriority.UseBorders = false;
            this.xrTableCell52.Text = " ";
            this.xrTableCell52.Weight = 0.4583582258794523D;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell125,
            this.xrTableCell65,
            this.xrTableCell33,
            this.xrTableCell17,
            this.xrTableCell34,
            this.xrTableCell85,
            this.xrTableCell35,
            this.xrTableCell95,
            this.xrTableCell36,
            this.xrTableCell105,
            this.xrTableCell37});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.StylePriority.UseBorders = false;
            this.xrTableRow9.Weight = 1D;
            // 
            // xrTableCell125
            // 
            this.xrTableCell125.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell125.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell125.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell125.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.xrTableCell125.Name = "xrTableCell125";
            this.xrTableCell125.StylePriority.UseBackColor = false;
            this.xrTableCell125.StylePriority.UseBorderColor = false;
            this.xrTableCell125.StylePriority.UseBorders = false;
            this.xrTableCell125.StylePriority.UseFont = false;
            this.xrTableCell125.Text = "Capability Quality - Title / Definition";
            this.xrTableCell125.Weight = 0.90247813953908973D;
            // 
            // xrTableCell65
            // 
            this.xrTableCell65.BackColor = System.Drawing.Color.LightCyan;
            this.xrTableCell65.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell65.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell65.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell65.Multiline = true;
            this.xrTableCell65.Name = "xrTableCell65";
            this.xrTableCell65.StylePriority.UseBackColor = false;
            this.xrTableCell65.StylePriority.UseBorderColor = false;
            this.xrTableCell65.StylePriority.UseBorders = false;
            this.xrTableCell65.StylePriority.UseFont = false;
            this.xrTableCell65.Text = "Milestone\r\nAs-Is";
            this.xrTableCell65.Weight = 0.47254753155137186D;
            // 
            // xrTableCell33
            // 
            this.xrTableCell33.BackColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell33.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell33.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell33.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell33.ForeColor = System.Drawing.Color.White;
            this.xrTableCell33.Multiline = true;
            this.xrTableCell33.Name = "xrTableCell33";
            this.xrTableCell33.StylePriority.UseBackColor = false;
            this.xrTableCell33.StylePriority.UseBorderColor = false;
            this.xrTableCell33.StylePriority.UseBorders = false;
            this.xrTableCell33.StylePriority.UseFont = false;
            this.xrTableCell33.StylePriority.UseForeColor = false;
            this.xrTableCell33.Text = "Milestone \r\nTo-Be";
            this.xrTableCell33.Weight = 0.45835891751643704D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell17.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell17.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.StylePriority.UseBackColor = false;
            this.xrTableCell17.StylePriority.UseBorderColor = false;
            this.xrTableCell17.StylePriority.UseBorders = false;
            this.xrTableCell17.Text = " ";
            this.xrTableCell17.Weight = 0.45835891751643709D;
            // 
            // xrTableCell34
            // 
            this.xrTableCell34.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell34.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell34.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell34.Name = "xrTableCell34";
            this.xrTableCell34.StylePriority.UseBackColor = false;
            this.xrTableCell34.StylePriority.UseBorderColor = false;
            this.xrTableCell34.StylePriority.UseBorders = false;
            this.xrTableCell34.Text = " ";
            this.xrTableCell34.Weight = 0.45835893785730003D;
            // 
            // xrTableCell85
            // 
            this.xrTableCell85.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell85.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell85.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell85.Name = "xrTableCell85";
            this.xrTableCell85.StylePriority.UseBackColor = false;
            this.xrTableCell85.StylePriority.UseBorderColor = false;
            this.xrTableCell85.StylePriority.UseBorders = false;
            this.xrTableCell85.Text = " ";
            this.xrTableCell85.Weight = 0.45835893785730009D;
            // 
            // xrTableCell35
            // 
            this.xrTableCell35.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell35.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell35.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell35.Name = "xrTableCell35";
            this.xrTableCell35.StylePriority.UseBackColor = false;
            this.xrTableCell35.StylePriority.UseBorderColor = false;
            this.xrTableCell35.StylePriority.UseBorders = false;
            this.xrTableCell35.Text = " ";
            this.xrTableCell35.Weight = 0.45835893785730009D;
            // 
            // xrTableCell95
            // 
            this.xrTableCell95.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell95.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell95.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell95.Name = "xrTableCell95";
            this.xrTableCell95.StylePriority.UseBackColor = false;
            this.xrTableCell95.StylePriority.UseBorderColor = false;
            this.xrTableCell95.StylePriority.UseBorders = false;
            this.xrTableCell95.Text = " ";
            this.xrTableCell95.Weight = 0.45835893785730009D;
            // 
            // xrTableCell36
            // 
            this.xrTableCell36.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell36.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell36.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell36.Name = "xrTableCell36";
            this.xrTableCell36.StylePriority.UseBackColor = false;
            this.xrTableCell36.StylePriority.UseBorderColor = false;
            this.xrTableCell36.StylePriority.UseBorders = false;
            this.xrTableCell36.Text = " ";
            this.xrTableCell36.Weight = 0.45835891751643704D;
            // 
            // xrTableCell105
            // 
            this.xrTableCell105.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell105.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell105.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell105.Name = "xrTableCell105";
            this.xrTableCell105.StylePriority.UseBackColor = false;
            this.xrTableCell105.StylePriority.UseBorderColor = false;
            this.xrTableCell105.StylePriority.UseBorders = false;
            this.xrTableCell105.Text = " ";
            this.xrTableCell105.Weight = 0.45835891751643709D;
            // 
            // xrTableCell37
            // 
            this.xrTableCell37.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell37.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell37.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell37.Name = "xrTableCell37";
            this.xrTableCell37.StylePriority.UseBackColor = false;
            this.xrTableCell37.StylePriority.UseBorderColor = false;
            this.xrTableCell37.StylePriority.UseBorders = false;
            this.xrTableCell37.Text = " ";
            this.xrTableCell37.Weight = 0.4583582258794523D;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell126,
            this.xrTableCell66,
            this.xrTableCell28,
            this.xrTableCell76,
            this.xrTableCell29,
            this.xrTableCell86,
            this.xrTableCell30,
            this.xrTableCell96,
            this.xrTableCell31,
            this.xrTableCell106,
            this.xrTableCell32});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.StylePriority.UseBorders = false;
            this.xrTableRow8.Weight = 1D;
            // 
            // xrTableCell126
            // 
            this.xrTableCell126.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell126.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell126.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell126.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.xrTableCell126.Name = "xrTableCell126";
            this.xrTableCell126.StylePriority.UseBackColor = false;
            this.xrTableCell126.StylePriority.UseBorderColor = false;
            this.xrTableCell126.StylePriority.UseBorders = false;
            this.xrTableCell126.StylePriority.UseFont = false;
            this.xrTableCell126.Text = "Capability Quality - Title / Definition";
            this.xrTableCell126.Weight = 0.90247813953908973D;
            // 
            // xrTableCell66
            // 
            this.xrTableCell66.BackColor = System.Drawing.Color.LightCyan;
            this.xrTableCell66.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell66.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell66.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell66.Multiline = true;
            this.xrTableCell66.Name = "xrTableCell66";
            this.xrTableCell66.StylePriority.UseBackColor = false;
            this.xrTableCell66.StylePriority.UseBorderColor = false;
            this.xrTableCell66.StylePriority.UseBorders = false;
            this.xrTableCell66.StylePriority.UseFont = false;
            this.xrTableCell66.Text = "Milestone\r\nAs-Is";
            this.xrTableCell66.Weight = 0.47254753155137186D;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell28.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell28.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.StylePriority.UseBackColor = false;
            this.xrTableCell28.StylePriority.UseBorderColor = false;
            this.xrTableCell28.StylePriority.UseBorders = false;
            this.xrTableCell28.Text = " ";
            this.xrTableCell28.Weight = 0.45835891751643704D;
            // 
            // xrTableCell76
            // 
            this.xrTableCell76.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell76.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell76.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell76.Name = "xrTableCell76";
            this.xrTableCell76.StylePriority.UseBackColor = false;
            this.xrTableCell76.StylePriority.UseBorderColor = false;
            this.xrTableCell76.StylePriority.UseBorders = false;
            this.xrTableCell76.Text = " ";
            this.xrTableCell76.Weight = 0.45835891751643709D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.BackColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell29.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell29.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell29.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell29.ForeColor = System.Drawing.Color.White;
            this.xrTableCell29.Multiline = true;
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.StylePriority.UseBackColor = false;
            this.xrTableCell29.StylePriority.UseBorderColor = false;
            this.xrTableCell29.StylePriority.UseBorders = false;
            this.xrTableCell29.StylePriority.UseFont = false;
            this.xrTableCell29.StylePriority.UseForeColor = false;
            this.xrTableCell29.Text = "Milestone \r\nTo-Be";
            this.xrTableCell29.Weight = 0.45835893785730003D;
            // 
            // xrTableCell86
            // 
            this.xrTableCell86.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell86.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell86.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell86.Name = "xrTableCell86";
            this.xrTableCell86.StylePriority.UseBackColor = false;
            this.xrTableCell86.StylePriority.UseBorderColor = false;
            this.xrTableCell86.StylePriority.UseBorders = false;
            this.xrTableCell86.Text = " ";
            this.xrTableCell86.Weight = 0.45835893785730009D;
            // 
            // xrTableCell30
            // 
            this.xrTableCell30.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell30.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell30.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell30.Name = "xrTableCell30";
            this.xrTableCell30.StylePriority.UseBackColor = false;
            this.xrTableCell30.StylePriority.UseBorderColor = false;
            this.xrTableCell30.StylePriority.UseBorders = false;
            this.xrTableCell30.Text = " ";
            this.xrTableCell30.Weight = 0.45835893785730009D;
            // 
            // xrTableCell96
            // 
            this.xrTableCell96.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell96.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell96.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell96.Name = "xrTableCell96";
            this.xrTableCell96.StylePriority.UseBackColor = false;
            this.xrTableCell96.StylePriority.UseBorderColor = false;
            this.xrTableCell96.StylePriority.UseBorders = false;
            this.xrTableCell96.Text = " ";
            this.xrTableCell96.Weight = 0.45835893785730009D;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell31.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell31.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.StylePriority.UseBackColor = false;
            this.xrTableCell31.StylePriority.UseBorderColor = false;
            this.xrTableCell31.StylePriority.UseBorders = false;
            this.xrTableCell31.Text = " ";
            this.xrTableCell31.Weight = 0.45835891751643704D;
            // 
            // xrTableCell106
            // 
            this.xrTableCell106.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell106.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell106.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell106.Name = "xrTableCell106";
            this.xrTableCell106.StylePriority.UseBackColor = false;
            this.xrTableCell106.StylePriority.UseBorderColor = false;
            this.xrTableCell106.StylePriority.UseBorders = false;
            this.xrTableCell106.Text = " ";
            this.xrTableCell106.Weight = 0.45835891751643709D;
            // 
            // xrTableCell32
            // 
            this.xrTableCell32.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell32.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell32.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell32.Name = "xrTableCell32";
            this.xrTableCell32.StylePriority.UseBackColor = false;
            this.xrTableCell32.StylePriority.UseBorderColor = false;
            this.xrTableCell32.StylePriority.UseBorders = false;
            this.xrTableCell32.Text = " ";
            this.xrTableCell32.Weight = 0.4583582258794523D;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell127,
            this.xrTableCell67,
            this.xrTableCell23,
            this.xrTableCell77,
            this.xrTableCell24,
            this.xrTableCell87,
            this.xrTableCell25,
            this.xrTableCell97,
            this.xrTableCell26,
            this.xrTableCell107,
            this.xrTableCell27});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.StylePriority.UseBorders = false;
            this.xrTableRow7.Weight = 1D;
            // 
            // xrTableCell127
            // 
            this.xrTableCell127.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell127.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell127.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell127.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.xrTableCell127.Name = "xrTableCell127";
            this.xrTableCell127.StylePriority.UseBackColor = false;
            this.xrTableCell127.StylePriority.UseBorderColor = false;
            this.xrTableCell127.StylePriority.UseBorders = false;
            this.xrTableCell127.StylePriority.UseFont = false;
            this.xrTableCell127.Text = "Capability Quality - Title / Definition";
            this.xrTableCell127.Weight = 0.90247813953908973D;
            // 
            // xrTableCell67
            // 
            this.xrTableCell67.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell67.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell67.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell67.Name = "xrTableCell67";
            this.xrTableCell67.StylePriority.UseBackColor = false;
            this.xrTableCell67.StylePriority.UseBorderColor = false;
            this.xrTableCell67.StylePriority.UseBorders = false;
            this.xrTableCell67.Text = " ";
            this.xrTableCell67.Weight = 0.47254753155137186D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell23.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell23.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.StylePriority.UseBackColor = false;
            this.xrTableCell23.StylePriority.UseBorderColor = false;
            this.xrTableCell23.StylePriority.UseBorders = false;
            this.xrTableCell23.Text = " ";
            this.xrTableCell23.Weight = 0.45835891751643704D;
            // 
            // xrTableCell77
            // 
            this.xrTableCell77.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell77.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell77.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell77.Name = "xrTableCell77";
            this.xrTableCell77.StylePriority.UseBackColor = false;
            this.xrTableCell77.StylePriority.UseBorderColor = false;
            this.xrTableCell77.StylePriority.UseBorders = false;
            this.xrTableCell77.Text = " ";
            this.xrTableCell77.Weight = 0.45835891751643709D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell24.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell24.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.StylePriority.UseBackColor = false;
            this.xrTableCell24.StylePriority.UseBorderColor = false;
            this.xrTableCell24.StylePriority.UseBorders = false;
            this.xrTableCell24.Text = " ";
            this.xrTableCell24.Weight = 0.45835893785730003D;
            // 
            // xrTableCell87
            // 
            this.xrTableCell87.BackColor = System.Drawing.Color.LightCyan;
            this.xrTableCell87.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell87.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell87.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell87.Multiline = true;
            this.xrTableCell87.Name = "xrTableCell87";
            this.xrTableCell87.StylePriority.UseBackColor = false;
            this.xrTableCell87.StylePriority.UseBorderColor = false;
            this.xrTableCell87.StylePriority.UseBorders = false;
            this.xrTableCell87.StylePriority.UseFont = false;
            this.xrTableCell87.Text = "Milestone\r\nAs-Is";
            this.xrTableCell87.Weight = 0.45835893785730009D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell25.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell25.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.StylePriority.UseBackColor = false;
            this.xrTableCell25.StylePriority.UseBorderColor = false;
            this.xrTableCell25.StylePriority.UseBorders = false;
            this.xrTableCell25.Text = " ";
            this.xrTableCell25.Weight = 0.45835893785730009D;
            // 
            // xrTableCell97
            // 
            this.xrTableCell97.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell97.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell97.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell97.Name = "xrTableCell97";
            this.xrTableCell97.StylePriority.UseBackColor = false;
            this.xrTableCell97.StylePriority.UseBorderColor = false;
            this.xrTableCell97.StylePriority.UseBorders = false;
            this.xrTableCell97.Text = " ";
            this.xrTableCell97.Weight = 0.45835893785730009D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell26.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell26.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.StylePriority.UseBackColor = false;
            this.xrTableCell26.StylePriority.UseBorderColor = false;
            this.xrTableCell26.StylePriority.UseBorders = false;
            this.xrTableCell26.Text = " ";
            this.xrTableCell26.Weight = 0.45835891751643704D;
            // 
            // xrTableCell107
            // 
            this.xrTableCell107.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell107.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell107.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell107.Name = "xrTableCell107";
            this.xrTableCell107.StylePriority.UseBackColor = false;
            this.xrTableCell107.StylePriority.UseBorderColor = false;
            this.xrTableCell107.StylePriority.UseBorders = false;
            this.xrTableCell107.Text = " ";
            this.xrTableCell107.Weight = 0.45835891751643709D;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.BackColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell27.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell27.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell27.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell27.ForeColor = System.Drawing.Color.White;
            this.xrTableCell27.Multiline = true;
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.StylePriority.UseBackColor = false;
            this.xrTableCell27.StylePriority.UseBorderColor = false;
            this.xrTableCell27.StylePriority.UseBorders = false;
            this.xrTableCell27.StylePriority.UseFont = false;
            this.xrTableCell27.StylePriority.UseForeColor = false;
            this.xrTableCell27.Text = "Milestone \r\nTo-Be";
            this.xrTableCell27.Weight = 0.4583582258794523D;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell128,
            this.xrTableCell68,
            this.xrTableCell62,
            this.xrTableCell78,
            this.xrTableCell88,
            this.xrTableCell98,
            this.xrTableCell108,
            this.xrTableCell109,
            this.xrTableCell110,
            this.xrTableCell111,
            this.xrTableCell112});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // xrTableCell128
            // 
            this.xrTableCell128.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell128.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell128.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell128.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.xrTableCell128.Name = "xrTableCell128";
            this.xrTableCell128.StylePriority.UseBackColor = false;
            this.xrTableCell128.StylePriority.UseBorderColor = false;
            this.xrTableCell128.StylePriority.UseBorders = false;
            this.xrTableCell128.StylePriority.UseFont = false;
            this.xrTableCell128.Text = "Capability Quality - Title / Definition";
            this.xrTableCell128.Weight = 0.90247813953908973D;
            // 
            // xrTableCell68
            // 
            this.xrTableCell68.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell68.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell68.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell68.Name = "xrTableCell68";
            this.xrTableCell68.StylePriority.UseBackColor = false;
            this.xrTableCell68.StylePriority.UseBorderColor = false;
            this.xrTableCell68.StylePriority.UseBorders = false;
            this.xrTableCell68.Text = " ";
            this.xrTableCell68.Weight = 0.47254753155137186D;
            // 
            // xrTableCell62
            // 
            this.xrTableCell62.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell62.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell62.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell62.Name = "xrTableCell62";
            this.xrTableCell62.StylePriority.UseBackColor = false;
            this.xrTableCell62.StylePriority.UseBorderColor = false;
            this.xrTableCell62.StylePriority.UseBorders = false;
            this.xrTableCell62.Text = " ";
            this.xrTableCell62.Weight = 0.45835891751643704D;
            // 
            // xrTableCell78
            // 
            this.xrTableCell78.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell78.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell78.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell78.Name = "xrTableCell78";
            this.xrTableCell78.StylePriority.UseBackColor = false;
            this.xrTableCell78.StylePriority.UseBorderColor = false;
            this.xrTableCell78.StylePriority.UseBorders = false;
            this.xrTableCell78.Text = " ";
            this.xrTableCell78.Weight = 0.45835891751643709D;
            // 
            // xrTableCell88
            // 
            this.xrTableCell88.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell88.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell88.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell88.Name = "xrTableCell88";
            this.xrTableCell88.StylePriority.UseBackColor = false;
            this.xrTableCell88.StylePriority.UseBorderColor = false;
            this.xrTableCell88.StylePriority.UseBorders = false;
            this.xrTableCell88.Text = " ";
            this.xrTableCell88.Weight = 0.45835893785730003D;
            // 
            // xrTableCell98
            // 
            this.xrTableCell98.BackColor = System.Drawing.Color.LightCyan;
            this.xrTableCell98.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell98.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell98.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell98.Multiline = true;
            this.xrTableCell98.Name = "xrTableCell98";
            this.xrTableCell98.StylePriority.UseBackColor = false;
            this.xrTableCell98.StylePriority.UseBorderColor = false;
            this.xrTableCell98.StylePriority.UseBorders = false;
            this.xrTableCell98.StylePriority.UseFont = false;
            this.xrTableCell98.Text = "Milestone\r\nAs-Is";
            this.xrTableCell98.Weight = 0.45835893785730009D;
            // 
            // xrTableCell108
            // 
            this.xrTableCell108.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell108.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell108.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell108.Name = "xrTableCell108";
            this.xrTableCell108.StylePriority.UseBackColor = false;
            this.xrTableCell108.StylePriority.UseBorderColor = false;
            this.xrTableCell108.StylePriority.UseBorders = false;
            this.xrTableCell108.Text = " ";
            this.xrTableCell108.Weight = 0.45835893785730009D;
            // 
            // xrTableCell109
            // 
            this.xrTableCell109.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell109.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell109.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell109.Name = "xrTableCell109";
            this.xrTableCell109.StylePriority.UseBackColor = false;
            this.xrTableCell109.StylePriority.UseBorderColor = false;
            this.xrTableCell109.StylePriority.UseBorders = false;
            this.xrTableCell109.Text = " ";
            this.xrTableCell109.Weight = 0.45835893785730009D;
            // 
            // xrTableCell110
            // 
            this.xrTableCell110.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell110.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell110.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell110.Name = "xrTableCell110";
            this.xrTableCell110.StylePriority.UseBackColor = false;
            this.xrTableCell110.StylePriority.UseBorderColor = false;
            this.xrTableCell110.StylePriority.UseBorders = false;
            this.xrTableCell110.Text = " ";
            this.xrTableCell110.Weight = 0.45835891751643704D;
            // 
            // xrTableCell111
            // 
            this.xrTableCell111.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell111.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell111.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell111.Name = "xrTableCell111";
            this.xrTableCell111.StylePriority.UseBackColor = false;
            this.xrTableCell111.StylePriority.UseBorderColor = false;
            this.xrTableCell111.StylePriority.UseBorders = false;
            this.xrTableCell111.Text = " ";
            this.xrTableCell111.Weight = 0.45835891751643709D;
            // 
            // xrTableCell112
            // 
            this.xrTableCell112.BackColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell112.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell112.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell112.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell112.ForeColor = System.Drawing.Color.White;
            this.xrTableCell112.Multiline = true;
            this.xrTableCell112.Name = "xrTableCell112";
            this.xrTableCell112.StylePriority.UseBackColor = false;
            this.xrTableCell112.StylePriority.UseBorderColor = false;
            this.xrTableCell112.StylePriority.UseBorders = false;
            this.xrTableCell112.StylePriority.UseFont = false;
            this.xrTableCell112.StylePriority.UseForeColor = false;
            this.xrTableCell112.Text = "Milestone \r\nTo-Be";
            this.xrTableCell112.Weight = 0.4583582258794523D;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.GroupHeader1.HeightF = 45.91733F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(1.272771F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable1.SizeF = new System.Drawing.SizeF(1046.727F, 45.91733F);
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell129,
            this.xrTableCell130,
            this.xrTableCell131,
            this.xrTableCell132,
            this.xrTableCell133,
            this.xrTableCell134});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell129
            // 
            this.xrTableCell129.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell129.Bookmark = "Business Process name";
            this.xrTableCell129.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell129.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell129.Name = "xrTableCell129";
            this.xrTableCell129.StylePriority.UseBackColor = false;
            this.xrTableCell129.StylePriority.UseBorders = false;
            this.xrTableCell129.StylePriority.UseFont = false;
            this.xrTableCell129.StylePriority.UseTextAlignment = false;
            this.xrTableCell129.Text = "BUSINESS PROCESS NAME";
            this.xrTableCell129.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell129.Weight = 0.98541683892556164D;
            // 
            // xrTableCell130
            // 
            this.xrTableCell130.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrTableCell130.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell130.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell130.Name = "xrTableCell130";
            this.xrTableCell130.StylePriority.UseBackColor = false;
            this.xrTableCell130.StylePriority.UseBorders = false;
            this.xrTableCell130.StylePriority.UseFont = false;
            this.xrTableCell130.StylePriority.UseTextAlignment = false;
            this.xrTableCell130.Text = "Level 1";
            this.xrTableCell130.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell130.Weight = 1.0145831610744382D;
            // 
            // xrTableCell131
            // 
            this.xrTableCell131.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrTableCell131.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell131.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell131.Name = "xrTableCell131";
            this.xrTableCell131.StylePriority.UseBackColor = false;
            this.xrTableCell131.StylePriority.UseBorders = false;
            this.xrTableCell131.StylePriority.UseFont = false;
            this.xrTableCell131.StylePriority.UseTextAlignment = false;
            this.xrTableCell131.Text = "Level 2";
            this.xrTableCell131.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell131.Weight = 1D;
            // 
            // xrTableCell132
            // 
            this.xrTableCell132.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrTableCell132.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell132.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell132.Name = "xrTableCell132";
            this.xrTableCell132.StylePriority.UseBackColor = false;
            this.xrTableCell132.StylePriority.UseBorders = false;
            this.xrTableCell132.StylePriority.UseFont = false;
            this.xrTableCell132.StylePriority.UseTextAlignment = false;
            this.xrTableCell132.Text = "Level 3";
            this.xrTableCell132.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell132.Weight = 1D;
            // 
            // xrTableCell133
            // 
            this.xrTableCell133.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrTableCell133.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell133.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell133.Name = "xrTableCell133";
            this.xrTableCell133.StylePriority.UseBackColor = false;
            this.xrTableCell133.StylePriority.UseBorders = false;
            this.xrTableCell133.StylePriority.UseFont = false;
            this.xrTableCell133.StylePriority.UseTextAlignment = false;
            this.xrTableCell133.Text = "Level 4";
            this.xrTableCell133.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell133.Weight = 1D;
            // 
            // xrTableCell134
            // 
            this.xrTableCell134.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrTableCell134.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell134.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell134.Name = "xrTableCell134";
            this.xrTableCell134.StylePriority.UseBackColor = false;
            this.xrTableCell134.StylePriority.UseBorders = false;
            this.xrTableCell134.StylePriority.UseFont = false;
            this.xrTableCell134.StylePriority.UseTextAlignment = false;
            this.xrTableCell134.Text = "Level 5";
            this.xrTableCell134.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell134.Weight = 1D;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DevDB";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "RC_TYPE";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"134\" />";
            table1.Name = "view_allitems";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "RC_NAME";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "RC_ID";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "id";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "bp_name";
            table2.MetaSerializable = "<Meta X=\"180\" Y=\"210\" Width=\"125\" Height=\"210\" />";
            table2.Name = "rc_assessment_processes";
            columnExpression5.Table = table2;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "bp_identifier";
            columnExpression6.Table = table2;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "bp_description";
            columnExpression7.Table = table2;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "res_response";
            table3.MetaSerializable = "<Meta X=\"685\" Y=\"30\" Width=\"125\" Height=\"191\" />";
            table3.Name = "rc_responses";
            columnExpression8.Table = table3;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "res_assessment";
            columnExpression9.Table = table3;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "res_date";
            columnExpression10.Table = table3;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "mil_name";
            table4.MetaSerializable = "<Meta X=\"840\" Y=\"30\" Width=\"125\" Height=\"153\" />";
            table4.Name = "rc_milestones";
            columnExpression11.Table = table4;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "mil_description";
            columnExpression12.Table = table4;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "pro_description";
            table5.MetaSerializable = "<Meta X=\"530\" Y=\"70\" Width=\"125\" Height=\"153\" />";
            table5.Name = "rc_projects";
            columnExpression13.Table = table5;
            column13.Expression = columnExpression13;
            columnExpression14.ColumnName = "pro_color";
            columnExpression14.Table = table5;
            column14.Expression = columnExpression14;
            columnExpression15.ColumnName = "pro_name";
            columnExpression15.Table = table5;
            column15.Expression = columnExpression15;
            columnExpression16.ColumnName = "area_name";
            table6.MetaSerializable = "<Meta X=\"510\" Y=\"400\" Width=\"125\" Height=\"191\" />";
            table6.Name = "rc_assessment_areas";
            columnExpression16.Table = table6;
            column16.Expression = columnExpression16;
            columnExpression17.ColumnName = "cat_name";
            table7.MetaSerializable = "<Meta X=\"340\" Y=\"280\" Width=\"125\" Height=\"210\" />";
            table7.Name = "rc_assessment_categories";
            columnExpression17.Table = table7;
            column17.Expression = columnExpression17;
            columnExpression18.ColumnName = "cat_description";
            columnExpression18.Table = table7;
            column18.Expression = columnExpression18;
            columnExpression19.ColumnName = "area_description";
            columnExpression19.Table = table6;
            column19.Expression = columnExpression19;
            columnExpression20.ColumnName = "res_itemID";
            columnExpression20.Table = table3;
            column20.Expression = columnExpression20;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.Columns.Add(column9);
            selectQuery1.Columns.Add(column10);
            selectQuery1.Columns.Add(column11);
            selectQuery1.Columns.Add(column12);
            selectQuery1.Columns.Add(column13);
            selectQuery1.Columns.Add(column14);
            selectQuery1.Columns.Add(column15);
            selectQuery1.Columns.Add(column16);
            selectQuery1.Columns.Add(column17);
            selectQuery1.Columns.Add(column18);
            selectQuery1.Columns.Add(column19);
            selectQuery1.Columns.Add(column20);
            selectQuery1.Name = "view_allitems_1";
            relationColumnInfo1.NestedKeyColumn = "bp_id";
            relationColumnInfo1.ParentKeyColumn = "id";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            relationColumnInfo2.NestedKeyColumn = "cat_id";
            relationColumnInfo2.ParentKeyColumn = "bp_bcID";
            join2.KeyColumns.Add(relationColumnInfo2);
            join2.Nested = table7;
            join2.Parent = table2;
            relationColumnInfo3.NestedKeyColumn = "area_id";
            relationColumnInfo3.ParentKeyColumn = "cat_baID";
            join3.KeyColumns.Add(relationColumnInfo3);
            join3.Nested = table6;
            join3.Parent = table7;
            relationColumnInfo4.NestedKeyColumn = "act_bpID";
            relationColumnInfo4.ParentKeyColumn = "bp_id";
            join4.KeyColumns.Add(relationColumnInfo4);
            table8.MetaSerializable = "<Meta X=\"340\" Y=\"70\" Width=\"125\" Height=\"134\" />";
            table8.Name = "rc_assessment_active";
            join4.Nested = table8;
            join4.Parent = table2;
            relationColumnInfo5.NestedKeyColumn = "pro_ID";
            relationColumnInfo5.ParentKeyColumn = "act_projectID";
            join5.KeyColumns.Add(relationColumnInfo5);
            join5.Nested = table5;
            join5.Parent = table8;
            relationColumnInfo6.NestedKeyColumn = "res_projectID";
            relationColumnInfo6.ParentKeyColumn = "pro_ID";
            join6.KeyColumns.Add(relationColumnInfo6);
            join6.Nested = table3;
            join6.Parent = table5;
            relationColumnInfo7.NestedKeyColumn = "mil_id";
            relationColumnInfo7.ParentKeyColumn = "res_milestoneID";
            join7.KeyColumns.Add(relationColumnInfo7);
            join7.Nested = table4;
            join7.Parent = table3;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Relations.Add(join2);
            selectQuery1.Relations.Add(join3);
            selectQuery1.Relations.Add(join4);
            selectQuery1.Relations.Add(join5);
            selectQuery1.Relations.Add(join6);
            selectQuery1.Relations.Add(join7);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            selectQuery1.Tables.Add(table7);
            selectQuery1.Tables.Add(table6);
            selectQuery1.Tables.Add(table8);
            selectQuery1.Tables.Add(table5);
            selectQuery1.Tables.Add(table3);
            selectQuery1.Tables.Add(table4);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // count_of_area_names
            // 
            this.count_of_area_names.DataMember = "view_allitems_1";
            this.count_of_area_names.Expression = "[area_name].count()";
            this.count_of_area_names.Name = "count_of_area_names";
            // 
            // xrLabel29
            // 
            this.xrLabel29.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[count_of_area_names]")});
            this.xrLabel29.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 69.54168F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(220.0001F, 120F);
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.StylePriority.UseTextAlignment = false;
            this.xrLabel29.Text = "5";
            this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel31
            // 
            this.xrLabel31.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[count_of_bp_name]")});
            this.xrLabel31.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(9.999847F, 69.54168F);
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(220.0002F, 120F);
            this.xrLabel31.StylePriority.UseFont = false;
            this.xrLabel31.StylePriority.UseTextAlignment = false;
            this.xrLabel31.Text = "BP";
            this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel31.TextFormatString = "{0:#,#}";
            // 
            // count_of_bp_name
            // 
            this.count_of_bp_name.DataMember = "view_allitems_1";
            this.count_of_bp_name.Expression = "[bp_name].count()";
            this.count_of_bp_name.Name = "count_of_bp_name";
            // 
            // rep_pro_Business_Architecture_Analysis
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.PageFooter,
            this.ReportHeader,
            this.BCM_Quality_Tables,
            this.DetailReport});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.count_of_area_names,
            this.count_of_bp_name});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "view_allitems_1";
            this.DataSource = this.sqlDataSource1;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(25, 26, 25, 25);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.PaperKind = System.Drawing.Printing.PaperKind.LetterRotated;
            this.Version = "17.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
