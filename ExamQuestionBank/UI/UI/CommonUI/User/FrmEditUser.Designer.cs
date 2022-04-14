using CustomerControl;
namespace CustomerUI.UI.Common
{
    partial class FrmEditUser
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
            this.editPanel1 = new CustomerControl.EditPanel();
            this.editPanel2 = new CustomerControl.EditPanel();
            this.editPanel3 = new CustomerControl.EditPanel();
            this.editPanel4 = new CustomerControl.EditPanel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 52.84F)});
            this.tablePanel1.Controls.Add(this.simpleButton1);
            this.tablePanel1.Controls.Add(this.editPanel4);
            this.tablePanel1.Controls.Add(this.editPanel3);
            this.tablePanel1.Controls.Add(this.editPanel2);
            this.tablePanel1.Controls.Add(this.editPanel1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F)});
            this.tablePanel1.Size = new System.Drawing.Size(486, 211);
            this.tablePanel1.TabIndex = 0;
            // 
            // editPanel1
            // 
            this.tablePanel1.SetColumn(this.editPanel1, 0);
            this.editPanel1.Location = new System.Drawing.Point(3, 3);
            this.editPanel1.Name = "editPanel1";
            this.tablePanel1.SetRow(this.editPanel1, 0);
            this.editPanel1.Size = new System.Drawing.Size(480, 37);
            this.editPanel1.TabIndex = 0;
            // 
            // editPanel2
            // 
            this.tablePanel1.SetColumn(this.editPanel2, 0);
            this.editPanel2.Location = new System.Drawing.Point(3, 46);
            this.editPanel2.Name = "editPanel2";
            this.tablePanel1.SetRow(this.editPanel2, 1);
            this.editPanel2.Size = new System.Drawing.Size(480, 37);
            this.editPanel2.TabIndex = 1;
            // 
            // editPanel3
            // 
            this.tablePanel1.SetColumn(this.editPanel3, 0);
            this.editPanel3.Location = new System.Drawing.Point(3, 89);
            this.editPanel3.Name = "editPanel3";
            this.tablePanel1.SetRow(this.editPanel3, 2);
            this.editPanel3.Size = new System.Drawing.Size(480, 37);
            this.editPanel3.TabIndex = 2;
            // 
            // editPanel4
            // 
            this.tablePanel1.SetColumn(this.editPanel4, 0);
            this.editPanel4.Location = new System.Drawing.Point(3, 132);
            this.editPanel4.Name = "editPanel4";
            this.tablePanel1.SetRow(this.editPanel4, 3);
            this.editPanel4.Size = new System.Drawing.Size(480, 37);
            this.editPanel4.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.tablePanel1.SetColumn(this.simpleButton1, 0);
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton1.Location = new System.Drawing.Point(386, 177);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 5, 25, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.tablePanel1.SetRow(this.simpleButton1, 4);
            this.simpleButton1.Size = new System.Drawing.Size(75, 29);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "提交";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 211);
            this.Controls.Add(this.tablePanel1);
            this.Name = "FrmEditUser";
            this.Text = "用户信息-编辑";
            this.Load += new System.EventHandler(this.FrmEditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private EditPanel editPanel4;
        private EditPanel editPanel3;
        private EditPanel editPanel2;
        private EditPanel editPanel1;
    }
}