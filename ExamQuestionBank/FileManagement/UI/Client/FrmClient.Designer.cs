namespace FileManagement.UI
{
    partial class FrmClient
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clientSource = new System.Windows.Forms.BindingSource(this.components);
            this.colPROJECT_NUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROJECT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSTALLATION_MATERIAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOWER_CUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADD_MATERIAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRETURN_MATERIAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPARENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientSource)).BeginInit();
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
            this.tablePanel1.Size = new System.Drawing.Size(800, 450);
            this.tablePanel1.TabIndex = 0;
            // 
            // buttonPanel1
            // 
            this.tablePanel1.SetColumn(this.buttonPanel1, 0);
            this.buttonPanel1.Location = new System.Drawing.Point(3, 3);
            this.buttonPanel1.Name = "buttonPanel1";
            this.tablePanel1.SetRow(this.buttonPanel1, 0);
            this.buttonPanel1.Size = new System.Drawing.Size(794, 40);
            this.buttonPanel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.tablePanel1.SetColumn(this.gridControl1, 0);
            this.gridControl1.DataSource = this.clientSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 49);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.tablePanel1.SetRow(this.gridControl1, 1);
            this.gridControl1.Size = new System.Drawing.Size(794, 398);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPROJECT_NUMBER,
            this.colPROJECT_NAME,
            this.colINSTALLATION_MATERIAL,
            this.colPOWER_CUT,
            this.colADD_MATERIAL,
            this.colRETURN_MATERIAL,
            this.colID,
            this.colPARENT_ID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 30;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // clientSource
            // 
            this.clientSource.DataSource = typeof(FileManagement.Model.Client);
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
            // colINSTALLATION_MATERIAL
            // 
            this.colINSTALLATION_MATERIAL.Caption = "报装资料";
            this.colINSTALLATION_MATERIAL.FieldName = "INSTALLATION_MATERIAL";
            this.colINSTALLATION_MATERIAL.Name = "colINSTALLATION_MATERIAL";
            this.colINSTALLATION_MATERIAL.Visible = true;
            this.colINSTALLATION_MATERIAL.VisibleIndex = 2;
            // 
            // colPOWER_CUT
            // 
            this.colPOWER_CUT.Caption = "停电";
            this.colPOWER_CUT.FieldName = "POWER_CUT";
            this.colPOWER_CUT.Name = "colPOWER_CUT";
            this.colPOWER_CUT.Visible = true;
            this.colPOWER_CUT.VisibleIndex = 3;
            // 
            // colADD_MATERIAL
            // 
            this.colADD_MATERIAL.Caption = "增资";
            this.colADD_MATERIAL.FieldName = "ADD_MATERIAL";
            this.colADD_MATERIAL.Name = "colADD_MATERIAL";
            this.colADD_MATERIAL.Visible = true;
            this.colADD_MATERIAL.VisibleIndex = 4;
            // 
            // colRETURN_MATERIAL
            // 
            this.colRETURN_MATERIAL.Caption = "退料";
            this.colRETURN_MATERIAL.FieldName = "RETURN_MATERIAL";
            this.colRETURN_MATERIAL.Name = "colRETURN_MATERIAL";
            this.colRETURN_MATERIAL.Visible = true;
            this.colRETURN_MATERIAL.VisibleIndex = 5;
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
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablePanel1);
            this.Name = "FrmClient";
            this.Text = "用户资料";
            this.Load += new System.EventHandler(this.FrmClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ButtonPanel buttonPanel1;
        private System.Windows.Forms.BindingSource clientSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPROJECT_NUMBER;
        private DevExpress.XtraGrid.Columns.GridColumn colPROJECT_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colINSTALLATION_MATERIAL;
        private DevExpress.XtraGrid.Columns.GridColumn colPOWER_CUT;
        private DevExpress.XtraGrid.Columns.GridColumn colADD_MATERIAL;
        private DevExpress.XtraGrid.Columns.GridColumn colRETURN_MATERIAL;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colPARENT_ID;
    }
}