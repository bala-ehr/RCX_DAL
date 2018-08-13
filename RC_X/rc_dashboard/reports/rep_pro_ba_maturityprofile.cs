using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Text;

/// <summary>
/// Summary description for rep_pro_ba_maturityprofile
/// </summary>
public class rep_pro_ba_maturityprofile : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private PageHeaderBand PageHeader;
    private XRLabel xrLabel1;
    private XRLabel xrLabel2;
    private GroupHeaderBand GroupHeader1;
    private XRLabel xrLabel9;
    private XRLabel xrLabel8;
    private XRLabel xrLabel7;
    private XRLabel xrLabel6;
    private XRLabel xrLabel5;
    private XRLabel xrLabel4;
    private XRLabel xrLabel3;
    private PageFooterBand PageFooter;
    private XRLabel xrLabel17;
    private XRPageInfo xrPageInfo2;
    private XRPageInfo xrPageInfo1;
    private XRLine xrLine1;
    private XRLabel xrLabel18;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private DevExpress.XtraReports.Parameters.Parameter ProjectID;
    private DevExpress.XtraReports.Parameters.Parameter ProjectName;
    private DevExpress.XtraReports.Parameters.Parameter ProjectColor;
    private XRTable DetailTable;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell92;
    private XRTableCell xrTableCell94;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell7;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public rep_pro_ba_maturityprofile()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rep_pro_ba_maturityprofile));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.DetailTable = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell92 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell94 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.ProjectID = new DevExpress.XtraReports.Parameters.Parameter();
            this.ProjectName = new DevExpress.XtraReports.Parameters.Parameter();
            this.ProjectColor = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.DetailTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.DetailTable});
            this.Detail.HeightF = 31.97739F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Business Process", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // DetailTable
            // 
            this.DetailTable.BackColor = System.Drawing.Color.Transparent;
            this.DetailTable.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.DetailTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.DetailTable.Name = "DetailTable";
            this.DetailTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow8});
            this.DetailTable.SizeF = new System.Drawing.SizeF(785.9967F, 25F);
            this.DetailTable.StylePriority.UseBackColor = false;
            this.DetailTable.StylePriority.UseBorders = false;
            this.DetailTable.StylePriority.UseTextAlignment = false;
            this.DetailTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell92,
            this.xrTableCell94,
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 1D;
            // 
            // xrTableCell92
            // 
            this.xrTableCell92.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BP ID]")});
            this.xrTableCell92.Name = "xrTableCell92";
            this.xrTableCell92.Text = "Area name ";
            this.xrTableCell92.Weight = 0.534514734762184D;
            // 
            // xrTableCell94
            // 
            this.xrTableCell94.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Business Process]")});
            this.xrTableCell94.Name = "xrTableCell94";
            this.xrTableCell94.Text = "Process Name";
            this.xrTableCell94.Weight = 2.1829398405931673D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[As-Is]")});
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "AsIs";
            this.xrTableCell1.Visible = false;
            this.xrTableCell1.Weight = 0.29551219400831674D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[To-Be]")});
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "ToBe";
            this.xrTableCell2.Visible = false;
            this.xrTableCell2.Weight = 0.33438827038514568D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "xrTableCell3";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell3.Weight = 0.585343430985466D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "xrTableCell4";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell4.Weight = 0.585343430985466D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "xrTableCell5";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell5.Weight = 0.585343430985466D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.Text = "xrTableCell6";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell6.Weight = 0.585343430985466D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "xrTableCell7";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell7.Weight = 0.585343430985466D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 19F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 3.916613F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrLabel2,
            this.xrLabel1});
            this.PageHeader.HeightF = 69.33334F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(1.271566E-05F, 46.33334F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(785.9968F, 23F);
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[ProjectName]")});
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(387.6249F, 46.33334F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Project Name";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel2.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel2_BeforePrint);
            // 
            // xrLabel1
            // 
            this.xrLabel1.Bookmark = "Summary";
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(387.625F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(398.375F, 46.33334F);
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Business Architecture Maturity";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel1_BeforePrint);
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Business Area", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 38.33333F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(712.6666F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(73.33325F, 35.5F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Level 5";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(639.3366F, 0F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(73.33002F, 35.5F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Level 4";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(566.0066F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(73.33002F, 35.5F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Level 3";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(492.6766F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(73.32999F, 35.5F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Level 2";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(419.3466F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(73.33005F, 35.5F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Level 1";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Business Area]")});
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(66.96238F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(273.4721F, 35.5F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "area_name";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel3.BorderColor = System.Drawing.Color.Blue;
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Area Identifier]")});
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(66.96238F, 35.5F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "area_Identifier";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel18,
            this.xrPageInfo1,
            this.xrPageInfo2,
            this.xrLabel17});
            this.PageFooter.HeightF = 113.2084F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrLabel18
            // 
            this.xrLabel18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(660.1667F, 76.66666F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(66.97913F, 35.50002F);
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "page";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel18.TextTrimming = System.Drawing.StringTrimming.None;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(727.1459F, 76.66666F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(58.85413F, 35.50001F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 76.66666F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(269.2708F, 36.54169F);
            this.xrPageInfo2.StylePriority.UseFont = false;
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel17
            // 
            this.xrLabel17.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(0F, 53.57295F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(197.2917F, 23.09373F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Generated by ReadyCert® for";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DevDB";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            queryParameter1.Name = "ProjectID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.ProjectID]", typeof(System.Guid));
            customSqlQuery1.Parameters.Add(queryParameter1);
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // ProjectID
            // 
            this.ProjectID.Description = "ProjectID";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.Type = typeof(System.Guid);
            this.ProjectID.ValueInfo = "00000000-0000-0000-0000-000000000000";
            this.ProjectID.Visible = false;
            // 
            // ProjectName
            // 
            this.ProjectName.Description = "ProjectName";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Visible = false;
            // 
            // ProjectColor
            // 
            this.ProjectColor.Description = "ProjectColor";
            this.ProjectColor.Name = "ProjectColor";
            this.ProjectColor.Visible = false;
            // 
            // rep_pro_ba_maturityprofile
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.GroupHeader1,
            this.PageFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "Query";
            this.DataSource = this.sqlDataSource1;
            this.FilterString = "[BP Deleted] = False";
            this.Margins = new System.Drawing.Printing.Margins(51, 0, 19, 4);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.ProjectID,
            this.ProjectName,
            this.ProjectColor});
            this.Version = "17.2";
            ((System.ComponentModel.ISupportInitialize)(this.DetailTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion


    private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        try
        {
            xrTableCell3.Text = "";
            xrTableCell3.BackColor = Color.White;
            xrTableCell4.Text = "";
            xrTableCell4.BackColor = Color.White;
            xrTableCell5.Text = "";
            xrTableCell5.BackColor = Color.White;
            xrTableCell6.Text = "";
            xrTableCell6.BackColor = Color.White;
            xrTableCell7.Text = "";
            xrTableCell7.BackColor = Color.White;

            var currentBPID = GetCurrentColumnValue("BP ID").ToString();
            var AsIS = Convert.ToInt32(GetCurrentColumnValue("As-Is").ToString());
            var ToBE = Convert.ToInt32(GetCurrentColumnValue("To-Be").ToString());

            if ((AsIS == 0 && ToBE == 0) || (AsIS == 1 && ToBE == 1))
            {
                //StringBuilder sb = new StringBuilder();
                //sb.AppendLine("As-Is");
                //sb.AppendLine("To-Be");
                //xrTableCell3.Text = sb.ToString().Replace(Environment.NewLine, " ");

                xrTableCell3.Text = "As-Is " + Environment.NewLine + "To-Be";
                xrTableCell3.BackColor = Color.LawnGreen;
                xrTableCell4.Text = "";
                xrTableCell4.BackColor = Color.White;
                xrTableCell5.Text = "";
                xrTableCell5.BackColor = Color.White;
                xrTableCell6.Text = "";
                xrTableCell6.BackColor = Color.White;
                xrTableCell7.Text = "";
                xrTableCell7.BackColor = Color.White;
            }
            if (AsIS <= 1 && ToBE > 1)
            {
                xrTableCell3.Text = "As-Is";
                xrTableCell3.BackColor = Color.LightBlue;
                //xrTableCell4.Text = "";
                //xrTableCell4.BackColor = Color.White;
                //xrTableCell5.Text = "";
                //xrTableCell5.BackColor = Color.White;
                //xrTableCell6.Text = "";
                //xrTableCell6.BackColor = Color.White;
                //xrTableCell7.Text = "";
                //xrTableCell7.BackColor = Color.White;
            }
             if (AsIS > 1 && ToBE <= 1)
            {
                xrTableCell3.Text = "To-Be";
                xrTableCell3.BackColor = Color.Yellow;
                //xrTableCell4.Text = "";
                //xrTableCell4.BackColor = Color.White;
                //xrTableCell5.Text = "";
                //xrTableCell5.BackColor = Color.White;
                //xrTableCell6.Text = "";
                //xrTableCell6.BackColor = Color.White;
                //xrTableCell7.Text = "";
                //xrTableCell7.BackColor = Color.White;
            }
             if (AsIS == 2 && ToBE == 2)
            {
                xrTableCell4.Text = "As-Is " + Environment.NewLine + "To-Be";
                xrTableCell4.BackColor = Color.LawnGreen;
                xrTableCell3.Text = "";
                xrTableCell3.BackColor = Color.White;
                xrTableCell5.Text = "";
                xrTableCell5.BackColor = Color.White;
                xrTableCell6.Text = "";
                xrTableCell6.BackColor = Color.White;
                xrTableCell7.Text = "";
                xrTableCell7.BackColor = Color.White;
            }
             if (AsIS == 2 && (ToBE > 2 || ToBE <= 1))
            {
                xrTableCell4.Text = "As-Is";
                xrTableCell4.BackColor = Color.LightBlue;
                //xrTableCell3.Text = "";
                //xrTableCell3.BackColor = Color.White;
                //xrTableCell5.Text = "";
                //xrTableCell5.BackColor = Color.White;
                //xrTableCell6.Text = "";
                //xrTableCell6.BackColor = Color.White;
                //xrTableCell7.Text = "";
                //xrTableCell7.BackColor = Color.White;
            }
             if ((AsIS > 2 || AsIS <= 1) && ToBE == 2)
            {
                xrTableCell4.Text = "To-Be";
                xrTableCell4.BackColor = Color.Yellow;
                //xrTableCell3.Text = "";
                //xrTableCell3.BackColor = Color.White;
                //xrTableCell5.Text = "";
                //xrTableCell5.BackColor = Color.White;
                //xrTableCell6.Text = "";
                //xrTableCell6.BackColor = Color.White;
                //xrTableCell7.Text = "";
                //xrTableCell7.BackColor = Color.White;
            }
             if (AsIS == 3 && ToBE == 3)
            {
                xrTableCell5.Text = "As-Is " + Environment.NewLine + "To-Be";
                xrTableCell5.BackColor = Color.LawnGreen;
                //xrTableCell3.Text = "";
                //xrTableCell3.BackColor = Color.White;
                //xrTableCell4.Text = "";
                //xrTableCell4.BackColor = Color.White;
                //xrTableCell6.Text = "";
                //xrTableCell6.BackColor = Color.White;
                //xrTableCell7.Text = "";
                //xrTableCell7.BackColor = Color.White;
            }
             if (AsIS == 3 && (ToBE > 3 || ToBE <= 2))
            {
                xrTableCell5.Text = "As-Is";
                xrTableCell5.BackColor = Color.LightBlue;
                //xrTableCell3.Text = "";
                //xrTableCell3.BackColor = Color.White;
                //xrTableCell4.Text = "";
                //xrTableCell4.BackColor = Color.White;
                //xrTableCell6.Text = "";
                //xrTableCell6.BackColor = Color.White;
                //xrTableCell7.Text = "";
                //xrTableCell7.BackColor = Color.White;
            }
             if ((AsIS > 3 || AsIS <= 2) && ToBE == 3)
            {
                xrTableCell5.Text = "To-Be";
                xrTableCell5.BackColor = Color.Yellow;
                //xrTableCell3.Text = "";
                //xrTableCell3.BackColor = Color.White;
                //xrTableCell4.Text = "";
                //xrTableCell4.BackColor = Color.White;
                //xrTableCell6.Text = "";
                //xrTableCell6.BackColor = Color.White;
                //xrTableCell7.Text = "";
                //xrTableCell7.BackColor = Color.White;
            }
             if (AsIS == 4 && ToBE == 4)
            {
                xrTableCell6.Text = "As-Is " + Environment.NewLine + "To-Be";
                xrTableCell6.BackColor = Color.LawnGreen;
                //xrTableCell3.Text = "";
                //xrTableCell3.BackColor = Color.White;
                //xrTableCell4.Text = "";
                //xrTableCell4.BackColor = Color.White;
                //xrTableCell5.Text = "";
                //xrTableCell5.BackColor = Color.White;
                //xrTableCell7.Text = "";
                //xrTableCell7.BackColor = Color.White;
            }
             if (AsIS == 4 && (ToBE > 4 || ToBE <= 3))
            {
                xrTableCell6.Text = "As-Is";
                xrTableCell6.BackColor = Color.LightBlue;
                //xrTableCell3.Text = "";
                //xrTableCell3.BackColor = Color.White;
                //xrTableCell4.Text = "";
                //xrTableCell4.BackColor = Color.White;
                //xrTableCell5.Text = "";
                //xrTableCell5.BackColor = Color.White;
                //xrTableCell7.Text = "";
                //xrTableCell7.BackColor = Color.White;
            }
             if ((AsIS > 4 || AsIS <= 3) && ToBE == 4)
            {
                xrTableCell6.Text = "To-Be";
                xrTableCell6.BackColor = Color.Yellow;
                //xrTableCell3.Text = "";
                //xrTableCell3.BackColor = Color.White;
                //xrTableCell4.Text = "";
                //xrTableCell4.BackColor = Color.White;
                //xrTableCell5.Text = "";
                //xrTableCell5.BackColor = Color.White;
                //xrTableCell7.Text = "";
                //xrTableCell7.BackColor = Color.White;
            }
             if (AsIS == 5 && ToBE == 5)
            {
                xrTableCell7.Text = "As-Is " + Environment.NewLine + "To-Be";
                xrTableCell7.BackColor = Color.LawnGreen;
                //xrTableCell3.Text = "";
                //xrTableCell3.BackColor = Color.White;
                //xrTableCell4.Text = "";
                //xrTableCell4.BackColor = Color.White;
                //xrTableCell5.Text = "";
                //xrTableCell5.BackColor = Color.White;
                //xrTableCell6.Text = "";
                //xrTableCell6.BackColor = Color.White;
            }
             if (AsIS == 5 && (ToBE > 5 || ToBE <= 4))
            {
                xrTableCell7.Text = "As-Is";
                xrTableCell7.BackColor = Color.LightBlue;
                //xrTableCell3.Text = "";
                //xrTableCell3.BackColor = Color.White;
                //xrTableCell4.Text = "";
                //xrTableCell4.BackColor = Color.White;
                //xrTableCell5.Text = "";
                //xrTableCell5.BackColor = Color.White;
                //xrTableCell6.Text = "";
                //xrTableCell6.BackColor = Color.White;
            }
             if ((AsIS > 5 || AsIS <= 4) && ToBE == 5)
            {
                xrTableCell7.Text = "To-Be";
                xrTableCell7.BackColor = Color.Yellow;
                //xrTableCell3.Text = "";
                //xrTableCell3.BackColor = Color.White;
                //xrTableCell4.Text = "";
                //xrTableCell4.BackColor = Color.White;
                //xrTableCell5.Text = "";
                //xrTableCell5.BackColor = Color.White;
                //xrTableCell6.Text = "";
                //xrTableCell6.BackColor = Color.White;
            }
        }
        catch
        {
        }
    }

    private void xrLabel2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        XRLabel ProjecName = (XRLabel)sender;

        string ProjectColor = this.Parameters["ProjectColor"].Value.ToString();
        ProjecName.BackColor = System.Drawing.ColorTranslator.FromHtml(ProjectColor);
    }

    private void xrLabel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        XRLabel ProjecName = (XRLabel)sender;

        string ProjectColor = this.Parameters["ProjectColor"].Value.ToString();
        ProjecName.BackColor = System.Drawing.ColorTranslator.FromHtml(ProjectColor);
    }
}
