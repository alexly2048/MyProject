namespace FileManagement.UI
{
    partial class FrmContract
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
            this.gridContract = new DevExpress.XtraGrid.GridControl();
            this.contractSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPROJECT_NUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROJECT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONTRACT_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONTRACT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAPPENDIX_FILE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPARENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.gridContract);
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(796, 450);
            this.tablePanel1.TabIndex = 0;
            // 
            // gridContract
            // 
            this.tablePanel1.SetColumn(this.gridContract, 0);
            this.gridContract.DataSource = this.contractSource;
            this.gridContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContract.Location = new System.Drawing.Point(3, 43);
            this.gridContract.MainView = this.gridView1;
            this.gridContract.Name = "gridContract";
            this.tablePanel1.SetRow(this.gridContract, 1);
            this.gridContract.Size = new System.Drawing.Size(790, 404);
            this.gridContract.TabIndex = 1;
            this.gridContract.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contractSource
            // 
            this.contractSource.DataSource = typeof(FileManagement.Model.ProjectContract);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPROJECT_NUMBER,
            this.colPROJECT_NAME,
            this.colCONTRACT_NO,
            this.colCONTRACT_NAME,
            this.colAPPENDIX_FILE,
            this.colREMARK,
            this.colID,
            this.colPARENT_ID});
            this.gridView1.GridControl = this.gridContract;
            this.gridView1.IndicatorWidth = 30;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colPROJECT_NUMBER
            // 
            this.colPROJECT_NUMBER.Caption = "工程编号";
            this.colPROJECT_NUMBER.FieldName = "PROJECT_NUMBER";
            this.colPROJECT_NUMBER.Name = "colPROJECT_NUMBER";
            this.colPROJECT_NUMBER.Visible = true;
            this.colPROJECT_NUMBER.VisibleIndex = 0;
            // 
            // colPROJECT_NAME
            // 
            this.colPROJECT_NAME.Caption = "工程名称";
            this.colPROJECT_NAME.FieldName = "PROJECT_NAME";
            this.colPROJECT_NAME.Name = "colPROJECT_NAME";
            this.colPROJECT_NAME.Visible = true;
            this.colPROJECT_NAME.VisibleIndex = 1;
            // 
            // colCONTRACT_NO
            // 
            this.colCONTRACT_NO.Caption = "合同编号";
            this.colCONTRACT_NO.FieldName = "CONTRACT_NO";
            this.colCONTRACT_NO.Name = "colCONTRACT_NO";
            this.colCONTRACT_NO.Visible = true;
            this.colCONTRACT_NO.VisibleIndex = 2;
            // 
            // colCONTRACT_NAME
            // 
            this.colCONTRACT_NAME.Caption = "合同名称";
            this.colCONTRACT_NAME.FieldName = "CONTRACT_NAME";
            this.colCONTRACT_NAME.Name = "colCONTRACT_NAME";
            this.colCONTRACT_NAME.Visible = true;
            this.colCONTRACT_NAME.VisibleIndex = 3;
            // 
            // colAPPENDIX_FILE
            // 
            this.colAPPENDIX_FILE.Caption = "附件";
            this.colAPPENDIX_FILE.FieldName = "APPENDIX_FILE";
            this.colAPPENDIX_FILE.Name = "colAPPENDIX_FILE";
            this.colAPPENDIX_FILE.Visible = true;
            this.colAPPENDIX_FILE.VisibleIndex = 5;
            // 
            // colREMARK
            // 
            this.colREMARK.Caption = "备注";
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 4;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colPARENT_ID
            // 
            this.colPARENT_ID.FieldName = "PARENT_ID";
            this.colPARENT_ID.Name = "colPARENT_ID";
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 0);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 55F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F)});
            this.tablePanel2.Controls.Add(this.btnDelete);
            this.tablePanel2.Controls.Add(this.btnUpdate);
            this.tablePanel2.Controls.Add(this.btnAdd);
            this.tablePanel2.Controls.Add(this.btnQuery);
            this.tablePanel2.Controls.Add(this.textEdit1);
            this.tablePanel2.Controls.Add(this.labelControl1);
            this.tablePanel2.Location = new System.Drawing.Point(3, 3);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 0);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(790, 34);
            this.tablePanel2.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.tablePanel2.SetColumn(this.btnDelete, 5);
            this.btnDelete.Location = new System.Drawing.Point(705, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnDelete.Name = "btnDelete";
            this.tablePanel2.SetRow(this.btnDelete, 0);
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.tablePanel2.SetColumn(this.btnUpdate, 4);
            this.btnUpdate.Location = new System.Drawing.Point(610, 5);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.tablePanel2.SetRow(this.btnUpdate, 0);
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.tablePanel2.SetColumn(this.btnAdd, 3);
            this.btnAdd.Location = new System.Drawing.Point(515, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnAdd.Name = "btnAdd";
            this.tablePanel2.SetRow(this.btnAdd, 0);
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnQuery
            // 
            this.tablePanel2.SetColumn(this.btnQuery, 2);
            this.btnQuery.Location = new System.Drawing.Point(420, 5);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnQuery.Name = "btnQuery";
            this.tablePanel2.SetRow(this.btnQuery, 0);
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // textEdit1
            // 
            this.tablePanel2.SetColumn(this.textEdit1, 1);
            this.textEdit1.Location = new System.Drawing.Point(79, 7);
            this.textEdit1.Name = "textEdit1";
            this.tablePanel2.SetRow(this.textEdit1, 0);
            this.textEdit1.Size = new System.Drawing.Size(328, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.tablePanel2.SetColumn(this.labelControl1, 0);
            this.labelControl1.Location = new System.Drawing.Point(20, 10);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel2.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "关键字";
            // 
            // FrmContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.tablePanel1);
            this.Name = "FrmContract";
            this.Text = "合同文件管理";
            this.Load += new System.EventHandler(this.FrmContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.tablePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraGrid.GridControl gridContract;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource contractSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPROJECT_NUMBER;
        private DevExpress.XtraGrid.Columns.GridColumn colPROJECT_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colCONTRACT_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colCONTRACT_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colPARENT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colAPPENDIX_FILE;
    }
}