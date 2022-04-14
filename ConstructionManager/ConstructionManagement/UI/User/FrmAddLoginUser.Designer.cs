namespace ConstructionManagement.UI
{
    partial class FrmAddLoginUser
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
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUserId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUserName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPwd, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSubmit, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(379, 182);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(25, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(25, 10, 20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "密码";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(25, 10, 20, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "用户名";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(25, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(25, 10, 20, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "用户ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserId
            // 
            this.txtUserId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserId.Location = new System.Drawing.Point(89, 10);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(280, 21);
            this.txtUserId.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserName.Location = new System.Drawing.Point(89, 51);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(280, 21);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPwd
            // 
            this.txtPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPwd.Location = new System.Drawing.Point(89, 92);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(280, 21);
            this.txtPwd.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSubmit.Location = new System.Drawing.Point(269, 133);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(10, 10, 35, 10);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 39);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FrmAddLoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 182);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmAddLoginUser";
            this.Text = "新增用户";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnSubmit;
    }
}