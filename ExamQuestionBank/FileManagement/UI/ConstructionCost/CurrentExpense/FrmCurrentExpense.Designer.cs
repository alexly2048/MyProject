namespace FileManagement.UI
{
    partial class FrmCurrentExpense
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
            this.currentSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colITEM_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREASON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCATEGORY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQUANTITY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPARENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buttonPanel1 = new FileManagement.UI.ButtonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel1.Controls.Add(this.gridControl1);
            this.tablePanel1.Controls.Add(this.buttonPanel1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(933, 525);
            this.tablePanel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.tablePanel1.SetColumn(this.gridControl1, 0);
            this.gridControl1.DataSource = this.currentSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 49);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.tablePanel1.SetRow(this.gridControl1, 1);
            this.gridControl1.Size = new System.Drawing.Size(927, 473);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // currentSource
            // 
            this.currentSource.DataSource = typeof(FileManagement.Model.CurrentExpense);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colITEM_NAME,
            this.colREASON,
            this.colCATEGORY,
            this.colUNIT,
            this.colQUANTITY,
            this.colPRICE,
            this.colMONEY,
            this.colREMARK,
            this.colID,
            this.colPARENT_ID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 30;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colITEM_NAME
            // 
            this.colITEM_NAME.Caption = "项目";
            this.colITEM_NAME.FieldName = "ITEM_NAME";
            this.colITEM_NAME.Name = "colITEM_NAME";
            this.colITEM_NAME.Visible = true;
            this.colITEM_NAME.VisibleIndex = 0;
            // 
            // colREASON
            // 
            this.colREASON.Caption = "原由";
            this.colREASON.FieldName = "REASON";
            this.colREASON.Name = "colREASON";
            this.colREASON.Visible = true;
            this.colREASON.VisibleIndex = 1;
            // 
            // colCATEGORY
            // 
            this.colCATEGORY.Caption = "类别";
            this.colCATEGORY.FieldName = "CATEGORY";
            this.colCATEGORY.Name = "colCATEGORY";
            this.colCATEGORY.Visible = true;
            this.colCATEGORY.VisibleIndex = 2;
            // 
            // colUNIT
            // 
            this.colUNIT.Caption = "单位";
            this.colUNIT.FieldName = "UNIT";
            this.colUNIT.Name = "colUNIT";
            this.colUNIT.Visible = true;
            this.colUNIT.VisibleIndex = 3;
            // 
            // colQUANTITY
            // 
            this.colQUANTITY.Caption = "数量";
            this.colQUANTITY.FieldName = "QUANTITY";
            this.colQUANTITY.Name = "colQUANTITY";
            this.colQUANTITY.Visible = true;
            this.colQUANTITY.VisibleIndex = 4;
            // 
            // colPRICE
            // 
            this.colPRICE.Caption = "单价";
            this.colPRICE.FieldName = "PRICE";
            this.colPRICE.Name = "colPRICE";
            this.colPRICE.Visible = true;
            this.colPRICE.VisibleIndex = 5;
            // 
            // colMONEY
            // 
            this.colMONEY.Caption = "合价";
            this.colMONEY.FieldName = "MONEY";
            this.colMONEY.Name = "colMONEY";
            this.colMONEY.Visible = true;
            this.colMONEY.VisibleIndex = 6;
            // 
            // colREMARK
            // 
            this.colREMARK.Caption = "备注";
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 7;
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
            // buttonPanel1
            // 
            this.tablePanel1.SetColumn(this.buttonPanel1, 0);
            this.buttonPanel1.Location = new System.Drawing.Point(3, 3);
            this.buttonPanel1.Name = "buttonPanel1";
            this.tablePanel1.SetRow(this.buttonPanel1, 0);
            this.buttonPanel1.Size = new System.Drawing.Size(927, 40);
            this.buttonPanel1.TabIndex = 0;
            // 
            // FrmCurrentExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 525);
            this.Controls.Add(this.tablePanel1);
            this.Name = "FrmCurrentExpense";
            this.Text = "日常费用开支";
            this.Load += new System.EventHandler(this.FrmCurrentExpense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ButtonPanel buttonPanel1;
        private System.Windows.Forms.BindingSource currentSource;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colREASON;
        private DevExpress.XtraGrid.Columns.GridColumn colCATEGORY;
        private DevExpress.XtraGrid.Columns.GridColumn colUNIT;
        private DevExpress.XtraGrid.Columns.GridColumn colQUANTITY;
        private DevExpress.XtraGrid.Columns.GridColumn colPRICE;
        private DevExpress.XtraGrid.Columns.GridColumn colMONEY;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colPARENT_ID;
    }
}