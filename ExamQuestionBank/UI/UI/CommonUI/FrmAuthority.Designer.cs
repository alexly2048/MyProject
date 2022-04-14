using CustomerControl;
namespace CustomerUI.UI.Common
{
    partial class FrmAuthority
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
            this.authoritySource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUSER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPARENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buttonPanel1 = new ButtonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authoritySource)).BeginInit();
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
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(820, 493);
            this.tablePanel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.tablePanel1.SetColumn(this.gridControl1, 0);
            this.gridControl1.DataSource = this.authoritySource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 49);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.tablePanel1.SetRow(this.gridControl1, 1);
            this.gridControl1.Size = new System.Drawing.Size(814, 441);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // authoritySource
            // 
            this.authoritySource.DataSource = typeof(CustomerUI.Model.Authorities);
            // 
            // gridView1
            // 
            this.gridView1.ActiveFilterEnabled = false;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUSER_ID,
            this.colUSER_NAME,
            this.colITEM_ID,
            this.colITEM_NAME,
            this.colITEM_TYPE,
            this.colDESCRIPTION,
            this.colID,
            this.colPARENT_ID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 30;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // authoritySource
            // 
            this.authoritySource.DataSource = typeof(CustomerUI.Model.Authorities);
            // 
            // colUSER_ID
            // 
            this.colUSER_ID.Caption = "用户 ID";
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
            this.colUSER_NAME.Visible = true;
            this.colUSER_NAME.VisibleIndex = 1;
            // 
            // colITEM_ID
            // 
            this.colITEM_ID.Caption = "功能编号";
            this.colITEM_ID.FieldName = "ITEM_ID";
            this.colITEM_ID.Name = "colITEM_ID";
            this.colITEM_ID.Visible = true;
            this.colITEM_ID.VisibleIndex = 2;
            // 
            // colITEM_NAME
            // 
            this.colITEM_NAME.Caption = "功能名称";
            this.colITEM_NAME.FieldName = "ITEM_NAME";
            this.colITEM_NAME.Name = "colITEM_NAME";
            this.colITEM_NAME.Visible = true;
            this.colITEM_NAME.VisibleIndex = 3;
            // 
            // colITEM_TYPE
            // 
            this.colITEM_TYPE.Caption = "类型";
            this.colITEM_TYPE.FieldName = "ITEM_TYPE";
            this.colITEM_TYPE.Name = "colITEM_TYPE";
            this.colITEM_TYPE.Visible = true;
            this.colITEM_TYPE.VisibleIndex = 4;
            // 
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.Caption = "说明";
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            this.colDESCRIPTION.Visible = true;
            this.colDESCRIPTION.VisibleIndex = 5;
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
            this.buttonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPanel1.Location = new System.Drawing.Point(3, 3);
            this.buttonPanel1.Name = "buttonPanel1";
            this.tablePanel1.SetRow(this.buttonPanel1, 0);
            this.buttonPanel1.Size = new System.Drawing.Size(814, 40);
            this.buttonPanel1.TabIndex = 0;
            // 
            // FrmAuthority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 493);
            this.Controls.Add(this.tablePanel1);
            this.Name = "FrmAuthority";
            this.Text = "用户权限管理";
            this.Load += new System.EventHandler(this.FrmAuthority_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authoritySource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private ButtonPanel buttonPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource authoritySource;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colPARENT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_TYPE;
    }
}