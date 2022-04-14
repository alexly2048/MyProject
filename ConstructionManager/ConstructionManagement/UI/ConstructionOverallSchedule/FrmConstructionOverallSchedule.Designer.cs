namespace ConstructionManagement.UI
{
    partial class FrmConstructionOverallSchedule
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
            System.Windows.Forms.BindingSource BSSchedule;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.colProjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectScheduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            BSSchedule = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(BSSchedule)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BSSchedule
            // 
            BSSchedule.DataSource = typeof(ConstructionManagement.Model.ConstructionOverallSchedule);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.513274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.48672F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 451);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSchedule);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "施工进度";
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.AllowUserToDeleteRows = false;
            this.dgvSchedule.AutoGenerateColumns = false;
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSchedule.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProjectCode,
            this.projectNameDataGridViewTextBoxColumn,
            this.projectScheduleDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dgvSchedule.DataSource = BSSchedule;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchedule.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchedule.Location = new System.Drawing.Point(3, 17);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSchedule.RowTemplate.Height = 23;
            this.dgvSchedule.Size = new System.Drawing.Size(766, 383);
            this.dgvSchedule.TabIndex = 0;
            this.dgvSchedule.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedule_CellDoubleClick);
            // 
            // colProjectCode
            // 
            this.colProjectCode.DataPropertyName = "ProjectCode";
            this.colProjectCode.HeaderText = "项目编号";
            this.colProjectCode.Name = "colProjectCode";
            this.colProjectCode.ReadOnly = true;
            // 
            // projectNameDataGridViewTextBoxColumn
            // 
            this.projectNameDataGridViewTextBoxColumn.DataPropertyName = "ProjectName";
            this.projectNameDataGridViewTextBoxColumn.HeaderText = "项目名称";
            this.projectNameDataGridViewTextBoxColumn.Name = "projectNameDataGridViewTextBoxColumn";
            this.projectNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projectScheduleDataGridViewTextBoxColumn
            // 
            this.projectScheduleDataGridViewTextBoxColumn.DataPropertyName = "ProjectSchedule";
            this.projectScheduleDataGridViewTextBoxColumn.HeaderText = "进度";
            this.projectScheduleDataGridViewTextBoxColumn.Name = "projectScheduleDataGridViewTextBoxColumn";
            this.projectScheduleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnRefresh);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(772, 36);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(687, 3);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5, 3, 10, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 30);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmConstructionOverallSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 451);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmConstructionOverallSchedule";
            this.Text = "施工总体进度";
            this.Load += new System.EventHandler(this.FrmConstructionOverallSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(BSSchedule)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn constructionNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectScheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}