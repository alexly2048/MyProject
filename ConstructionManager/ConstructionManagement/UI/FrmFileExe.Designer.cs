namespace ConstructionManagement.UI
{
    partial class FrmFileExe
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvShortcuts = new System.Windows.Forms.DataGridView();
            this.filePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortcutSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShortcuts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortcutSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvShortcuts, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(519, 419);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvShortcuts
            // 
            this.dgvShortcuts.AllowUserToAddRows = false;
            this.dgvShortcuts.AllowUserToDeleteRows = false;
            this.dgvShortcuts.AutoGenerateColumns = false;
            this.dgvShortcuts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShortcuts.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvShortcuts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShortcuts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filePathDataGridViewTextBoxColumn,
            this.fileNameDataGridViewTextBoxColumn,
            this.imageNameDataGridViewTextBoxColumn});
            this.dgvShortcuts.DataSource = this.shortcutSource;
            this.dgvShortcuts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShortcuts.Location = new System.Drawing.Point(3, 49);
            this.dgvShortcuts.Name = "dgvShortcuts";
            this.dgvShortcuts.ReadOnly = true;
            this.dgvShortcuts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvShortcuts.RowTemplate.Height = 23;
            this.dgvShortcuts.Size = new System.Drawing.Size(513, 367);
            this.dgvShortcuts.TabIndex = 0;
            // 
            // filePathDataGridViewTextBoxColumn
            // 
            this.filePathDataGridViewTextBoxColumn.DataPropertyName = "FilePath";
            this.filePathDataGridViewTextBoxColumn.HeaderText = "路径";
            this.filePathDataGridViewTextBoxColumn.Name = "filePathDataGridViewTextBoxColumn";
            this.filePathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "文件名";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageNameDataGridViewTextBoxColumn
            // 
            this.imageNameDataGridViewTextBoxColumn.DataPropertyName = "ImageName";
            this.imageNameDataGridViewTextBoxColumn.HeaderText = "图标名";
            this.imageNameDataGridViewTextBoxColumn.Name = "imageNameDataGridViewTextBoxColumn";
            this.imageNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shortcutSource
            // 
            this.shortcutSource.DataSource = typeof(ConstructionManagement.Model.FileShortcut);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(513, 40);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(423, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 5, 15, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmFileExe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 419);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmFileExe";
            this.Text = "快捷方式管理";
            this.Load += new System.EventHandler(this.FrmFileExe_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShortcuts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortcutSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvShortcuts;
        private System.Windows.Forms.BindingSource shortcutSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDelete;
    }
}