namespace CustomerUI.UI.QuestionBank
{
    partial class FormExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExam));
            this.splashManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::CustomerUI.UI.QuestionBank.WaitFormForGenerateExam), true, true);
            this.labelDescription = new DevExpress.XtraEditors.LabelControl();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.xtraScrollableControl2 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.tablePanel = new DevExpress.Utils.Layout.TablePanel();
            this.descriptionReadOnly = new DevExpress.XtraEditors.LabelControl();
            this.lableSubjectTypeReadOnly = new DevExpress.XtraEditors.LabelControl();
            this.labelSubjectType = new DevExpress.XtraEditors.LabelControl();
            this.labelSubjectDescription = new DevExpress.XtraEditors.LabelControl();
            this.displayImage = new CustomerUI.UI.QuestionBank.ControlLib.DisplayImagePanel();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.btnPre = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.submitBtn = new DevExpress.XtraEditors.SimpleButton();
            this.xtraScrollableControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel)).BeginInit();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splashManager
            // 
            this.splashManager.ClosingDelay = 500;
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(468, 361);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(0, 14);
            this.labelDescription.TabIndex = 0;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Location = new System.Drawing.Point(333, 508);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(75, 23);
            this.xtraScrollableControl1.TabIndex = 1;
            // 
            // xtraScrollableControl2
            // 
            this.xtraScrollableControl2.AutoScrollMinSize = new System.Drawing.Size(0, 3000);
            this.xtraScrollableControl2.Controls.Add(this.tablePanel);
            this.xtraScrollableControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl2.FireScrollEventOnMouseWheel = true;
            this.xtraScrollableControl2.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl2.Name = "xtraScrollableControl2";
            this.xtraScrollableControl2.Size = new System.Drawing.Size(917, 543);
            this.xtraScrollableControl2.TabIndex = 2;
            // 
            // tablePanel
            // 
            this.tablePanel.AutoSize = true;
            this.tablePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel.Controls.Add(this.descriptionReadOnly);
            this.tablePanel.Controls.Add(this.lableSubjectTypeReadOnly);
            this.tablePanel.Controls.Add(this.labelSubjectType);
            this.tablePanel.Controls.Add(this.labelSubjectDescription);
            this.tablePanel.Controls.Add(this.displayImage);
            this.tablePanel.Controls.Add(this.tablePanel2);
            this.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel.Location = new System.Drawing.Point(0, 0);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 15F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F)});
            this.tablePanel.Size = new System.Drawing.Size(900, 3000);
            this.tablePanel.TabIndex = 3;
            // 
            // descriptionReadOnly
            // 
            this.descriptionReadOnly.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionReadOnly.Appearance.Options.UseFont = true;
            this.descriptionReadOnly.Appearance.Options.UseTextOptions = true;
            this.descriptionReadOnly.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.descriptionReadOnly.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tablePanel.SetColumn(this.descriptionReadOnly, 0);
            this.descriptionReadOnly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionReadOnly.Location = new System.Drawing.Point(15, 47);
            this.descriptionReadOnly.Margin = new System.Windows.Forms.Padding(15, 3, 10, 3);
            this.descriptionReadOnly.Name = "descriptionReadOnly";
            this.tablePanel.SetRow(this.descriptionReadOnly, 2);
            this.descriptionReadOnly.Size = new System.Drawing.Size(97, 23);
            this.descriptionReadOnly.TabIndex = 9;
            this.descriptionReadOnly.Text = "背景阅读";
            // 
            // lableSubjectTypeReadOnly
            // 
            this.lableSubjectTypeReadOnly.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableSubjectTypeReadOnly.Appearance.Options.UseFont = true;
            this.lableSubjectTypeReadOnly.Appearance.Options.UseTextOptions = true;
            this.lableSubjectTypeReadOnly.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lableSubjectTypeReadOnly.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lableSubjectTypeReadOnly.AppearanceDisabled.Options.UseTextOptions = true;
            this.lableSubjectTypeReadOnly.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lableSubjectTypeReadOnly.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tablePanel.SetColumn(this.lableSubjectTypeReadOnly, 0);
            this.lableSubjectTypeReadOnly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lableSubjectTypeReadOnly.Location = new System.Drawing.Point(15, 18);
            this.lableSubjectTypeReadOnly.Margin = new System.Windows.Forms.Padding(15, 3, 10, 3);
            this.lableSubjectTypeReadOnly.Name = "lableSubjectTypeReadOnly";
            this.tablePanel.SetRow(this.lableSubjectTypeReadOnly, 1);
            this.lableSubjectTypeReadOnly.Size = new System.Drawing.Size(97, 23);
            this.lableSubjectTypeReadOnly.TabIndex = 8;
            this.lableSubjectTypeReadOnly.Text = "题目题型";
            // 
            // labelSubjectType
            // 
            this.labelSubjectType.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubjectType.Appearance.Options.UseFont = true;
            this.tablePanel.SetColumn(this.labelSubjectType, 1);
            this.labelSubjectType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSubjectType.Location = new System.Drawing.Point(125, 18);
            this.labelSubjectType.Name = "labelSubjectType";
            this.tablePanel.SetRow(this.labelSubjectType, 1);
            this.labelSubjectType.Size = new System.Drawing.Size(650, 23);
            this.labelSubjectType.TabIndex = 7;
            this.labelSubjectType.Text = "题型";
            // 
            // labelSubjectDescription
            // 
            this.labelSubjectDescription.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubjectDescription.Appearance.Options.UseFont = true;
            this.tablePanel.SetColumn(this.labelSubjectDescription, 1);
            this.labelSubjectDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSubjectDescription.Location = new System.Drawing.Point(125, 47);
            this.labelSubjectDescription.Name = "labelSubjectDescription";
            this.tablePanel.SetRow(this.labelSubjectDescription, 2);
            this.labelSubjectDescription.Size = new System.Drawing.Size(650, 23);
            this.labelSubjectDescription.TabIndex = 6;
            this.labelSubjectDescription.Text = "背景阅读";
            // 
            // displayImage
            // 
            this.tablePanel.SetColumn(this.displayImage, 1);
            this.displayImage.Location = new System.Drawing.Point(125, 76);
            this.displayImage.Name = "displayImage";
            this.tablePanel.SetRow(this.displayImage, 3);
            this.displayImage.Size = new System.Drawing.Size(650, 250);
            this.displayImage.TabIndex = 5;
            // 
            // tablePanel2
            // 
            this.tablePanel.SetColumn(this.tablePanel2, 0);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 55F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel.SetColumnSpan(this.tablePanel2, 3);
            this.tablePanel2.Controls.Add(this.btnPre);
            this.tablePanel2.Controls.Add(this.btnNext);
            this.tablePanel2.Controls.Add(this.submitBtn);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(0, 349);
            this.tablePanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel.SetRow(this.tablePanel2, 5);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(900, 40);
            this.tablePanel2.TabIndex = 4;
            // 
            // btnPre
            // 
            this.btnPre.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.btnPre, 1);
            this.btnPre.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPre.ImageOptions.Image")));
            this.btnPre.Location = new System.Drawing.Point(140, 5);
            this.btnPre.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.btnPre.Name = "btnPre";
            this.tablePanel2.SetRow(this.btnPre, 0);
            this.btnPre.Size = new System.Drawing.Size(100, 30);
            this.btnPre.TabIndex = 0;
            this.btnPre.Text = "上一题";
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.btnNext, 2);
            this.btnNext.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.ImageOptions.Image")));
            this.btnNext.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnNext.Location = new System.Drawing.Point(270, 5);
            this.btnNext.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.btnNext.Name = "btnNext";
            this.tablePanel2.SetRow(this.btnNext, 0);
            this.btnNext.Size = new System.Drawing.Size(100, 30);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "下一题";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.submitBtn, 5);
            this.submitBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("submitBtn.ImageOptions.Image")));
            this.submitBtn.Location = new System.Drawing.Point(650, 5);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.submitBtn.Name = "submitBtn";
            this.tablePanel2.SetRow(this.submitBtn, 0);
            this.submitBtn.Size = new System.Drawing.Size(110, 30);
            this.submitBtn.TabIndex = 0;
            this.submitBtn.Text = "提交试卷";
            this.submitBtn.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FormExam
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 543);
            this.Controls.Add(this.xtraScrollableControl2);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "试卷";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormQuestion_Load);
            this.Shown += new System.EventHandler(this.FormExam_Shown);
            this.xtraScrollableControl2.ResumeLayout(false);
            this.xtraScrollableControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel)).EndInit();
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraSplashScreen.SplashScreenManager splashManager;
        private DevExpress.XtraEditors.LabelControl labelDescription;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl2;
        private DevExpress.Utils.Layout.TablePanel tablePanel;
        private DevExpress.XtraEditors.LabelControl descriptionReadOnly;
        private DevExpress.XtraEditors.LabelControl lableSubjectTypeReadOnly;
        private DevExpress.XtraEditors.LabelControl labelSubjectType;
        private DevExpress.XtraEditors.LabelControl labelSubjectDescription;
        private ControlLib.DisplayImagePanel displayImage;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.SimpleButton btnPre;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton submitBtn;
    }
}