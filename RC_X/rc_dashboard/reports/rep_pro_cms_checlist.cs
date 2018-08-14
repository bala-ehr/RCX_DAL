using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Web.UI.WebControls;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Sql.DataApi;
using System.Data;
using System.Linq;
using System.IO;
using DevExpress.Spreadsheet;


/// <summary>
/// Summary description for rep_pro_cms_checlist
/// </summary>
public class rep_pro_cms_checlist : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private GroupHeaderBand Objective;
    private GroupHeaderBand Checklist;
    private XRLabel xrLabel6;
    private XRLabel xrLabel5;
    private XRLabel xrLabel2;
    private XRLabel xrLabel1;
    private XRLabel xrLabel8;
    private XRLabel xrLabel7;
    private XRLabel xrLabel21;
    private XRLabel xrLabel22;
    private XRLabel xrLabel23;
    private XRLabel xrLabel24;
    private XRLabel xrLabel25;
    private XRLabel xrLabel26;
    private XRLabel xrLabel27;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell27;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell29;
    private XRTableCell xrTableCell30;
    private XRTableCell xrTableCell31;
    private XRTableCell xrTableCell32;
    private XRTableCell xrTableCell33;
    private XRTableCell xrTableCell34;
    private XRTableCell xrTableCell35;
    private XRTableCell xrTableCell36;
    private XRTableCell xrTableCell37;
    private XRTableCell xrTableCell38;
    private XRTableCell xrTableCell39;
    private XRTableCell xrTableCell40;
    private XRTableCell xrTableCell41;
    private XRTableCell xrTableCell42;
    private XRLabel xrLabel3;
    private XRLabel xrLabel4;
    private XRLabel xrLabel9;
    private XRLabel xrLabel10;
    private XRLabel xrLabel11;
    private XRLabel xrLabel12;
    private XRLabel xrLabel13;
    private XRLabel xrLabel28;
    private XRLabel xrLabel29;
    private XRLabel xrLabel30;
    private XRLabel xrLabel31;
    private XRLabel xrLabel32;
    private XRLabel xrLabel33;
    private XRLabel xrLabel34;
    private DevExpress.XtraReports.Parameters.Parameter ProjectID;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private XRCheckBox xrCheckBox3;
    private XRCheckBox xrCheckBox2;
    private XRCheckBox xrCheckBox1;
    private DevExpress.XtraReports.Parameters.Parameter ChecklistID;
    private XRPictureBox xrPictureBox1;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public rep_pro_cms_checlist()
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
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rep_pro_cms_checlist));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo1 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Objective = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.Checklist = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrCheckBox3 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox2 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox1 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.ProjectID = new DevExpress.XtraReports.Parameters.Parameter();
            this.ChecklistID = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DevDB";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.MetaSerializable = "<Meta X=\"20\" Y=\"20\" Width=\"100\" Height=\"377\" />";
            customSqlQuery1.Name = "Query";
            queryParameter1.Name = "ProjectID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.ProjectID]", typeof(System.Guid));
            queryParameter2.Name = "ChecklistID";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.ChecklistID]", typeof(System.Guid));
            customSqlQuery1.Parameters.Add(queryParameter1);
            customSqlQuery1.Parameters.Add(queryParameter2);
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            customSqlQuery2.MetaSerializable = "<Meta X=\"970\" Y=\"90\" Width=\"100\" Height=\"88\" />";
            customSqlQuery2.Name = "Query_1";
            queryParameter3.Name = "ProjectID";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.ProjectID]", typeof(System.Guid));
            customSqlQuery2.Parameters.Add(queryParameter3);
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            customSqlQuery3.MetaSerializable = "<Meta X=\"220\" Y=\"20\" Width=\"100\" Height=\"71\" />";
            customSqlQuery3.Name = "Query_2";
            queryParameter4.Name = "ProjectID";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.ProjectID]", typeof(System.Guid));
            customSqlQuery3.Parameters.Add(queryParameter4);
            customSqlQuery3.Sql = resources.GetString("customSqlQuery3.Sql");
            customSqlQuery4.MetaSerializable = "<Meta X=\"730\" Y=\"20\" Width=\"100\" Height=\"649\" />";
            customSqlQuery4.Name = "Query_3";
            queryParameter5.Name = "ProjectID";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("[Parameters.ProjectID]", typeof(System.Guid));
            queryParameter6.Name = "ChecklistID";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("[Parameters.ChecklistID]", typeof(System.Guid));
            customSqlQuery4.Parameters.Add(queryParameter5);
            customSqlQuery4.Parameters.Add(queryParameter6);
            customSqlQuery4.Sql = resources.GetString("customSqlQuery4.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            customSqlQuery2,
            customSqlQuery3,
            customSqlQuery4});
            masterDetailInfo1.DetailQueryName = "Query_1";
            relationColumnInfo1.NestedKeyColumn = "att_itemid";
            relationColumnInfo1.ParentKeyColumn = "R1Criteria Id";
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo1);
            masterDetailInfo1.MasterQueryName = "Query_3";
            this.sqlDataSource1.Relations.AddRange(new DevExpress.DataAccess.Sql.MasterDetailInfo[] {
            masterDetailInfo1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.HeightF = 30F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable2
            // 
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(3000F, 30F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell22,
            this.xrTableCell23,
            this.xrTableCell24,
            this.xrTableCell25,
            this.xrTableCell26,
            this.xrTableCell27,
            this.xrTableCell28,
            this.xrTableCell29,
            this.xrTableCell30,
            this.xrTableCell31,
            this.xrTableCell32,
            this.xrTableCell33,
            this.xrTableCell34,
            this.xrTableCell35,
            this.xrTableCell36,
            this.xrTableCell37,
            this.xrTableCell38,
            this.xrTableCell39,
            this.xrTableCell40,
            this.xrTableCell41,
            this.xrTableCell42});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[R1Criteria Title]")});
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.Text = "xrTableCell1";
            this.xrTableCell22.Weight = 1.4834555249284889D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[R1Criteria]")});
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.Text = "xrTableCell2";
            this.xrTableCell23.Weight = 3.2723268694629266D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[R1Criteria Source]")});
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.Text = "xrTableCell3";
            this.xrTableCell24.Weight = 1.5663591551859954D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[R1Response Assesment]")});
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.Text = "xrTableCell4";
            this.xrTableCell25.Weight = 0.67846270925333085D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.Multiline = true;
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.Text = "[Query_3Query_1.titles]\r\n\r\n[R1Response]";
            this.xrTableCell26.Weight = 1.9328530950133067D;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[R1Reviewer Date]")});
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.Text = "xrTableCell7";
            this.xrTableCell27.TextFormatString = "{0:MM/dd/yyyy}";
            this.xrTableCell27.Weight = 1.068961269622261D;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[R1Reviewer]")});
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.Text = "xrTableCell8";
            this.xrTableCell28.Weight = 1.5510824798958089D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[R1Reviwer Assessments]")});
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.Text = "xrTableCell9";
            this.xrTableCell29.Weight = 1.6361610485103011D;
            // 
            // xrTableCell30
            // 
            this.xrTableCell30.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[R1Comments]")});
            this.xrTableCell30.Name = "xrTableCell30";
            this.xrTableCell30.Text = "xrTableCell10";
            this.xrTableCell30.Weight = 1.4965464263560144D;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[R2Response Assesment]")});
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.Text = "xrTableCell11";
            this.xrTableCell31.Weight = 0.678460812102033D;
            // 
            // xrTableCell32
            // 
            this.xrTableCell32.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[R2Response]")});
            this.xrTableCell32.Name = "xrTableCell32";
            this.xrTableCell32.Text = "xrTableCell12";
            this.xrTableCell32.Weight = 1.9328537842309679D;
            // 
            // xrTableCell33
            // 
            this.xrTableCell33.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[R2Reviewer Date]")});
            this.xrTableCell33.Name = "xrTableCell33";
            this.xrTableCell33.Text = "xrTableCell13";
            this.xrTableCell33.TextFormatString = "{0:MM/dd/yyyy}";
            this.xrTableCell33.Weight = 1.0689619562405825D;
            // 
            // xrTableCell34
            // 
            this.xrTableCell34.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[R2Reviewer]")});
            this.xrTableCell34.Name = "xrTableCell34";
            this.xrTableCell34.Text = "xrTableCell14[]";
            this.xrTableCell34.Weight = 1.5510831193992622D;
            // 
            // xrTableCell35
            // 
            this.xrTableCell35.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[R2Reviwer Assessments]")});
            this.xrTableCell35.Name = "xrTableCell35";
            this.xrTableCell35.Text = "xrTableCell15";
            this.xrTableCell35.Weight = 1.6361623369076019D;
            // 
            // xrTableCell36
            // 
            this.xrTableCell36.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[R2Comments]")});
            this.xrTableCell36.Name = "xrTableCell36";
            this.xrTableCell36.Text = "xrTableCell16";
            this.xrTableCell36.Weight = 1.496543949571457D;
            // 
            // xrTableCell37
            // 
            this.xrTableCell37.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[R3Response Assesment]")});
            this.xrTableCell37.Name = "xrTableCell37";
            this.xrTableCell37.Text = "xrTableCell17";
            this.xrTableCell37.Weight = 0.67846084283656616D;
            // 
            // xrTableCell38
            // 
            this.xrTableCell38.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[R3Response]")});
            this.xrTableCell38.Name = "xrTableCell38";
            this.xrTableCell38.Text = "xrTableCell18";
            this.xrTableCell38.Weight = 1.9328524358221273D;
            // 
            // xrTableCell39
            // 
            this.xrTableCell39.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[R3Reviewer Date]")});
            this.xrTableCell39.Name = "xrTableCell39";
            this.xrTableCell39.Text = "xrTableCell19";
            this.xrTableCell39.TextFormatString = "{0:MM/dd/yyyy}";
            this.xrTableCell39.Weight = 0.84644366063566423D;
            // 
            // xrTableCell40
            // 
            this.xrTableCell40.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[R3Reviewer]")});
            this.xrTableCell40.Name = "xrTableCell40";
            this.xrTableCell40.Text = "xrTableCell20";
            this.xrTableCell40.Weight = 1.7735962607840321D;
            // 
            // xrTableCell41
            // 
            this.xrTableCell41.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[R3Reviwer Assessments]")});
            this.xrTableCell41.Name = "xrTableCell41";
            this.xrTableCell41.Text = "xrTableCell21";
            this.xrTableCell41.Weight = 1.6361610459515994D;
            // 
            // xrTableCell42
            // 
            this.xrTableCell42.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[R3Comments]")});
            this.xrTableCell42.Name = "xrTableCell42";
            this.xrTableCell42.Text = "xrTableCell6";
            this.xrTableCell42.Weight = 1.4965527019743841D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.StylePriority.UseFont = false;
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Objective
            // 
            this.Objective.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel27});
            this.Objective.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("R1Objective Id", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Objective.HeightF = 36.54168F;
            this.Objective.Name = "Objective";
            // 
            // xrLabel27
            // 
            this.xrLabel27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(218)))), ((int)(((byte)(78)))));
            this.xrLabel27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[R1Objective Name]")});
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(3000F, 36.54168F);
            this.xrLabel27.StylePriority.UseBackColor = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            this.xrLabel27.Text = "Objective Name";
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // Checklist
            // 
            this.Checklist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(217)))), ((int)(((byte)(241)))));
            this.Checklist.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.xrCheckBox3,
            this.xrCheckBox2,
            this.xrCheckBox1,
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel9,
            this.xrLabel10,
            this.xrLabel11,
            this.xrLabel12,
            this.xrLabel13,
            this.xrLabel28,
            this.xrLabel29,
            this.xrLabel30,
            this.xrLabel31,
            this.xrLabel32,
            this.xrLabel33,
            this.xrLabel34,
            this.xrLabel21,
            this.xrLabel22,
            this.xrLabel23,
            this.xrLabel24,
            this.xrLabel25,
            this.xrLabel26,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel2,
            this.xrLabel1});
            this.Checklist.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("R1Checklist Id", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Checklist.HeightF = 152.0833F;
            this.Checklist.Level = 1;
            this.Checklist.Name = "Checklist";
            this.Checklist.StylePriority.UseBackColor = false;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(212.5F, 35.49998F);
            // 
            // xrCheckBox3
            // 
            this.xrCheckBox3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrCheckBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrCheckBox3.LocationFloat = new DevExpress.Utils.PointFloat(212.5F, 76.29167F);
            this.xrCheckBox3.Name = "xrCheckBox3";
            this.xrCheckBox3.SizeF = new System.Drawing.SizeF(391.2505F, 23F);
            this.xrCheckBox3.StylePriority.UseBorders = false;
            this.xrCheckBox3.StylePriority.UseFont = false;
            this.xrCheckBox3.Text = "Operational";
            this.xrCheckBox3.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrCheckBox3_BeforePrint);
            // 
            // xrCheckBox2
            // 
            this.xrCheckBox2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrCheckBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrCheckBox2.LocationFloat = new DevExpress.Utils.PointFloat(374.5838F, 35.49998F);
            this.xrCheckBox2.Name = "xrCheckBox2";
            this.xrCheckBox2.SizeF = new System.Drawing.SizeF(229.1667F, 40.79169F);
            this.xrCheckBox2.StylePriority.UseBorders = false;
            this.xrCheckBox2.StylePriority.UseFont = false;
            this.xrCheckBox2.Text = "Final";
            this.xrCheckBox2.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrCheckBox2_BeforePrint);
            // 
            // xrCheckBox1
            // 
            this.xrCheckBox1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrCheckBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrCheckBox1.LocationFloat = new DevExpress.Utils.PointFloat(212.5F, 35.49998F);
            this.xrCheckBox1.Name = "xrCheckBox1";
            this.xrCheckBox1.SizeF = new System.Drawing.SizeF(162.0838F, 40.79167F);
            this.xrCheckBox1.StylePriority.UseBorders = false;
            this.xrCheckBox1.StylePriority.UseFont = false;
            this.xrCheckBox1.Text = "Project Initiation";
            this.xrCheckBox1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrCheckBox1_BeforePrint);
            // 
            // xrLabel3
            // 
            this.xrLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(217)))), ((int)(((byte)(241)))));
            this.xrLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(603.7507F, 35.49998F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(798.7492F, 63.79167F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Project Initiation Milestone Review";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel4
            // 
            this.xrLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(217)))), ((int)(((byte)(241)))));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(603.7507F, 99.29167F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(64.79163F, 52.79166F);
            this.xrLabel4.StylePriority.UseBackColor = false;
            this.xrLabel4.Text = "Yes/No";
            // 
            // xrLabel9
            // 
            this.xrLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(217)))), ((int)(((byte)(241)))));
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(668.5424F, 99.29167F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(184.1666F, 52.79166F);
            this.xrLabel9.StylePriority.UseBackColor = false;
            this.xrLabel9.Text = "Milestone Evidance";
            // 
            // xrLabel10
            // 
            this.xrLabel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(853.1258F, 99.29167F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(102.0833F, 52.79166F);
            this.xrLabel10.StylePriority.UseBackColor = false;
            this.xrLabel10.Text = "Riview Date";
            // 
            // xrLabel11
            // 
            this.xrLabel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(955.2091F, 99.29167F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(148.1246F, 52.79166F);
            this.xrLabel11.StylePriority.UseBackColor = false;
            this.xrLabel11.Text = "Reviewer Name";
            // 
            // xrLabel12
            // 
            this.xrLabel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(1103.334F, 99.29167F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(156.2493F, 52.79166F);
            this.xrLabel12.StylePriority.UseBackColor = false;
            this.xrLabel12.Text = "Reviewer Assessment";
            // 
            // xrLabel13
            // 
            this.xrLabel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(1259.583F, 99.29167F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(142.9169F, 52.79166F);
            this.xrLabel13.StylePriority.UseBackColor = false;
            this.xrLabel13.Text = "Reviewer Comments";
            // 
            // xrLabel28
            // 
            this.xrLabel28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.xrLabel28.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(1402.5F, 35.49998F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(798.7495F, 63.79167F);
            this.xrLabel28.StylePriority.UseBackColor = false;
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.Text = "Operational Milestone Review(s)";
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel29
            // 
            this.xrLabel29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(1402.5F, 99.29167F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(64.79163F, 52.79166F);
            this.xrLabel29.StylePriority.UseBackColor = false;
            this.xrLabel29.Text = "Yes/No";
            // 
            // xrLabel30
            // 
            this.xrLabel30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(1467.292F, 99.29167F);
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(184.1665F, 52.79166F);
            this.xrLabel30.StylePriority.UseBackColor = false;
            this.xrLabel30.Text = "Milestone Evidance";
            // 
            // xrLabel31
            // 
            this.xrLabel31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(1651.875F, 99.29167F);
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(102.0834F, 52.79166F);
            this.xrLabel31.StylePriority.UseBackColor = false;
            this.xrLabel31.Text = "Riview Date";
            // 
            // xrLabel32
            // 
            this.xrLabel32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(1753.959F, 99.29167F);
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(148.1249F, 52.79166F);
            this.xrLabel32.StylePriority.UseBackColor = false;
            this.xrLabel32.Text = "Reviewer Name";
            // 
            // xrLabel33
            // 
            this.xrLabel33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(1902.084F, 99.29167F);
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(156.25F, 52.79166F);
            this.xrLabel33.StylePriority.UseBackColor = false;
            this.xrLabel33.Text = "Reviewer Assessment";
            // 
            // xrLabel34
            // 
            this.xrLabel34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(2058.334F, 99.29167F);
            this.xrLabel34.Name = "xrLabel34";
            this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel34.SizeF = new System.Drawing.SizeF(142.9158F, 52.79166F);
            this.xrLabel34.StylePriority.UseBackColor = false;
            this.xrLabel34.Text = "Reviewer Comments";
            // 
            // xrLabel21
            // 
            this.xrLabel21.BackColor = System.Drawing.Color.RoyalBlue;
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(2201.25F, 99.29167F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(64.79175F, 52.79166F);
            this.xrLabel21.StylePriority.UseBackColor = false;
            this.xrLabel21.Text = "Yes/No";
            // 
            // xrLabel22
            // 
            this.xrLabel22.BackColor = System.Drawing.Color.RoyalBlue;
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(2266.042F, 99.29167F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(184.1665F, 52.79166F);
            this.xrLabel22.StylePriority.UseBackColor = false;
            this.xrLabel22.Text = "Milestone Evidance";
            // 
            // xrLabel23
            // 
            this.xrLabel23.BackColor = System.Drawing.Color.RoyalBlue;
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(2450.625F, 99.29167F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(80.83325F, 52.79166F);
            this.xrLabel23.StylePriority.UseBackColor = false;
            this.xrLabel23.Text = "Riview Date";
            // 
            // xrLabel24
            // 
            this.xrLabel24.BackColor = System.Drawing.Color.RoyalBlue;
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(2531.458F, 99.29167F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(169.3745F, 52.79166F);
            this.xrLabel24.StylePriority.UseBackColor = false;
            this.xrLabel24.Text = "Reviewer Name";
            // 
            // xrLabel25
            // 
            this.xrLabel25.BackColor = System.Drawing.Color.RoyalBlue;
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(2700.833F, 99.29167F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(156.25F, 52.79166F);
            this.xrLabel25.StylePriority.UseBackColor = false;
            this.xrLabel25.Text = "Reviewer Assessment";
            // 
            // xrLabel26
            // 
            this.xrLabel26.BackColor = System.Drawing.Color.RoyalBlue;
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(2857.083F, 99.29167F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(142.917F, 52.79166F);
            this.xrLabel26.StylePriority.UseBackColor = false;
            this.xrLabel26.Text = "Reviewer Comments";
            // 
            // xrLabel8
            // 
            this.xrLabel8.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(454.1667F, 99.29167F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(149.5838F, 52.79166F);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Source";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel7
            // 
            this.xrLabel7.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(141.6667F, 99.29167F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(312.4999F, 52.79166F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "System Review Criteria";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel6
            // 
            this.xrLabel6.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrLabel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel6.ForeColor = System.Drawing.Color.Red;
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(3.576279E-05F, 99.29167F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(141.6667F, 52.79166F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Ref # \r\n(MITA State-specific)\r\n";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.xrLabel5.BorderColor = System.Drawing.Color.Black;
            this.xrLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(2201.25F, 35.49998F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(798.75F, 63.79167F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Final Milestone Certification Review";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(217)))), ((int)(((byte)(241)))));
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 35.49998F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(212.5F, 63.79169F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Milestone Review(s)";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(217)))), ((int)(((byte)(241)))));
            this.xrLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(212.5F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(2787.5F, 35.5F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Checklist Title";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel1_BeforePrint);
            // 
            // ProjectID
            // 
            this.ProjectID.Description = "ProjectID";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.Type = typeof(System.Guid);
            this.ProjectID.ValueInfo = "00000000-0000-0000-0000-000000000000";
            this.ProjectID.Visible = false;
            // 
            // ChecklistID
            // 
            this.ChecklistID.Description = "ChecklistID";
            this.ChecklistID.Name = "ChecklistID";
            this.ChecklistID.Type = typeof(System.Guid);
            this.ChecklistID.ValueInfo = "00000000-0000-0000-0000-000000000000";
            this.ChecklistID.Visible = false;
            // 
            // rep_pro_cms_checlist
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.Objective,
            this.Checklist});
            this.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "Query_3";
            this.DataSource = this.sqlDataSource1;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageWidth = 3000;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.ProjectID,
            this.ChecklistID});
            this.Version = "17.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    

    private void xrCheckBox1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        ITable src = sqlDataSource1.Result["Query"];
        DataTable dest = new DataTable("Query");
        foreach (IColumn column in src.Columns)
            dest.Columns.Add(column.Name, column.Type);
        foreach (IRow row in src)
            dest.Rows.Add(row.ToArray());

        String milestone = "R1";
        bool contains = dest.AsEnumerable().Any(row => milestone == row.Field<String>("Milestone Type"));


        if (contains == true)
        {
            xrCheckBox1.Checked = true;
        }


    }

    private void xrCheckBox2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        ITable src = sqlDataSource1.Result["Query"];
        DataTable dest = new DataTable("Query");
        foreach (IColumn column in src.Columns)
            dest.Columns.Add(column.Name, column.Type);
        foreach (IRow row in src)
            dest.Rows.Add(row.ToArray());

        String milestone = "R3";
        bool contains = dest.AsEnumerable().Any(row => milestone == row.Field<String>("Milestone Type"));
        if (contains == true)
        {
            xrCheckBox2.Checked = true;
        }
       
    }

    private void xrCheckBox3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        ITable src = sqlDataSource1.Result["Query"];
        DataTable dest = new DataTable("Query");
        foreach (IColumn column in src.Columns)
            dest.Columns.Add(column.Name, column.Type);
        foreach (IRow row in src)
            dest.Rows.Add(row.ToArray());

        String milestone = "R2";
        bool contains = dest.AsEnumerable().Any(row => milestone == row.Field<String>("Milestone Type"));


        if (contains == true)
        {
            xrCheckBox3.Checked = true;
        }

    }

    private void xrLabel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        xrLabel1.Text = "";
        var checklistName = GetCurrentColumnValue("R1Checklist Title").ToString();
        xrLabel1.Text = checklistName + " Checklist (MITA Module)";
    }

    private void xrPictureBox1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        //System.Drawing.Image image = System.Drawing.Image.FromFile(@"..\..\Content\Images\CMSLogo.jpg");

        //xrPictureBox1.Image = System.Drawing.Image.FromFile("CMSLogo.jpg");
        //xrPictureBox1.ImageUrl = @"..\..\Content\Images\CMSLogo.jpg";
        // xrPictureBox1.Image = new Bitmap("C:/Users/Mohan Babu/Source27/Repos/RCX/RC_X/Content/Images/CMSLogo.jpg");
        //xrPictureBox1.Image = new Bitmap("http://wiki.readycert.net/cmslogofeat2.jpg");
        xrPictureBox1.ImageUrl = "http://wiki.readycert.net/cmslogofeat2.jpg";

        
    }
}
