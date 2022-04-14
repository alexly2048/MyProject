namespace ConstructionManagement.UI
{
    partial class FrmEditItemFile
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnSelectFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFilePath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDesc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSubmit, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 141);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectFile.Location = new System.Drawing.Point(10, 10);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(10);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 30);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "选择文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(56, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "说明";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilePath.Location = new System.Drawing.Point(98, 12);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(3, 12, 10, 12);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(286, 21);
            this.txtFilePath.TabIndex = 2;
            // 
            // txtDesc
            // 
            this.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDesc.Location = new System.Drawing.Point(98, 60);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(286, 21);
            this.txtDesc.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSubmit.Location = new System.Drawing.Point(304, 96);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 40);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FrmEditItemFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 141);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmEditItemFile";
            this.Text = "子项文件-新增";
            this.Load += new System.EventHandler(this.FrmEditItemFile_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnSubmit;
    }
}