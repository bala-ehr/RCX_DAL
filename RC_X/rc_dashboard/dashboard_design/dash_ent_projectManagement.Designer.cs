namespace RC_X.rc_dashboard.dashboard_design
{
    partial class dash_ent_projectManagement
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
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dash_ent_projectManagement));
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension6 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension7 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension8 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.pivotDashboardItem1 = new DevExpress.DashboardCommon.PivotDashboardItem();
            this.dashboardSqlDataSource1 = new DevExpress.DashboardCommon.DashboardSqlDataSource();
            this.pieDashboardItem1 = new DevExpress.DashboardCommon.PieDashboardItem();
            this.treeViewDashboardItem1 = new DevExpress.DashboardCommon.TreeViewDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.pivotDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardSqlDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pivotDashboardItem1
            // 
            dimension1.DataMember = "Home";
            dimension2.DataMember = "pm_title";
            this.pivotDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1,
            dimension2});
            this.pivotDashboardItem1.ComponentName = "pivotDashboardItem1";
            measure1.DataMember = "pm_createddate";
            measure1.ShowGrandTotals = false;
            measure1.ShowTotals = false;
            measure1.SummaryType = DevExpress.DashboardCommon.SummaryType.Max;
            dimension3.DataMember = "pm_type";
            dimension3.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
            this.pivotDashboardItem1.DataItemRepository.Clear();
            this.pivotDashboardItem1.DataItemRepository.Add(measure1, "DataItem1");
            this.pivotDashboardItem1.DataItemRepository.Add(dimension3, "DataItem3");
            this.pivotDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0");
            this.pivotDashboardItem1.DataItemRepository.Add(dimension2, "DataItem2");
            this.pivotDashboardItem1.DataMember = "Query";
            this.pivotDashboardItem1.DataSource = this.dashboardSqlDataSource1;
            this.pivotDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.pivotDashboardItem1.LayoutType = DevExpress.DashboardCommon.PivotLayoutType.Compact;
            this.pivotDashboardItem1.Name = "Pivot 1";
            this.pivotDashboardItem1.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3});
            this.pivotDashboardItem1.ShowCaption = false;
            this.pivotDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure1});
            // 
            // dashboardSqlDataSource1
            // 
            this.dashboardSqlDataSource1.ComponentName = "dashboardSqlDataSource1";
            this.dashboardSqlDataSource1.ConnectionName = "DevDB";
            this.dashboardSqlDataSource1.Name = "SQL Data Source 1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.dashboardSqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.dashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource1.ResultSchemaSerializable");
            // 
            // pieDashboardItem1
            // 
            dimension4.DataMember = "pm_type";
            this.pieDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension4});
            this.pieDashboardItem1.ComponentName = "pieDashboardItem1";
            measure2.DataMember = "pm_createddate";
            measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.Count;
            dimension5.DataMember = "Home";
            this.pieDashboardItem1.DataItemRepository.Clear();
            this.pieDashboardItem1.DataItemRepository.Add(dimension4, "DataItem1");
            this.pieDashboardItem1.DataItemRepository.Add(measure2, "DataItem2");
            this.pieDashboardItem1.DataItemRepository.Add(dimension5, "DataItem0");
            this.pieDashboardItem1.DataMember = "Query";
            this.pieDashboardItem1.DataSource = this.dashboardSqlDataSource1;
            this.pieDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.pieDashboardItem1.Name = "Pies 1";
            this.pieDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension5});
            this.pieDashboardItem1.ShowCaption = false;
            this.pieDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure2});
            // 
            // treeViewDashboardItem1
            // 
            this.treeViewDashboardItem1.ComponentName = "treeViewDashboardItem1";
            dimension6.DataMember = "pm_type";
            dimension6.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
            dimension7.DataMember = "Home";
            dimension8.DataMember = "pm_status";
            this.treeViewDashboardItem1.DataItemRepository.Clear();
            this.treeViewDashboardItem1.DataItemRepository.Add(dimension6, "DataItem0");
            this.treeViewDashboardItem1.DataItemRepository.Add(dimension7, "DataItem1");
            this.treeViewDashboardItem1.DataItemRepository.Add(dimension8, "DataItem2");
            this.treeViewDashboardItem1.DataMember = "Query";
            this.treeViewDashboardItem1.DataSource = this.dashboardSqlDataSource1;
            this.treeViewDashboardItem1.FilterDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension7,
            dimension6,
            dimension8});
            this.treeViewDashboardItem1.InteractivityOptions.IgnoreMasterFilters = true;
            this.treeViewDashboardItem1.Name = "Data selector";
            this.treeViewDashboardItem1.ShowCaption = true;
            // 
            // dash_ent_projectManagement
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardSqlDataSource1});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.treeViewDashboardItem1,
            this.pivotDashboardItem1,
            this.pieDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.pivotDashboardItem1;
            dashboardLayoutItem1.Weight = 49.939098660170522D;
            dashboardLayoutItem2.DashboardItem = this.pieDashboardItem1;
            dashboardLayoutItem2.Weight = 25.091352009744213D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup2.DashboardItem = null;
            dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup2.Weight = 86.927480916030532D;
            dashboardLayoutItem3.DashboardItem = this.treeViewDashboardItem1;
            dashboardLayoutItem3.Weight = 13.072519083969466D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2,
            dashboardLayoutItem3});
            dashboardLayoutGroup1.DashboardItem = null;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.ShowMasterFilterState = false;
            this.Title.Text = "Project Management";
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardSqlDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.DashboardSqlDataSource dashboardSqlDataSource1;
        private DevExpress.DashboardCommon.TreeViewDashboardItem treeViewDashboardItem1;
        private DevExpress.DashboardCommon.PieDashboardItem pieDashboardItem1;
        private DevExpress.DashboardCommon.PivotDashboardItem pivotDashboardItem1;
    }
}
