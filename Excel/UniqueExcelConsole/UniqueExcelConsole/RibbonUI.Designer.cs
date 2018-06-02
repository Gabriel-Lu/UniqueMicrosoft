namespace UniqueExcelConsole
{
    partial class RibbonUI : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonUI()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.种植小助手 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.label1 = this.Factory.CreateRibbonLabel();
            this.DebugLabel = this.Factory.CreateRibbonLabel();
            this.Connect = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.AI = this.Factory.CreateRibbonButton();
            this.种植小助手.SuspendLayout();
            this.group1.SuspendLayout();
            this.group3.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // 种植小助手
            // 
            this.种植小助手.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.种植小助手.Groups.Add(this.group1);
            this.种植小助手.Groups.Add(this.group3);
            this.种植小助手.Groups.Add(this.group2);
            this.种植小助手.Label = "Unique MS";
            this.种植小助手.Name = "种植小助手";
            // 
            // group1
            // 
            this.group1.Items.Add(this.Connect);
            this.group1.Label = "Socket Connector";
            this.group1.Name = "group1";
            // 
            // group3
            // 
            this.group3.Items.Add(this.label1);
            this.group3.Items.Add(this.DebugLabel);
            this.group3.Label = "调试信息";
            this.group3.Name = "group3";
            // 
            // label1
            // 
            this.label1.Label = "调试信息";
            this.label1.Name = "label1";
            // 
            // DebugLabel
            // 
            this.DebugLabel.Label = "暂无调试信息输出";
            this.DebugLabel.Name = "DebugLabel";
            // 
            // Connect
            // 
            this.Connect.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.Connect.Label = "连接设备";
            this.Connect.Name = "Connect";
            this.Connect.OfficeImageId = "OrgChartLayoutSpacingChange";
            this.Connect.ShowImage = true;
            this.Connect.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Connect_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.AI);
            this.group2.Label = "召唤AI种植小助手";
            this.group2.Name = "group2";
            // 
            // AI
            // 
            this.AI.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.AI.Label = "种植小助手";
            this.AI.Name = "AI";
            this.AI.OfficeImageId = "NewCustomButton";
            this.AI.ShowImage = true;
            this.AI.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AI_Click);
            // 
            // RibbonUI
            // 
            this.Name = "RibbonUI";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.种植小助手);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibbonUI_Load);
            this.种植小助手.ResumeLayout(false);
            this.种植小助手.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab 种植小助手;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Connect;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label1;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel DebugLabel;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton AI;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonUI RibbonUI
        {
            get { return this.GetRibbon<RibbonUI>(); }
        }
    }
}
