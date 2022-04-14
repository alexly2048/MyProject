namespace ConstructionManagement.UI
{
    partial class FrmItemImage
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
            this.imageSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvImages = new System.Windows.Forms.DataGridView();
            this.thumbnailImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.imageFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageRemotePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thumbnailRemotePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.displayImage = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImages)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayImage)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageSource
            // 
            this.imageSource.DataSource = typeof(ConstructionManagement.Model.SubItemImage);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1055, 536);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1049, 484);
            this.splitContainer1.SplitterDistance = 349;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvImages);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 484);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图片文件列表";
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
            this.thumbnailImageDataGridViewImageColumn,
            this.imageFullNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.imageNameDataGridViewTextBoxColumn,
            this.imageRemotePathDataGridViewTextBoxColumn,
            this.imageTypeDataGridViewTextBoxColumn,
            this.thumbnailRemotePathDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.parentIdDataGridViewTextBoxColumn});
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
            this.dgvImages.Location = new System.Drawing.Point(3, 17);
            this.dgvImages.Name = "dgvImages";
            this.dgvImages.ReadOnly = true;
            this.dgvImages.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvImages.RowTemplate.Height = 23;
            this.dgvImages.Size = new System.Drawing.Size(343, 464);
            this.dgvImages.TabIndex = 0;
            this.dgvImages.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImages_CellDoubleClick);
            // 
            // thumbnailImageDataGridViewImageColumn
            // 
            this.thumbnailImageDataGridViewImageColumn.DataPropertyName = "ThumbnailImage";
            this.thumbnailImageDataGridViewImageColumn.HeaderText = "缩略图";
            this.thumbnailImageDataGridViewImageColumn.Name = "thumbnailImageDataGridViewImageColumn";
            this.thumbnailImageDataGridViewImageColumn.ReadOnly = true;
            // 
            // imageFullNameDataGridViewTextBoxColumn
            // 
            this.imageFullNameDataGridViewTextBoxColumn.DataPropertyName = "ImageFullName";
            this.imageFullNameDataGridViewTextBoxColumn.HeaderText = "文件名";
            this.imageFullNameDataGridViewTextBoxColumn.Name = "imageFullNameDataGridViewTextBoxColumn";
            this.imageFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "说明";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageNameDataGridViewTextBoxColumn
            // 
            this.imageNameDataGridViewTextBoxColumn.DataPropertyName = "ImageName";
            this.imageNameDataGridViewTextBoxColumn.HeaderText = "ImageName";
            this.imageNameDataGridViewTextBoxColumn.Name = "imageNameDataGridViewTextBoxColumn";
            this.imageNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.imageNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // imageRemotePathDataGridViewTextBoxColumn
            // 
            this.imageRemotePathDataGridViewTextBoxColumn.DataPropertyName = "ImageRemotePath";
            this.imageRemotePathDataGridViewTextBoxColumn.HeaderText = "ImageRemotePath";
            this.imageRemotePathDataGridViewTextBoxColumn.Name = "imageRemotePathDataGridViewTextBoxColumn";
            this.imageRemotePathDataGridViewTextBoxColumn.ReadOnly = true;
            this.imageRemotePathDataGridViewTextBoxColumn.Visible = false;
            // 
            // imageTypeDataGridViewTextBoxColumn
            // 
            this.imageTypeDataGridViewTextBoxColumn.DataPropertyName = "ImageType";
            this.imageTypeDataGridViewTextBoxColumn.HeaderText = "ImageType";
            this.imageTypeDataGridViewTextBoxColumn.Name = "imageTypeDataGridViewTextBoxColumn";
            this.imageTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.imageTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // thumbnailRemotePathDataGridViewTextBoxColumn
            // 
            this.thumbnailRemotePathDataGridViewTextBoxColumn.DataPropertyName = "ThumbnailRemotePath";
            this.thumbnailRemotePathDataGridViewTextBoxColumn.HeaderText = "ThumbnailRemotePath";
            this.thumbnailRemotePathDataGridViewTextBoxColumn.Name = "thumbnailRemotePathDataGridViewTextBoxColumn";
            this.thumbnailRemotePathDataGridViewTextBoxColumn.ReadOnly = true;
            this.thumbnailRemotePathDataGridViewTextBoxColumn.Visible = false;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.displayImage);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 484);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图片浏览";
            // 
            // displayImage
            // 
            this.displayImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayImage.Location = new System.Drawing.Point(3, 17);
            this.displayImage.Margin = new System.Windows.Forms.Padding(8);
            this.displayImage.Name = "displayImage";
            this.displayImage.Padding = new System.Windows.Forms.Padding(10);
            this.displayImage.Size = new System.Drawing.Size(690, 464);
            this.displayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.displayImage.TabIndex = 0;
            this.displayImage.TabStop = false;
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1049, 40);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(969, 5);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 30);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(884, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(799, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmItemImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 536);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmItemImage";
            this.Text = "子项-附件图片";
            this.Load += new System.EventHandler(this.FrmItemImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImages)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displayImage)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource imageSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvImages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox displayImage;
        private System.Windows.Forms.DataGridViewImageColumn thumbnailImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageRemotePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thumbnailRemotePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}