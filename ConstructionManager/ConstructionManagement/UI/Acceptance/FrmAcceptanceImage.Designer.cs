namespace ConstructionManagement.UI
{
    partial class FrmAcceptanceImage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvImages = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullFileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remoteFilePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageKindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvImages, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(667, 425);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvImages
            // 
            this.dgvImages.AllowUserToAddRows = false;
            this.dgvImages.AllowUserToDeleteRows = false;
            this.dgvImages.AutoGenerateColumns = false;
            this.dgvImages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImages.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvImages.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.colProjectNo,
            this.parentIdDataGridViewTextBoxColumn,
            this.fileNameDataGridViewTextBoxColumn,
            this.fullFileNameDataGridViewTextBoxColumn,
            this.remoteFilePathDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.imageKindDataGridViewTextBoxColumn});
            this.dgvImages.DataSource = this.imageSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImages.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImages.Location = new System.Drawing.Point(3, 49);
            this.dgvImages.Name = "dgvImages";
            this.dgvImages.ReadOnly = true;
            this.dgvImages.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImages.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvImages.RowTemplate.Height = 23;
            this.dgvImages.Size = new System.Drawing.Size(661, 373);
            this.dgvImages.TabIndex = 0;
            this.dgvImages.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImages_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // colProjectNo
            // 
            this.colProjectNo.DataPropertyName = "ProjectNo";
            this.colProjectNo.HeaderText = "ProjectNo";
            this.colProjectNo.Name = "colProjectNo";
            this.colProjectNo.ReadOnly = true;
            this.colProjectNo.Visible = false;
            // 
            // parentIdDataGridViewTextBoxColumn
            // 
            this.parentIdDataGridViewTextBoxColumn.DataPropertyName = "ParentId";
            this.parentIdDataGridViewTextBoxColumn.HeaderText = "ParentId";
            this.parentIdDataGridViewTextBoxColumn.Name = "parentIdDataGridViewTextBoxColumn";
            this.parentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.parentIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "文件名";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullFileNameDataGridViewTextBoxColumn
            // 
            this.fullFileNameDataGridViewTextBoxColumn.DataPropertyName = "FullFileName";
            this.fullFileNameDataGridViewTextBoxColumn.HeaderText = "FullFileName";
            this.fullFileNameDataGridViewTextBoxColumn.Name = "fullFileNameDataGridViewTextBoxColumn";
            this.fullFileNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullFileNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // remoteFilePathDataGridViewTextBoxColumn
            // 
            this.remoteFilePathDataGridViewTextBoxColumn.DataPropertyName = "RemoteFilePath";
            this.remoteFilePathDataGridViewTextBoxColumn.HeaderText = "文件路径";
            this.remoteFilePathDataGridViewTextBoxColumn.Name = "remoteFilePathDataGridViewTextBoxColumn";
            this.remoteFilePathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "文件说明";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageKindDataGridViewTextBoxColumn
            // 
            this.imageKindDataGridViewTextBoxColumn.DataPropertyName = "ImageKind";
            this.imageKindDataGridViewTextBoxColumn.HeaderText = "ImageKind";
            this.imageKindDataGridViewTextBoxColumn.Name = "imageKindDataGridViewTextBoxColumn";
            this.imageKindDataGridViewTextBoxColumn.ReadOnly = true;
            this.imageKindDataGridViewTextBoxColumn.Visible = false;
            // 
            // imageSource
            // 
            this.imageSource.DataSource = typeof(ConstructionManagement.Model.AcceptanceImage);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnRefresh);
            this.flowLayoutPanel1.Controls.Add(this.btnDel);
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(661, 40);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(581, 5);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 30);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(496, 5);
            this.btnDel.Margin = new System.Windows.Forms.Padding(5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 30);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(411, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmAcceptanceImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 425);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmAcceptanceImage";
            this.Text = "图像编辑";
            this.Load += new System.EventHandler(this.FrmAccptanceImage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvImages;
        private System.Windows.Forms.BindingSource imageSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullFileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remoteFilePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageKindDataGridViewTextBoxColumn;
    }
}