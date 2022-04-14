namespace ConstructionManagement.UI
{
    partial class FrmSubItemFile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvItemFiles = new System.Windows.Forms.DataGridView();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullFileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 391);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvItemFiles);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件列表";
            // 
            // dgvItemFiles
            // 
            this.dgvItemFiles.AllowUserToAddRows = false;
            this.dgvItemFiles.AllowUserToDeleteRows = false;
            this.dgvItemFiles.AutoGenerateColumns = false;
            this.dgvItemFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemFiles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvItemFiles.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvItemFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileNameDataGridViewTextBoxColumn,
            this.fileTypeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.localPathDataGridViewTextBoxColumn,
            this.fullFileNameDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.parentIdDataGridViewTextBoxColumn});
            this.dgvItemFiles.DataSource = this.fileSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemFiles.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemFiles.Location = new System.Drawing.Point(3, 17);
            this.dgvItemFiles.Name = "dgvItemFiles";
            this.dgvItemFiles.ReadOnly = true;
            this.dgvItemFiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvItemFiles.RowTemplate.Height = 23;
            this.dgvItemFiles.Size = new System.Drawing.Size(628, 319);
            this.dgvItemFiles.TabIndex = 0;
            this.dgvItemFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemFiles_CellDoubleClick);
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "文件名";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fileTypeDataGridViewTextBoxColumn
            // 
            this.fileTypeDataGridViewTextBoxColumn.DataPropertyName = "FileType";
            this.fileTypeDataGridViewTextBoxColumn.HeaderText = "类型";
            this.fileTypeDataGridViewTextBoxColumn.Name = "fileTypeDataGridViewTextBoxColumn";
            this.fileTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "说明";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localPathDataGridViewTextBoxColumn
            // 
            this.localPathDataGridViewTextBoxColumn.DataPropertyName = "LocalPath";
            this.localPathDataGridViewTextBoxColumn.HeaderText = "LocalPath";
            this.localPathDataGridViewTextBoxColumn.Name = "localPathDataGridViewTextBoxColumn";
            this.localPathDataGridViewTextBoxColumn.ReadOnly = true;
            this.localPathDataGridViewTextBoxColumn.Visible = false;
            // 
            // fullFileNameDataGridViewTextBoxColumn
            // 
            this.fullFileNameDataGridViewTextBoxColumn.DataPropertyName = "FullFileName";
            this.fullFileNameDataGridViewTextBoxColumn.HeaderText = "FullFileName";
            this.fullFileNameDataGridViewTextBoxColumn.Name = "fullFileNameDataGridViewTextBoxColumn";
            this.fullFileNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullFileNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // parentIdDataGridViewTextBoxColumn
            // 
            this.parentIdDataGridViewTextBoxColumn.DataPropertyName = "ParentId";
            this.parentIdDataGridViewTextBoxColumn.HeaderText = "ParentId";
            this.parentIdDataGridViewTextBoxColumn.Name = "parentIdDataGridViewTextBoxColumn";
            this.parentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.parentIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // fileSource
            // 
            this.fileSource.DataSource = typeof(ConstructionManagement.Model.SubItemFile);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnRefresh);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(634, 40);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(549, 5);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 30);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(464, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(379, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmSubItemFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 391);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmSubItemFile";
            this.Text = "子项文件";
            this.Load += new System.EventHandler(this.FrmSubItemFile_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvItemFiles;
        private System.Windows.Forms.BindingSource fileSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remotePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullFileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentIdDataGridViewTextBoxColumn;
    }
}