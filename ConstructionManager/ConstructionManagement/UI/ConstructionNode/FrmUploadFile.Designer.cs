namespace ConstructionManagement.UI
{
    partial class FrmUploadFile
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
            System.Windows.Forms.BindingSource BindingSourceUploadFiles;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.constructionNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemoteFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConstructionField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            BindingSourceUploadFiles = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(BindingSourceUploadFiles)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BindingSourceUploadFiles
            // 
            BindingSourceUploadFiles.DataSource = typeof(ConstructionManagement.Model.AppendixFile);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(878, 444);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFiles);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件列表";
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.AutoGenerateColumns = false;
            this.dgvFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFiles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvFiles.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.constructionNoDataGridViewTextBoxColumn,
            this.colFileName,
            this.fileTypeDataGridViewTextBoxColumn,
            this.fileSizeDataGridViewTextBoxColumn,
            this.colRemoteFilePath,
            this.colFullFileName,
            this.colID,
            this.colParentId,
            this.colLocalFilePath,
            this.colCreateDate,
            this.colConstructionField});
            this.dgvFiles.DataSource = BindingSourceUploadFiles;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFiles.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFiles.Location = new System.Drawing.Point(3, 17);
            this.dgvFiles.MultiSelect = false;
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ReadOnly = true;
            this.dgvFiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvFiles.RowTemplate.Height = 23;
            this.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiles.Size = new System.Drawing.Size(866, 368);
            this.dgvFiles.TabIndex = 0;
            this.dgvFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellDoubleClick);
            // 
            // constructionNoDataGridViewTextBoxColumn
            // 
            this.constructionNoDataGridViewTextBoxColumn.DataPropertyName = "ConstructionNo";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.constructionNoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.constructionNoDataGridViewTextBoxColumn.HeaderText = "施工节点编号";
            this.constructionNoDataGridViewTextBoxColumn.Name = "constructionNoDataGridViewTextBoxColumn";
            this.constructionNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colFileName
            // 
            this.colFileName.DataPropertyName = "FileName";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colFileName.DefaultCellStyle = dataGridViewCellStyle2;
            this.colFileName.HeaderText = "文件名";
            this.colFileName.Name = "colFileName";
            this.colFileName.ReadOnly = true;
            // 
            // fileTypeDataGridViewTextBoxColumn
            // 
            this.fileTypeDataGridViewTextBoxColumn.DataPropertyName = "FileType";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fileTypeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.fileTypeDataGridViewTextBoxColumn.HeaderText = "类型";
            this.fileTypeDataGridViewTextBoxColumn.Name = "fileTypeDataGridViewTextBoxColumn";
            this.fileTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fileSizeDataGridViewTextBoxColumn
            // 
            this.fileSizeDataGridViewTextBoxColumn.DataPropertyName = "FileSize";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fileSizeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.fileSizeDataGridViewTextBoxColumn.HeaderText = "大小";
            this.fileSizeDataGridViewTextBoxColumn.Name = "fileSizeDataGridViewTextBoxColumn";
            this.fileSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colRemoteFilePath
            // 
            this.colRemoteFilePath.DataPropertyName = "RemoteFilePath";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colRemoteFilePath.DefaultCellStyle = dataGridViewCellStyle5;
            this.colRemoteFilePath.HeaderText = "远程文件地址";
            this.colRemoteFilePath.Name = "colRemoteFilePath";
            this.colRemoteFilePath.ReadOnly = true;
            // 
            // colFullFileName
            // 
            this.colFullFileName.DataPropertyName = "FullFileName";
            this.colFullFileName.HeaderText = "FullFileName";
            this.colFullFileName.Name = "colFullFileName";
            this.colFullFileName.ReadOnly = true;
            this.colFullFileName.Visible = false;
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
            // colLocalFilePath
            // 
            this.colLocalFilePath.DataPropertyName = "LocalFilePath";
            this.colLocalFilePath.HeaderText = "LocalFilePath";
            this.colLocalFilePath.Name = "colLocalFilePath";
            this.colLocalFilePath.ReadOnly = true;
            this.colLocalFilePath.Visible = false;
            // 
            // colCreateDate
            // 
            this.colCreateDate.DataPropertyName = "CreateDate";
            this.colCreateDate.HeaderText = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.ReadOnly = true;
            this.colCreateDate.Visible = false;
            // 
            // colConstructionField
            // 
            this.colConstructionField.DataPropertyName = "ConstructionField";
            this.colConstructionField.HeaderText = "ConstructionField";
            this.colConstructionField.Name = "colConstructionField";
            this.colConstructionField.ReadOnly = true;
            this.colConstructionField.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnRefresh, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(872, 44);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Location = new System.Drawing.Point(792, 5);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 34);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDel
            // 
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDel.Location = new System.Drawing.Point(707, 5);
            this.btnDel.Margin = new System.Windows.Forms.Padding(5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 34);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.Location = new System.Drawing.Point(622, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "上传";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmUploadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 444);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmUploadFile";
            this.Text = "附件";
            this.Load += new System.EventHandler(this.FrmUploadFile_Load);
            ((System.ComponentModel.ISupportInitialize)(BindingSourceUploadFiles)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn construtionFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadFileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadFilePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constructionNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemoteFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConstructionField;
    }
}