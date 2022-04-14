namespace CustomerUI.UI.QuestionBank
{
    partial class FormQuestionImages
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.editThird = new CustomerUI.UI.QuestionBank.ControlLib.EditImagePanel();
            this.editSecond = new CustomerUI.UI.QuestionBank.ControlLib.EditImagePanel();
            this.editFirst = new CustomerUI.UI.QuestionBank.ControlLib.EditImagePanel();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.editThird);
            this.tablePanel1.Controls.Add(this.editSecond);
            this.tablePanel1.Controls.Add(this.editFirst);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Size = new System.Drawing.Size(941, 502);
            this.tablePanel1.TabIndex = 0;
            // 
            // editThird
            // 
            this.tablePanel1.SetColumn(this.editThird, 2);
            this.editThird.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editThird.Location = new System.Drawing.Point(630, 3);
            this.editThird.Name = "editThird";
            this.tablePanel1.SetRow(this.editThird, 0);
            this.editThird.Size = new System.Drawing.Size(308, 496);
            this.editThird.TabIndex = 2;
            // 
            // editSecond
            // 
            this.tablePanel1.SetColumn(this.editSecond, 1);
            this.editSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editSecond.Location = new System.Drawing.Point(317, 3);
            this.editSecond.Name = "editSecond";
            this.tablePanel1.SetRow(this.editSecond, 0);
            this.editSecond.Size = new System.Drawing.Size(308, 496);
            this.editSecond.TabIndex = 1;
            // 
            // editFirst
            // 
            this.tablePanel1.SetColumn(this.editFirst, 0);
            this.editFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editFirst.Location = new System.Drawing.Point(3, 3);
            this.editFirst.Name = "editFirst";
            this.tablePanel1.SetRow(this.editFirst, 0);
            this.editFirst.Size = new System.Drawing.Size(308, 496);
            this.editFirst.TabIndex = 0;
            // 
            // FormQuestionImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 502);
            this.Controls.Add(this.tablePanel1);
            this.Name = "FormQuestionImages";
            this.Text = "问题图片";
            this.Load += new System.EventHandler(this.FormQuestionImages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private ControlLib.EditImagePanel editThird;
        private ControlLib.EditImagePanel editSecond;
        private ControlLib.EditImagePanel editFirst;
    }
}