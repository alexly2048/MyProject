namespace CustomerUI.UI.QuestionBank
{
    partial class FormExamBank
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
            this.bankSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCOURSE_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOURSE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRADE_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRADE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXAM_GUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUBJECT_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVERY_EASY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEASY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMMON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIFFICULTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVERY_DIFFICULTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPanel = new CustomerControl.ButtonPanel();
            this.colIS_ENABLE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel1.Controls.Add(this.gridControl1);
            this.tablePanel1.Controls.Add(this.btnPanel);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(730, 514);
            this.tablePanel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.tablePanel1.SetColumn(this.gridControl1, 0);
            this.gridControl1.DataSource = this.bankSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 49);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.tablePanel1.SetRow(this.gridControl1, 1);
            this.gridControl1.Size = new System.Drawing.Size(724, 462);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bankSource
            // 
            this.bankSource.DataSource = typeof(CustomerUI.Model.QuestionBankModel.DisplayExamBank);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOURSE_CODE,
            this.colCOURSE_NAME,
            this.colGRADE_CODE,
            this.colGRADE_NAME,
            this.colEXAM_GUID,
            this.colSUBJECT_TYPE,
            this.colVERY_EASY,
            this.colEASY,
            this.colCOMMON,
            this.colDIFFICULTY,
            this.colVERY_DIFFICULTY,
            this.colIS_ENABLE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 30;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCOURSE_CODE
            // 
            this.colCOURSE_CODE.Caption = "课程编号";
            this.colCOURSE_CODE.FieldName = "COURSE_CODE";
            this.colCOURSE_CODE.Name = "colCOURSE_CODE";
            this.colCOURSE_CODE.Visible = true;
            this.colCOURSE_CODE.VisibleIndex = 0;
            // 
            // colCOURSE_NAME
            // 
            this.colCOURSE_NAME.Caption = "课程名称";
            this.colCOURSE_NAME.FieldName = "COURSE_NAME";
            this.colCOURSE_NAME.Name = "colCOURSE_NAME";
            this.colCOURSE_NAME.Visible = true;
            this.colCOURSE_NAME.VisibleIndex = 1;
            // 
            // colGRADE_CODE
            // 
            this.colGRADE_CODE.Caption = "年级编号";
            this.colGRADE_CODE.FieldName = "GRADE_CODE";
            this.colGRADE_CODE.Name = "colGRADE_CODE";
            this.colGRADE_CODE.Visible = true;
            this.colGRADE_CODE.VisibleIndex = 2;
            // 
            // colGRADE_NAME
            // 
            this.colGRADE_NAME.Caption = "年级名称";
            this.colGRADE_NAME.FieldName = "GRADE_NAME";
            this.colGRADE_NAME.Name = "colGRADE_NAME";
            this.colGRADE_NAME.Visible = true;
            this.colGRADE_NAME.VisibleIndex = 3;
            // 
            // colEXAM_GUID
            // 
            this.colEXAM_GUID.Caption = "考试编号";
            this.colEXAM_GUID.FieldName = "EXAM_GUID";
            this.colEXAM_GUID.Name = "colEXAM_GUID";
            this.colEXAM_GUID.Visible = true;
            this.colEXAM_GUID.VisibleIndex = 4;
            // 
            // colSUBJECT_TYPE
            // 
            this.colSUBJECT_TYPE.Caption = "题目类型";
            this.colSUBJECT_TYPE.FieldName = "SUBJECT_TYPE";
            this.colSUBJECT_TYPE.Name = "colSUBJECT_TYPE";
            this.colSUBJECT_TYPE.Visible = true;
            this.colSUBJECT_TYPE.VisibleIndex = 5;
            // 
            // colVERY_EASY
            // 
            this.colVERY_EASY.Caption = "非常简单";
            this.colVERY_EASY.FieldName = "VERY_EASY";
            this.colVERY_EASY.Name = "colVERY_EASY";
            this.colVERY_EASY.Visible = true;
            this.colVERY_EASY.VisibleIndex = 6;
            // 
            // colEASY
            // 
            this.colEASY.Caption = "简单";
            this.colEASY.FieldName = "EASY";
            this.colEASY.Name = "colEASY";
            this.colEASY.Visible = true;
            this.colEASY.VisibleIndex = 7;
            // 
            // colCOMMON
            // 
            this.colCOMMON.Caption = "一般";
            this.colCOMMON.FieldName = "COMMON";
            this.colCOMMON.Name = "colCOMMON";
            this.colCOMMON.Visible = true;
            this.colCOMMON.VisibleIndex = 8;
            // 
            // colDIFFICULTY
            // 
            this.colDIFFICULTY.Caption = "困难";
            this.colDIFFICULTY.FieldName = "DIFFICULTY";
            this.colDIFFICULTY.Name = "colDIFFICULTY";
            this.colDIFFICULTY.Visible = true;
            this.colDIFFICULTY.VisibleIndex = 9;
            // 
            // colVERY_DIFFICULTY
            // 
            this.colVERY_DIFFICULTY.Caption = "非常困难";
            this.colVERY_DIFFICULTY.FieldName = "VERY_DIFFICULTY";
            this.colVERY_DIFFICULTY.Name = "colVERY_DIFFICULTY";
            this.colVERY_DIFFICULTY.Visible = true;
            this.colVERY_DIFFICULTY.VisibleIndex = 10;
            // 
            // btnPanel
            // 
            this.tablePanel1.SetColumn(this.btnPanel, 0);
            this.btnPanel.Location = new System.Drawing.Point(3, 3);
            this.btnPanel.Name = "btnPanel";
            this.tablePanel1.SetRow(this.btnPanel, 0);
            this.btnPanel.Size = new System.Drawing.Size(724, 40);
            this.btnPanel.TabIndex = 0;
            // 
            // colIS_ENABLE
            // 
            this.colIS_ENABLE.Caption = "启用状态";
            this.colIS_ENABLE.FieldName = "IS_ENABLE";
            this.colIS_ENABLE.Name = "colIS_ENABLE";
            this.colIS_ENABLE.Visible = true;
            this.colIS_ENABLE.VisibleIndex = 11;
            // 
            // FormExamBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 514);
            this.Controls.Add(this.tablePanel1);
            this.Name = "FormExamBank";
            this.Text = "试卷库";
            this.Load += new System.EventHandler(this.FormExamBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private CustomerControl.ButtonPanel btnPanel;
        private System.Windows.Forms.BindingSource bankSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCOURSE_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colCOURSE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colGRADE_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colGRADE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colEXAM_GUID;
        private DevExpress.XtraGrid.Columns.GridColumn colSUBJECT_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colVERY_EASY;
        private DevExpress.XtraGrid.Columns.GridColumn colEASY;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMMON;
        private DevExpress.XtraGrid.Columns.GridColumn colDIFFICULTY;
        private DevExpress.XtraGrid.Columns.GridColumn colVERY_DIFFICULTY;
        private DevExpress.XtraGrid.Columns.GridColumn colIS_ENABLE;
    }
}