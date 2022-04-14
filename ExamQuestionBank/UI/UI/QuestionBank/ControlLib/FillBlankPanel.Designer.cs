namespace CustomerUI.UI.QuestionBank.ControlLib
{
    partial class FillBlankPanel
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.LQuestion = new DevExpress.XtraEditors.MemoEdit();
            this.tAnswer = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LOrderNo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LQuestion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAnswer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel1.Controls.Add(this.LQuestion);
            this.tablePanel1.Controls.Add(this.tAnswer);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.LOrderNo);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 80F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F)});
            this.tablePanel1.Size = new System.Drawing.Size(650, 600);
            this.tablePanel1.TabIndex = 0;
            // 
            // LQuestion
            // 
            this.tablePanel1.SetColumn(this.LQuestion, 1);
            this.LQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LQuestion.Location = new System.Drawing.Point(115, 3);
            this.LQuestion.Name = "LQuestion";
            this.LQuestion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LQuestion.Properties.Appearance.Options.UseFont = true;
            this.LQuestion.Properties.Appearance.Options.UseTextOptions = true;
            this.LQuestion.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LQuestion.Properties.ReadOnly = true;
            this.tablePanel1.SetRow(this.LQuestion, 0);
            this.LQuestion.Size = new System.Drawing.Size(532, 96);
            this.LQuestion.TabIndex = 4;
            // 
            // tAnswer
            // 
            this.tablePanel1.SetColumn(this.tAnswer, 1);
            this.tAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAnswer.Location = new System.Drawing.Point(115, 105);
            this.tAnswer.Name = "tAnswer";
            this.tAnswer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAnswer.Properties.Appearance.Options.UseFont = true;
            this.tablePanel1.SetRow(this.tAnswer, 1);
            this.tAnswer.Size = new System.Drawing.Size(532, 492);
            this.tAnswer.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tablePanel1.SetColumn(this.labelControl3, 0);
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.Location = new System.Drawing.Point(15, 105);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(15, 3, 10, 3);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 1);
            this.labelControl3.Size = new System.Drawing.Size(87, 492);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "答案";
            // 
            // LOrderNo
            // 
            this.LOrderNo.Appearance.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LOrderNo.Appearance.Options.UseFont = true;
            this.LOrderNo.Appearance.Options.UseTextOptions = true;
            this.LOrderNo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.LOrderNo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tablePanel1.SetColumn(this.LOrderNo, 0);
            this.LOrderNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LOrderNo.Location = new System.Drawing.Point(15, 3);
            this.LOrderNo.Margin = new System.Windows.Forms.Padding(15, 3, 10, 3);
            this.LOrderNo.Name = "LOrderNo";
            this.tablePanel1.SetRow(this.LOrderNo, 0);
            this.LOrderNo.Size = new System.Drawing.Size(87, 96);
            this.LOrderNo.TabIndex = 0;
            this.LOrderNo.Text = "填空题 10";
            // 
            // FillBlankPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "FillBlankPanel";
            this.Size = new System.Drawing.Size(650, 600);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LQuestion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAnswer.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        public DevExpress.XtraEditors.LabelControl LOrderNo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit tAnswer;
        private DevExpress.XtraEditors.MemoEdit LQuestion;
    }
}
