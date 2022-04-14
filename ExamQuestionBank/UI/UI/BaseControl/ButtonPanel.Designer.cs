namespace CustomUI.UI
{
    partial class ButtonPanel
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
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textKeyword = new DevExpress.XtraEditors.TextEdit();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textKeyword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 55F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F)});
            this.tablePanel1.Controls.Add(this.btnAdd);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.textKeyword);
            this.tablePanel1.Controls.Add(this.btnQuery);
            this.tablePanel1.Controls.Add(this.btnUpdate);
            this.tablePanel1.Controls.Add(this.btnDelete);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F)});
            this.tablePanel1.Size = new System.Drawing.Size(840, 40);
            this.tablePanel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.tablePanel1.SetColumn(this.btnAdd, 2);
            this.btnAdd.Location = new System.Drawing.Point(487, 8);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnAdd.Name = "btnAdd";
            this.tablePanel1.SetRow(this.btnAdd, 0);
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "新增";
            // 
            // labelControl1
            // 
            this.tablePanel1.SetColumn(this.labelControl1, 0);
            this.labelControl1.Location = new System.Drawing.Point(20, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "关键字";
            // 
            // textKeyword
            // 
            this.tablePanel1.SetColumn(this.textKeyword, 1);
            this.textKeyword.Location = new System.Drawing.Point(79, 10);
            this.textKeyword.Name = "textKeyword";
            this.tablePanel1.SetRow(this.textKeyword, 0);
            this.textKeyword.Size = new System.Drawing.Size(395, 20);
            this.textKeyword.TabIndex = 0;
            // 
            // btnQuery
            // 
            this.tablePanel1.SetColumn(this.btnQuery, 3);
            this.btnQuery.Location = new System.Drawing.Point(582, 8);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnQuery.Name = "btnQuery";
            this.tablePanel1.SetRow(this.btnQuery, 0);
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            // 
            // btnUpdate
            // 
            this.tablePanel1.SetColumn(this.btnUpdate, 4);
            this.btnUpdate.Location = new System.Drawing.Point(677, 8);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.tablePanel1.SetRow(this.btnUpdate, 0);
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "修改";
            // 
            // btnDelete
            // 
            this.tablePanel1.SetColumn(this.btnDelete, 5);
            this.btnDelete.Location = new System.Drawing.Point(772, 8);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnDelete.Name = "btnDelete";
            this.tablePanel1.SetRow(this.btnDelete, 0);
            this.btnDelete.Size = new System.Drawing.Size(58, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除";
            // 
            // ButtonPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "ButtonPanel";
            this.Size = new System.Drawing.Size(840, 40);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textKeyword.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.Utils.Layout.TablePanel tablePanel1;
        public DevExpress.XtraEditors.SimpleButton btnAdd;
        public DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit textKeyword;
        public DevExpress.XtraEditors.SimpleButton btnQuery;
        public DevExpress.XtraEditors.SimpleButton btnUpdate;
        public DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}
