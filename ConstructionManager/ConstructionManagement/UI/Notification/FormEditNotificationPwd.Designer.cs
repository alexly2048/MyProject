namespace ConstructionManagement.UI
{
    partial class FormEditNotificationPwd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tOriginal = new System.Windows.Forms.TextBox();
            this.tNew = new System.Windows.Forms.TextBox();
            this.tEnsure = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tOriginal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tNew, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tEnsure, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(548, 257);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 5, 15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原始密码";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(10, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 5, 15, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(10, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 5, 15, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tOriginal
            // 
            this.tOriginal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tOriginal.Location = new System.Drawing.Point(81, 34);
            this.tOriginal.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.tOriginal.Name = "tOriginal";
            this.tOriginal.PasswordChar = '*';
            this.tOriginal.Size = new System.Drawing.Size(464, 21);
            this.tOriginal.TabIndex = 3;
            // 
            // tNew
            // 
            this.tNew.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tNew.Location = new System.Drawing.Point(81, 94);
            this.tNew.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.tNew.Name = "tNew";
            this.tNew.PasswordChar = '*';
            this.tNew.Size = new System.Drawing.Size(464, 21);
            this.tNew.TabIndex = 4;
            // 
            // tEnsure
            // 
            this.tEnsure.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tEnsure.Location = new System.Drawing.Point(81, 154);
            this.tEnsure.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.tEnsure.Name = "tEnsure";
            this.tEnsure.PasswordChar = '*';
            this.tEnsure.Size = new System.Drawing.Size(464, 21);
            this.tEnsure.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnSubmit, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 205);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 25, 0, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(548, 42);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSubmit.Location = new System.Drawing.Point(164, 3);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 3, 35, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 36);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.Location = new System.Drawing.Point(309, 3);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(35, 3, 3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "退出";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormEditNotificationPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 257);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormEditNotificationPwd";
            this.Text = "FormEditNotificationPwd";
            this.Load += new System.EventHandler(this.FormEditNotificationPwd_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tOriginal;
        private System.Windows.Forms.TextBox tNew;
        private System.Windows.Forms.TextBox tEnsure;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}