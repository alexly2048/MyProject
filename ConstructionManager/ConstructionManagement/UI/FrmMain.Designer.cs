namespace ConstructionManagement.UI
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmConstructionNode = new System.Windows.Forms.ToolStripMenuItem();
            this.itemConstructionNode = new System.Windows.Forms.ToolStripMenuItem();
            this.itemConstructionLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOverallSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAcceptance = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMiddleAcceptance = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFinalAcceptance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSystemManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsUserManager = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAuthorityManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.itemChangeBackground = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmConstructionNode,
            this.tsmOverallSchedule,
            this.tsmAcceptance,
            this.tsmSystemManagement});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmConstructionNode
            // 
            this.tsmConstructionNode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemConstructionNode,
            this.itemConstructionLog});
            this.tsmConstructionNode.Name = "tsmConstructionNode";
            this.tsmConstructionNode.Size = new System.Drawing.Size(68, 21);
            this.tsmConstructionNode.Text = "项目施工";
            // 
            // itemConstructionNode
            // 
            this.itemConstructionNode.Name = "itemConstructionNode";
            this.itemConstructionNode.Size = new System.Drawing.Size(124, 22);
            this.itemConstructionNode.Text = "施工节点";
            this.itemConstructionNode.Click += new System.EventHandler(this.itemConstructionNode_Click);
            // 
            // itemConstructionLog
            // 
            this.itemConstructionLog.Name = "itemConstructionLog";
            this.itemConstructionLog.Size = new System.Drawing.Size(124, 22);
            this.itemConstructionLog.Text = "施工日志";
            this.itemConstructionLog.Click += new System.EventHandler(this.itemConstructionLog_Click);
            // 
            // tsmOverallSchedule
            // 
            this.tsmOverallSchedule.Name = "tsmOverallSchedule";
            this.tsmOverallSchedule.Size = new System.Drawing.Size(80, 21);
            this.tsmOverallSchedule.Text = "施工总进度";
            this.tsmOverallSchedule.Click += new System.EventHandler(this.tsmOverallSchedule_Click);
            // 
            // tsmAcceptance
            // 
            this.tsmAcceptance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMiddleAcceptance,
            this.itemFinalAcceptance});
            this.tsmAcceptance.Name = "tsmAcceptance";
            this.tsmAcceptance.Size = new System.Drawing.Size(68, 21);
            this.tsmAcceptance.Text = "施工验收";
            // 
            // itemMiddleAcceptance
            // 
            this.itemMiddleAcceptance.Name = "itemMiddleAcceptance";
            this.itemMiddleAcceptance.Size = new System.Drawing.Size(124, 22);
            this.itemMiddleAcceptance.Text = "中间验收";
            this.itemMiddleAcceptance.Click += new System.EventHandler(this.itemMiddleAcceptance_Click);
            // 
            // itemFinalAcceptance
            // 
            this.itemFinalAcceptance.Name = "itemFinalAcceptance";
            this.itemFinalAcceptance.Size = new System.Drawing.Size(124, 22);
            this.itemFinalAcceptance.Text = "竣工验收";
            this.itemFinalAcceptance.Click += new System.EventHandler(this.itemFinalAcceptance_Click);
            // 
            // tsmSystemManagement
            // 
            this.tsmSystemManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsUserManager,
            this.tsmAuthorityManagement,
            this.itemChangeBackground});
            this.tsmSystemManagement.Name = "tsmSystemManagement";
            this.tsmSystemManagement.Size = new System.Drawing.Size(68, 21);
            this.tsmSystemManagement.Text = "系统管理";
            // 
            // tmsUserManager
            // 
            this.tmsUserManager.Name = "tmsUserManager";
            this.tmsUserManager.Size = new System.Drawing.Size(136, 22);
            this.tmsUserManager.Text = "用户管理";
            this.tmsUserManager.Click += new System.EventHandler(this.tmsUserManager_Click);
            // 
            // tsmAuthorityManagement
            // 
            this.tsmAuthorityManagement.Name = "tsmAuthorityManagement";
            this.tsmAuthorityManagement.Size = new System.Drawing.Size(136, 22);
            this.tsmAuthorityManagement.Text = "权限管理";
            this.tsmAuthorityManagement.Click += new System.EventHandler(this.tsmAuthorityManagement_Click);
            // 
            // itemChangeBackground
            // 
            this.itemChangeBackground.Name = "itemChangeBackground";
            this.itemChangeBackground.Size = new System.Drawing.Size(136, 22);
            this.itemChangeBackground.Text = "更换背景图";
            this.itemChangeBackground.Click += new System.EventHandler(this.itemChangeBackground_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 407);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "主界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmConstructionNode;
        private System.Windows.Forms.ToolStripMenuItem tsmOverallSchedule;
        private System.Windows.Forms.ToolStripMenuItem tsmAcceptance;
        private System.Windows.Forms.ToolStripMenuItem itemMiddleAcceptance;
        private System.Windows.Forms.ToolStripMenuItem itemFinalAcceptance;
        private System.Windows.Forms.ToolStripMenuItem tsmSystemManagement;
        private System.Windows.Forms.ToolStripMenuItem tmsUserManager;
        private System.Windows.Forms.ToolStripMenuItem tsmAuthorityManagement;
        private System.Windows.Forms.ToolStripMenuItem itemConstructionNode;
        private System.Windows.Forms.ToolStripMenuItem itemConstructionLog;
        private System.Windows.Forms.ToolStripMenuItem itemChangeBackground;
    }
}