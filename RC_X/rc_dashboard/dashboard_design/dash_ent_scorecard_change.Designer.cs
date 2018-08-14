namespace RC_X.rc_dashboard.dashboard_design
{
    partial class dash_ent_scorecard_change
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dash_ent_scorecard_change));
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.GridDimensionColumn gridDimensionColumn1 = new DevExpress.DashboardCommon.GridDimensionColumn();
            DevExpress.DashboardCommon.Dimension dimension6 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.GridDimensionColumn gridDimensionColumn2 = new DevExpress.DashboardCommon.GridDimensionColumn();
            DevExpress.DashboardCommon.Dimension dimension7 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.GridDimensionColumn gridDimensionColumn3 = new DevExpress.DashboardCommon.GridDimensionColumn();
            DevExpress.DashboardCommon.Dimension dimension8 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.GridDimensionColumn gridDimensionColumn4 = new DevExpress.DashboardCommon.GridDimensionColumn();
            DevExpress.DashboardCommon.Dimension dimension9 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.GridDimensionColumn gridDimensionColumn5 = new DevExpress.DashboardCommon.GridDimensionColumn();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.GridMeasureColumn gridMeasureColumn1 = new DevExpress.DashboardCommon.GridMeasureColumn();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.GridMeasureColumn gridMeasureColumn2 = new DevExpress.DashboardCommon.GridMeasureColumn();
            DevExpress.DashboardCommon.Dimension dimension10 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.GridDimensionColumn gridDimensionColumn6 = new DevExpress.DashboardCommon.GridDimensionColumn();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.dashboardSqlDataSource1 = new DevExpress.DashboardCommon.DashboardSqlDataSource();
            this.treeViewDashboardItem1 = new DevExpress.DashboardCommon.TreeViewDashboardItem();
            this.gridDashboardItem1 = new DevExpress.DashboardCommon.GridDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardSqlDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // dashboardSqlDataSource1
            // 
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
            dimension1.DataMember = "Project Name";
            dimension2.DataMember = "Business Area";
            dimension3.DataMember = "Business Processes";
            dimension4.DataMember = "card_name";
            this.treeViewDashboardItem1.DataItemRepository.Clear();
            this.treeViewDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0");
            this.treeViewDashboardItem1.DataItemRepository.Add(dimension2, "DataItem1");
            this.treeViewDashboardItem1.DataItemRepository.Add(dimension3, "DataItem2");
            this.treeViewDashboardItem1.DataItemRepository.Add(dimension4, "DataItem3");
            this.treeViewDashboardItem1.DataMember = "Query";
            this.treeViewDashboardItem1.DataSource = this.dashboardSqlDataSource1;
            this.treeViewDashboardItem1.FilterDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1,
            dimension2,
            dimension3,
            dimension4});
            this.treeViewDashboardItem1.InteractivityOptions.IgnoreMasterFilters = true;
            this.treeViewDashboardItem1.Name = "Select Project";
            this.treeViewDashboardItem1.ShowCaption = true;
            // 
            // gridDashboardItem1
            // 
            dimension5.DataMember = "BA";
            gridDimensionColumn1.Weight = 20.638820638820643D;
            gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDimensionColumn1.AddDataItem("Dimension", dimension5);
            dimension6.DataMember = "Business Processes";
            gridDimensionColumn2.Weight = 115.72481572481574D;
            gridDimensionColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDimensionColumn2.AddDataItem("Dimension", dimension6);
            dimension7.DataMember = "card_name";
            gridDimensionColumn3.Weight = 109.09090909090911D;
            gridDimensionColumn3.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDimensionColumn3.AddDataItem("Dimension", dimension7);
            dimension8.DataMember = "Standards and Conditions";
            gridDimensionColumn4.Weight = 100.982800982801D;
            gridDimensionColumn4.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDimensionColumn4.AddDataItem("Dimension", dimension8);
            dimension9.DataMember = "Type Of Architecture";
            gridDimensionColumn5.Weight = 129.72972972972974D;
            gridDimensionColumn5.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDimensionColumn5.AddDataItem("Dimension", dimension9);
            measure1.DataMember = "As-Is";
            measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
            measure1.SummaryType = DevExpress.DashboardCommon.SummaryType.Max;
            gridMeasureColumn1.Weight = 39.803439803439815D;
            gridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridMeasureColumn1.AddDataItem("Measure", measure1);
            measure2.DataMember = "To-Be";
            measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.Max;
            gridMeasureColumn2.Weight = 41.277641277641287D;
            gridMeasureColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridMeasureColumn2.AddDataItem("Measure", measure2);
            dimension10.DataMember = "Project Name";
            gridDimensionColumn6.Weight = 79.606879606879616D;
            gridDimensionColumn6.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDimensionColumn6.AddDataItem("Dimension", dimension10);
            this.gridDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.GridColumnBase[] {
            gridDimensionColumn1,
            gridDimensionColumn2,
            gridDimensionColumn3,
            gridDimensionColumn4,
            gridDimensionColumn5,
            gridMeasureColumn1,
            gridMeasureColumn2,
            gridDimensionColumn6});
            this.gridDashboardItem1.ComponentName = "gridDashboardItem1";
            this.gridDashboardItem1.DataItemRepository.Clear();
            this.gridDashboardItem1.DataItemRepository.Add(dimension5, "DataItem0");
            this.gridDashboardItem1.DataItemRepository.Add(dimension6, "DataItem1");
            this.gridDashboardItem1.DataItemRepository.Add(dimension7, "DataItem2");
            this.gridDashboardItem1.DataItemRepository.Add(dimension8, "DataItem3");
            this.gridDashboardItem1.DataItemRepository.Add(dimension9, "DataItem4");
            this.gridDashboardItem1.DataItemRepository.Add(measure1, "DataItem5");
            this.gridDashboardItem1.DataItemRepository.Add(measure2, "DataItem6");
            this.gridDashboardItem1.DataItemRepository.Add(dimension10, "DataItem7");
            this.gridDashboardItem1.DataMember = "Query";
            this.gridDashboardItem1.DataSource = this.dashboardSqlDataSource1;
            this.gridDashboardItem1.GridOptions.AllowCellMerge = true;
            this.gridDashboardItem1.GridOptions.EnableBandedRows = true;
            this.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.gridDashboardItem1.Name = "Grid 1";
            this.gridDashboardItem1.ShowCaption = false;
            // 
            // dash_ent_scorecard_change
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardSqlDataSource1});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.treeViewDashboardItem1,
            this.gridDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.gridDashboardItem1;
            dashboardLayoutItem1.Weight = 86.6412213740458D;
            dashboardLayoutItem2.DashboardItem = this.treeViewDashboardItem1;
            dashboardLayoutItem2.Weight = 13.358778625954198D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup1.DashboardItem = null;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.ShowMasterFilterState = false;
            this.Title.Text = "ScoreCard Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dashboardSqlDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.DashboardSqlDataSource dashboardSqlDataSource1;
        private DevExpress.DashboardCommon.TreeViewDashboardItem treeViewDashboardItem1;
        private DevExpress.DashboardCommon.GridDashboardItem gridDashboardItem1;
    }
}
