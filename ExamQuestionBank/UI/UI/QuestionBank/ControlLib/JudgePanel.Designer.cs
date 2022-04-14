namespace CustomerUI.UI.QuestionBank.ControlLib
{
    partial class JudgePanel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LOrderNo = new DevExpress.XtraEditors.LabelControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.checkCorrect = new DevExpress.XtraEditors.CheckEdit();
            this.LQuestion = new DevExpress.XtraEditors.LabelControl();
            this.checkError = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkCorrect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkError.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LOrderNo
            // 
            this.LOrderNo.Appearance.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LOrderNo.Appearance.Options.UseFont = true;
            this.LOrderNo.Appearance.Options.UseTextOptions = true;
            this.LOrderNo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.LOrderNo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.LOrderNo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.tablePanel1.SetColumn(this.LOrderNo, 0);
            this.LOrderNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LOrderNo.Location = new System.Drawing.Point(17, 3);
            this.LOrderNo.Margin = new System.Windows.Forms.Padding(17, 3, 12, 3);
            this.LOrderNo.Name = "LOrderNo";
            this.tablePanel1.SetRow(this.LOrderNo, 0);
            this.LOrderNo.Size = new System.Drawing.Size(87, 402);
            this.LOrderNo.TabIndex = 0;
            this.LOrderNo.Text = "判断题 10";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel1.Appearance.Options.UseBackColor = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F)});
            this.tablePanel1.Controls.Add(this.checkCorrect);
            this.tablePanel1.Controls.Add(this.LQuestion);
            this.tablePanel1.Controls.Add(this.checkError);
            this.tablePanel1.Controls.Add(this.LOrderNo);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(758, 408);
            this.tablePanel1.TabIndex = 0;
            // 
            // checkCorrect
            // 
            this.tablePanel1.SetColumn(this.checkCorrect, 2);
            this.checkCorrect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkCorrect.Location = new System.Drawing.Point(622, 3);
            this.checkCorrect.Name = "checkCorrect";
            this.checkCorrect.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCorrect.Properties.Appearance.Options.UseFont = true;
            this.checkCorrect.Properties.Caption = "正确";
            this.tablePanel1.SetRow(this.checkCorrect, 0);
            this.checkCorrect.Size = new System.Drawing.Size(87, 402);
            this.checkCorrect.TabIndex = 4;
            // 
            // LQuestion
            // 
            this.LQuestion.Appearance.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LQuestion.Appearance.Options.UseFont = true;
            this.LQuestion.Appearance.Options.UseTextOptions = true;
            this.LQuestion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.LQuestion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LQuestion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.tablePanel1.SetColumn(this.LQuestion, 1);
            this.LQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LQuestion.Location = new System.Drawing.Point(119, 3);
            this.LQuestion.Name = "LQuestion";
            this.tablePanel1.SetRow(this.LQuestion, 0);
            this.LQuestion.Size = new System.Drawing.Size(497, 402);
            this.LQuestion.TabIndex = 3;
            this.LQuestion.Text = "labelControl1";
            // 
            // checkError
            // 
            this.tablePanel1.SetColumn(this.checkError, 3);
            this.checkError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkError.Location = new System.Drawing.Point(715, 3);
            this.checkError.Name = "checkError";
            this.checkError.Properties.Appearance.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkError.Properties.Appearance.Options.UseFont = true;
            this.checkError.Properties.Appearance.Options.UseTextOptions = true;
            this.checkError.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.checkError.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.checkError.Properties.Caption = "错误";
            this.tablePanel1.SetRow(this.checkError, 0);
            this.checkError.Size = new System.Drawing.Size(40, 402);
            this.checkError.TabIndex = 2;
            this.checkError.CheckedChanged += new System.EventHandler(this.checkError_CheckedChanged);
            // 
            // JudgePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "JudgePanel";
            this.Size = new System.Drawing.Size(758, 408);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkCorrect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkError.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl LOrderNo;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        public DevExpress.XtraEditors.LabelControl LQuestion;
        public DevExpress.XtraEditors.CheckEdit checkError;
        private DevExpress.XtraEditors.CheckEdit checkCorrect;
    }
}
