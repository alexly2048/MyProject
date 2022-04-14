namespace CustomerUI.UI.QuestionBank
{
    partial class FormDisplayImage
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
            this.displayPic = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.displayPic.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // displayPic
            // 
            this.displayPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayPic.Location = new System.Drawing.Point(0, 0);
            this.displayPic.Name = "displayPic";
            this.displayPic.Properties.ReadOnly = true;
            this.displayPic.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.displayPic.Size = new System.Drawing.Size(933, 525);
            this.displayPic.TabIndex = 0;
            // 
            // FormDisplayImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 525);
            this.Controls.Add(this.displayPic);
            this.Name = "FormDisplayImage";
            this.Text = "显示图片";
            this.Load += new System.EventHandler(this.FormDisplayImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayPic.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit displayPic;
    }
}