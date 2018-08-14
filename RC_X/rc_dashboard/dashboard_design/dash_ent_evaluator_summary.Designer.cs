namespace RC_X.rc_dashboard.dashboard_design
{
    partial class dash_ent_evaluator_summary
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.DashboardCommon.CalculatedField calculatedField1 = new DevExpress.DashboardCommon.CalculatedField();
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
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dash_ent_evaluator_summary));
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension6 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension7 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.dashboardSqlDataSource1 = new DevExpress.DashboardCommon.DashboardSqlDataSource();
            this.treeViewDashboardItem1 = new DevExpress.DashboardCommon.TreeViewDashboardItem();
            this.pivotDashboardItem1 = new DevExpress.DashboardCommon.PivotDashboardItem();
            this.pieDashboardItem1 = new DevExpress.DashboardCommon.PieDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardSqlDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // dashboardSqlDataSource1
            // 
            calculatedField1.DataMember = "rc_evaluation";
            calculatedField1.Expression = "CountDistinct([eval_responseID])";
            calculatedField1.Name = "Count of Evaluations";
            this.dashboardSqlDataSource1.CalculatedFields.AddRange(new DevExpress.DashboardCommon.CalculatedField[] {
            calculatedField1});
            this.dashboardSqlDataSource1.ComponentName = "dashboardSqlDataSource1";
            this.dashboardSqlDataSource1.ConnectionName = "DevDB";
            this.dashboardSqlDataSource1.Name = "SQL Data Source 1";
            columnExpression1.ColumnName = "eval_reviewer_assessments";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"210\" />";
            table1.Name = "rc_evaluation";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "eval_description";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "eval_date";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "eval_by";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "pro_name";
            table2.MetaSerializable = "<Meta X=\"260\" Y=\"100\" Width=\"125\" Height=\"362\" />";
            table2.Name = "rc_projects";
            columnExpression5.Table = table2;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "eval_responseID";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Name = "rc_evaluation";
            relationColumnInfo1.NestedKeyColumn = "pro_ID";
            relationColumnInfo1.ParentKeyColumn = "eval_projectID";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            this.dashboardSqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.dashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource1.ResultSchemaSerializable");
            // 
            // treeViewDashboardItem1
            // 
            this.treeViewDashboardItem1.ComponentName = "treeViewDashboardItem1";
            dimension1.DataMember = "pro_name";
            dimension1.Name = "Project Name";
            this.treeViewDashboardItem1.DataItemRepository.Clear();
            this.treeViewDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0");
            this.treeViewDashboardItem1.DataMember = "rc_evaluation";
            this.treeViewDashboardItem1.DataSource = this.dashboardSqlDataSource1;
            this.treeViewDashboardItem1.FilterDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.treeViewDashboardItem1.InteractivityOptions.IgnoreMasterFilters = true;
            this.treeViewDashboardItem1.Name = "Data Selector";
            this.treeViewDashboardItem1.ShowCaption = true;
            // 
            // pivotDashboardItem1
            // 
            dimension2.DataMember = "pro_name";
            dimension2.Name = "Project Name";
            dimension3.DataMember = "eval_reviewer_assessments";
            dimension3.Name = "Evaluation Assessment";
            this.pivotDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension2,
            dimension3});
            this.pivotDashboardItem1.ComponentName = "pivotDashboardItem1";
            measure1.DataMember = "Count of Evaluations";
            dimension4.DataMember = "eval_date";
            dimension4.DateTimeFormat.YearFormat = DevExpress.DashboardCommon.YearFormat.Full;
            dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.None;
            dimension4.Name = "Evaluation Date";
            this.pivotDashboardItem1.DataItemRepository.Clear();
            this.pivotDashboardItem1.DataItemRepository.Add(measure1, "DataItem0");
            this.pivotDashboardItem1.DataItemRepository.Add(dimension2, "DataItem1");
            this.pivotDashboardItem1.DataItemRepository.Add(dimension4, "DataItem4");
            this.pivotDashboardItem1.DataItemRepository.Add(dimension3, "DataItem3");
            this.pivotDashboardItem1.DataMember = "rc_evaluation";
            this.pivotDashboardItem1.DataSource = this.dashboardSqlDataSource1;
            this.pivotDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.pivotDashboardItem1.LayoutType = DevExpress.DashboardCommon.PivotLayoutType.Compact;
            this.pivotDashboardItem1.Name = "Info Pivot - Projects by Evaluation Counts by Evaluation Date";
            this.pivotDashboardItem1.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension4});
            this.pivotDashboardItem1.ShowCaption = true;
            this.pivotDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure1});
            // 
            // pieDashboardItem1
            // 
            dimension5.DataMember = "pro_name";
            dimension5.Name = "Project Name";
            dimension6.DataMember = "eval_by";
            dimension6.Name = "Evaluator";
            this.pieDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension5,
            dimension6});
            this.pieDashboardItem1.ComponentName = "pieDashboardItem1";
            measure2.DataMember = "Count of Evaluations";
            measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General;
            dimension7.DataMember = "pro_name";
            dimension7.Name = "Project Name";
            this.pieDashboardItem1.DataItemRepository.Clear();
            this.pieDashboardItem1.DataItemRepository.Add(measure2, "DataItem0");
            this.pieDashboardItem1.DataItemRepository.Add(dimension5, "DataItem2");
            this.pieDashboardItem1.DataItemRepository.Add(dimension7, "DataItem3");
            this.pieDashboardItem1.DataItemRepository.Add(dimension6, "DataItem1");
            this.pieDashboardItem1.DataMember = "rc_evaluation";
            this.pieDashboardItem1.DataSource = this.dashboardSqlDataSource1;
            this.pieDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.pieDashboardItem1.InteractivityOptions.IsDrillDownEnabled = true;
            this.pieDashboardItem1.LabelContentType = ((DevExpress.DashboardCommon.PieValueType)((DevExpress.DashboardCommon.PieValueType.Argument | DevExpress.DashboardCommon.PieValueType.Value)));
            this.pieDashboardItem1.Name = "Evaluations by Project by Evaluator";
            this.pieDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension7});
            this.pieDashboardItem1.ShowCaption = true;
            this.pieDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure2});
            // 
            // dash_ent_evaluator_summary
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardSqlDataSource1});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.treeViewDashboardItem1,
            this.pivotDashboardItem1,
            this.pieDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.treeViewDashboardItem1;
            dashboardLayoutItem1.Weight = 10.855263157894736D;
            dashboardLayoutItem2.DashboardItem = this.pivotDashboardItem1;
            dashboardLayoutItem2.Weight = 26.5625D;
            dashboardLayoutItem3.DashboardItem = this.pieDashboardItem1;
            dashboardLayoutItem3.Weight = 62.58223684210526D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2,
            dashboardLayoutItem3});
            dashboardLayoutGroup1.DashboardItem = null;
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Enterprise Evaluator Summary";
            ((System.ComponentModel.ISupportInitialize)(this.dashboardSqlDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.DashboardSqlDataSource dashboardSqlDataSource1;
        private DevExpress.DashboardCommon.TreeViewDashboardItem treeViewDashboardItem1;
        private DevExpress.DashboardCommon.PivotDashboardItem pivotDashboardItem1;
        private DevExpress.DashboardCommon.PieDashboardItem pieDashboardItem1;
    }
}
