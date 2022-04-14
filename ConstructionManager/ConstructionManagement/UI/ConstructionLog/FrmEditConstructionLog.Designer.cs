namespace ConstructionManagement.UI
{
    partial class FrmEditConstructionLog
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.txtWeather = new System.Windows.Forms.TextBox();
            this.txtWind = new System.Windows.Forms.TextBox();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbConstructionNode = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.rtbProduct = new System.Windows.Forms.RichTextBox();
            this.rtbSecure = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.rtbProduct, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rtbSecure, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 689);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 390);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "技术质量安全记录";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(726, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "生产情况";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtEvent, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtWeather, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtWind, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtTemperature, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtPeople, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.dtDate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbConstructionNode, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(726, 120);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(10, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 40);
            this.label4.TabIndex = 1;
            this.label4.Text = "突发事件";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(10, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "日期";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(348, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 40);
            this.label5.TabIndex = 2;
            this.label5.Text = "风力";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(348, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 40);
            this.label6.TabIndex = 3;
            this.label6.Text = "天气状况";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(553, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 40);
            this.label7.TabIndex = 4;
            this.label7.Text = "气温";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(553, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 40);
            this.label8.TabIndex = 5;
            this.label8.Text = "人力";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEvent
            // 
            this.txtEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEvent.Location = new System.Drawing.Point(76, 90);
            this.txtEvent.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(259, 21);
            this.txtEvent.TabIndex = 7;
            // 
            // txtWeather
            // 
            this.txtWeather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWeather.Location = new System.Drawing.Point(414, 50);
            this.txtWeather.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtWeather.Name = "txtWeather";
            this.txtWeather.Size = new System.Drawing.Size(126, 21);
            this.txtWeather.TabIndex = 8;
            // 
            // txtWind
            // 
            this.txtWind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWind.Location = new System.Drawing.Point(414, 90);
            this.txtWind.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtWind.Name = "txtWind";
            this.txtWind.Size = new System.Drawing.Size(126, 21);
            this.txtWind.TabIndex = 9;
            // 
            // txtTemperature
            // 
            this.txtTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTemperature.Location = new System.Drawing.Point(595, 50);
            this.txtTemperature.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(128, 21);
            this.txtTemperature.TabIndex = 10;
            // 
            // txtPeople
            // 
            this.txtPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPeople.Location = new System.Drawing.Point(595, 90);
            this.txtPeople.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(128, 21);
            this.txtPeople.TabIndex = 11;
            // 
            // dtDate
            // 
            this.dtDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtDate.Location = new System.Drawing.Point(76, 50);
            this.dtDate.Margin = new System.Windows.Forms.Padding(3, 10, 3, 310);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(259, 21);
            this.dtDate.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 40);
            this.label9.TabIndex = 13;
            this.label9.Text = "施工项目";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbConstructionNode
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbConstructionNode, 5);
            this.cbConstructionNode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbConstructionNode.FormattingEnabled = true;
            this.cbConstructionNode.Location = new System.Drawing.Point(76, 10);
            this.cbConstructionNode.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.cbConstructionNode.Name = "cbConstructionNode";
            this.cbConstructionNode.Size = new System.Drawing.Size(647, 20);
            this.cbConstructionNode.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSubmit);
            this.flowLayoutPanel1.Controls.Add(this.btnPrint);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 641);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(726, 45);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(641, 5);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 30);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(546, 5);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 30);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "打印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // rtbProduct
            // 
            this.rtbProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbProduct.Location = new System.Drawing.Point(3, 157);
            this.rtbProduct.Name = "rtbProduct";
            this.rtbProduct.Size = new System.Drawing.Size(726, 222);
            this.rtbProduct.TabIndex = 4;
            this.rtbProduct.Text = "";
            // 
            // rtbSecure
            // 
            this.rtbSecure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSecure.Location = new System.Drawing.Point(3, 413);
            this.rtbSecure.Name = "rtbSecure";
            this.rtbSecure.Size = new System.Drawing.Size(726, 222);
            this.rtbSecure.TabIndex = 5;
            this.rtbSecure.Text = "";
            // 
            // FrmEditConstructionLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 689);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmEditConstructionLog";
            this.Text = "施工日志-编辑";
            this.Load += new System.EventHandler(this.FrmEditConstructionLog_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.TextBox txtWeather;
        private System.Windows.Forms.TextBox txtWind;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox txtPeople;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.RichTextBox rtbProduct;
        private System.Windows.Forms.RichTextBox rtbSecure;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbConstructionNode;
    }
}