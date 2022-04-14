namespace ConstructionManagement.UI
{
    partial class FrmConstructionQuantity
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
            System.Windows.Forms.BindingSource BindingSourceConstructionQuantity;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvQuantity = new System.Windows.Forms.DataGridView();
            this.constructionNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemFeatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allOfProcessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reminderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            BindingSourceConstructionQuantity = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(BindingSourceConstructionQuantity)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuantity)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BindingSourceConstructionQuantity
            // 
            BindingSourceConstructionQuantity.DataSource = typeof(ConstructionManagement.Model.ConstructionQuantity);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(795, 536);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvQuantity);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 484);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "工程量";
            // 
            // dgvQuantity
            // 
            this.dgvQuantity.AllowUserToAddRows = false;
            this.dgvQuantity.AllowUserToDeleteRows = false;
            this.dgvQuantity.AutoGenerateColumns = false;
            this.dgvQuantity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuantity.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvQuantity.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvQuantity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuantity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.constructionNoDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemFeatureDataGridViewTextBoxColumn,
            this.itemUnitDataGridViewTextBoxColumn,
            this.designNumDataGridViewTextBoxColumn,
            this.modifyNumDataGridViewTextBoxColumn,
            this.allOfProcessDataGridViewTextBoxColumn,
            this.reminderDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.colParentId});
            this.dgvQuantity.DataSource = BindingSourceConstructionQuantity;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuantity.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuantity.Location = new System.Drawing.Point(3, 17);
            this.dgvQuantity.Name = "dgvQuantity";
            this.dgvQuantity.ReadOnly = true;
            this.dgvQuantity.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvQuantity.RowTemplate.Height = 23;
            this.dgvQuantity.Size = new System.Drawing.Size(783, 464);
            this.dgvQuantity.TabIndex = 0;
            this.dgvQuantity.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuantity_CellDoubleClick);
            // 
            // constructionNoDataGridViewTextBoxColumn
            // 
            this.constructionNoDataGridViewTextBoxColumn.DataPropertyName = "ConstructionNo";
            this.constructionNoDataGridViewTextBoxColumn.HeaderText = "项目编码";
            this.constructionNoDataGridViewTextBoxColumn.Name = "constructionNoDataGridViewTextBoxColumn";
            this.constructionNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "子目名称";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemFeatureDataGridViewTextBoxColumn
            // 
            this.itemFeatureDataGridViewTextBoxColumn.DataPropertyName = "ItemFeature";
            this.itemFeatureDataGridViewTextBoxColumn.HeaderText = "项目特征";
            this.itemFeatureDataGridViewTextBoxColumn.Name = "itemFeatureDataGridViewTextBoxColumn";
            this.itemFeatureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemUnitDataGridViewTextBoxColumn
            // 
            this.itemUnitDataGridViewTextBoxColumn.DataPropertyName = "ItemUnit";
            this.itemUnitDataGridViewTextBoxColumn.HeaderText = "单位";
            this.itemUnitDataGridViewTextBoxColumn.Name = "itemUnitDataGridViewTextBoxColumn";
            this.itemUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designNumDataGridViewTextBoxColumn
            // 
            this.designNumDataGridViewTextBoxColumn.DataPropertyName = "DesignNum";
            this.designNumDataGridViewTextBoxColumn.HeaderText = "设计数量";
            this.designNumDataGridViewTextBoxColumn.Name = "designNumDataGridViewTextBoxColumn";
            this.designNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modifyNumDataGridViewTextBoxColumn
            // 
            this.modifyNumDataGridViewTextBoxColumn.DataPropertyName = "ModifyNum";
            this.modifyNumDataGridViewTextBoxColumn.HeaderText = "变更";
            this.modifyNumDataGridViewTextBoxColumn.Name = "modifyNumDataGridViewTextBoxColumn";
            this.modifyNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // allOfProcessDataGridViewTextBoxColumn
            // 
            this.allOfProcessDataGridViewTextBoxColumn.DataPropertyName = "AllOfProcess";
            this.allOfProcessDataGridViewTextBoxColumn.HeaderText = "施工汇总";
            this.allOfProcessDataGridViewTextBoxColumn.Name = "allOfProcessDataGridViewTextBoxColumn";
            this.allOfProcessDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reminderDataGridViewTextBoxColumn
            // 
            this.reminderDataGridViewTextBoxColumn.DataPropertyName = "Reminder";
            this.reminderDataGridViewTextBoxColumn.HeaderText = "余量";
            this.reminderDataGridViewTextBoxColumn.Name = "reminderDataGridViewTextBoxColumn";
            this.reminderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // colParentId
            // 
            this.colParentId.DataPropertyName = "ParentId";
            this.colParentId.HeaderText = "ParentId";
            this.colParentId.Name = "colParentId";
            this.colParentId.ReadOnly = true;
            this.colParentId.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnRefresh);
            this.flowLayoutPanel1.Controls.Add(this.btnDel);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(789, 40);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(709, 3);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 30);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(624, 3);
            this.btnDel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 30);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(539, 3);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(454, 3);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmConstructionQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 536);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmConstructionQuantity";
            this.Text = "工程量统计";
            this.Load += new System.EventHandler(this.FrmConstructionQuantity_Load);
            ((System.ComponentModel.ISupportInitialize)(BindingSourceConstructionQuantity)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuantity)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvQuantity;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constructionNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemFeatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifyNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allOfProcessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reminderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParentId;
    }
}