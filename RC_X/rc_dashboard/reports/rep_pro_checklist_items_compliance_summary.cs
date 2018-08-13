using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for rep_pro_checklist_items_compliance_summary
/// </summary>
public class rep_pro_checklist_items_compliance_summary : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private PageFooterBand PageFooter;
    private XRLabel xrLabel8;
    private XRLabel xrLabel6;
    private XRLine xrLine1;
    private XRLabel xrLabel10;
    private XRLabel xrLabel9;
    private XRLabel xrLabel19;
    private XRLabel xrLabel21;
    private XRLabel xrLabel17;
    private XRLabel xrLabel20;
    private XRControlStyle Label_Style_notable;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private XRLabel xrLabel24;
    private XRLabel xrLabel11;
    private XRControlStyle Output_Style;
    private XRLabel xrLabel18;
    private XRLabel xrLabel15;
    private DevExpress.XtraReports.Parameters.Parameter Project;
    private XRLabel xrLabel27;
    private XRLabel xrLabel28;
    private XRLabel xrLabel31;
    private XRLabel xrLabel33;
    private GroupHeaderBand chklist_title_group;
    private GroupHeaderBand SRC_TITLE_SORT_HEADER;
    private XRLabel xrLabel3;
    private XRLabel xrLabel1;
    private XRLabel xrLabel2;
    private GroupHeaderBand GroupHeader1;
    private CalculatedField calculatedField2;
    private XRLabel xrLabel7;
    private XRPageInfo xrPageInfo2;
    private XRRichText xrRichText2;
    private XRRichText xrRichText1;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public rep_pro_checklist_items_compliance_summary()
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.CustomExpression customExpression1 = new DevExpress.DataAccess.Sql.CustomExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.CustomExpression customExpression2 = new DevExpress.DataAccess.Sql.CustomExpression();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table5 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.CustomExpression customExpression3 = new DevExpress.DataAccess.Sql.CustomExpression();
            DevExpress.DataAccess.Sql.Column column14 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table6 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column15 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column16 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.CustomExpression customExpression4 = new DevExpress.DataAccess.Sql.CustomExpression();
            DevExpress.DataAccess.Sql.Column column17 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column18 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.CustomExpression customExpression5 = new DevExpress.DataAccess.Sql.CustomExpression();
            DevExpress.DataAccess.Sql.Column column19 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression14 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column20 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression15 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table7 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column21 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.CustomExpression customExpression6 = new DevExpress.DataAccess.Sql.CustomExpression();
            DevExpress.DataAccess.Sql.Column column22 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression16 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column23 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression17 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column24 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression18 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join3 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo3 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join4 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo4 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join5 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo5 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join6 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo6 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Table table8 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Join join7 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo7 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Sorting sorting1 = new DevExpress.DataAccess.Sql.Sorting();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression19 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Sorting sorting2 = new DevExpress.DataAccess.Sql.Sorting();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression20 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rep_pro_checklist_items_compliance_summary));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.Label_Style_notable = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.Output_Style = new DevExpress.XtraReports.UI.XRControlStyle();
            this.Project = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.chklist_title_group = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.SRC_TITLE_SORT_HEADER = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.calculatedField2 = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText2 = new DevExpress.XtraReports.UI.XRRichText();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DevDB";
            this.sqlDataSource1.Name = "sqlDataSource1";
            column1.Alias = "SRC Title";
            columnExpression1.ColumnName = "src_title";
            table1.MetaSerializable = "<Meta X=\"600\" Y=\"260\" Width=\"125\" Height=\"248\" />";
            table1.Name = "rc_rtm_criteria";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            column2.Alias = "Response to SRC";
            columnExpression2.ColumnName = "res_response";
            table2.MetaSerializable = "<Meta X=\"130\" Y=\"180\" Width=\"125\" Height=\"191\" />";
            table2.Name = "rc_responses";
            columnExpression2.Table = table2;
            column2.Expression = columnExpression2;
            column3.Alias = "nonsense-delete";
            customExpression1.Expression = "[rc_responses.res_date]";
            column3.Expression = customExpression1;
            column4.Alias = "Milestone Name";
            columnExpression3.ColumnName = "mil_name";
            table3.MetaSerializable = "<Meta X=\"380\" Y=\"370\" Width=\"125\" Height=\"153\" />";
            table3.Name = "rc_milestones";
            columnExpression3.Table = table3;
            column4.Expression = columnExpression3;
            column5.Alias = "Yes/No/N/A";
            columnExpression4.ColumnName = "res_assessment";
            columnExpression4.Table = table2;
            column5.Expression = columnExpression4;
            columnExpression5.ColumnName = "IsStatic";
            columnExpression5.Table = table3;
            column6.Expression = columnExpression5;
            column7.Alias = "SRC Definition";
            columnExpression6.ColumnName = "src_criteria";
            columnExpression6.Table = table1;
            column7.Expression = columnExpression6;
            column8.Alias = "SRC Source";
            columnExpression7.ColumnName = "src_source";
            columnExpression7.Table = table1;
            column8.Expression = columnExpression7;
            column9.Alias = "src deleted, 1=deleted, 0=not deleted";
            customExpression2.Expression = "tostr([rc_rtm_criteria.src_deleted])";
            column9.Expression = customExpression2;
            column10.Alias = "CSF? checked unchecked";
            columnExpression8.ColumnName = "src_critical";
            columnExpression8.Table = table1;
            column10.Expression = columnExpression8;
            column11.Alias = "Business Objective Name";
            columnExpression9.ColumnName = "bo_name";
            table4.MetaSerializable = "<Meta X=\"820\" Y=\"270\" Width=\"125\" Height=\"153\" />";
            table4.Name = "rc_rtm_objectives";
            columnExpression9.Table = table4;
            column11.Expression = columnExpression9;
            column12.Alias = "Checklist Title";
            columnExpression10.ColumnName = "ch_title";
            table5.MetaSerializable = "<Meta X=\"1010\" Y=\"290\" Width=\"125\" Height=\"134\" />";
            table5.Name = "rc_rtm_checklists";
            columnExpression10.Table = table5;
            column12.Expression = columnExpression10;
            column13.Alias = "checklist deleted, 1= deleted 0=not deleted";
            customExpression3.Expression = "TOSTR([rc_rtm_checklists.ch_deleted])";
            column13.Expression = customExpression3;
            columnExpression11.ColumnName = "eval_reviewer_assessments";
            table6.MetaSerializable = "<Meta X=\"430\" Y=\"50\" Width=\"210\" Height=\"210\" />";
            table6.Name = "rc_evaluation";
            columnExpression11.Table = table6;
            column14.Expression = columnExpression11;
            columnExpression12.ColumnName = "eval_description";
            columnExpression12.Table = table6;
            column15.Expression = columnExpression12;
            column16.Alias = "tostr_eval date";
            customExpression4.Expression = "TOINT([rc_evaluation.eval_date])";
            column16.Expression = customExpression4;
            columnExpression13.ColumnName = "eval_by";
            columnExpression13.Table = table6;
            column17.Expression = columnExpression13;
            column18.Alias = "bo deleted, 1=deleted =notdeleted";
            customExpression5.Expression = "ToSTR([rc_rtm_objectives.bo_deleted])";
            column18.Expression = customExpression5;
            columnExpression14.ColumnName = "res_date";
            columnExpression14.Table = table2;
            column19.Expression = columnExpression14;
            columnExpression15.ColumnName = "pro_name";
            table7.MetaSerializable = "<Meta X=\"1335\" Y=\"30\" Width=\"125\" Height=\"153\" />";
            table7.Name = "rc_projects";
            columnExpression15.Table = table7;
            column20.Expression = columnExpression15;
            column21.Alias = "ToSTR-Act_ISACTIVE";
            customExpression6.Expression = "ToSTR([rc_rtm_active.act_isacctive])";
            column21.Expression = customExpression6;
            columnExpression16.ColumnName = "src_deleted";
            columnExpression16.Table = table1;
            column22.Expression = columnExpression16;
            columnExpression17.ColumnName = "bo_deleted";
            columnExpression17.Table = table4;
            column23.Expression = columnExpression17;
            columnExpression18.ColumnName = "ch_deleted";
            columnExpression18.Table = table5;
            column24.Expression = columnExpression18;
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
            selectQuery1.Columns.Add(column21);
            selectQuery1.Columns.Add(column22);
            selectQuery1.Columns.Add(column23);
            selectQuery1.Columns.Add(column24);
            selectQuery1.Distinct = true;
            selectQuery1.FilterString = "[rc_rtm_criteria.src_title] Is Not Null And [rc_rtm_criteria.src_deleted] = \'0\'";
            selectQuery1.GroupFilterString = "";
            selectQuery1.Name = "rc_criteria_with_project_and_response";
            relationColumnInfo1.NestedKeyColumn = "bo_id";
            relationColumnInfo1.ParentKeyColumn = "src_objective";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table4;
            join1.Parent = table1;
            relationColumnInfo2.NestedKeyColumn = "ch_id";
            relationColumnInfo2.ParentKeyColumn = "bo_checklist";
            join2.KeyColumns.Add(relationColumnInfo2);
            join2.Nested = table5;
            join2.Parent = table4;
            relationColumnInfo3.NestedKeyColumn = "res_itemID";
            relationColumnInfo3.ParentKeyColumn = "src_id";
            join3.KeyColumns.Add(relationColumnInfo3);
            join3.Nested = table2;
            join3.Parent = table1;
            join3.Type = DevExpress.Xpo.DB.JoinType.LeftOuter;
            relationColumnInfo4.NestedKeyColumn = "mil_id";
            relationColumnInfo4.ParentKeyColumn = "res_milestoneID";
            join4.KeyColumns.Add(relationColumnInfo4);
            join4.Nested = table3;
            join4.Parent = table2;
            join4.Type = DevExpress.Xpo.DB.JoinType.LeftOuter;
            relationColumnInfo5.NestedKeyColumn = "eval_responseID";
            relationColumnInfo5.ParentKeyColumn = "res_id";
            join5.KeyColumns.Add(relationColumnInfo5);
            join5.Nested = table6;
            join5.Parent = table2;
            join5.Type = DevExpress.Xpo.DB.JoinType.LeftOuter;
            relationColumnInfo6.NestedKeyColumn = "act_checklist";
            relationColumnInfo6.ParentKeyColumn = "ch_id";
            join6.KeyColumns.Add(relationColumnInfo6);
            table8.MetaSerializable = "<Meta X=\"1180\" Y=\"260\" Width=\"125\" Height=\"134\" />";
            table8.Name = "rc_rtm_active";
            join6.Nested = table8;
            join6.Parent = table5;
            relationColumnInfo7.NestedKeyColumn = "pro_ID";
            relationColumnInfo7.ParentKeyColumn = "act_projectID";
            join7.KeyColumns.Add(relationColumnInfo7);
            join7.Nested = table7;
            join7.Parent = table8;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Relations.Add(join2);
            selectQuery1.Relations.Add(join3);
            selectQuery1.Relations.Add(join4);
            selectQuery1.Relations.Add(join5);
            selectQuery1.Relations.Add(join6);
            selectQuery1.Relations.Add(join7);
            columnExpression19.ColumnName = "ch_title";
            columnExpression19.Table = table5;
            sorting1.Expression = columnExpression19;
            columnExpression20.ColumnName = "src_title";
            columnExpression20.Table = table1;
            sorting2.Expression = columnExpression20;
            selectQuery1.Sorting.Add(sorting1);
            selectQuery1.Sorting.Add(sorting2);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table4);
            selectQuery1.Tables.Add(table5);
            selectQuery1.Tables.Add(table2);
            selectQuery1.Tables.Add(table3);
            selectQuery1.Tables.Add(table6);
            selectQuery1.Tables.Add(table8);
            selectQuery1.Tables.Add(table7);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText2,
            this.xrRichText1,
            this.xrLabel18,
            this.xrLabel15,
            this.xrLabel24,
            this.xrLabel9,
            this.xrLabel19,
            this.xrLabel21,
            this.xrLabel17,
            this.xrLabel20,
            this.xrLine1,
            this.xrLabel8,
            this.xrLabel6});
            this.Detail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detail.HeightF = 219.6396F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry;
            this.Detail.StylePriority.UseBorders = false;
            this.Detail.StylePriority.UseFont = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel18
            // 
            this.xrLabel18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[rc_criteria_with_project_and_response].[eval_reviewer_assessments]")});
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(534.2441F, 72.45616F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(290.7559F, 30.70511F);
            this.xrLabel18.StyleName = "Output_Style";
            this.xrLabel18.Text = "xrLabel18";
            // 
            // xrLabel15
            // 
            this.xrLabel15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[rc_criteria_with_project_and_response].[eval_date]")});
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(534.2443F, 29.56553F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(290.7559F, 30.7051F);
            this.xrLabel15.StyleName = "Output_Style";
            this.xrLabel15.Text = "xrLabel15";
            // 
            // xrLabel24
            // 
            this.xrLabel24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[rc_criteria_with_project_and_response].[Yes/No/N/A]")});
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(89.15498F, 29.23219F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(321.5891F, 31.03843F);
            this.xrLabel24.StyleName = "Output_Style";
            this.xrLabel24.Text = "xrLabel24";
            // 
            // xrLabel9
            // 
            this.xrLabel9.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrLabel9.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.xrLabel9.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel9.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel9.ForeColor = System.Drawing.Color.Black;
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.23219F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(89.15497F, 31.03844F);
            this.xrLabel9.StyleName = "Label_Style_notable";
            this.xrLabel9.StylePriority.UseBackColor = false;
            this.xrLabel9.StylePriority.UseBorderColor = false;
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseForeColor = false;
            this.xrLabel9.StylePriority.UsePadding = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Compliance:";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel19
            // 
            this.xrLabel19.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrLabel19.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.xrLabel19.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel19.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel19.ForeColor = System.Drawing.Color.Black;
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(414.2562F, 118.0455F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(119.9882F, 30.70511F);
            this.xrLabel19.StyleName = "Label_Style_notable";
            this.xrLabel19.StylePriority.UseBackColor = false;
            this.xrLabel19.StylePriority.UseBorderColor = false;
            this.xrLabel19.StylePriority.UseBorderDashStyle = false;
            this.xrLabel19.StylePriority.UseBorders = false;
            this.xrLabel19.StylePriority.UseBorderWidth = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseForeColor = false;
            this.xrLabel19.StylePriority.UsePadding = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Comments:";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel21
            // 
            this.xrLabel21.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrLabel21.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.xrLabel21.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel21.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel21.ForeColor = System.Drawing.Color.Black;
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(414.256F, 29.23217F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(119.9883F, 31.03846F);
            this.xrLabel21.StyleName = "Label_Style_notable";
            this.xrLabel21.StylePriority.UseBackColor = false;
            this.xrLabel21.StylePriority.UseBorderColor = false;
            this.xrLabel21.StylePriority.UseBorders = false;
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseForeColor = false;
            this.xrLabel21.StylePriority.UsePadding = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "Evaluation Date:";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel17
            // 
            this.xrLabel17.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrLabel17.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.xrLabel17.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel17.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel17.ForeColor = System.Drawing.Color.Black;
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(0F, 72.45616F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(89.15498F, 87.96115F);
            this.xrLabel17.StyleName = "Label_Style_notable";
            this.xrLabel17.StylePriority.UseBackColor = false;
            this.xrLabel17.StylePriority.UseBorderColor = false;
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseForeColor = false;
            this.xrLabel17.StylePriority.UsePadding = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "R1 Project Initiation Milestone Evidence";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel20
            // 
            this.xrLabel20.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrLabel20.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.xrLabel20.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel20.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel20.ForeColor = System.Drawing.Color.Black;
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(414.256F, 72.45616F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(119.9883F, 30.70511F);
            this.xrLabel20.StyleName = "Label_Style_notable";
            this.xrLabel20.StylePriority.UseBackColor = false;
            this.xrLabel20.StylePriority.UseBorderColor = false;
            this.xrLabel20.StylePriority.UseBorders = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseForeColor = false;
            this.xrLabel20.StylePriority.UsePadding = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "Assessment:";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 27.00001F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(825.0001F, 2.232145F);
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(411.7441F, 0F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(413.256F, 27.00001F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Evaluation";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(410.7441F, 27.00001F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Response";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 11.35119F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 12F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7,
            this.xrPageInfo2});
            this.PageFooter.HeightF = 45.50003F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel7.ForeColor = System.Drawing.Color.Black;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(197.2917F, 23.09373F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.StylePriority.UsePadding = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Generated by ReadyCert® on:";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPageInfo2.ForeColor = System.Drawing.Color.Black;
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 23.09373F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(197.2917F, 22.4063F);
            this.xrPageInfo2.StylePriority.UseFont = false;
            this.xrPageInfo2.StylePriority.UseForeColor = false;
            this.xrPageInfo2.StylePriority.UsePadding = false;
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel10
            // 
            this.xrLabel10.BackColor = System.Drawing.Color.Teal;
            this.xrLabel10.BorderColor = System.Drawing.Color.Black;
            this.xrLabel10.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[rc_criteria_with_project_and_response].[SRC Definition]")});
            this.xrLabel10.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel10.ForeColor = System.Drawing.Color.Black;
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(1.000023F, 22.51504F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 2, 2, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(410.7441F, 33.48211F);
            this.xrLabel10.StyleName = "Output_Style";
            this.xrLabel10.StylePriority.UseForeColor = false;
            this.xrLabel10.Text = "SRC CRITERIA FIELD (DEFINITION)";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Label_Style_notable
            // 
            this.Label_Style_notable.BackColor = System.Drawing.Color.DarkOrange;
            this.Label_Style_notable.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Style_notable.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Label_Style_notable.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Label_Style_notable.BorderWidth = 4F;
            this.Label_Style_notable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Style_notable.Name = "Label_Style_notable";
            this.Label_Style_notable.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 1, 1, 100F);
            this.Label_Style_notable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel11
            // 
            this.xrLabel11.BackColor = System.Drawing.Color.Teal;
            this.xrLabel11.BorderColor = System.Drawing.Color.Black;
            this.xrLabel11.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[rc_criteria_with_project_and_response].[SRC Source]")});
            this.xrLabel11.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel11.ForeColor = System.Drawing.Color.Black;
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(411.7441F, 22.51504F);
            this.xrLabel11.Multiline = true;
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 2, 2, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(413.2561F, 33.48211F);
            this.xrLabel11.StyleName = "Output_Style";
            this.xrLabel11.Text = "SRC Source";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Output_Style
            // 
            this.Output_Style.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Output_Style.BorderColor = System.Drawing.Color.Transparent;
            this.Output_Style.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Output_Style.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Output_Style.BorderWidth = 1F;
            this.Output_Style.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output_Style.Name = "Output_Style";
            this.Output_Style.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 0, 4, 0, 100F);
            this.Output_Style.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Project
            // 
            this.Project.Description = "Select a Project";
            dynamicListLookUpSettings1.DataAdapter = null;
            dynamicListLookUpSettings1.DataMember = "rc_criteria_with_project_and_response";
            dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings1.DisplayMember = "pro_name";
            dynamicListLookUpSettings1.ValueMember = "pro_name";
            this.Project.LookUpSettings = dynamicListLookUpSettings1;
            this.Project.MultiValue = true;
            this.Project.Name = "Project";
            // 
            // xrLabel27
            // 
            this.xrLabel27.BackColor = System.Drawing.Color.Teal;
            this.xrLabel27.BorderColor = System.Drawing.Color.White;
            this.xrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[rc_criteria_with_project_and_response].[Business Objective Name]")});
            this.xrLabel27.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel27.ForeColor = System.Drawing.Color.White;
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(123.3334F, 0F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(701.2413F, 22.51505F);
            this.xrLabel27.StylePriority.UseBackColor = false;
            this.xrLabel27.StylePriority.UseBorderColor = false;
            this.xrLabel27.StylePriority.UseBorders = false;
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UseForeColor = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            this.xrLabel27.Text = "BO NAME FIELD";
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel28
            // 
            this.xrLabel28.BackColor = System.Drawing.Color.Teal;
            this.xrLabel28.BorderColor = System.Drawing.Color.White;
            this.xrLabel28.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel28.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel28.ForeColor = System.Drawing.Color.White;
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(1.000055F, 0F);
            this.xrLabel28.Multiline = true;
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(122.3333F, 22.51503F);
            this.xrLabel28.StylePriority.UseBackColor = false;
            this.xrLabel28.StylePriority.UseBorderColor = false;
            this.xrLabel28.StylePriority.UseBorders = false;
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UseForeColor = false;
            this.xrLabel28.StylePriority.UsePadding = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.Text = "Business Objective:";
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel31
            // 
            this.xrLabel31.BackColor = System.Drawing.Color.Teal;
            this.xrLabel31.BorderColor = System.Drawing.Color.White;
            this.xrLabel31.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel31.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[rc_criteria_with_project_and_response].[Checklist Title]")});
            this.xrLabel31.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel31.ForeColor = System.Drawing.Color.White;
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(72.29177F, 0F);
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(752.7082F, 23.09372F);
            this.xrLabel31.StylePriority.UseBackColor = false;
            this.xrLabel31.StylePriority.UseBorderColor = false;
            this.xrLabel31.StylePriority.UseBorders = false;
            this.xrLabel31.StylePriority.UseFont = false;
            this.xrLabel31.StylePriority.UseForeColor = false;
            this.xrLabel31.StylePriority.UseTextAlignment = false;
            this.xrLabel31.Text = "Checklist Name FIELD";
            this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel33
            // 
            this.xrLabel33.BackColor = System.Drawing.Color.Teal;
            this.xrLabel33.BorderColor = System.Drawing.Color.White;
            this.xrLabel33.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel33.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel33.ForeColor = System.Drawing.Color.White;
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(72.29174F, 23.09373F);
            this.xrLabel33.StylePriority.UseBackColor = false;
            this.xrLabel33.StylePriority.UseBorderColor = false;
            this.xrLabel33.StylePriority.UseBorders = false;
            this.xrLabel33.StylePriority.UseFont = false;
            this.xrLabel33.StylePriority.UseForeColor = false;
            this.xrLabel33.StylePriority.UsePadding = false;
            this.xrLabel33.StylePriority.UseTextAlignment = false;
            this.xrLabel33.Text = "Checklist: ";
            this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // chklist_title_group
            // 
            this.chklist_title_group.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel33,
            this.xrLabel31});
            this.chklist_title_group.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Checklist Title", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.chklist_title_group.HeightF = 23.09373F;
            this.chklist_title_group.Level = 2;
            this.chklist_title_group.Name = "chklist_title_group";
            this.chklist_title_group.RepeatEveryPage = true;
            // 
            // SRC_TITLE_SORT_HEADER
            // 
            this.SRC_TITLE_SORT_HEADER.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel1,
            this.xrLabel2});
            this.SRC_TITLE_SORT_HEADER.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("SRC Title", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.SRC_TITLE_SORT_HEADER.HeightF = 55.99715F;
            this.SRC_TITLE_SORT_HEADER.Name = "SRC_TITLE_SORT_HEADER";
            this.SRC_TITLE_SORT_HEADER.RepeatEveryPage = true;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BackColor = System.Drawing.Color.Teal;
            this.xrLabel3.BorderColor = System.Drawing.Color.White;
            this.xrLabel3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.ForeColor = System.Drawing.Color.White;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(411.3189F, 3.178914E-05F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(413.6813F, 22.51503F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseBorderDashStyle = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Source:";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.Teal;
            this.xrLabel1.BorderColor = System.Drawing.Color.White;
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.ForeColor = System.Drawing.Color.White;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(72.29175F, 22.51503F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "SRC:";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.Teal;
            this.xrLabel2.BorderColor = System.Drawing.Color.White;
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[rc_criteria_with_project_and_response].[SRC Title]")});
            this.xrLabel2.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.ForeColor = System.Drawing.Color.White;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(72.29177F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(339.0272F, 22.51505F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "SRC Title FIELD";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel27,
            this.xrLabel28});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Business Objective Name", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 22.51505F;
            this.GroupHeader1.Level = 1;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            // 
            // calculatedField2
            // 
            this.calculatedField2.DataMember = "rc_criteria_with_project_and_response";
            this.calculatedField2.Expression = "ToStr([ch_deleted])";
            this.calculatedField2.Name = "calculatedField2";
            // 
            // xrRichText1
            // 
            this.xrRichText1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Rtf", "[Response to SRC]")});
            this.xrRichText1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(89.15501F, 72.45617F);
            this.xrRichText1.Name = "xrRichText1";
            this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
            this.xrRichText1.SizeF = new System.Drawing.SizeF(321.5891F, 147.1834F);
            this.xrRichText1.StyleName = "Output_Style";
            // 
            // xrRichText2
            // 
            this.xrRichText2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Rtf", "[eval_description]")});
            this.xrRichText2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText2.LocationFloat = new DevExpress.Utils.PointFloat(534.2444F, 118.0455F);
            this.xrRichText2.Name = "xrRichText2";
            this.xrRichText2.SerializableRtfString = resources.GetString("xrRichText2.SerializableRtfString");
            this.xrRichText2.SizeF = new System.Drawing.SizeF(280.7556F, 101.5941F);
            this.xrRichText2.StyleName = "Output_Style";
            // 
            // rep_pro_checklist_items_compliance_summary
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageFooter,
            this.chklist_title_group,
            this.SRC_TITLE_SORT_HEADER,
            this.GroupHeader1});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.calculatedField2});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "rc_criteria_with_project_and_response";
            this.DataSource = this.sqlDataSource1;
            this.FilterString = "[bo_deleted] = False And [ch_deleted] = False And [src_deleted] = False And [pro_" +
    "name] In (?Project, \' \')";
            this.Margins = new System.Drawing.Printing.Margins(13, 12, 11, 12);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.Project});
            this.ScriptsSource = "\r\nprivate void SubBand1_BeforePrint(object sender, System.Drawing.Printing.PrintE" +
    "ventArgs e) {\r\n\r\n}\r\n";
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Label_Style_notable,
            this.Output_Style});
            this.Version = "17.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
