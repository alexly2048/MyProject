namespace CustomerUI.UI.QuestionBank.ControlLib
{
    partial class EditImagePanel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditImagePanel));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.displayPic = new DevExpress.XtraEditors.PictureEdit();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.tFileName = new DevExpress.XtraEditors.TextEdit();
            this.btnSelectImage = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayPic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tFileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.displayPic);
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Controls.Add(this.tablePanel3);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F)});
            this.tablePanel1.Size = new System.Drawing.Size(459, 370);
            this.tablePanel1.TabIndex = 0;
            // 
            // displayPic
            // 
            this.displayPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tablePanel1.SetColumn(this.displayPic, 0);
            this.displayPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayPic.Location = new System.Drawing.Point(3, 3);
            this.displayPic.Name = "displayPic";
            this.displayPic.Properties.ReadOnly = true;
            this.displayPic.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.displayPic.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.tablePanel1.SetRow(this.displayPic, 0);
            this.displayPic.Size = new System.Drawing.Size(453, 284);
            this.displayPic.TabIndex = 6;
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 0);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel2.Controls.Add(this.tFileName);
            this.tablePanel2.Controls.Add(this.btnSelectImage);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(0, 290);
            this.tablePanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 1);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(459, 40);
            this.tablePanel2.TabIndex = 5;
            // 
            // tFileName
            // 
            this.tablePanel2.SetColumn(this.tFileName, 1);
            this.tFileName.Location = new System.Drawing.Point(108, 10);
            this.tFileName.Name = "tFileName";
            this.tablePanel2.SetRow(this.tFileName, 0);
            this.tFileName.Size = new System.Drawing.Size(348, 20);
            this.tFileName.TabIndex = 1;
            // 
            // btnSelectImage
            // 
            this.tablePanel2.SetColumn(this.btnSelectImage, 0);
            this.btnSelectImage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectImage.ImageOptions.Image")));
            this.btnSelectImage.Location = new System.Drawing.Point(20, 8);
            this.btnSelectImage.Margin = new System.Windows.Forms.Padding(20, 5, 10, 5);
            this.btnSelectImage.Name = "btnSelectImage";
            this.tablePanel2.SetRow(this.btnSelectImage, 0);
            this.btnSelectImage.Size = new System.Drawing.Size(75, 23);
            this.btnSelectImage.TabIndex = 0;
            this.btnSelectImage.Text = "选择图片";
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // tablePanel3
            // 
            this.tablePanel1.SetColumn(this.tablePanel3, 0);
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel3.Controls.Add(this.btnSubmit);
            this.tablePanel3.Controls.Add(this.btnDelete);
            this.tablePanel3.Location = new System.Drawing.Point(0, 330);
            this.tablePanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel1.SetRow(this.tablePanel3, 2);
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel3.Size = new System.Drawing.Size(459, 40);
            this.tablePanel3.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.tablePanel3.SetColumn(this.btnSubmit, 3);
            this.btnSubmit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.ImageOptions.Image")));
            this.btnSubmit.Location = new System.Drawing.Point(260, 8);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.tablePanel3.SetRow(this.btnSubmit, 0);
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "提交";
            // 
            // btnDelete
            // 
            this.tablePanel3.SetColumn(this.btnDelete, 1);
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(125, 8);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btnDelete.Name = "btnDelete";
            this.tablePanel3.SetRow(this.btnDelete, 0);
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "删除";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(15, 8);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 0;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(98, 10);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(317, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // EditImagePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "EditImagePanel";
            this.Size = new System.Drawing.Size(459, 370);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displayPic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tFileName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.TextEdit tFileName;
        private DevExpress.XtraEditors.SimpleButton btnSelectImage;
        protected internal DevExpress.XtraEditors.SimpleButton btnSubmit;
        protected internal DevExpress.XtraEditors.SimpleButton btnDelete;
        protected internal DevExpress.XtraEditors.PictureEdit displayPic;
    }
}
