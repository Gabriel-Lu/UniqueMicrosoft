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
            this.group2 = this.Factory.CreateRibbonGroup();
            this.group4 = this.Factory.CreateRibbonGroup();
            this.group5 = this.Factory.CreateRibbonGroup();
            this.Connect = this.Factory.CreateRibbonButton();
            this.AI = this.Factory.CreateRibbonButton();
            this.Draw = this.Factory.CreateRibbonButton();
            this.UploadQing = this.Factory.CreateRibbonButton();
            this.CarMove = this.Factory.CreateRibbonButton();
            this.CarStop = this.Factory.CreateRibbonButton();
            this.separator2 = this.Factory.CreateRibbonSeparator();
            this.group6 = this.Factory.CreateRibbonGroup();
            this.种植小助手.SuspendLayout();
            this.group1.SuspendLayout();
            this.group3.SuspendLayout();
            this.group2.SuspendLayout();
            this.group4.SuspendLayout();
            this.group5.SuspendLayout();
            this.group6.SuspendLayout();
            this.SuspendLayout();
            // 
            // 种植小助手
            // 
            this.种植小助手.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.种植小助手.Groups.Add(this.group1);
            this.种植小助手.Groups.Add(this.group6);
            this.种植小助手.Groups.Add(this.group3);
            this.种植小助手.Groups.Add(this.group2);
            this.种植小助手.Groups.Add(this.group4);
            this.种植小助手.Groups.Add(this.group5);
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
            // group2
            // 
            this.group2.Items.Add(this.AI);
            this.group2.Label = "召唤AI种植小助手";
            this.group2.Name = "group2";
            // 
            // group4
            // 
            this.group4.Items.Add(this.Draw);
            this.group4.Label = "建立种植用地";
            this.group4.Name = "group4";
            // 
            // group5
            // 
            this.group5.Items.Add(this.UploadQing);
            this.group5.Label = "上传数据进行分析";
            this.group5.Name = "group5";
            // 
            // Connect
            // 
            this.Connect.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.Connect.Label = "连接固定设备";
            this.Connect.Name = "Connect";
            this.Connect.OfficeImageId = "OrgChartLayoutSpacingChange";
            this.Connect.ShowImage = true;
            this.Connect.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Connect_Click);
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
            // Draw
            // 
            this.Draw.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.Draw.Label = "Adjust Route Of Inspection";
            this.Draw.Name = "Draw";
            this.Draw.OfficeImageId = "PageWidthGuideShowHide";
            this.Draw.ShowImage = true;
            this.Draw.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Draw_Click);
            // 
            // UploadQing
            // 
            this.UploadQing.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.UploadQing.Label = "上传至青云";
            this.UploadQing.Name = "UploadQing";
            this.UploadQing.OfficeImageId = "OverallFeedback";
            this.UploadQing.ShowImage = true;
            this.UploadQing.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.UploadQing_Click);
            // 
            // CarMove
            // 
            this.CarMove.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.CarMove.Label = "检测车开始检测";
            this.CarMove.Name = "CarMove";
            this.CarMove.OfficeImageId = "ProcessEngineeringApplyTagFormat";
            this.CarMove.ShowImage = true;
            this.CarMove.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CarMove_Click);
            // 
            // CarStop
            // 
            this.CarStop.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.CarStop.Label = "小车停止检测";
            this.CarStop.Name = "CarStop";
            this.CarStop.OfficeImageId = "PositionAbsoluteMarks";
            this.CarStop.ShowImage = true;
            this.CarStop.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CarStop_Click);
            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            // 
            // group6
            // 
            this.group6.Items.Add(this.CarMove);
            this.group6.Items.Add(this.separator2);
            this.group6.Items.Add(this.CarStop);
            this.group6.Label = "检测小车控制面板";
            this.group6.Name = "group6";
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
            this.group4.ResumeLayout(false);
            this.group4.PerformLayout();
            this.group5.ResumeLayout(false);
            this.group5.PerformLayout();
            this.group6.ResumeLayout(false);
            this.group6.PerformLayout();
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
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Draw;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group5;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton UploadQing;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton CarMove;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton CarStop;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group6;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonUI RibbonUI
        {
            get { return this.GetRibbon<RibbonUI>(); }
        }
    }
}
