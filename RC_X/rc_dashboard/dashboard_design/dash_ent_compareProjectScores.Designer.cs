namespace RC_X.rc_dashboard.dashboard_design
{
    partial class dash_ent_compareProjectScores
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
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.CalculatedField calculatedField1 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dash_ent_compareProjectScores));
            DevExpress.DashboardCommon.Dimension dimension6 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension7 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension8 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.pivotDashboardItem1 = new DevExpress.DashboardCommon.PivotDashboardItem();
            this.dashboardSqlDataSource1 = new DevExpress.DashboardCommon.DashboardSqlDataSource();
            this.treeViewDashboardItem1 = new DevExpress.DashboardCommon.TreeViewDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.pivotDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardSqlDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pivotDashboardItem1
            // 
            this.pivotDashboardItem1.AutoExpandColumnGroups = true;
            this.pivotDashboardItem1.AutoExpandRowGroups = true;
            dimension1.DataMember = "Project Name";
            this.pivotDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.pivotDashboardItem1.ComponentName = "pivotDashboardItem1";
            dimension2.DataMember = "Project Name";
            measure1.DataMember = "As-Is";
            measure1.Name = "As-Is";
            measure1.ShowGrandTotals = false;
            measure1.ShowTotals = false;
            measure1.SummaryType = DevExpress.DashboardCommon.SummaryType.Min;
            measure2.DataMember = "To-Be";
            measure2.Name = "To-Be";
            measure2.ShowGrandTotals = false;
            measure2.ShowTotals = false;
            measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.Min;
            dimension3.DataMember = "Card Name";
            dimension4.DataMember = "Question";
            dimension5.DataMember = "BP Name";
            this.pivotDashboardItem1.DataItemRepository.Clear();
            this.pivotDashboardItem1.DataItemRepository.Add(dimension2, "DataItem9");
            this.pivotDashboardItem1.DataItemRepository.Add(measure1, "DataItem7");
            this.pivotDashboardItem1.DataItemRepository.Add(measure2, "DataItem8");
            this.pivotDashboardItem1.DataItemRepository.Add(dimension1, "DataItem11");
            this.pivotDashboardItem1.DataItemRepository.Add(dimension3, "DataItem0");
            this.pivotDashboardItem1.DataItemRepository.Add(dimension4, "DataItem6");
            this.pivotDashboardItem1.DataItemRepository.Add(dimension5, "DataItem2");
            this.pivotDashboardItem1.DataMember = "Query";
            this.pivotDashboardItem1.DataSource = this.dashboardSqlDataSource1;
            this.pivotDashboardItem1.HiddenDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension2});
            this.pivotDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.pivotDashboardItem1.LayoutType = DevExpress.DashboardCommon.PivotLayoutType.Tabular;
            this.pivotDashboardItem1.Name = "2 Project Compare Pivot Grid";
            this.pivotDashboardItem1.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension5,
            dimension3,
            dimension4});
            this.pivotDashboardItem1.ShowCaption = true;
            this.pivotDashboardItem1.ShowColumnGrandTotals = false;
            this.pivotDashboardItem1.ShowRowGrandTotals = false;
            this.pivotDashboardItem1.ShowRowTotals = false;
            this.pivotDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure1,
            measure2});
            // 
            // dashboardSqlDataSource1
            // 
            calculatedField1.DataMember = "Query";
            calculatedField1.Expression = "[To-Be] - [As-Is]";
            calculatedField1.Name = "Calculated Impact";
            this.dashboardSqlDataSource1.CalculatedFields.AddRange(new DevExpress.DashboardCommon.CalculatedField[] {
            calculatedField1});
            this.dashboardSqlDataSource1.ComponentName = "dashboardSqlDataSource1";
            this.dashboardSqlDataSource1.ConnectionName = "OhioDB";
            this.dashboardSqlDataSource1.Name = "SQL Data Source 1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.dashboardSqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.dashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource1.ResultSchemaSerializable");
            // 
            // treeViewDashboardItem1
            // 
            this.treeViewDashboardItem1.ComponentName = "treeViewDashboardItem1";
            dimension6.DataMember = "Project Name";
            dimension7.DataMember = "BA Name";
            dimension8.DataMember = "BP Name";
            this.treeViewDashboardItem1.DataItemRepository.Clear();
            this.treeViewDashboardItem1.DataItemRepository.Add(dimension6, "DataItem0");
            this.treeViewDashboardItem1.DataItemRepository.Add(dimension7, "DataItem1");
            this.treeViewDashboardItem1.DataItemRepository.Add(dimension8, "DataItem2");
            this.treeViewDashboardItem1.DataMember = "Query";
            this.treeViewDashboardItem1.DataSource = this.dashboardSqlDataSource1;
            this.treeViewDashboardItem1.FilterDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension6,
            dimension7,
            dimension8});
            this.treeViewDashboardItem1.InteractivityOptions.IgnoreMasterFilters = true;
            this.treeViewDashboardItem1.Name = "Data selector";
            this.treeViewDashboardItem1.ShowCaption = true;
            // 
            // dash_ent_compareProjectScores
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardSqlDataSource1});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.pivotDashboardItem1,
            this.treeViewDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.pivotDashboardItem1;
            dashboardLayoutItem1.Weight = 84.351145038167942D;
            dashboardLayoutItem2.DashboardItem = this.treeViewDashboardItem1;
            dashboardLayoutItem2.Weight = 15.648854961832061D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup1.DashboardItem = null;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.ImageUrl = "https://readycert.net/images/logo.png";
            this.Title.ShowMasterFilterState = false;
            this.Title.Text = "Business Process - Cross Project Compare";
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardSqlDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.DashboardSqlDataSource dashboardSqlDataSource1;
        private DevExpress.DashboardCommon.PivotDashboardItem pivotDashboardItem1;
        private DevExpress.DashboardCommon.TreeViewDashboardItem treeViewDashboardItem1;
    }
}
