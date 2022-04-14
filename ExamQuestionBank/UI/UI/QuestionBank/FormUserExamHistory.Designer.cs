namespace CustomerUI.UI.QuestionBank
{
    partial class FormUserExamHistory
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
            this.components = new System.ComponentModel.Container();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.source = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUSER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_EXAM_GUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQUESTION_ORDER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQUESTION_GUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQUESTION_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQUESTION_CONTENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colANSWER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSCORE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_ANSWER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_SCORE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colANSWER_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.lTotal = new DevExpress.XtraEditors.LabelControl();
            this.lEassay = new DevExpress.XtraEditors.LabelControl();
            this.lFIll = new DevExpress.XtraEditors.LabelControl();
            this.lMulti = new DevExpress.XtraEditors.LabelControl();
            this.lWrite = new DevExpress.XtraEditors.LabelControl();
            this.lReader = new DevExpress.XtraEditors.LabelControl();
            this.lJudge = new DevExpress.XtraEditors.LabelControl();
            this.lSingle = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.l13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnPanel = new CustomerControl.ButtonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.source)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel1.Controls.Add(this.gridControl1);
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Controls.Add(this.btnPanel);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 150F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Size = new System.Drawing.Size(794, 594);
            this.tablePanel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.tablePanel1.SetColumn(this.gridControl1, 0);
            this.gridControl1.DataSource = this.source;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 193);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.tablePanel1.SetRow(this.gridControl1, 2);
            this.gridControl1.Size = new System.Drawing.Size(788, 398);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // source
            // 
            this.source.DataSource = typeof(CustomerUI.Model.QuestionBankModel.UserExamHistory);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUSER_ID,
            this.colUSER_NAME,
            this.colUSER_EXAM_GUID,
            this.colQUESTION_ORDER,
            this.colQUESTION_GUID,
            this.colQUESTION_TYPE,
            this.colQUESTION_CONTENT,
            this.colANSWER,
            this.colSCORE,
            this.colUSER_ANSWER,
            this.colUSER_SCORE,
            this.colANSWER_STATUS,
            this.colID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 30;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colUSER_ID
            // 
            this.colUSER_ID.FieldName = "USER_ID";
            this.colUSER_ID.Name = "colUSER_ID";
            this.colUSER_ID.Visible = true;
            this.colUSER_ID.VisibleIndex = 0;
            // 
            // colUSER_NAME
            // 
            this.colUSER_NAME.Caption = "用户名";
            this.colUSER_NAME.FieldName = "USER_NAME";
            this.colUSER_NAME.Name = "colUSER_NAME";
            // 
            // colUSER_EXAM_GUID
            // 
            this.colUSER_EXAM_GUID.Caption = "考试ID";
            this.colUSER_EXAM_GUID.FieldName = "USER_EXAM_GUID";
            this.colUSER_EXAM_GUID.Name = "colUSER_EXAM_GUID";
            this.colUSER_EXAM_GUID.Visible = true;
            this.colUSER_EXAM_GUID.VisibleIndex = 1;
            // 
            // colQUESTION_ORDER
            // 
            this.colQUESTION_ORDER.Caption = "试题序号";
            this.colQUESTION_ORDER.FieldName = "QUESTION_ORDER";
            this.colQUESTION_ORDER.Name = "colQUESTION_ORDER";
            this.colQUESTION_ORDER.Visible = true;
            this.colQUESTION_ORDER.VisibleIndex = 2;
            // 
            // colQUESTION_GUID
            // 
            this.colQUESTION_GUID.FieldName = "QUESTION_GUID";
            this.colQUESTION_GUID.Name = "colQUESTION_GUID";
            // 
            // colQUESTION_TYPE
            // 
            this.colQUESTION_TYPE.Caption = "试题类型";
            this.colQUESTION_TYPE.FieldName = "QUESTION_TYPE";
            this.colQUESTION_TYPE.Name = "colQUESTION_TYPE";
            this.colQUESTION_TYPE.Visible = true;
            this.colQUESTION_TYPE.VisibleIndex = 3;
            // 
            // colQUESTION_CONTENT
            // 
            this.colQUESTION_CONTENT.AppearanceCell.Options.UseTextOptions = true;
            this.colQUESTION_CONTENT.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colQUESTION_CONTENT.Caption = "试题内容";
            this.colQUESTION_CONTENT.FieldName = "QUESTION_CONTENT";
            this.colQUESTION_CONTENT.Name = "colQUESTION_CONTENT";
            this.colQUESTION_CONTENT.Visible = true;
            this.colQUESTION_CONTENT.VisibleIndex = 4;
            // 
            // colANSWER
            // 
            this.colANSWER.Caption = "答案";
            this.colANSWER.FieldName = "ANSWER";
            this.colANSWER.Name = "colANSWER";
            this.colANSWER.Visible = true;
            this.colANSWER.VisibleIndex = 5;
            // 
            // colSCORE
            // 
            this.colSCORE.Caption = "试题分数";
            this.colSCORE.FieldName = "SCORE";
            this.colSCORE.Name = "colSCORE";
            this.colSCORE.Visible = true;
            this.colSCORE.VisibleIndex = 6;
            // 
            // colUSER_ANSWER
            // 
            this.colUSER_ANSWER.AppearanceCell.Options.UseTextOptions = true;
            this.colUSER_ANSWER.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colUSER_ANSWER.Caption = "用户答案";
            this.colUSER_ANSWER.FieldName = "USER_ANSWER";
            this.colUSER_ANSWER.Name = "colUSER_ANSWER";
            this.colUSER_ANSWER.Visible = true;
            this.colUSER_ANSWER.VisibleIndex = 7;
            // 
            // colUSER_SCORE
            // 
            this.colUSER_SCORE.Caption = "用户得分";
            this.colUSER_SCORE.FieldName = "USER_SCORE";
            this.colUSER_SCORE.Name = "colUSER_SCORE";
            this.colUSER_SCORE.Visible = true;
            this.colUSER_SCORE.VisibleIndex = 8;
            // 
            // colANSWER_STATUS
            // 
            this.colANSWER_STATUS.Caption = "用户答题状态";
            this.colANSWER_STATUS.FieldName = "ANSWER_STATUS";
            this.colANSWER_STATUS.Name = "colANSWER_STATUS";
            this.colANSWER_STATUS.Visible = true;
            this.colANSWER_STATUS.VisibleIndex = 9;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 0);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel2.Controls.Add(this.lTotal);
            this.tablePanel2.Controls.Add(this.lEassay);
            this.tablePanel2.Controls.Add(this.lFIll);
            this.tablePanel2.Controls.Add(this.lMulti);
            this.tablePanel2.Controls.Add(this.lWrite);
            this.tablePanel2.Controls.Add(this.lReader);
            this.tablePanel2.Controls.Add(this.lJudge);
            this.tablePanel2.Controls.Add(this.lSingle);
            this.tablePanel2.Controls.Add(this.labelControl8);
            this.tablePanel2.Controls.Add(this.labelControl7);
            this.tablePanel2.Controls.Add(this.labelControl6);
            this.tablePanel2.Controls.Add(this.l13);
            this.tablePanel2.Controls.Add(this.labelControl4);
            this.tablePanel2.Controls.Add(this.labelControl3);
            this.tablePanel2.Controls.Add(this.labelControl2);
            this.tablePanel2.Controls.Add(this.labelControl1);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(0, 40);
            this.tablePanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 1);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(794, 150);
            this.tablePanel2.TabIndex = 1;
            // 
            // lTotal
            // 
            this.tablePanel2.SetColumn(this.lTotal, 3);
            this.lTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTotal.Location = new System.Drawing.Point(599, 117);
            this.lTotal.Name = "lTotal";
            this.tablePanel2.SetRow(this.lTotal, 3);
            this.lTotal.Size = new System.Drawing.Size(193, 30);
            this.lTotal.TabIndex = 15;
            this.lTotal.Text = "0";
            // 
            // lEassay
            // 
            this.tablePanel2.SetColumn(this.lEassay, 3);
            this.lEassay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lEassay.Location = new System.Drawing.Point(599, 79);
            this.lEassay.Name = "lEassay";
            this.tablePanel2.SetRow(this.lEassay, 2);
            this.lEassay.Size = new System.Drawing.Size(193, 32);
            this.lEassay.TabIndex = 14;
            this.lEassay.Text = "0";
            // 
            // lFIll
            // 
            this.tablePanel2.SetColumn(this.lFIll, 3);
            this.lFIll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lFIll.Location = new System.Drawing.Point(599, 41);
            this.lFIll.Name = "lFIll";
            this.tablePanel2.SetRow(this.lFIll, 1);
            this.lFIll.Size = new System.Drawing.Size(193, 32);
            this.lFIll.TabIndex = 13;
            this.lFIll.Text = "0";
            // 
            // lMulti
            // 
            this.tablePanel2.SetColumn(this.lMulti, 3);
            this.lMulti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lMulti.Location = new System.Drawing.Point(599, 3);
            this.lMulti.Name = "lMulti";
            this.tablePanel2.SetRow(this.lMulti, 0);
            this.lMulti.Size = new System.Drawing.Size(193, 32);
            this.lMulti.TabIndex = 12;
            this.lMulti.Text = "0";
            // 
            // lWrite
            // 
            this.tablePanel2.SetColumn(this.lWrite, 1);
            this.lWrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lWrite.Location = new System.Drawing.Point(202, 117);
            this.lWrite.Name = "lWrite";
            this.tablePanel2.SetRow(this.lWrite, 3);
            this.lWrite.Size = new System.Drawing.Size(193, 30);
            this.lWrite.TabIndex = 11;
            this.lWrite.Text = "0";
            // 
            // lReader
            // 
            this.tablePanel2.SetColumn(this.lReader, 1);
            this.lReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lReader.Location = new System.Drawing.Point(202, 79);
            this.lReader.Name = "lReader";
            this.tablePanel2.SetRow(this.lReader, 2);
            this.lReader.Size = new System.Drawing.Size(193, 32);
            this.lReader.TabIndex = 10;
            this.lReader.Text = "0";
            // 
            // lJudge
            // 
            this.tablePanel2.SetColumn(this.lJudge, 1);
            this.lJudge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lJudge.Location = new System.Drawing.Point(202, 41);
            this.lJudge.Name = "lJudge";
            this.tablePanel2.SetRow(this.lJudge, 1);
            this.lJudge.Size = new System.Drawing.Size(193, 32);
            this.lJudge.TabIndex = 9;
            this.lJudge.Text = "0";
            // 
            // lSingle
            // 
            this.tablePanel2.SetColumn(this.lSingle, 1);
            this.lSingle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lSingle.Location = new System.Drawing.Point(202, 3);
            this.lSingle.Name = "lSingle";
            this.tablePanel2.SetRow(this.lSingle, 0);
            this.lSingle.Size = new System.Drawing.Size(193, 32);
            this.lSingle.TabIndex = 8;
            this.lSingle.Text = "0";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tablePanel2.SetColumn(this.labelControl8, 2);
            this.labelControl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl8.Location = new System.Drawing.Point(400, 117);
            this.labelControl8.Name = "labelControl8";
            this.tablePanel2.SetRow(this.labelControl8, 3);
            this.labelControl8.Size = new System.Drawing.Size(193, 30);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "总分数";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tablePanel2.SetColumn(this.labelControl7, 2);
            this.labelControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl7.Location = new System.Drawing.Point(400, 79);
            this.labelControl7.Name = "labelControl7";
            this.tablePanel2.SetRow(this.labelControl7, 2);
            this.labelControl7.Size = new System.Drawing.Size(193, 32);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "问答题分数";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tablePanel2.SetColumn(this.labelControl6, 2);
            this.labelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl6.Location = new System.Drawing.Point(400, 41);
            this.labelControl6.Name = "labelControl6";
            this.tablePanel2.SetRow(this.labelControl6, 1);
            this.labelControl6.Size = new System.Drawing.Size(193, 32);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "填空题分数";
            // 
            // l13
            // 
            this.l13.Appearance.Options.UseTextOptions = true;
            this.l13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.l13.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tablePanel2.SetColumn(this.l13, 2);
            this.l13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l13.Location = new System.Drawing.Point(400, 3);
            this.l13.Name = "l13";
            this.tablePanel2.SetRow(this.l13, 0);
            this.l13.Size = new System.Drawing.Size(193, 32);
            this.l13.TabIndex = 4;
            this.l13.Text = "多选题分数";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tablePanel2.SetColumn(this.labelControl4, 0);
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl4.Location = new System.Drawing.Point(3, 117);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel2.SetRow(this.labelControl4, 3);
            this.labelControl4.Size = new System.Drawing.Size(193, 30);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "写作题分数";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tablePanel2.SetColumn(this.labelControl3, 0);
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.Location = new System.Drawing.Point(3, 79);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel2.SetRow(this.labelControl3, 2);
            this.labelControl3.Size = new System.Drawing.Size(193, 32);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "阅读理解题分数";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tablePanel2.SetColumn(this.labelControl2, 0);
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(3, 41);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel2.SetRow(this.labelControl2, 1);
            this.labelControl2.Size = new System.Drawing.Size(193, 32);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "判断题分数";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tablePanel2.SetColumn(this.labelControl1, 0);
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel2.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(193, 32);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "单选题分数";
            // 
            // btnPanel
            // 
            this.tablePanel1.SetColumn(this.btnPanel, 0);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPanel.Location = new System.Drawing.Point(3, 3);
            this.btnPanel.Name = "btnPanel";
            this.tablePanel1.SetRow(this.btnPanel, 0);
            this.btnPanel.Size = new System.Drawing.Size(788, 34);
            this.btnPanel.TabIndex = 0;
            // 
            // FormUserExamHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 594);
            this.Controls.Add(this.tablePanel1);
            this.Name = "FormUserExamHistory";
            this.Text = "用户试卷历史浏览";
            this.Load += new System.EventHandler(this.FormUserExamHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.source)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.tablePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private CustomerControl.ButtonPanel btnPanel;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.LabelControl lTotal;
        private DevExpress.XtraEditors.LabelControl lEassay;
        private DevExpress.XtraEditors.LabelControl lFIll;
        private DevExpress.XtraEditors.LabelControl lMulti;
        private DevExpress.XtraEditors.LabelControl lWrite;
        private DevExpress.XtraEditors.LabelControl lReader;
        private DevExpress.XtraEditors.LabelControl lJudge;
        private DevExpress.XtraEditors.LabelControl lSingle;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl l13;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource source;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_EXAM_GUID;
        private DevExpress.XtraGrid.Columns.GridColumn colQUESTION_ORDER;
        private DevExpress.XtraGrid.Columns.GridColumn colQUESTION_GUID;
        private DevExpress.XtraGrid.Columns.GridColumn colQUESTION_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colQUESTION_CONTENT;
        private DevExpress.XtraGrid.Columns.GridColumn colANSWER;
        private DevExpress.XtraGrid.Columns.GridColumn colSCORE;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_ANSWER;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_SCORE;
        private DevExpress.XtraGrid.Columns.GridColumn colANSWER_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
    }
}