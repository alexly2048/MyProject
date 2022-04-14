
namespace ConstructionManagement.UI
{
    partial class FormEditUser
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
            this.label4 = new System.Windows.Forms.Label();
            this.tId = new System.Windows.Forms.TextBox();
            this.tName = new System.Windows.Forms.TextBox();
            this.tPwd = new System.Windows.Forms.TextBox();
            this.tEnsure = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnConfirm = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tPwd, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tEnsure, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(526, 322);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 0, 10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(15, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 0, 10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "用户名";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(15, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 0, 10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "密码";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(15, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(15, 0, 10, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "确认密码";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tId
            // 
            this.tId.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tId.Location = new System.Drawing.Point(81, 33);
            this.tId.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.tId.Name = "tId";
            this.tId.Size = new System.Drawing.Size(442, 21);
            this.tId.TabIndex = 1;
            // 
            // tName
            // 
            this.tName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tName.Location = new System.Drawing.Point(81, 97);
            this.tName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(442, 21);
            this.tName.TabIndex = 1;
            // 
            // tPwd
            // 
            this.tPwd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tPwd.Location = new System.Drawing.Point(81, 161);
            this.tPwd.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.tPwd.Name = "tPwd";
            this.tPwd.PasswordChar = '*';
            this.tPwd.Size = new System.Drawing.Size(442, 21);
            this.tPwd.TabIndex = 1;
            // 
            // tEnsure
            // 
            this.tEnsure.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tEnsure.Location = new System.Drawing.Point(81, 225);
            this.tEnsure.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.tEnsure.Name = "tEnsure";
            this.tEnsure.PasswordChar = '*';
            this.tEnsure.Size = new System.Drawing.Size(442, 21);
            this.tEnsure.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnConfirm, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 259);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(520, 60);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirm.Location = new System.Drawing.Point(409, 15);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(15, 15, 35, 10);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(76, 35);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(304, 15);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(10, 15, 15, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 322);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormEditUser";
            this.Text = "更新用户信息";
            this.Load += new System.EventHandler(this.FormEditUser_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tId;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tPwd;
        private System.Windows.Forms.TextBox tEnsure;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}