namespace UniqueExcelConsole
{
    [System.ComponentModel.ToolboxItemAttribute(false)]
    partial class AIActionPane
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
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
            this.Send = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AnsBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(236, 85);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(99, 34);
            this.Send.TabIndex = 9;
            this.Send.Text = "发送";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 43);
            this.label2.TabIndex = 8;
            this.label2.Text = "AI：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnsBox
            // 
            this.AnsBox.Location = new System.Drawing.Point(128, 135);
            this.AnsBox.Multiline = true;
            this.AnsBox.Name = "AnsBox";
            this.AnsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AnsBox.Size = new System.Drawing.Size(207, 307);
            this.AnsBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "问题：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Question
            // 
            this.Question.Location = new System.Drawing.Point(139, 33);
            this.Question.Multiline = true;
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(196, 37);
            this.Question.TabIndex = 5;
            // 
            // AIActionPane
            // 
            this.Controls.Add(this.Send);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Question);
            this.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "AIActionPane";
            this.Size = new System.Drawing.Size(515, 638);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AnsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Question;
    }
}
