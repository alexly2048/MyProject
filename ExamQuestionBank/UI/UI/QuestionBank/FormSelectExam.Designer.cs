namespace CustomerUI.UI.QuestionBank
{
    partial class FormSelectExam
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
            this.userExamSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRADE_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXAM_GUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRADE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOURSE_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOURSE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIS_COMPLETE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repIS_COMPLETE = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colCREATE_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPLETE_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPanel = new CustomerControl.ButtonPanel();
            this.colUSER_EXAM_GUID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userExamSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repIS_COMPLETE)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.gridControl1);
            this.tablePanel1.Controls.Add(this.btnPanel);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Size = new System.Drawing.Size(933, 525);
            this.tablePanel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.tablePanel1.SetColumn(this.gridControl1, 0);
            this.gridControl1.DataSource = this.userExamSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repIS_COMPLETE});
            this.tablePanel1.SetRow(this.gridControl1, 1);
            this.gridControl1.Size = new System.Drawing.Size(927, 479);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // userExamSource
            // 
            this.userExamSource.DataSource = typeof(CustomerUI.Model.QuestionBankModel.DisplayUserExam);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colUSER_EXAM_GUID,
            this.colUSER_ID,
            this.colUSER_NAME,
            this.colGRADE_CODE,
            this.colEXAM_GUID,
            this.colGRADE_NAME,
            this.colCOURSE_CODE,
            this.colCOURSE_NAME,
            this.colIS_COMPLETE,
            this.colCREATE_DATE,
            this.colCOMPLETE_DATE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 30;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colUSER_ID
            // 
            this.colUSER_ID.Caption = "用户编号";
            this.colUSER_ID.FieldName = "USER_ID";
            this.colUSER_ID.Name = "colUSER_ID";
            // 
            // colUSER_NAME
            // 
            this.colUSER_NAME.Caption = "用户名";
            this.colUSER_NAME.FieldName = "USER_NAME";
            this.colUSER_NAME.Name = "colUSER_NAME";
            // 
            // colGRADE_CODE
            // 
            this.colGRADE_CODE.FieldName = "GRADE_CODE";
            this.colGRADE_CODE.Name = "colGRADE_CODE";
            // 
            // colEXAM_GUID
            // 
            this.colEXAM_GUID.Caption = "考试编号";
            this.colEXAM_GUID.FieldName = "EXAM_GUID";
            this.colEXAM_GUID.Name = "colEXAM_GUID";
            this.colEXAM_GUID.Visible = true;
            this.colEXAM_GUID.VisibleIndex = 0;
            // 
            // colGRADE_NAME
            // 
            this.colGRADE_NAME.Caption = "年级名称";
            this.colGRADE_NAME.FieldName = "GRADE_NAME";
            this.colGRADE_NAME.Name = "colGRADE_NAME";
            this.colGRADE_NAME.Visible = true;
            this.colGRADE_NAME.VisibleIndex = 2;
            // 
            // colCOURSE_CODE
            // 
            this.colCOURSE_CODE.FieldName = "COURSE_CODE";
            this.colCOURSE_CODE.Name = "colCOURSE_CODE";
            // 
            // colCOURSE_NAME
            // 
            this.colCOURSE_NAME.Caption = "课程名称";
            this.colCOURSE_NAME.FieldName = "COURSE_NAME";
            this.colCOURSE_NAME.Name = "colCOURSE_NAME";
            this.colCOURSE_NAME.Visible = true;
            this.colCOURSE_NAME.VisibleIndex = 3;
            // 
            // colIS_COMPLETE
            // 
            this.colIS_COMPLETE.Caption = "考试状态";
            this.colIS_COMPLETE.ColumnEdit = this.repIS_COMPLETE;
            this.colIS_COMPLETE.FieldName = "IS_COMPLETE";
            this.colIS_COMPLETE.Name = "colIS_COMPLETE";
            this.colIS_COMPLETE.Visible = true;
            this.colIS_COMPLETE.VisibleIndex = 4;
            // 
            // repIS_COMPLETE
            // 
            this.repIS_COMPLETE.AutoHeight = false;
            this.repIS_COMPLETE.Name = "repIS_COMPLETE";
            // 
            // colCREATE_DATE
            // 
            this.colCREATE_DATE.Caption = "创建日期";
            this.colCREATE_DATE.FieldName = "CREATE_DATE";
            this.colCREATE_DATE.Name = "colCREATE_DATE";
            this.colCREATE_DATE.Visible = true;
            this.colCREATE_DATE.VisibleIndex = 5;
            // 
            // colCOMPLETE_DATE
            // 
            this.colCOMPLETE_DATE.Caption = "完成日期";
            this.colCOMPLETE_DATE.FieldName = "COMPLETE_DATE";
            this.colCOMPLETE_DATE.Name = "colCOMPLETE_DATE";
            this.colCOMPLETE_DATE.Visible = true;
            this.colCOMPLETE_DATE.VisibleIndex = 6;
            // 
            // btnPanel
            // 
            this.tablePanel1.SetColumn(this.btnPanel, 0);
            this.btnPanel.Location = new System.Drawing.Point(3, 3);
            this.btnPanel.Name = "btnPanel";
            this.tablePanel1.SetRow(this.btnPanel, 0);
            this.btnPanel.Size = new System.Drawing.Size(927, 34);
            this.btnPanel.TabIndex = 0;
            // 
            // colUSER_EXAM_GUID
            // 
            this.colUSER_EXAM_GUID.Caption = "用户考试编号";
            this.colUSER_EXAM_GUID.FieldName = "USER_EXAM_GUID";
            this.colUSER_EXAM_GUID.Name = "colUSER_EXAM_GUID";
            this.colUSER_EXAM_GUID.Visible = true;
            this.colUSER_EXAM_GUID.VisibleIndex = 1;
            // 
            // FormSelectExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 525);
            this.Controls.Add(this.tablePanel1);
            this.Name = "FormSelectExam";
            this.Text = "用户考试";
            this.Load += new System.EventHandler(this.FormUserExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userExamSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repIS_COMPLETE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private CustomerControl.ButtonPanel btnPanel;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource userExamSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colGRADE_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colGRADE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colCOURSE_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colCOURSE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colIS_COMPLETE;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMPLETE_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colEXAM_GUID;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repIS_COMPLETE;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_EXAM_GUID;
    }
}