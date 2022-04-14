namespace ConstructionManagement.UI
{
    partial class FrmSubItem
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
            System.Windows.Forms.BindingSource BindingSourceSubItem;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSubItems = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.featureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workDoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doneDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appendixImagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appendixFilesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            BindingSourceSubItem = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(BindingSourceSubItem)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubItems)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BindingSourceSubItem
            // 
            BindingSourceSubItem.DataSource = typeof(ConstructionManagement.Model.ConstructionSubItem);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.5618F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.4382F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 445);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSubItems);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "子项内容";
            // 
            // dgvSubItems
            // 
            this.dgvSubItems.AllowUserToAddRows = false;
            this.dgvSubItems.AllowUserToDeleteRows = false;
            this.dgvSubItems.AutoGenerateColumns = false;
            this.dgvSubItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSubItems.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSubItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.colID,
            this.colParentId,
            this.featureDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.partDataGridViewTextBoxColumn,
            this.workDoneDataGridViewTextBoxColumn,
            this.doneDateDataGridViewTextBoxColumn,
            this.appendixImagesDataGridViewTextBoxColumn,
            this.appendixFilesDataGridViewTextBoxColumn});
            this.dgvSubItems.DataSource = BindingSourceSubItem;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubItems.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubItems.Location = new System.Drawing.Point(3, 17);
            this.dgvSubItems.Name = "dgvSubItems";
            this.dgvSubItems.ReadOnly = true;
            this.dgvSubItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSubItems.RowTemplate.Height = 23;
            this.dgvSubItems.Size = new System.Drawing.Size(788, 372);
            this.dgvSubItems.TabIndex = 0;
            this.dgvSubItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubItems_CellDoubleClick);
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "子目名称";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colParentId
            // 
            this.colParentId.DataPropertyName = "ParentId";
            this.colParentId.HeaderText = "ParentId";
            this.colParentId.Name = "colParentId";
            this.colParentId.ReadOnly = true;
            this.colParentId.Visible = false;
            // 
            // featureDataGridViewTextBoxColumn
            // 
            this.featureDataGridViewTextBoxColumn.DataPropertyName = "Feature";
            this.featureDataGridViewTextBoxColumn.HeaderText = "项目特征";
            this.featureDataGridViewTextBoxColumn.Name = "featureDataGridViewTextBoxColumn";
            this.featureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "单位";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partDataGridViewTextBoxColumn
            // 
            this.partDataGridViewTextBoxColumn.DataPropertyName = "Part";
            this.partDataGridViewTextBoxColumn.HeaderText = "施工部位";
            this.partDataGridViewTextBoxColumn.Name = "partDataGridViewTextBoxColumn";
            this.partDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workDoneDataGridViewTextBoxColumn
            // 
            this.workDoneDataGridViewTextBoxColumn.DataPropertyName = "WorkDone";
            this.workDoneDataGridViewTextBoxColumn.HeaderText = "施工完成";
            this.workDoneDataGridViewTextBoxColumn.Name = "workDoneDataGridViewTextBoxColumn";
            this.workDoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doneDateDataGridViewTextBoxColumn
            // 
            this.doneDateDataGridViewTextBoxColumn.DataPropertyName = "DoneDate";
            this.doneDateDataGridViewTextBoxColumn.HeaderText = "日期";
            this.doneDateDataGridViewTextBoxColumn.Name = "doneDateDataGridViewTextBoxColumn";
            this.doneDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appendixImagesDataGridViewTextBoxColumn
            // 
            this.appendixImagesDataGridViewTextBoxColumn.DataPropertyName = "AppendixImages";
            this.appendixImagesDataGridViewTextBoxColumn.HeaderText = "附件图片";
            this.appendixImagesDataGridViewTextBoxColumn.Name = "appendixImagesDataGridViewTextBoxColumn";
            this.appendixImagesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appendixFilesDataGridViewTextBoxColumn
            // 
            this.appendixFilesDataGridViewTextBoxColumn.DataPropertyName = "AppendixFiles";
            this.appendixFilesDataGridViewTextBoxColumn.HeaderText = "附件文件";
            this.appendixFilesDataGridViewTextBoxColumn.Name = "appendixFilesDataGridViewTextBoxColumn";
            this.appendixFilesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnQuery, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDel, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdate, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 41);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery.Location = new System.Drawing.Point(714, 5);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(5);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 31);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "刷新";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnDel
            // 
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDel.Location = new System.Drawing.Point(629, 5);
            this.btnDel.Margin = new System.Windows.Forms.Padding(5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 31);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Location = new System.Drawing.Point(544, 5);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(459, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmSubItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmSubItem";
            this.Text = "施工-子项";
            this.Load += new System.EventHandler(this.FrmSubItem_Load);
            ((System.ComponentModel.ISupportInitialize)(BindingSourceSubItem)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubItems)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSubItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn featureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workDoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doneDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appendixImagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appendixFilesDataGridViewTextBoxColumn;
    }
}