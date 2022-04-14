namespace FileManagement.UI
{
    partial class FrmConstructionCost
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
            this.buttonPanel1 = new FileManagement.UI.ButtonPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.constructionCostSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPROJECT_NUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROJECT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTAL_COST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESIGN_COST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPERVISOR_COST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXPERIMENT_COST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSTALLATION_COST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONSTRUCTION_COST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSAFE_CIVILIZED_COST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOTHER_COST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBUDGET_CONSTRUCTION_COST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUBCONTRACT_COST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREVIEW_COST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAPPROVED_COST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANAGEMENT_COST_RATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANAGEMENT_COST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLABOR_COST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSPECTION_COST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATERIAL_COST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATERIAL_TAX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGENERAL_COST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROFIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPARENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constructionCostSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 47.6F)});
            this.tablePanel1.Controls.Add(this.buttonPanel1);
            this.tablePanel1.Controls.Add(this.gridControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(933, 525);
            this.tablePanel1.TabIndex = 0;
            // 
            // buttonPanel1
            // 
            this.tablePanel1.SetColumn(this.buttonPanel1, 0);
            this.buttonPanel1.Location = new System.Drawing.Point(3, 3);
            this.buttonPanel1.Name = "buttonPanel1";
            this.tablePanel1.SetRow(this.buttonPanel1, 0);
            this.buttonPanel1.Size = new System.Drawing.Size(927, 34);
            this.buttonPanel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.tablePanel1.SetColumn(this.gridControl1, 0);
            this.gridControl1.DataSource = this.constructionCostSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.tablePanel1.SetRow(this.gridControl1, 1);
            this.gridControl1.Size = new System.Drawing.Size(927, 479);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // constructionCostSource
            // 
            this.constructionCostSource.DataSource = typeof(FileManagement.Model.ConstructionCost);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPROJECT_NUMBER,
            this.colPROJECT_NAME,
            this.colTOTAL_COST,
            this.colDESIGN_COST,
            this.colSUPERVISOR_COST,
            this.colEXPERIMENT_COST,
            this.colINSTALLATION_COST,
            this.colCONSTRUCTION_COST,
            this.colSAFE_CIVILIZED_COST,
            this.colOTHER_COST,
            this.colBUDGET_CONSTRUCTION_COST,
            this.colSUBCONTRACT_COST,
            this.colREVIEW_COST,
            this.colAPPROVED_COST,
            this.colRATE,
            this.colMANAGEMENT_COST_RATE,
            this.colMANAGEMENT_COST,
            this.colLABOR_COST,
            this.colINSPECTION_COST,
            this.colMATERIAL_COST,
            this.colMATERIAL_TAX,
            this.colGENERAL_COST,
            this.colPROFIT,
            this.colID,
            this.colPARENT_ID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 30;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
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
            // colTOTAL_COST
            // 
            this.colTOTAL_COST.Caption = "总造价";
            this.colTOTAL_COST.FieldName = "TOTAL_COST";
            this.colTOTAL_COST.Name = "colTOTAL_COST";
            this.colTOTAL_COST.Visible = true;
            this.colTOTAL_COST.VisibleIndex = 2;
            // 
            // colDESIGN_COST
            // 
            this.colDESIGN_COST.Caption = "设计费";
            this.colDESIGN_COST.FieldName = "DESIGN_COST";
            this.colDESIGN_COST.Name = "colDESIGN_COST";
            this.colDESIGN_COST.Visible = true;
            this.colDESIGN_COST.VisibleIndex = 3;
            // 
            // colSUPERVISOR_COST
            // 
            this.colSUPERVISOR_COST.Caption = "监理费";
            this.colSUPERVISOR_COST.FieldName = "SUPERVISOR_COST";
            this.colSUPERVISOR_COST.Name = "colSUPERVISOR_COST";
            this.colSUPERVISOR_COST.Visible = true;
            this.colSUPERVISOR_COST.VisibleIndex = 4;
            // 
            // colEXPERIMENT_COST
            // 
            this.colEXPERIMENT_COST.Caption = "试验费";
            this.colEXPERIMENT_COST.FieldName = "EXPERIMENT_COST";
            this.colEXPERIMENT_COST.Name = "colEXPERIMENT_COST";
            this.colEXPERIMENT_COST.Visible = true;
            this.colEXPERIMENT_COST.VisibleIndex = 5;
            // 
            // colINSTALLATION_COST
            // 
            this.colINSTALLATION_COST.Caption = "安装工程";
            this.colINSTALLATION_COST.FieldName = "INSTALLATION_COST";
            this.colINSTALLATION_COST.Name = "colINSTALLATION_COST";
            this.colINSTALLATION_COST.Visible = true;
            this.colINSTALLATION_COST.VisibleIndex = 6;
            // 
            // colCONSTRUCTION_COST
            // 
            this.colCONSTRUCTION_COST.Caption = "建筑工程";
            this.colCONSTRUCTION_COST.FieldName = "CONSTRUCTION_COST";
            this.colCONSTRUCTION_COST.Name = "colCONSTRUCTION_COST";
            this.colCONSTRUCTION_COST.Visible = true;
            this.colCONSTRUCTION_COST.VisibleIndex = 7;
            // 
            // colSAFE_CIVILIZED_COST
            // 
            this.colSAFE_CIVILIZED_COST.Caption = "安全文明施工费";
            this.colSAFE_CIVILIZED_COST.FieldName = "SAFE_CIVILIZED_COST";
            this.colSAFE_CIVILIZED_COST.Name = "colSAFE_CIVILIZED_COST";
            this.colSAFE_CIVILIZED_COST.Visible = true;
            this.colSAFE_CIVILIZED_COST.VisibleIndex = 8;
            // 
            // colOTHER_COST
            // 
            this.colOTHER_COST.Caption = "其他";
            this.colOTHER_COST.FieldName = "OTHER_COST";
            this.colOTHER_COST.Name = "colOTHER_COST";
            this.colOTHER_COST.Visible = true;
            this.colOTHER_COST.VisibleIndex = 9;
            // 
            // colBUDGET_CONSTRUCTION_COST
            // 
            this.colBUDGET_CONSTRUCTION_COST.Caption = "预算施工费";
            this.colBUDGET_CONSTRUCTION_COST.FieldName = "BUDGET_CONSTRUCTION_COST";
            this.colBUDGET_CONSTRUCTION_COST.Name = "colBUDGET_CONSTRUCTION_COST";
            this.colBUDGET_CONSTRUCTION_COST.Visible = true;
            this.colBUDGET_CONSTRUCTION_COST.VisibleIndex = 10;
            // 
            // colSUBCONTRACT_COST
            // 
            this.colSUBCONTRACT_COST.Caption = "分包费";
            this.colSUBCONTRACT_COST.FieldName = "SUBCONTRACT_COST";
            this.colSUBCONTRACT_COST.Name = "colSUBCONTRACT_COST";
            this.colSUBCONTRACT_COST.Visible = true;
            this.colSUBCONTRACT_COST.VisibleIndex = 11;
            // 
            // colREVIEW_COST
            // 
            this.colREVIEW_COST.Caption = "送审价";
            this.colREVIEW_COST.FieldName = "REVIEW_COST";
            this.colREVIEW_COST.Name = "colREVIEW_COST";
            this.colREVIEW_COST.Visible = true;
            this.colREVIEW_COST.VisibleIndex = 12;
            // 
            // colAPPROVED_COST
            // 
            this.colAPPROVED_COST.Caption = "审定价";
            this.colAPPROVED_COST.FieldName = "APPROVED_COST";
            this.colAPPROVED_COST.Name = "colAPPROVED_COST";
            this.colAPPROVED_COST.Visible = true;
            this.colAPPROVED_COST.VisibleIndex = 13;
            // 
            // colRATE
            // 
            this.colRATE.Caption = "税率";
            this.colRATE.FieldName = "RATE";
            this.colRATE.Name = "colRATE";
            this.colRATE.Visible = true;
            this.colRATE.VisibleIndex = 14;
            // 
            // colMANAGEMENT_COST_RATE
            // 
            this.colMANAGEMENT_COST_RATE.Caption = "管理费点";
            this.colMANAGEMENT_COST_RATE.FieldName = "MANAGEMENT_COST_RATE";
            this.colMANAGEMENT_COST_RATE.Name = "colMANAGEMENT_COST_RATE";
            this.colMANAGEMENT_COST_RATE.Visible = true;
            this.colMANAGEMENT_COST_RATE.VisibleIndex = 15;
            // 
            // colMANAGEMENT_COST
            // 
            this.colMANAGEMENT_COST.Caption = "管理费";
            this.colMANAGEMENT_COST.FieldName = "MANAGEMENT_COST";
            this.colMANAGEMENT_COST.Name = "colMANAGEMENT_COST";
            this.colMANAGEMENT_COST.Visible = true;
            this.colMANAGEMENT_COST.VisibleIndex = 16;
            // 
            // colLABOR_COST
            // 
            this.colLABOR_COST.Caption = "劳务";
            this.colLABOR_COST.FieldName = "LABOR_COST";
            this.colLABOR_COST.Name = "colLABOR_COST";
            this.colLABOR_COST.Visible = true;
            this.colLABOR_COST.VisibleIndex = 17;
            // 
            // colINSPECTION_COST
            // 
            this.colINSPECTION_COST.Caption = "审定试验费及检验费";
            this.colINSPECTION_COST.FieldName = "INSPECTION_COST";
            this.colINSPECTION_COST.Name = "colINSPECTION_COST";
            this.colINSPECTION_COST.Visible = true;
            this.colINSPECTION_COST.VisibleIndex = 18;
            // 
            // colMATERIAL_COST
            // 
            this.colMATERIAL_COST.Caption = "材料费用";
            this.colMATERIAL_COST.FieldName = "MATERIAL_COST";
            this.colMATERIAL_COST.Name = "colMATERIAL_COST";
            this.colMATERIAL_COST.Visible = true;
            this.colMATERIAL_COST.VisibleIndex = 19;
            // 
            // colMATERIAL_TAX
            // 
            this.colMATERIAL_TAX.Caption = "材料税";
            this.colMATERIAL_TAX.FieldName = "MATERIAL_TAX";
            this.colMATERIAL_TAX.Name = "colMATERIAL_TAX";
            this.colMATERIAL_TAX.Visible = true;
            this.colMATERIAL_TAX.VisibleIndex = 20;
            // 
            // colGENERAL_COST
            // 
            this.colGENERAL_COST.Caption = "日常开支费用";
            this.colGENERAL_COST.FieldName = "GENERAL_COST";
            this.colGENERAL_COST.Name = "colGENERAL_COST";
            this.colGENERAL_COST.Visible = true;
            this.colGENERAL_COST.VisibleIndex = 21;
            // 
            // colPROFIT
            // 
            this.colPROFIT.Caption = "利润";
            this.colPROFIT.FieldName = "PROFIT";
            this.colPROFIT.Name = "colPROFIT";
            this.colPROFIT.Visible = true;
            this.colPROFIT.VisibleIndex = 22;
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
            // FrmConstructionCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 525);
            this.Controls.Add(this.tablePanel1);
            this.Name = "FrmConstructionCost";
            this.Text = "造价";
            this.Load += new System.EventHandler(this.FrmConstructionCost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constructionCostSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.BindingSource constructionCostSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPROJECT_NUMBER;
        private DevExpress.XtraGrid.Columns.GridColumn colPROJECT_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colTOTAL_COST;
        private DevExpress.XtraGrid.Columns.GridColumn colDESIGN_COST;
        private DevExpress.XtraGrid.Columns.GridColumn colSUPERVISOR_COST;
        private DevExpress.XtraGrid.Columns.GridColumn colEXPERIMENT_COST;
        private DevExpress.XtraGrid.Columns.GridColumn colINSTALLATION_COST;
        private DevExpress.XtraGrid.Columns.GridColumn colCONSTRUCTION_COST;
        private DevExpress.XtraGrid.Columns.GridColumn colSAFE_CIVILIZED_COST;
        private DevExpress.XtraGrid.Columns.GridColumn colOTHER_COST;
        private DevExpress.XtraGrid.Columns.GridColumn colBUDGET_CONSTRUCTION_COST;
        private DevExpress.XtraGrid.Columns.GridColumn colSUBCONTRACT_COST;
        private DevExpress.XtraGrid.Columns.GridColumn colREVIEW_COST;
        private DevExpress.XtraGrid.Columns.GridColumn colAPPROVED_COST;
        private DevExpress.XtraGrid.Columns.GridColumn colRATE;
        private DevExpress.XtraGrid.Columns.GridColumn colMANAGEMENT_COST_RATE;
        private DevExpress.XtraGrid.Columns.GridColumn colMANAGEMENT_COST;
        private DevExpress.XtraGrid.Columns.GridColumn colLABOR_COST;
        private DevExpress.XtraGrid.Columns.GridColumn colINSPECTION_COST;
        private DevExpress.XtraGrid.Columns.GridColumn colMATERIAL_COST;
        private DevExpress.XtraGrid.Columns.GridColumn colMATERIAL_TAX;
        private DevExpress.XtraGrid.Columns.GridColumn colGENERAL_COST;
        private DevExpress.XtraGrid.Columns.GridColumn colPROFIT;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colPARENT_ID;
        private ButtonPanel buttonPanel1;
    }
}