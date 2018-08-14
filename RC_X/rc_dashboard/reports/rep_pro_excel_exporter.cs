using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for rep_pro_excel_exporter
/// </summary>
public class rep_pro_excel_exporter : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public rep_pro_excel_exporter()
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
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column14 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression14 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column15 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression15 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column16 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression16 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column17 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression17 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column18 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression18 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column19 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression19 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table5 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column20 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression20 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column21 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression21 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table6 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column22 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression22 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column23 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression23 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table7 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column24 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression24 = new DevExpress.DataAccess.Sql.ColumnExpression();
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
            DevExpress.DataAccess.Sql.Table table8 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Join join6 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo6 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join7 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo7 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rep_pro_excel_exporter));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
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
            this.TopMargin.HeightF = 100F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "OhioDB";
            this.sqlDataSource1.Name = "sqlDataSource1";
            column1.Alias = "Score Column 1";
            columnExpression1.ColumnName = "score_col1";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"120\" Height=\"324\" />";
            table1.Name = "rc_scorecards_scores";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            column2.Alias = "Measure Column 1";
            columnExpression2.ColumnName = "score_colmeasure1";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            column3.Alias = "Score Column 2";
            columnExpression3.ColumnName = "score_col2";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            column4.Alias = "Measure Columns 2 ";
            columnExpression4.ColumnName = "score_colmeasure2";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            column5.Alias = "Standard";
            columnExpression5.ColumnName = "stan_standard";
            table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"134\" />";
            table2.Name = "rc_scorecards_standards";
            columnExpression5.Table = table2;
            column5.Expression = columnExpression5;
            column6.Alias = "Standard Capability Quality";
            columnExpression6.ColumnName = "stan_capabilityquality";
            columnExpression6.Table = table2;
            column6.Expression = columnExpression6;
            column7.Alias = "Score #";
            columnExpression7.ColumnName = "value_score";
            table3.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"153\" />";
            table3.Name = "rc_scorestandard_values";
            columnExpression7.Table = table3;
            column7.Expression = columnExpression7;
            column8.Alias = "Score Definition";
            columnExpression8.ColumnName = "value_scoretext";
            columnExpression8.Table = table3;
            column8.Expression = columnExpression8;
            column9.Alias = "ignore.0";
            columnExpression9.ColumnName = "value_measures";
            columnExpression9.Table = table3;
            column9.Expression = columnExpression9;
            column10.Alias = "Card Name";
            columnExpression10.ColumnName = "card_name";
            table4.MetaSerializable = "<Meta X=\"180\" Y=\"200\" Width=\"125\" Height=\"438\" />";
            table4.Name = "rc_scorecards";
            columnExpression10.Table = table4;
            column10.Expression = columnExpression10;
            column11.Alias = "ignore.1";
            columnExpression11.ColumnName = "card_measure";
            columnExpression11.Table = table4;
            column11.Expression = columnExpression11;
            column12.Alias = "ignore.2";
            columnExpression12.ColumnName = "card_measure_notes";
            columnExpression12.Table = table4;
            column12.Expression = columnExpression12;
            column13.Alias = "ignore.3";
            columnExpression13.ColumnName = "card_desc";
            columnExpression13.Table = table4;
            column13.Expression = columnExpression13;
            column14.Alias = "Milestone 1 Label";
            columnExpression14.ColumnName = "card_col1";
            columnExpression14.Table = table4;
            column14.Expression = columnExpression14;
            columnExpression15.ColumnName = "card_measure1";
            columnExpression15.Table = table4;
            column15.Expression = columnExpression15;
            columnExpression16.ColumnName = "card_colenabled1";
            columnExpression16.Table = table4;
            column16.Expression = columnExpression16;
            column17.Alias = "Milestone 2 Label";
            columnExpression17.ColumnName = "card_col2";
            columnExpression17.Table = table4;
            column17.Expression = columnExpression17;
            columnExpression18.ColumnName = "card_measure2";
            columnExpression18.Table = table4;
            column18.Expression = columnExpression18;
            columnExpression19.ColumnName = "bp_name";
            table5.MetaSerializable = "<Meta X=\"540\" Y=\"270\" Width=\"125\" Height=\"210\" />";
            table5.Name = "rc_assessment_processes";
            columnExpression19.Table = table5;
            column19.Expression = columnExpression19;
            columnExpression20.ColumnName = "bp_identifier";
            columnExpression20.Table = table5;
            column20.Expression = columnExpression20;
            columnExpression21.ColumnName = "area_name";
            table6.MetaSerializable = "<Meta X=\"510\" Y=\"500\" Width=\"125\" Height=\"191\" />";
            table6.Name = "rc_assessment_areas";
            columnExpression21.Table = table6;
            column21.Expression = columnExpression21;
            columnExpression22.ColumnName = "area_identifier";
            columnExpression22.Table = table6;
            column22.Expression = columnExpression22;
            column23.Alias = "rc_assessment_areas_1_area_name";
            columnExpression23.ColumnName = "area_name";
            table7.Alias = "rc_assessment_areas_1";
            table7.MetaSerializable = "<Meta X=\"940\" Y=\"150\" Width=\"125\" Height=\"191\" />";
            table7.Name = "rc_assessment_areas";
            columnExpression23.Table = table7;
            column23.Expression = columnExpression23;
            column24.Alias = "rc_assessment_areas_1_area_identifier";
            columnExpression24.ColumnName = "area_identifier";
            columnExpression24.Table = table7;
            column24.Expression = columnExpression24;
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
            selectQuery1.FilterString = "[rc_scorecards.card_name] <> \'Barbara BCM Test\'";
            selectQuery1.GroupFilterString = "";
            selectQuery1.Name = "rc_scorecards_scores_1";
            relationColumnInfo1.NestedKeyColumn = "stan_id";
            relationColumnInfo1.ParentKeyColumn = "score_standard";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            relationColumnInfo2.NestedKeyColumn = "value_standard";
            relationColumnInfo2.ParentKeyColumn = "stan_id";
            join2.KeyColumns.Add(relationColumnInfo2);
            join2.Nested = table3;
            join2.Parent = table2;
            relationColumnInfo3.NestedKeyColumn = "card_id";
            relationColumnInfo3.ParentKeyColumn = "stan_card";
            join3.KeyColumns.Add(relationColumnInfo3);
            join3.Nested = table4;
            join3.Parent = table2;
            relationColumnInfo4.NestedKeyColumn = "bp_id";
            relationColumnInfo4.ParentKeyColumn = "score_itemid";
            join4.KeyColumns.Add(relationColumnInfo4);
            join4.Nested = table5;
            join4.Parent = table1;
            join4.Type = DevExpress.Xpo.DB.JoinType.LeftOuter;
            relationColumnInfo5.NestedKeyColumn = "cat_id";
            relationColumnInfo5.ParentKeyColumn = "bp_bcID";
            join5.KeyColumns.Add(relationColumnInfo5);
            table8.MetaSerializable = "<Meta X=\"750\" Y=\"150\" Width=\"125\" Height=\"210\" />";
            table8.Name = "rc_assessment_categories";
            join5.Nested = table8;
            join5.Parent = table5;
            join5.Type = DevExpress.Xpo.DB.JoinType.LeftOuter;
            relationColumnInfo6.NestedKeyColumn = "area_id";
            relationColumnInfo6.ParentKeyColumn = "score_itemid";
            join6.KeyColumns.Add(relationColumnInfo6);
            join6.Nested = table6;
            join6.Parent = table1;
            join6.Type = DevExpress.Xpo.DB.JoinType.LeftOuter;
            relationColumnInfo7.NestedKeyColumn = "area_id";
            relationColumnInfo7.ParentKeyColumn = "cat_baID";
            join7.KeyColumns.Add(relationColumnInfo7);
            join7.Nested = table7;
            join7.Parent = table8;
            join7.Type = DevExpress.Xpo.DB.JoinType.LeftOuter;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Relations.Add(join2);
            selectQuery1.Relations.Add(join3);
            selectQuery1.Relations.Add(join4);
            selectQuery1.Relations.Add(join5);
            selectQuery1.Relations.Add(join6);
            selectQuery1.Relations.Add(join7);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            selectQuery1.Tables.Add(table3);
            selectQuery1.Tables.Add(table4);
            selectQuery1.Tables.Add(table5);
            selectQuery1.Tables.Add(table8);
            selectQuery1.Tables.Add(table6);
            selectQuery1.Tables.Add(table7);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // rep_pro_excel_exporter
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "rc_scorecards_scores_1";
            this.DataSource = this.sqlDataSource1;
            this.Version = "17.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
