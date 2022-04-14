namespace ConstructionManagement.UI
{
    partial class FrmWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWindow));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConstructionManager = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFileManagementSys = new System.Windows.Forms.ToolStripMenuItem();
            this.报销系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.财务系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExamSys = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFileShortcut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNotification = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShortcut = new System.Windows.Forms.ToolStripMenuItem();
            this.itemNotificationPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTelDict = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCalculater = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbNotification = new System.Windows.Forms.RichTextBox();
            this.rtbMemo = new System.Windows.Forms.RichTextBox();
            this.listExe = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(989, 581);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMaterial,
            this.tsmConstructionManager,
            this.itemFileManagementSys,
            this.报销系统ToolStripMenuItem,
            this.财务系统ToolStripMenuItem,
            this.itemExamSys,
            this.tsmFileShortcut,
            this.tsmTelDict,
            this.tsmCalculater});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(259, 561);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmMaterial
            // 
            this.tsmMaterial.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsmMaterial.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tsmMaterial.Margin = new System.Windows.Forms.Padding(10);
            this.tsmMaterial.Name = "tsmMaterial";
            this.tsmMaterial.Size = new System.Drawing.Size(226, 29);
            this.tsmMaterial.Text = "材料管理及人员管理系统";
            this.tsmMaterial.Click += new System.EventHandler(this.tsmMaterial_Click);
            // 
            // tsmConstructionManager
            // 
            this.tsmConstructionManager.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.tsmConstructionManager.ForeColor = System.Drawing.SystemColors.Window;
            this.tsmConstructionManager.Margin = new System.Windows.Forms.Padding(10);
            this.tsmConstructionManager.Name = "tsmConstructionManager";
            this.tsmConstructionManager.Size = new System.Drawing.Size(226, 29);
            this.tsmConstructionManager.Text = "施工管理系统";
            this.tsmConstructionManager.Click += new System.EventHandler(this.tsmConstructionManager_Click);
            // 
            // itemFileManagementSys
            // 
            this.itemFileManagementSys.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.itemFileManagementSys.ForeColor = System.Drawing.SystemColors.Window;
            this.itemFileManagementSys.Margin = new System.Windows.Forms.Padding(10);
            this.itemFileManagementSys.Name = "itemFileManagementSys";
            this.itemFileManagementSys.Size = new System.Drawing.Size(226, 29);
            this.itemFileManagementSys.Text = "资料管理系统";
            this.itemFileManagementSys.Click += new System.EventHandler(this.itemFileManagementSys_Click);
            // 
            // 报销系统ToolStripMenuItem
            // 
            this.报销系统ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.报销系统ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.报销系统ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.报销系统ToolStripMenuItem.Name = "报销系统ToolStripMenuItem";
            this.报销系统ToolStripMenuItem.Size = new System.Drawing.Size(226, 29);
            this.报销系统ToolStripMenuItem.Text = "报销系统";
            // 
            // 财务系统ToolStripMenuItem
            // 
            this.财务系统ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.财务系统ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.财务系统ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.财务系统ToolStripMenuItem.Name = "财务系统ToolStripMenuItem";
            this.财务系统ToolStripMenuItem.Size = new System.Drawing.Size(226, 29);
            this.财务系统ToolStripMenuItem.Text = "财务系统";
            // 
            // itemExamSys
            // 
            this.itemExamSys.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.itemExamSys.ForeColor = System.Drawing.Color.White;
            this.itemExamSys.Margin = new System.Windows.Forms.Padding(10);
            this.itemExamSys.Name = "itemExamSys";
            this.itemExamSys.Size = new System.Drawing.Size(226, 29);
            this.itemExamSys.Text = "考试系统";
            this.itemExamSys.Click += new System.EventHandler(this.itemExamSys_Click);
            // 
            // tsmFileShortcut
            // 
            this.tsmFileShortcut.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNotification,
            this.tsmShortcut,
            this.itemNotificationPwd});
            this.tsmFileShortcut.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.tsmFileShortcut.ForeColor = System.Drawing.SystemColors.Window;
            this.tsmFileShortcut.Margin = new System.Windows.Forms.Padding(10);
            this.tsmFileShortcut.Name = "tsmFileShortcut";
            this.tsmFileShortcut.Size = new System.Drawing.Size(226, 29);
            this.tsmFileShortcut.Text = "系统管理";
            // 
            // tsmNotification
            // 
            this.tsmNotification.Name = "tsmNotification";
            this.tsmNotification.Size = new System.Drawing.Size(236, 30);
            this.tsmNotification.Text = "公告管理";
            this.tsmNotification.Click += new System.EventHandler(this.tsmNotification_Click);
            // 
            // tsmShortcut
            // 
            this.tsmShortcut.Name = "tsmShortcut";
            this.tsmShortcut.Size = new System.Drawing.Size(236, 30);
            this.tsmShortcut.Text = "办公软件工具管理";
            this.tsmShortcut.Click += new System.EventHandler(this.tsmShortcut_Click);
            // 
            // itemNotificationPwd
            // 
            this.itemNotificationPwd.Name = "itemNotificationPwd";
            this.itemNotificationPwd.Size = new System.Drawing.Size(236, 30);
            this.itemNotificationPwd.Text = "公告密码设置";
            this.itemNotificationPwd.Click += new System.EventHandler(this.itemNotificationPwd_Click);
            // 
            // tsmTelDict
            // 
            this.tsmTelDict.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsmTelDict.ForeColor = System.Drawing.Color.White;
            this.tsmTelDict.Margin = new System.Windows.Forms.Padding(10);
            this.tsmTelDict.Name = "tsmTelDict";
            this.tsmTelDict.Size = new System.Drawing.Size(226, 29);
            this.tsmTelDict.Text = "备忘录";
            this.tsmTelDict.Click += new System.EventHandler(this.tsmTelDict_Click);
            // 
            // tsmCalculater
            // 
            this.tsmCalculater.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsmCalculater.ForeColor = System.Drawing.Color.White;
            this.tsmCalculater.Margin = new System.Windows.Forms.Padding(10);
            this.tsmCalculater.Name = "tsmCalculater";
            this.tsmCalculater.Size = new System.Drawing.Size(226, 29);
            this.tsmCalculater.Text = "计算器";
            this.tsmCalculater.Click += new System.EventHandler(this.tsmCalculater_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackgroundImage = global::ConstructionManagement.Properties.Resources.back;
            this.tableLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.rtbNotification, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.rtbMemo, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.listExe, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(262, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(724, 575);
            this.tableLayoutPanel3.TabIndex = 3;
            this.tableLayoutPanel3.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanel3_CellPaint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(0, 259);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.label2.Size = new System.Drawing.Size(724, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "备忘录";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label3.Size = new System.Drawing.Size(362, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "办公软件工具";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(362, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label4.Size = new System.Drawing.Size(362, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "公司公告";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbNotification
            // 
            this.rtbNotification.BackColor = System.Drawing.Color.White;
            this.rtbNotification.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNotification.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbNotification.Location = new System.Drawing.Point(365, 42);
            this.rtbNotification.Name = "rtbNotification";
            this.rtbNotification.ReadOnly = true;
            this.rtbNotification.Size = new System.Drawing.Size(356, 214);
            this.rtbNotification.TabIndex = 1;
            this.rtbNotification.Text = "";
            // 
            // rtbMemo
            // 
            this.rtbMemo.BackColor = System.Drawing.Color.White;
            this.rtbMemo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel3.SetColumnSpan(this.rtbMemo, 2);
            this.rtbMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMemo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbMemo.Location = new System.Drawing.Point(3, 307);
            this.rtbMemo.Name = "rtbMemo";
            this.tableLayoutPanel3.SetRowSpan(this.rtbMemo, 2);
            this.rtbMemo.Size = new System.Drawing.Size(718, 265);
            this.rtbMemo.TabIndex = 2;
            this.rtbMemo.Text = "";
            // 
            // listExe
            // 
            this.listExe.AllowDrop = true;
            this.listExe.BackColor = System.Drawing.Color.White;
            this.listExe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listExe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listExe.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listExe.HideSelection = false;
            this.listExe.Location = new System.Drawing.Point(3, 42);
            this.listExe.Name = "listExe";
            this.listExe.Size = new System.Drawing.Size(356, 214);
            this.listExe.TabIndex = 3;
            this.listExe.UseCompatibleStateImageBehavior = false;
            this.listExe.View = System.Windows.Forms.View.SmallIcon;
            this.listExe.DragDrop += new System.Windows.Forms.DragEventHandler(this.listExe_DragDrop);
            this.listExe.DragEnter += new System.Windows.Forms.DragEventHandler(this.listExe_DragEnter);
            this.listExe.DoubleClick += new System.EventHandler(this.listExe_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(995, 637);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 44);
            this.panel1.TabIndex = 2;
            // 
            // FrmWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(995, 637);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "FrmWindow";
            this.Text = "管理窗体";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmWindow_FormClosing);
            this.Load += new System.EventHandler(this.FrmWindow_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmMaterial;
        private System.Windows.Forms.ToolStripMenuItem tsmConstructionManager;
        private System.Windows.Forms.ToolStripMenuItem itemFileManagementSys;
        private System.Windows.Forms.ToolStripMenuItem 报销系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 财务系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmFileShortcut;
        private System.Windows.Forms.ToolStripMenuItem tsmNotification;
        private System.Windows.Forms.ToolStripMenuItem tsmShortcut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbNotification;
        private System.Windows.Forms.RichTextBox rtbMemo;
        private System.Windows.Forms.ListView listExe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem tsmTelDict;
        private System.Windows.Forms.ToolStripMenuItem itemExamSys;
        private System.Windows.Forms.ToolStripMenuItem itemNotificationPwd;
        private System.Windows.Forms.ToolStripMenuItem tsmCalculater;
    }
}