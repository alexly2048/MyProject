namespace ConstructionManagement.UI
{
    partial class FrmAddNewFile
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConstructionNo = new System.Windows.Forms.TextBox();
            this.txtConstructionField = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnSelectFile, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFilePath, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSubmit, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtConstructionNo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtConstructionField, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(418, 168);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectFile.Location = new System.Drawing.Point(7, 85);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(5);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 31);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "选择文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilePath.Location = new System.Drawing.Point(90, 90);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(318, 21);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSubmit.Location = new System.Drawing.Point(328, 126);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 37);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "上传";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "施工节点编号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(29, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "阶段名称";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtConstructionNo
            // 
            this.txtConstructionNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConstructionNo.Location = new System.Drawing.Point(90, 10);
            this.txtConstructionNo.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.txtConstructionNo.Name = "txtConstructionNo";
            this.txtConstructionNo.Size = new System.Drawing.Size(318, 21);
            this.txtConstructionNo.TabIndex = 5;
            // 
            // txtConstructionField
            // 
            this.txtConstructionField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConstructionField.Location = new System.Drawing.Point(90, 50);
            this.txtConstructionField.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.txtConstructionField.Name = "txtConstructionField";
            this.txtConstructionField.Size = new System.Drawing.Size(318, 21);
            this.txtConstructionField.TabIndex = 6;
            // 
            // FrmAddNewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 168);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmAddNewFile";
            this.Text = "上传新文件";
            this.Load += new System.EventHandler(this.FrmAddNewFile_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConstructionNo;
        private System.Windows.Forms.TextBox txtConstructionField;
    }
}