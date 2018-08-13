namespace RC_X.rc_dashboard.dashboard_design
{
    partial class dash_pro_active_checklist
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dash_pro_active_checklist));
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
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
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // treeViewDashboardItem1
            // 
            this.treeViewDashboardItem1.ComponentName = "treeViewDashboardItem1";
            dimension1.DataMember = "Projectname";
            this.treeViewDashboardItem1.DataItemRepository.Clear();
            this.treeViewDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0");
            this.treeViewDashboardItem1.DataMember = "Checklists";
            this.treeViewDashboardItem1.DataSource = this.dashboardSqlDataSource1;
            this.treeViewDashboardItem1.FilterDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.treeViewDashboardItem1.InteractivityOptions.IgnoreMasterFilters = true;
            this.treeViewDashboardItem1.Name = "Data Selector";
            this.treeViewDashboardItem1.ShowCaption = true;
            // 
            // dashboardSqlDataSource1
            // 
            calculatedField1.DataMember = "Checklists";
            calculatedField1.Expression = "ToBoolean(IsNullOrEmpty([Responses]))";
            calculatedField1.Name = "Calculated Field 1";
            calculatedField2.DataMember = "Checklists";
            calculatedField2.Expression = "Iif([items] = [Responses], True, False)";
            calculatedField2.Name = "Calculated Field 2";
            this.dashboardSqlDataSource1.CalculatedFields.AddRange(new DevExpress.DashboardCommon.CalculatedField[] {
            calculatedField1,
            calculatedField2});
            this.dashboardSqlDataSource1.ComponentName = "dashboardSqlDataSource1";
            this.dashboardSqlDataSource1.ConnectionName = "DevDB";
            this.dashboardSqlDataSource1.Name = "SQL Data Source 1";
            customSqlQuery1.MetaSerializable = "<Meta X=\"260\" Y=\"-30\" Width=\"100\" Height=\"258\" />";
            customSqlQuery1.Name = "Checklists";
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
            dimension2.DataMember = "Projectname";
            this.pivotDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension2});
            this.pivotDashboardItem1.ComponentName = "pivotDashboardItem1";
            dimension3.DataMember = "ChecklistTitle";
            dimension4.DataMember = "src_title";
            measure1.DataMember = "items";
            measure1.ShowGrandTotals = false;
            measure2.DataMember = "Responses";
            measure2.ShowGrandTotals = false;
            this.pivotDashboardItem1.DataItemRepository.Clear();
            this.pivotDashboardItem1.DataItemRepository.Add(dimension3, "DataItem0");
            this.pivotDashboardItem1.DataItemRepository.Add(dimension4, "DataItem1");
            this.pivotDashboardItem1.DataItemRepository.Add(dimension2, "DataItem2");
            this.pivotDashboardItem1.DataItemRepository.Add(measure1, "DataItem3");
            this.pivotDashboardItem1.DataItemRepository.Add(measure2, "DataItem4");
            this.pivotDashboardItem1.DataMember = "Checklists";
            this.pivotDashboardItem1.DataSource = this.dashboardSqlDataSource1;
            this.pivotDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.pivotDashboardItem1.LayoutType = DevExpress.DashboardCommon.PivotLayoutType.Compact;
            this.pivotDashboardItem1.Name = "Active Checklists and SRC response Status by Project";
            this.pivotDashboardItem1.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3,
            dimension4});
            this.pivotDashboardItem1.ShowCaption = true;
            this.pivotDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure1,
            measure2});
            // 
            // dash_pro_active_checklist
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardSqlDataSource1});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.treeViewDashboardItem1,
            this.pivotDashboardItem1,
            this.textBoxDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.treeViewDashboardItem1;
            dashboardLayoutItem1.Weight = 50.098231827111981D;
            dashboardLayoutItem2.DashboardItem = this.textBoxDashboardItem1;
            dashboardLayoutItem2.Weight = 49.901768172888019D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup2.DashboardItem = null;
            dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup2.Weight = 23.350785340314136D;
            dashboardLayoutItem3.DashboardItem = this.pivotDashboardItem1;
            dashboardLayoutItem3.Weight = 76.649214659685867D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2,
            dashboardLayoutItem3});
            dashboardLayoutGroup1.DashboardItem = null;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.ImageUrl = "https://uploads-ssl.webflow.com/56d4b2fec160033816d1dfc8/56d600f404fd62186cba1578" +
    "_ReadyCertLogo_BIG.png";
            this.Title.Text = "Active Check";
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardSqlDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.DashboardSqlDataSource dashboardSqlDataSource1;
        private DevExpress.DashboardCommon.TreeViewDashboardItem treeViewDashboardItem1;
        private DevExpress.DashboardCommon.PivotDashboardItem pivotDashboardItem1;
        private DevExpress.DashboardCommon.TextBoxDashboardItem textBoxDashboardItem1;
    }
}
