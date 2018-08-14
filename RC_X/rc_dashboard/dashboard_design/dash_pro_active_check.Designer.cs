namespace RC_X.rc_dashboard.dashboard_design
{
    partial class dash_pro_active_check
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
            DevExpress.DashboardCommon.CalculatedField calculatedField1 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField2 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField3 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField4 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField5 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dash_pro_active_check));
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure3 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.treeViewDashboardItem1 = new DevExpress.DashboardCommon.TreeViewDashboardItem();
            this.dashboardSqlDataSource1 = new DevExpress.DashboardCommon.DashboardSqlDataSource();
            this.textBoxDashboardItem1 = new DevExpress.DashboardCommon.TextBoxDashboardItem();
            this.pivotDashboardItem1 = new DevExpress.DashboardCommon.PivotDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardSqlDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // treeViewDashboardItem1
            // 
            this.treeViewDashboardItem1.ComponentName = "treeViewDashboardItem1";
            dimension1.DataMember = "pro_name";
            this.treeViewDashboardItem1.DataItemRepository.Clear();
            this.treeViewDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0");
            this.treeViewDashboardItem1.DataMember = "rc_rtm_criteria";
            this.treeViewDashboardItem1.DataSource = this.dashboardSqlDataSource1;
            this.treeViewDashboardItem1.FilterDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.treeViewDashboardItem1.InteractivityOptions.IgnoreMasterFilters = true;
            this.treeViewDashboardItem1.Name = "Data Selector";
            this.treeViewDashboardItem1.ShowCaption = true;
            // 
            // dashboardSqlDataSource1
            // 
            calculatedField1.DataMember = "rc_rtm_criteria";
            calculatedField1.Expression = "CountDistinct([res_itemID])";
            calculatedField1.Name = "cd_res_itemID";
            calculatedField2.DataMember = "rc_rtm_criteria";
            calculatedField2.Expression = "CountDistinct([ch_title])";
            calculatedField2.Name = "cd_ch_title";
            calculatedField3.DataMember = "rc_rtm_criteria";
            calculatedField3.Expression = "CountDistinct([src_title])";
            calculatedField3.Name = "cd_src_title";
            calculatedField4.DataMember = "rc_rtm_criteria";
            calculatedField4.Expression = "ToBoolean(IsNullOrEmpty([res_itemID]))";
            calculatedField4.Name = "Calculated Field 1";
            calculatedField5.DataMember = "rc_rtm_criteria";
            calculatedField5.Expression = "[cd_res_itemID] = [cd_src_title]";
            calculatedField5.Name = "Calculated Field 2";
            this.dashboardSqlDataSource1.CalculatedFields.AddRange(new DevExpress.DashboardCommon.CalculatedField[] {
            calculatedField1,
            calculatedField2,
            calculatedField3,
            calculatedField4,
            calculatedField5});
            this.dashboardSqlDataSource1.ComponentName = "dashboardSqlDataSource1";
            this.dashboardSqlDataSource1.ConnectionName = "DevDB";
            this.dashboardSqlDataSource1.Name = "SQL Data Source 1";
            customSqlQuery1.Name = "rc_rtm_criteria";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.dashboardSqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.dashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource1.ResultSchemaSerializable");
            // 
            // textBoxDashboardItem1
            // 
            this.textBoxDashboardItem1.ComponentName = "textBoxDashboardItem1";
            this.textBoxDashboardItem1.DataItemRepository.Clear();
            this.textBoxDashboardItem1.InnerRtf = resources.GetString("textBoxDashboardItem1.InnerRtf");
            this.textBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.textBoxDashboardItem1.Name = "Text Box 1";
            this.textBoxDashboardItem1.ShowCaption = false;
            // 
            // pivotDashboardItem1
            // 
            dimension2.DataMember = "pro_name";
            this.pivotDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension2});
            this.pivotDashboardItem1.ComponentName = "pivotDashboardItem1";
            measure1.DataMember = "cd_res_itemID";
            measure1.Name = "# of Responses";
            dimension3.DataMember = "ch_title";
            dimension4.DataMember = "src_title";
            measure2.DataMember = "cd_src_title";
            measure2.Name = "Checklist Items";
            measure3.DataMember = "Calculated Field 2";
            measure3.Name = "Complete?";
            measure3.SummaryType = DevExpress.DashboardCommon.SummaryType.Count;
            this.pivotDashboardItem1.DataItemRepository.Clear();
            this.pivotDashboardItem1.DataItemRepository.Add(measure1, "DataItem1");
            this.pivotDashboardItem1.DataItemRepository.Add(dimension3, "DataItem2");
            this.pivotDashboardItem1.DataItemRepository.Add(dimension4, "DataItem0");
            this.pivotDashboardItem1.DataItemRepository.Add(dimension2, "DataItem3");
            this.pivotDashboardItem1.DataItemRepository.Add(measure2, "DataItem4");
            this.pivotDashboardItem1.DataItemRepository.Add(measure3, "DataItem5");
            this.pivotDashboardItem1.DataMember = "rc_rtm_criteria";
            this.pivotDashboardItem1.DataSource = this.dashboardSqlDataSource1;
            this.pivotDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.pivotDashboardItem1.LayoutType = DevExpress.DashboardCommon.PivotLayoutType.Tabular;
            this.pivotDashboardItem1.Name = "Active Checklists and SRC response Status by Project";
            this.pivotDashboardItem1.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3,
            dimension4});
            this.pivotDashboardItem1.ShowCaption = true;
            this.pivotDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure1,
            measure2,
            measure3});
            // 
            // dash_pro_active_check
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardSqlDataSource1});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.pivotDashboardItem1,
            this.treeViewDashboardItem1,
            this.textBoxDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.treeViewDashboardItem1;
            dashboardLayoutItem1.Weight = 50.986842105263158D;
            dashboardLayoutItem2.DashboardItem = this.textBoxDashboardItem1;
            dashboardLayoutItem2.Weight = 49.013157894736842D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup2.DashboardItem = null;
            dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup2.Weight = 16.569525395503746D;
            dashboardLayoutItem3.DashboardItem = this.pivotDashboardItem1;
            dashboardLayoutItem3.Weight = 83.430474604496254D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2,
            dashboardLayoutItem3});
            dashboardLayoutGroup1.DashboardItem = null;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.ImageUrl = "https://uploads-ssl.webflow.com/56d4b2fec160033816d1dfc8/56d600f404fd62186cba1578" +
    "_ReadyCertLogo_BIG.png";
            this.Title.ShowMasterFilterState = false;
            this.Title.Text = "Active Check";
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardSqlDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.DashboardSqlDataSource dashboardSqlDataSource1;
        private DevExpress.DashboardCommon.PivotDashboardItem pivotDashboardItem1;
        private DevExpress.DashboardCommon.TreeViewDashboardItem treeViewDashboardItem1;
        private DevExpress.DashboardCommon.TextBoxDashboardItem textBoxDashboardItem1;
    }
}
