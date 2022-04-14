namespace ConstructionManagement.UI
{
    partial class FrmAddAcceptanceImage
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 339F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFilePath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSubmit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.rtbDescription, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 142);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(86, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "文件说明";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectFile.Location = new System.Drawing.Point(71, 3);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 30);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "选择文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilePath.Location = new System.Drawing.Point(152, 5);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(3, 5, 5, 5);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(331, 21);
            this.txtFilePath.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSubmit.Location = new System.Drawing.Point(398, 107);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 30);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rtbDescription
            // 
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDescription.Location = new System.Drawing.Point(152, 41);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(3, 5, 5, 5);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(331, 56);
            this.rtbDescription.TabIndex = 5;
            this.rtbDescription.Text = "";
            // 
            // FrmAddAcceptanceImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 142);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmAddAcceptanceImage";
            this.Text = "新增验收图片";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RichTextBox rtbDescription;
    }
}