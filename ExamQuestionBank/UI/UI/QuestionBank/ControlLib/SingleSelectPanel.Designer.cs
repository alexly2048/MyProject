namespace CustomerUI.UI.QuestionBank.ControlLib
{
    partial class SingleSelectPanel
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
            this.LOrderNo = new DevExpress.XtraEditors.LabelControl();
            this.checkA = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.LA = new DevExpress.XtraEditors.LabelControl();
            this.LB = new DevExpress.XtraEditors.LabelControl();
            this.LC = new DevExpress.XtraEditors.LabelControl();
            this.LD = new DevExpress.XtraEditors.LabelControl();
            this.checkB = new DevExpress.XtraEditors.CheckEdit();
            this.checkC = new DevExpress.XtraEditors.CheckEdit();
            this.checkD = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LQuestion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel1.Appearance.Options.UseBackColor = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel1.Controls.Add(this.LQuestion);
            this.tablePanel1.Controls.Add(this.LOrderNo);
            this.tablePanel1.Controls.Add(this.checkA);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.labelControl4);
            this.tablePanel1.Controls.Add(this.labelControl5);
            this.tablePanel1.Controls.Add(this.LA);
            this.tablePanel1.Controls.Add(this.LB);
            this.tablePanel1.Controls.Add(this.LC);
            this.tablePanel1.Controls.Add(this.LD);
            this.tablePanel1.Controls.Add(this.checkB);
            this.tablePanel1.Controls.Add(this.checkC);
            this.tablePanel1.Controls.Add(this.checkD);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(724, 600);
            this.tablePanel1.TabIndex = 0;
            // 
            // LQuestion
            // 
            this.tablePanel1.SetColumn(this.LQuestion, 2);
            this.LQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LQuestion.Location = new System.Drawing.Point(144, 3);
            this.LQuestion.Name = "LQuestion";
            this.LQuestion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LQuestion.Properties.Appearance.Options.UseFont = true;
            this.LQuestion.Properties.Appearance.Options.UseTextOptions = true;
            this.LQuestion.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LQuestion.Properties.ReadOnly = true;
            this.tablePanel1.SetRow(this.LQuestion, 0);
            this.LQuestion.Size = new System.Drawing.Size(577, 189);
            this.LQuestion.TabIndex = 6;
            // 
            // LOrderNo
            // 
            this.LOrderNo.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOrderNo.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.LOrderNo, 0);
            this.LOrderNo.Location = new System.Drawing.Point(3, 86);
            this.LOrderNo.Name = "LOrderNo";
            this.tablePanel1.SetRow(this.LOrderNo, 0);
            this.LOrderNo.Size = new System.Drawing.Size(101, 23);
            this.LOrderNo.TabIndex = 5;
            this.LOrderNo.Text = "单选题 序号";
            // 
            // checkA
            // 
            this.tablePanel1.SetColumn(this.checkA, 0);
            this.checkA.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkA.Location = new System.Drawing.Point(74, 195);
            this.checkA.Margin = new System.Windows.Forms.Padding(29, 0, 10, 0);
            this.checkA.Name = "checkA";
            this.checkA.Properties.Caption = "";
            this.tablePanel1.SetRow(this.checkA, 1);
            this.checkA.Size = new System.Drawing.Size(23, 101);
            this.checkA.TabIndex = 4;
            this.checkA.CheckedChanged += new System.EventHandler(this.checkA_CheckedChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl2.AppearanceHovered.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.AppearanceHovered.Options.UseFont = true;
            this.labelControl2.AppearancePressed.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl2.AppearancePressed.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.labelControl2, 1);
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(119, 198);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 1);
            this.labelControl2.Size = new System.Drawing.Size(10, 95);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "A";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tablePanel1.SetColumn(this.labelControl3, 1);
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.Location = new System.Drawing.Point(119, 299);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 2);
            this.labelControl3.Size = new System.Drawing.Size(10, 95);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "B";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tablePanel1.SetColumn(this.labelControl4, 1);
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl4.Location = new System.Drawing.Point(119, 400);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel1.SetRow(this.labelControl4, 3);
            this.labelControl4.Size = new System.Drawing.Size(10, 95);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "C";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tablePanel1.SetColumn(this.labelControl5, 1);
            this.labelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl5.Location = new System.Drawing.Point(119, 501);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.labelControl5.Name = "labelControl5";
            this.tablePanel1.SetRow(this.labelControl5, 4);
            this.labelControl5.Size = new System.Drawing.Size(10, 96);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "D";
            // 
            // LA
            // 
            this.LA.Appearance.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LA.Appearance.Options.UseFont = true;
            this.LA.Appearance.Options.UseTextOptions = true;
            this.LA.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.LA.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.LA.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LA.AppearancePressed.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LA.AppearancePressed.Options.UseFont = true;
            this.LA.AppearancePressed.Options.UseTextOptions = true;
            this.LA.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.LA.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LA.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LA.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.tablePanel1.SetColumn(this.LA, 2);
            this.LA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LA.Location = new System.Drawing.Point(144, 198);
            this.LA.Name = "LA";
            this.tablePanel1.SetRow(this.LA, 1);
            this.LA.Size = new System.Drawing.Size(577, 95);
            this.LA.TabIndex = 3;
            this.LA.Text = "labelControl6";
            // 
            // LB
            // 
            this.LB.Appearance.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB.Appearance.Options.UseFont = true;
            this.LB.Appearance.Options.UseTextOptions = true;
            this.LB.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.LB.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.LB.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LB.AppearancePressed.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB.AppearancePressed.Options.UseFont = true;
            this.LB.AppearancePressed.Options.UseTextOptions = true;
            this.LB.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.LB.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LB.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LB.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.tablePanel1.SetColumn(this.LB, 2);
            this.LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB.Location = new System.Drawing.Point(144, 299);
            this.LB.Name = "LB";
            this.tablePanel1.SetRow(this.LB, 2);
            this.LB.Size = new System.Drawing.Size(577, 95);
            this.LB.TabIndex = 3;
            this.LB.Text = "labelControl6";
            // 
            // LC
            // 
            this.LC.Appearance.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LC.Appearance.Options.UseFont = true;
            this.LC.Appearance.Options.UseTextOptions = true;
            this.LC.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.LC.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.LC.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LC.AppearancePressed.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LC.AppearancePressed.Options.UseFont = true;
            this.LC.AppearancePressed.Options.UseTextOptions = true;
            this.LC.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.LC.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LC.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LC.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.tablePanel1.SetColumn(this.LC, 2);
            this.LC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LC.Location = new System.Drawing.Point(144, 400);
            this.LC.Name = "LC";
            this.tablePanel1.SetRow(this.LC, 3);
            this.LC.Size = new System.Drawing.Size(577, 95);
            this.LC.TabIndex = 3;
            this.LC.Text = "labelControl6";
            // 
            // LD
            // 
            this.LD.Appearance.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LD.Appearance.Options.UseFont = true;
            this.LD.Appearance.Options.UseTextOptions = true;
            this.LD.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.LD.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.LD.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LD.AppearancePressed.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LD.AppearancePressed.Options.UseFont = true;
            this.LD.AppearancePressed.Options.UseTextOptions = true;
            this.LD.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.LD.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LD.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LD.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.tablePanel1.SetColumn(this.LD, 2);
            this.LD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LD.Location = new System.Drawing.Point(144, 501);
            this.LD.Name = "LD";
            this.tablePanel1.SetRow(this.LD, 4);
            this.LD.Size = new System.Drawing.Size(577, 96);
            this.LD.TabIndex = 3;
            this.LD.Text = "labelControl6";
            // 
            // checkB
            // 
            this.tablePanel1.SetColumn(this.checkB, 0);
            this.checkB.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkB.Location = new System.Drawing.Point(74, 296);
            this.checkB.Margin = new System.Windows.Forms.Padding(29, 0, 10, 0);
            this.checkB.Name = "checkB";
            this.checkB.Properties.Caption = "";
            this.tablePanel1.SetRow(this.checkB, 2);
            this.checkB.Size = new System.Drawing.Size(23, 101);
            this.checkB.TabIndex = 4;
            this.checkB.CheckedChanged += new System.EventHandler(this.checkB_CheckedChanged);
            // 
            // checkC
            // 
            this.tablePanel1.SetColumn(this.checkC, 0);
            this.checkC.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkC.Location = new System.Drawing.Point(74, 397);
            this.checkC.Margin = new System.Windows.Forms.Padding(29, 0, 10, 0);
            this.checkC.Name = "checkC";
            this.checkC.Properties.Caption = "";
            this.tablePanel1.SetRow(this.checkC, 3);
            this.checkC.Size = new System.Drawing.Size(23, 101);
            this.checkC.TabIndex = 4;
            this.checkC.CheckedChanged += new System.EventHandler(this.checkC_CheckedChanged);
            // 
            // checkD
            // 
            this.tablePanel1.SetColumn(this.checkD, 0);
            this.checkD.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkD.Location = new System.Drawing.Point(74, 498);
            this.checkD.Margin = new System.Windows.Forms.Padding(29, 0, 10, 0);
            this.checkD.Name = "checkD";
            this.checkD.Properties.Caption = "";
            this.tablePanel1.SetRow(this.checkD, 4);
            this.checkD.Size = new System.Drawing.Size(23, 102);
            this.checkD.TabIndex = 4;
            this.checkD.CheckedChanged += new System.EventHandler(this.checkD_CheckedChanged);
            // 
            // SingleSelectPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "SingleSelectPanel";
            this.Size = new System.Drawing.Size(724, 600);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LQuestion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkD.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.LabelControl LA;
        public DevExpress.XtraEditors.LabelControl LB;
        public DevExpress.XtraEditors.LabelControl LC;
        public DevExpress.XtraEditors.LabelControl LD;
        public DevExpress.XtraEditors.CheckEdit checkA;
        public DevExpress.XtraEditors.CheckEdit checkB;
        public DevExpress.XtraEditors.CheckEdit checkC;
        public DevExpress.XtraEditors.CheckEdit checkD;
        private DevExpress.XtraEditors.LabelControl LOrderNo;
        private DevExpress.XtraEditors.MemoEdit LQuestion;
    }
}
