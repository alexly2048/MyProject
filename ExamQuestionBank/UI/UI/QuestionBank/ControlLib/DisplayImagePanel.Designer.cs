namespace CustomerUI.UI.QuestionBank.ControlLib
{
    partial class DisplayImagePanel
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.thirdPic = new DevExpress.XtraEditors.PictureEdit();
            this.secondPic = new DevExpress.XtraEditors.PictureEdit();
            this.firstPic = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thirdPic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstPic.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.thirdPic);
            this.tablePanel1.Controls.Add(this.secondPic);
            this.tablePanel1.Controls.Add(this.firstPic);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(795, 382);
            this.tablePanel1.TabIndex = 0;
            // 
            // thirdPic
            // 
            this.tablePanel1.SetColumn(this.thirdPic, 2);
            this.thirdPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirdPic.Location = new System.Drawing.Point(533, 3);
            this.thirdPic.Name = "thirdPic";
            this.thirdPic.Properties.ReadOnly = true;
            this.thirdPic.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.thirdPic.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.tablePanel1.SetRow(this.thirdPic, 0);
            this.thirdPic.Size = new System.Drawing.Size(259, 376);
            this.thirdPic.TabIndex = 2;
            this.thirdPic.DoubleClick += new System.EventHandler(this.firstPic_DoubleClick);
            // 
            // secondPic
            // 
            this.tablePanel1.SetColumn(this.secondPic, 1);
            this.secondPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondPic.Location = new System.Drawing.Point(268, 3);
            this.secondPic.Name = "secondPic";
            this.secondPic.Properties.ReadOnly = true;
            this.secondPic.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.secondPic.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.tablePanel1.SetRow(this.secondPic, 0);
            this.secondPic.Size = new System.Drawing.Size(259, 376);
            this.secondPic.TabIndex = 1;
            this.secondPic.DoubleClick += new System.EventHandler(this.firstPic_DoubleClick);
            // 
            // firstPic
            // 
            this.tablePanel1.SetColumn(this.firstPic, 0);
            this.firstPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstPic.Location = new System.Drawing.Point(3, 3);
            this.firstPic.Name = "firstPic";
            this.firstPic.Properties.ReadOnly = true;
            this.firstPic.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.firstPic.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.tablePanel1.SetRow(this.firstPic, 0);
            this.firstPic.Size = new System.Drawing.Size(259, 376);
            this.firstPic.TabIndex = 0;
            this.firstPic.DoubleClick += new System.EventHandler(this.firstPic_DoubleClick);
            // 
            // DisplayImagePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "DisplayImagePanel";
            this.Size = new System.Drawing.Size(795, 382);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thirdPic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstPic.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.PictureEdit thirdPic;
        private DevExpress.XtraEditors.PictureEdit secondPic;
        private DevExpress.XtraEditors.PictureEdit firstPic;
    }
}
