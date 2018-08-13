using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for rep_pro_state_self_assessment
/// </summary>
public class Spacer : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private ReportHeaderBand coverpage_toc;
    private XRPageBreak xrPageBreak1;
    private XRControlStyle BlueStyle_table_or_label;
    private XRControlStyle output_grey;
    private XRControlStyle yellow_heading_1;
    private XRControlStyle yellow_heading_2;
    private XRControlStyle output_whiteback;
    private XRControlStyle body;
    private XRControlStyle light_yellow_heading;
    private XRControlStyle light_yellow_body;
    private XRControlStyle yellow_heading_3;
    private XRControlStyle Heading_1;
    private XRControlStyle heading_2;
    private XRControlStyle heading_3;
    private XRControlStyle green_heading;
    private PageFooterBand PageFooter;
    private XRLabel xrLabel4;
    private XRPictureBox xrPictureBox9;
    private XRPictureBox xrPictureBox7;
    private XRPictureBox xrPictureBox6;
    private XRPictureBox xrPictureBox5;
    private XRPictureBox xrPictureBox4;
    private XRPictureBox xrPictureBox3;
    private XRPictureBox xrPictureBox2;
    private XRLabel xrLabel3;
    private XRLabel xrLabel2;
    private XRPictureBox xrPictureBox8;
    private XRPictureBox xrPictureBox10;
    private XRLabel xrLabel5;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel12;
    private XRPageInfo xrPageInfo2;
    private XRLabel xrLabel9;
    private XRPageInfo xrPageInfo1;
    private XRPanel xrPanel1;
    private XRLine xrLine2;
    private XRLine xrLine1;
    private XRLabel xrLabel1;
    private XRLine xrLine14;
    private XRLine xrLine13;
    private XRLine xrLine12;
    private XRLine xrLine11;
    private XRLabel xrLabel20;
    private XRLabel xrLabel10;
    private XRLabel xrLabel15;
    private XRLabel xrLabel17;
    private XRLabel xrLabel13;
    private XRLine xrLine10;
    private XRLine xrLine9;
    private XRLine xrLine8;
    private XRLine xrLine7;
    private XRLine xrLine6;
    private XRLine xrLine5;
    private XRLine xrLine4;
    private XRLine xrLine3;
    private XRLabel xrLabel19;
    private XRLabel xrLabel16;
    private XRLabel xrLabel14;
    private XRLabel xrLabel11;
    private XRLabel xrLabel8;
    private DetailReportBand APD_Checklist;
    private DetailBand Detail1;
    private DetailReportBand BA_Profile;
    private DetailBand Detail6;
    private DetailReportBand IA_profile;
    private DetailBand Detail2;
    private DetailReportBand TA_Profile;
    private DetailBand Detail3;
    private DetailReportBand SC_Profile;
    private DetailBand Detail4;
    private XRPanel xrPanel3;
    private XRTableOfContents xrTableOfContents1;
    private PageHeaderBand PageHeader;
    private XRPanel headerpanel;
    private XRLabel xrLabel7;
    private XRLabel xrLabel6;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell1;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public Spacer()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spacer));
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
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.coverpage_toc = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrPageBreak1 = new DevExpress.XtraReports.UI.XRPageBreak();
            this.BlueStyle_table_or_label = new DevExpress.XtraReports.UI.XRControlStyle();
            this.output_grey = new DevExpress.XtraReports.UI.XRControlStyle();
            this.yellow_heading_1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.yellow_heading_2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.output_whiteback = new DevExpress.XtraReports.UI.XRControlStyle();
            this.body = new DevExpress.XtraReports.UI.XRControlStyle();
            this.light_yellow_heading = new DevExpress.XtraReports.UI.XRControlStyle();
            this.light_yellow_body = new DevExpress.XtraReports.UI.XRControlStyle();
            this.yellow_heading_3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.Heading_1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.heading_2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.heading_3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.green_heading = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPictureBox8 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPictureBox3 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPictureBox4 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPictureBox5 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPictureBox6 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPictureBox7 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPictureBox9 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPictureBox10 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine6 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine7 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine8 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine9 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine10 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine11 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine12 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine13 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine14 = new DevExpress.XtraReports.UI.XRLine();
            this.APD_Checklist = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.BA_Profile = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail6 = new DevExpress.XtraReports.UI.DetailBand();
            this.IA_profile = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail2 = new DevExpress.XtraReports.UI.DetailBand();
            this.TA_Profile = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail3 = new DevExpress.XtraReports.UI.DetailBand();
            this.SC_Profile = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail4 = new DevExpress.XtraReports.UI.DetailBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.headerpanel = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableOfContents1 = new DevExpress.XtraReports.UI.XRTableOfContents();
            this.xrPanel3 = new DevExpress.XtraReports.UI.XRPanel();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 495.8452F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 100F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // coverpage_toc
            // 
            this.coverpage_toc.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel3,
            this.xrTableOfContents1,
            this.xrPanel1,
            this.xrLine1,
            this.xrLabel1,
            this.xrLabel5,
            this.xrLabel4,
            this.xrPictureBox9,
            this.xrPictureBox7,
            this.xrPictureBox6,
            this.xrPictureBox5,
            this.xrPictureBox4,
            this.xrPictureBox3,
            this.xrPictureBox2,
            this.xrLabel3,
            this.xrLabel2,
            this.xrPictureBox8,
            this.xrPageBreak1,
            this.xrPictureBox10,
            this.xrPictureBox1});
            this.coverpage_toc.HeightF = 1613.358F;
            this.coverpage_toc.KeepTogether = true;
            this.coverpage_toc.Name = "coverpage_toc";
            this.coverpage_toc.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            // 
            // xrPageBreak1
            // 
            this.xrPageBreak1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1000.374F);
            this.xrPageBreak1.Name = "xrPageBreak1";
            // 
            // BlueStyle_table_or_label
            // 
            this.BlueStyle_table_or_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.BlueStyle_table_or_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueStyle_table_or_label.Name = "BlueStyle_table_or_label";
            this.BlueStyle_table_or_label.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BlueStyle_table_or_label.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // output_grey
            // 
            this.output_grey.BackColor = System.Drawing.Color.WhiteSmoke;
            this.output_grey.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_grey.Name = "output_grey";
            this.output_grey.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            // 
            // yellow_heading_1
            // 
            this.yellow_heading_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.yellow_heading_1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellow_heading_1.Name = "yellow_heading_1";
            this.yellow_heading_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            // 
            // yellow_heading_2
            // 
            this.yellow_heading_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.yellow_heading_2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellow_heading_2.Name = "yellow_heading_2";
            this.yellow_heading_2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            // 
            // output_whiteback
            // 
            this.output_whiteback.BackColor = System.Drawing.Color.White;
            this.output_whiteback.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_whiteback.Name = "output_whiteback";
            this.output_whiteback.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.Color.White;
            this.body.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.body.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.body.BorderWidth = 0F;
            this.body.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.body.ForeColor = System.Drawing.Color.Black;
            this.body.Name = "body";
            this.body.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.body.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // light_yellow_heading
            // 
            this.light_yellow_heading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.light_yellow_heading.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.light_yellow_heading.Name = "light_yellow_heading";
            // 
            // light_yellow_body
            // 
            this.light_yellow_body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.light_yellow_body.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.light_yellow_body.Name = "light_yellow_body";
            // 
            // yellow_heading_3
            // 
            this.yellow_heading_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.yellow_heading_3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellow_heading_3.ForeColor = System.Drawing.Color.SteelBlue;
            this.yellow_heading_3.Name = "yellow_heading_3";
            this.yellow_heading_3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            // 
            // Heading_1
            // 
            this.Heading_1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading_1.ForeColor = System.Drawing.Color.SteelBlue;
            this.Heading_1.Name = "Heading_1";
            this.Heading_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            // 
            // heading_2
            // 
            this.heading_2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_2.Name = "heading_2";
            this.heading_2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            // 
            // heading_3
            // 
            this.heading_3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.heading_3.Name = "heading_3";
            this.heading_3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            // 
            // green_heading
            // 
            this.green_heading.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.green_heading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.green_heading.Name = "green_heading";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel12,
            this.xrPageInfo2,
            this.xrLabel9,
            this.xrPageInfo1});
            this.PageFooter.HeightF = 90.05364F;
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.PrintOn = ((DevExpress.XtraReports.UI.PrintOnPages)((DevExpress.XtraReports.UI.PrintOnPages.NotWithReportHeader | DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter)));
            // 
            // xrPictureBox8
            // 
            this.xrPictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox8.Image")));
            this.xrPictureBox8.LocationFloat = new DevExpress.Utils.PointFloat(415.1008F, 814.1093F);
            this.xrPictureBox8.Name = "xrPictureBox8";
            this.xrPictureBox8.SizeF = new System.Drawing.SizeF(232.8992F, 117.2649F);
            this.xrPictureBox8.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(444.6008F, 931.3742F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(178.6914F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Report Generated by ReadyCert";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Today()")});
            this.xrLabel3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(444.6008F, 954.3742F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(178.6914F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel3.TextFormatString = "{0:dd MMMM yyyy}";
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox2.Image")));
            this.xrPictureBox2.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopCenter;
            this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(36F, 868.84F);
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.SizeF = new System.Drawing.SizeF(25.73512F, 131.5342F);
            // 
            // xrPictureBox3
            // 
            this.xrPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox3.Image")));
            this.xrPictureBox3.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopCenter;
            this.xrPictureBox3.LocationFloat = new DevExpress.Utils.PointFloat(45.99998F, 916.6343F);
            this.xrPictureBox3.Name = "xrPictureBox3";
            this.xrPictureBox3.SizeF = new System.Drawing.SizeF(25.73512F, 83.73993F);
            // 
            // xrPictureBox4
            // 
            this.xrPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox4.Image")));
            this.xrPictureBox4.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopCenter;
            this.xrPictureBox4.LocationFloat = new DevExpress.Utils.PointFloat(58.58818F, 949.9307F);
            this.xrPictureBox4.Name = "xrPictureBox4";
            this.xrPictureBox4.SizeF = new System.Drawing.SizeF(22.68504F, 50.44348F);
            // 
            // xrPictureBox5
            // 
            this.xrPictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox5.Image")));
            this.xrPictureBox5.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopCenter;
            this.xrPictureBox5.LocationFloat = new DevExpress.Utils.PointFloat(112.8377F, 916.6343F);
            this.xrPictureBox5.Name = "xrPictureBox5";
            this.xrPictureBox5.SizeF = new System.Drawing.SizeF(25.73512F, 83.73993F);
            // 
            // xrPictureBox6
            // 
            this.xrPictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox6.Image")));
            this.xrPictureBox6.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopCenter;
            this.xrPictureBox6.LocationFloat = new DevExpress.Utils.PointFloat(105.8531F, 850.3325F);
            this.xrPictureBox6.Name = "xrPictureBox6";
            this.xrPictureBox6.SizeF = new System.Drawing.SizeF(25.73512F, 150.0417F);
            // 
            // xrPictureBox7
            // 
            this.xrPictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox7.Image")));
            this.xrPictureBox7.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopCenter;
            this.xrPictureBox7.LocationFloat = new DevExpress.Utils.PointFloat(87.10254F, 897.0263F);
            this.xrPictureBox7.Name = "xrPictureBox7";
            this.xrPictureBox7.SizeF = new System.Drawing.SizeF(25.73513F, 103.348F);
            // 
            // xrPictureBox9
            // 
            this.xrPictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox9.Image")));
            this.xrPictureBox9.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopCenter;
            this.xrPictureBox9.LocationFloat = new DevExpress.Utils.PointFloat(61.36741F, 878.6439F);
            this.xrPictureBox9.Name = "xrPictureBox9";
            this.xrPictureBox9.SizeF = new System.Drawing.SizeF(25.73512F, 121.7304F);
            // 
            // xrPictureBox10
            // 
            this.xrPictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox10.Image")));
            this.xrPictureBox10.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopCenter;
            this.xrPictureBox10.LocationFloat = new DevExpress.Utils.PointFloat(61.73514F, 823.8436F);
            this.xrPictureBox10.Name = "xrPictureBox10";
            this.xrPictureBox10.SizeF = new System.Drawing.SizeF(49.38283F, 176.5306F);
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(444.6007F, 977.3742F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(178.6914F, 23F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "info@readycert.net";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(444.6008F, 0F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(128.6458F, 35.50002F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "page";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel12.TextTrimming = System.Drawing.StringTrimming.None;
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 23.0937F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(269.2708F, 36.54169F);
            this.xrPageInfo2.StylePriority.UseFont = false;
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(197.2917F, 23.09373F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Generated by ReadyCert® on:";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(573.5208F, 0F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(74.47919F, 35.50002F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(647.9999F, 774.1822F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            // 
            // xrLabel5
            // 
            this.xrLabel5.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLabel5.Font = new System.Drawing.Font("Segoe UI", 26F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(150.1666F, 278.755F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(348.2604F, 226.1252F);
            this.xrLabel5.StyleName = "green_heading";
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "State \r\nSelf-Assessment";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLabel1.Font = new System.Drawing.Font("Segoe UI", 26F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1035.036F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(648F, 52.87915F);
            this.xrLabel1.StyleName = "green_heading";
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Report Overview";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLine1
            // 
            this.xrLine1.BorderWidth = 1F;
            this.xrLine1.ForeColor = System.Drawing.Color.DarkGreen;
            this.xrLine1.LineWidth = 2;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(150.1665F, 1111.915F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(350.2604F, 2.192993F);
            this.xrLine1.StylePriority.UseBorderWidth = false;
            this.xrLine1.StylePriority.UseForeColor = false;
            // 
            // xrLine2
            // 
            this.xrLine2.BorderWidth = 0F;
            this.xrLine2.ForeColor = System.Drawing.Color.DarkGreen;
            this.xrLine2.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine2.LineWidth = 2;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(323.2267F, 0F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(2.049194F, 726.5741F);
            this.xrLine2.StylePriority.UseBorderWidth = false;
            this.xrLine2.StylePriority.UseForeColor = false;
            // 
            // xrPanel1
            // 
            this.xrPanel1.CanGrow = false;
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine14,
            this.xrLine13,
            this.xrLine12,
            this.xrLine11,
            this.xrLabel20,
            this.xrLabel10,
            this.xrLabel15,
            this.xrLabel17,
            this.xrLabel13,
            this.xrLine10,
            this.xrLine9,
            this.xrLine8,
            this.xrLine7,
            this.xrLine6,
            this.xrLine5,
            this.xrLine4,
            this.xrLine3,
            this.xrLabel19,
            this.xrLabel16,
            this.xrLabel14,
            this.xrLabel11,
            this.xrLabel8,
            this.xrLine2});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1114.108F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(648F, 196F);
            // 
            // xrLabel19
            // 
            this.xrLabel19.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(152.2159F, 115.6057F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(171.0107F, 26.75673F);
            this.xrLabel19.StyleName = "output_grey";
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Count of Repository Items";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel16
            // 
            this.xrLabel16.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(152.2158F, 86.70422F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(171.0107F, 26.75689F);
            this.xrLabel16.StyleName = "output_grey";
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "Count of Responses";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(152.2158F, 57.80273F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(171.0109F, 26.7569F);
            this.xrLabel14.StyleName = "output_grey";
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "Count of Milestones";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(152.2158F, 28.90137F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(171.0109F, 26.75667F);
            this.xrLabel11.StyleName = "output_grey";
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Count of Business Processes";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(152.2158F, 0F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(171.0109F, 26.75667F);
            this.xrLabel8.StyleName = "output_grey";
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Count of Business Areas";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel13
            // 
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(325.2759F, 0F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(173.1019F, 26.75676F);
            this.xrLabel13.StyleName = "output_grey";
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "countdistinct(business area)";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel10
            // 
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(325.2759F, 28.90137F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(173.1018F, 26.75671F);
            this.xrLabel10.StyleName = "output_grey";
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "countdistinct(business process)";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel15
            // 
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(325.2758F, 57.8028F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(173.1019F, 26.75684F);
            this.xrLabel15.StyleName = "output_grey";
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "countdistinct(milestones)";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel17
            // 
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(325.276F, 86.70426F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(173.1018F, 26.75687F);
            this.xrLabel17.StyleName = "output_grey";
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "countdistinct(responses)";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel20
            // 
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(325.276F, 115.6057F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(173.1017F, 26.75671F);
            this.xrLabel20.StyleName = "output_grey";
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "countdistinct(rep items)";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLine3
            // 
            this.xrLine3.BorderWidth = 0F;
            this.xrLine3.ForeColor = System.Drawing.Color.DarkGreen;
            this.xrLine3.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine3.LineWidth = 2;
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(150.1666F, 0F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(2.049194F, 726.5741F);
            this.xrLine3.StylePriority.UseBorderWidth = false;
            this.xrLine3.StylePriority.UseForeColor = false;
            // 
            // xrLine4
            // 
            this.xrLine4.BorderWidth = 0F;
            this.xrLine4.ForeColor = System.Drawing.Color.DarkGreen;
            this.xrLine4.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine4.LineWidth = 2;
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(498.3778F, 0F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(2.049194F, 726.5741F);
            this.xrLine4.StylePriority.UseBorderWidth = false;
            this.xrLine4.StylePriority.UseForeColor = false;
            // 
            // xrLine5
            // 
            this.xrLine5.BorderWidth = 0F;
            this.xrLine5.ForeColor = System.Drawing.Color.DarkGreen;
            this.xrLine5.LineWidth = 2;
            this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(152.2159F, 26.75667F);
            this.xrLine5.Name = "xrLine5";
            this.xrLine5.SizeF = new System.Drawing.SizeF(171.0106F, 2.144609F);
            this.xrLine5.StylePriority.UseBorderWidth = false;
            this.xrLine5.StylePriority.UseForeColor = false;
            // 
            // xrLine6
            // 
            this.xrLine6.BorderWidth = 0F;
            this.xrLine6.ForeColor = System.Drawing.Color.DarkGreen;
            this.xrLine6.LineWidth = 2;
            this.xrLine6.LocationFloat = new DevExpress.Utils.PointFloat(152.2161F, 55.65808F);
            this.xrLine6.Name = "xrLine6";
            this.xrLine6.SizeF = new System.Drawing.SizeF(171.0106F, 2.144609F);
            this.xrLine6.StylePriority.UseBorderWidth = false;
            this.xrLine6.StylePriority.UseForeColor = false;
            // 
            // xrLine7
            // 
            this.xrLine7.BorderWidth = 0F;
            this.xrLine7.ForeColor = System.Drawing.Color.DarkGreen;
            this.xrLine7.LineWidth = 2;
            this.xrLine7.LocationFloat = new DevExpress.Utils.PointFloat(325.2758F, 26.75676F);
            this.xrLine7.Name = "xrLine7";
            this.xrLine7.SizeF = new System.Drawing.SizeF(173.1019F, 2.144609F);
            this.xrLine7.StylePriority.UseBorderWidth = false;
            this.xrLine7.StylePriority.UseForeColor = false;
            // 
            // xrLine8
            // 
            this.xrLine8.BorderWidth = 0F;
            this.xrLine8.ForeColor = System.Drawing.Color.DarkGreen;
            this.xrLine8.LineWidth = 2;
            this.xrLine8.LocationFloat = new DevExpress.Utils.PointFloat(152.2158F, 142.3625F);
            this.xrLine8.Name = "xrLine8";
            this.xrLine8.SizeF = new System.Drawing.SizeF(171.0106F, 2.144609F);
            this.xrLine8.StylePriority.UseBorderWidth = false;
            this.xrLine8.StylePriority.UseForeColor = false;
            // 
            // xrLine9
            // 
            this.xrLine9.BorderWidth = 0F;
            this.xrLine9.ForeColor = System.Drawing.Color.DarkGreen;
            this.xrLine9.LineWidth = 2;
            this.xrLine9.LocationFloat = new DevExpress.Utils.PointFloat(152.2161F, 84.55957F);
            this.xrLine9.Name = "xrLine9";
            this.xrLine9.SizeF = new System.Drawing.SizeF(171.0106F, 2.144609F);
            this.xrLine9.StylePriority.UseBorderWidth = false;
            this.xrLine9.StylePriority.UseForeColor = false;
            // 
            // xrLine10
            // 
            this.xrLine10.BorderWidth = 0F;
            this.xrLine10.ForeColor = System.Drawing.Color.DarkGreen;
            this.xrLine10.LineWidth = 2;
            this.xrLine10.LocationFloat = new DevExpress.Utils.PointFloat(152.2158F, 113.4611F);
            this.xrLine10.Name = "xrLine10";
            this.xrLine10.SizeF = new System.Drawing.SizeF(171.0106F, 2.144609F);
            this.xrLine10.StylePriority.UseBorderWidth = false;
            this.xrLine10.StylePriority.UseForeColor = false;
            // 
            // xrLine11
            // 
            this.xrLine11.BorderWidth = 0F;
            this.xrLine11.ForeColor = System.Drawing.Color.DarkGreen;
            this.xrLine11.LineWidth = 2;
            this.xrLine11.LocationFloat = new DevExpress.Utils.PointFloat(325.2758F, 55.65809F);
            this.xrLine11.Name = "xrLine11";
            this.xrLine11.SizeF = new System.Drawing.SizeF(173.1019F, 2.144609F);
            this.xrLine11.StylePriority.UseBorderWidth = false;
            this.xrLine11.StylePriority.UseForeColor = false;
            // 
            // xrLine12
            // 
            this.xrLine12.BorderWidth = 0F;
            this.xrLine12.ForeColor = System.Drawing.Color.DarkGreen;
            this.xrLine12.LineWidth = 2;
            this.xrLine12.LocationFloat = new DevExpress.Utils.PointFloat(325.276F, 84.55958F);
            this.xrLine12.Name = "xrLine12";
            this.xrLine12.SizeF = new System.Drawing.SizeF(173.1019F, 2.144609F);
            this.xrLine12.StylePriority.UseBorderWidth = false;
            this.xrLine12.StylePriority.UseForeColor = false;
            // 
            // xrLine13
            // 
            this.xrLine13.BorderWidth = 0F;
            this.xrLine13.ForeColor = System.Drawing.Color.DarkGreen;
            this.xrLine13.LineWidth = 2;
            this.xrLine13.LocationFloat = new DevExpress.Utils.PointFloat(325.2758F, 113.4611F);
            this.xrLine13.Name = "xrLine13";
            this.xrLine13.SizeF = new System.Drawing.SizeF(173.1019F, 2.144609F);
            this.xrLine13.StylePriority.UseBorderWidth = false;
            this.xrLine13.StylePriority.UseForeColor = false;
            // 
            // xrLine14
            // 
            this.xrLine14.BorderWidth = 0F;
            this.xrLine14.ForeColor = System.Drawing.Color.DarkGreen;
            this.xrLine14.LineWidth = 2;
            this.xrLine14.LocationFloat = new DevExpress.Utils.PointFloat(325.2759F, 142.3625F);
            this.xrLine14.Name = "xrLine14";
            this.xrLine14.SizeF = new System.Drawing.SizeF(173.1019F, 2.144609F);
            this.xrLine14.StylePriority.UseBorderWidth = false;
            this.xrLine14.StylePriority.UseForeColor = false;
            // 
            // APD_Checklist
            // 
            this.APD_Checklist.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
            this.APD_Checklist.DataMember = "rc_ent_apd_1";
            this.APD_Checklist.DataSource = this.sqlDataSource1;
            this.APD_Checklist.Level = 0;
            this.APD_Checklist.Name = "APD_Checklist";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail1.HeightF = 25F;
            this.Detail1.Name = "Detail1";
            // 
            // BA_Profile
            // 
            this.BA_Profile.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail6});
            this.BA_Profile.Level = 1;
            this.BA_Profile.Name = "BA_Profile";
            // 
            // Detail6
            // 
            this.Detail6.HeightF = 100F;
            this.Detail6.Name = "Detail6";
            // 
            // IA_profile
            // 
            this.IA_profile.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail2});
            this.IA_profile.Level = 2;
            this.IA_profile.Name = "IA_profile";
            // 
            // Detail2
            // 
            this.Detail2.HeightF = 100F;
            this.Detail2.Name = "Detail2";
            // 
            // TA_Profile
            // 
            this.TA_Profile.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail3});
            this.TA_Profile.Level = 3;
            this.TA_Profile.Name = "TA_Profile";
            // 
            // Detail3
            // 
            this.Detail3.HeightF = 100F;
            this.Detail3.Name = "Detail3";
            // 
            // SC_Profile
            // 
            this.SC_Profile.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail4});
            this.SC_Profile.Level = 4;
            this.SC_Profile.Name = "SC_Profile";
            // 
            // Detail4
            // 
            this.Detail4.HeightF = 80.64512F;
            this.Detail4.Name = "Detail4";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.headerpanel});
            this.PageHeader.HeightF = 77.41944F;
            this.PageHeader.Name = "PageHeader";
            // 
            // headerpanel
            // 
            this.headerpanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7,
            this.xrLabel6});
            this.headerpanel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.SizeF = new System.Drawing.SizeF(648F, 77.41944F);
            // 
            // xrLabel6
            // 
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(384.6936F, 9.999996F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 6, 2, 2, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(263.3065F, 54.43549F);
            this.xrLabel6.StyleName = "heading_2";
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Parameters.Project";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel7
            // 
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 9.999996F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 6, 2, 2, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(384.6935F, 54.43549F);
            this.xrLabel7.StyleName = "heading_2";
            this.xrLabel7.StylePriority.UsePadding = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Parameters.Project";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableOfContents1
            // 
            this.xrTableOfContents1.LevelDefault.Height = 23F;
            this.xrTableOfContents1.LevelDefault.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableOfContents1.LevelTitle.Height = 148F;
            this.xrTableOfContents1.LevelTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableOfContents1.LevelTitle.Text = "Title";
            this.xrTableOfContents1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1432.358F);
            this.xrTableOfContents1.Name = "xrTableOfContents1";
            // 
            // xrPanel3
            // 
            this.xrPanel3.BackColor = System.Drawing.Color.White;
            this.xrPanel3.LocationFloat = new DevExpress.Utils.PointFloat(1.845821E-05F, 1002.374F);
            this.xrPanel3.Name = "xrPanel3";
            this.xrPanel3.SizeF = new System.Drawing.SizeF(648.0001F, 32.66125F);
            this.xrPanel3.StylePriority.UseBackColor = false;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DevDB";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "apd_id";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"210\" />";
            table1.Name = "rc_ent_apd";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "apd_type";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "apd_number";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "apd_description";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "apd_startdate";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "apd_enddate";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "apd_Name";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "apd_deleted";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.Name = "rc_ent_apd_1";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(1.845821E-05F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(647.9999F, 25F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell1});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 11.5D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[apd_Name]")});
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "xrTableCell5";
            this.xrTableCell5.Weight = 0.083198268006187542D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[apd_number]")});
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Text = "xrTableCell6";
            this.xrTableCell6.Weight = 0.12288571760979225D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[apd_startdate]")});
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Text = "xrTableCell7";
            this.xrTableCell7.Weight = 0.10377333200988177D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[apd_enddate]")});
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Text = "xrTableCell8";
            this.xrTableCell8.Weight = 0.0839653395371596D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[apd_type]")});
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "xrTableCell1";
            this.xrTableCell1.Weight = 0.0839653395371596D;
            // 
            // Spacer
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.coverpage_toc,
            this.PageFooter,
            this.APD_Checklist,
            this.BA_Profile,
            this.IA_profile,
            this.TA_Profile,
            this.SC_Profile,
            this.PageHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DisplayName = "\"State Self-Assessment\"";
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margins = new System.Drawing.Printing.Margins(100, 102, 100, 0);
            this.Name = "Spacer";
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.BlueStyle_table_or_label,
            this.output_grey,
            this.yellow_heading_1,
            this.yellow_heading_2,
            this.output_whiteback,
            this.body,
            this.light_yellow_heading,
            this.light_yellow_body,
            this.yellow_heading_3,
            this.Heading_1,
            this.heading_2,
            this.heading_3,
            this.green_heading});
            this.Version = "17.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
