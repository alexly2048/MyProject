namespace CustomerUI.UI.QuestionBank
{
    partial class FormManageQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageQuestion));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.lookupType = new DevExpress.XtraEditors.LookUpEdit();
            this.tKeyword = new DevExpress.XtraEditors.TextEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdsoure = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSUBJECT_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUBJECT_GUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOURSE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQUESTION_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQUESTION_CONTENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSCORE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colANSWER_CONTENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIMAGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSELECT_ITEMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQUESTION_GUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUBJECT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQUESTION_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colANSWER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOURSE_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRADE_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRADE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIFFICULTY_LEVEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIS_ENABLE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKeyword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsoure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Controls.Add(this.gridControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1028, 670);
            this.tablePanel1.TabIndex = 0;
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 0);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F)});
            this.tablePanel2.Controls.Add(this.lookupType);
            this.tablePanel2.Controls.Add(this.tKeyword);
            this.tablePanel2.Controls.Add(this.btnDelete);
            this.tablePanel2.Controls.Add(this.btnUpdate);
            this.tablePanel2.Controls.Add(this.btnQuery);
            this.tablePanel2.Controls.Add(this.labelControl1);
            this.tablePanel2.Controls.Add(this.labelControl2);
            this.tablePanel2.Controls.Add(this.btnAdd);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(0, 0);
            this.tablePanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 0);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(1028, 40);
            this.tablePanel2.TabIndex = 2;
            // 
            // lookupType
            // 
            this.tablePanel2.SetColumn(this.lookupType, 3);
            this.lookupType.Location = new System.Drawing.Point(373, 10);
            this.lookupType.Name = "lookupType";
            this.lookupType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel2.SetRow(this.lookupType, 0);
            this.lookupType.Size = new System.Drawing.Size(208, 20);
            this.lookupType.TabIndex = 5;
            // 
            // tKeyword
            // 
            this.tablePanel2.SetColumn(this.tKeyword, 1);
            this.tKeyword.Location = new System.Drawing.Point(75, 10);
            this.tKeyword.Name = "tKeyword";
            this.tablePanel2.SetRow(this.tKeyword, 0);
            this.tKeyword.Size = new System.Drawing.Size(208, 20);
            this.tKeyword.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.tablePanel2.SetColumn(this.btnDelete, 7);
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(929, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.btnDelete.Name = "btnDelete";
            this.tablePanel2.SetRow(this.btnDelete, 0);
            this.btnDelete.Size = new System.Drawing.Size(87, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.tablePanel2.SetColumn(this.btnUpdate, 6);
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(818, 6);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.tablePanel2.SetRow(this.btnUpdate, 0);
            this.btnUpdate.Size = new System.Drawing.Size(87, 28);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnQuery
            // 
            this.tablePanel2.SetColumn(this.btnQuery, 4);
            this.btnQuery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.ImageOptions.Image")));
            this.btnQuery.Location = new System.Drawing.Point(596, 6);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.btnQuery.Name = "btnQuery";
            this.tablePanel2.SetRow(this.btnQuery, 0);
            this.btnQuery.Size = new System.Drawing.Size(87, 28);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // labelControl1
            // 
            this.tablePanel2.SetColumn(this.labelControl1, 0);
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.ImageOptions.Image")));
            this.labelControl1.Location = new System.Drawing.Point(12, 10);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel2.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(57, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "关键字";
            // 
            // labelControl2
            // 
            this.tablePanel2.SetColumn(this.labelControl2, 2);
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl2.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl2.ImageOptions.Image")));
            this.labelControl2.Location = new System.Drawing.Point(298, 10);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel2.SetRow(this.labelControl2, 0);
            this.labelControl2.Size = new System.Drawing.Size(69, 20);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "题目类型";
            // 
            // btnAdd
            // 
            this.tablePanel2.SetColumn(this.btnAdd, 5);
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(707, 6);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.btnAdd.Name = "btnAdd";
            this.tablePanel2.SetRow(this.btnAdd, 0);
            this.btnAdd.Size = new System.Drawing.Size(87, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gridControl1
            // 
            this.tablePanel1.SetColumn(this.gridControl1, 0);
            this.gridControl1.DataSource = this.bdsoure;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.tablePanel1.SetRow(this.gridControl1, 1);
            this.gridControl1.Size = new System.Drawing.Size(1022, 624);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsoure
            // 
            this.bdsoure.DataSource = typeof(CustomerUI.Model.QuestionBankModel.DisplayQuestionView);
            // 
            // gridView1
            // 
            this.gridView1.ActiveFilterEnabled = false;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSUBJECT_GUID,
            this.colCOURSE_NAME,
            this.colSUBJECT_TYPE,
            this.colQUESTION_TYPE,
            this.colQUESTION_CONTENT,
            this.colSCORE,
            this.colANSWER_CONTENT,
            this.colDESCRIPTION,
            this.colIMAGE,
            this.colSELECT_ITEMS,
            this.colQUESTION_GUID,
            this.colSUBJECT_ID,
            this.colQUESTION_ID,
            this.colDESCRIPTION_ID,
            this.colANSWER_ID,
            this.colCOURSE_CODE,
            this.colGRADE_CODE,
            this.colGRADE_NAME,
            this.colDIFFICULTY_LEVEL,
            this.colIS_ENABLE});
            this.gridView1.DetailHeight = 408;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 35;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView1.OptionsFilter.AllowFilterEditor = false;
            this.gridView1.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.gridView1.OptionsFilter.AllowMRUFilterList = false;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colSUBJECT_TYPE
            // 
            this.colSUBJECT_TYPE.Caption = "题目类型";
            this.colSUBJECT_TYPE.FieldName = "SUBJECT_TYPE";
            this.colSUBJECT_TYPE.Name = "colSUBJECT_TYPE";
            this.colSUBJECT_TYPE.Visible = true;
            this.colSUBJECT_TYPE.VisibleIndex = 1;
            // 
            // colSUBJECT_GUID
            // 
            this.colSUBJECT_GUID.FieldName = "SUBJECT_GUID";
            this.colSUBJECT_GUID.Name = "colSUBJECT_GUID";
            // 
            // colCOURSE_NAME
            // 
            this.colCOURSE_NAME.Caption = "科目";
            this.colCOURSE_NAME.FieldName = "COURSE_NAME";
            this.colCOURSE_NAME.Name = "colCOURSE_NAME";
            this.colCOURSE_NAME.Visible = true;
            this.colCOURSE_NAME.VisibleIndex = 0;
            // 
            // colQUESTION_TYPE
            // 
            this.colQUESTION_TYPE.Caption = "问题类型";
            this.colQUESTION_TYPE.FieldName = "QUESTION_TYPE";
            this.colQUESTION_TYPE.Name = "colQUESTION_TYPE";
            this.colQUESTION_TYPE.Visible = true;
            this.colQUESTION_TYPE.VisibleIndex = 2;
            // 
            // colQUESTION_CONTENT
            // 
            this.colQUESTION_CONTENT.Caption = "问题";
            this.colQUESTION_CONTENT.FieldName = "QUESTION_CONTENT";
            this.colQUESTION_CONTENT.Name = "colQUESTION_CONTENT";
            this.colQUESTION_CONTENT.Visible = true;
            this.colQUESTION_CONTENT.VisibleIndex = 3;
            // 
            // colSCORE
            // 
            this.colSCORE.Caption = "分数";
            this.colSCORE.FieldName = "SCORE";
            this.colSCORE.Name = "colSCORE";
            this.colSCORE.Visible = true;
            this.colSCORE.VisibleIndex = 4;
            // 
            // colANSWER_CONTENT
            // 
            this.colANSWER_CONTENT.Caption = "答案";
            this.colANSWER_CONTENT.FieldName = "ANSWER_CONTENT";
            this.colANSWER_CONTENT.Name = "colANSWER_CONTENT";
            this.colANSWER_CONTENT.Visible = true;
            this.colANSWER_CONTENT.VisibleIndex = 6;
            // 
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.Caption = "背景描述";
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            this.colDESCRIPTION.Visible = true;
            this.colDESCRIPTION.VisibleIndex = 5;
            // 
            // colIMAGE
            // 
            this.colIMAGE.Caption = "图片";
            this.colIMAGE.FieldName = "IMAGE";
            this.colIMAGE.Name = "colIMAGE";
            this.colIMAGE.Visible = true;
            this.colIMAGE.VisibleIndex = 7;
            // 
            // colSELECT_ITEMS
            // 
            this.colSELECT_ITEMS.Caption = "选项";
            this.colSELECT_ITEMS.FieldName = "SELECT_ITEMS";
            this.colSELECT_ITEMS.Name = "colSELECT_ITEMS";
            this.colSELECT_ITEMS.Visible = true;
            this.colSELECT_ITEMS.VisibleIndex = 8;
            // 
            // colQUESTION_GUID
            // 
            this.colQUESTION_GUID.FieldName = "QUESTION_GUID";
            this.colQUESTION_GUID.Name = "colQUESTION_GUID";
            // 
            // colSUBJECT_ID
            // 
            this.colSUBJECT_ID.FieldName = "SUBJECT_ID";
            this.colSUBJECT_ID.Name = "colSUBJECT_ID";
            // 
            // colQUESTION_ID
            // 
            this.colQUESTION_ID.FieldName = "QUESTION_ID";
            this.colQUESTION_ID.Name = "colQUESTION_ID";
            // 
            // colDESCRIPTION_ID
            // 
            this.colDESCRIPTION_ID.FieldName = "DESCRIPTION_ID";
            this.colDESCRIPTION_ID.Name = "colDESCRIPTION_ID";
            // 
            // colANSWER_ID
            // 
            this.colANSWER_ID.FieldName = "ANSWER_ID";
            this.colANSWER_ID.Name = "colANSWER_ID";
            // 
            // colCOURSE_CODE
            // 
            this.colCOURSE_CODE.Caption = "课程编号";
            this.colCOURSE_CODE.FieldName = "COURSE_CODE";
            this.colCOURSE_CODE.Name = "colCOURSE_CODE";
            this.colCOURSE_CODE.Visible = true;
            this.colCOURSE_CODE.VisibleIndex = 9;
            // 
            // colGRADE_CODE
            // 
            this.colGRADE_CODE.Caption = "年级编号";
            this.colGRADE_CODE.FieldName = "GRADE_CODE";
            this.colGRADE_CODE.Name = "colGRADE_CODE";
            this.colGRADE_CODE.Visible = true;
            this.colGRADE_CODE.VisibleIndex = 10;
            // 
            // colGRADE_NAME
            // 
            this.colGRADE_NAME.Caption = "年级名称";
            this.colGRADE_NAME.FieldName = "GRADE_NAME";
            this.colGRADE_NAME.Name = "colGRADE_NAME";
            this.colGRADE_NAME.Visible = true;
            this.colGRADE_NAME.VisibleIndex = 11;
            // 
            // colDIFFICULTY_LEVEL
            // 
            this.colDIFFICULTY_LEVEL.Caption = "难易级";
            this.colDIFFICULTY_LEVEL.FieldName = "DIFFICULTY_LEVEL";
            this.colDIFFICULTY_LEVEL.Name = "colDIFFICULTY_LEVEL";
            this.colDIFFICULTY_LEVEL.Visible = true;
            this.colDIFFICULTY_LEVEL.VisibleIndex = 12;
            // 
            // colIS_ENABLE
            // 
            this.colIS_ENABLE.Caption = "启用状态";
            this.colIS_ENABLE.FieldName = "IS_ENABLE";
            this.colIS_ENABLE.Name = "colIS_ENABLE";
            this.colIS_ENABLE.Visible = true;
            this.colIS_ENABLE.VisibleIndex = 13;
            // 
            // FormManageQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 670);
            this.Controls.Add(this.tablePanel1);
            this.Name = "FormManageQuestion";
            this.Text = "试卷题目管理";
            this.Load += new System.EventHandler(this.FormManageQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.tablePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKeyword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsoure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.LookUpEdit lookupType;
        private DevExpress.XtraEditors.TextEdit tKeyword;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.BindingSource bdsoure;
        private DevExpress.XtraGrid.Columns.GridColumn colSUBJECT_GUID;
        private DevExpress.XtraGrid.Columns.GridColumn colQUESTION_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colQUESTION_GUID;
        private DevExpress.XtraGrid.Columns.GridColumn colQUESTION_CONTENT;
        private DevExpress.XtraGrid.Columns.GridColumn colSCORE;
        private DevExpress.XtraGrid.Columns.GridColumn colSUBJECT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colQUESTION_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colANSWER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colANSWER_CONTENT;
        private DevExpress.XtraGrid.Columns.GridColumn colCOURSE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colIMAGE;
        private DevExpress.XtraGrid.Columns.GridColumn colSELECT_ITEMS;
        private DevExpress.XtraGrid.Columns.GridColumn colCOURSE_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colGRADE_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colGRADE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colDIFFICULTY_LEVEL;
        private DevExpress.XtraGrid.Columns.GridColumn colIS_ENABLE;
        private DevExpress.XtraGrid.Columns.GridColumn colSUBJECT_TYPE;
    }
}