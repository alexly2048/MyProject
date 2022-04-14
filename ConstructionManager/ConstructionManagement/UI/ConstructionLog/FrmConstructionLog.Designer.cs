namespace ConstructionManagement.UI
{
    partial class FrmConstructionLog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constructionCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constructionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weatherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constructionEventDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constructionDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.securityLogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbConstructionNode = new System.Windows.Forms.ComboBox();
            this.dtLogStart = new System.Windows.Forms.DateTimePicker();
            this.dtLogEnd = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(931, 446);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLogs);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询结果";
            // 
            // dgvLogs
            // 
            this.dgvLogs.AllowUserToAddRows = false;
            this.dgvLogs.AllowUserToDeleteRows = false;
            this.dgvLogs.AutoGenerateColumns = false;
            this.dgvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLogs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLogs.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.logIdDataGridViewTextBoxColumn,
            this.constructionCodeDataGridViewTextBoxColumn,
            this.constructionNameDataGridViewTextBoxColumn,
            this.logDateDataGridViewTextBoxColumn,
            this.weatherDataGridViewTextBoxColumn,
            this.temperatureDataGridViewTextBoxColumn,
            this.constructionEventDataGridViewTextBoxColumn,
            this.windDataGridViewTextBoxColumn,
            this.peopleDataGridViewTextBoxColumn,
            this.constructionDescriptionDataGridViewTextBoxColumn,
            this.securityLogDataGridViewTextBoxColumn});
            this.dgvLogs.DataSource = this.logSource;
            this.dgvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogs.Location = new System.Drawing.Point(3, 17);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.ReadOnly = true;
            this.dgvLogs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvLogs.RowTemplate.Height = 23;
            this.dgvLogs.Size = new System.Drawing.Size(919, 334);
            this.dgvLogs.TabIndex = 0;
            this.dgvLogs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLogs_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // logIdDataGridViewTextBoxColumn
            // 
            this.logIdDataGridViewTextBoxColumn.DataPropertyName = "LogId";
            this.logIdDataGridViewTextBoxColumn.HeaderText = "LogId";
            this.logIdDataGridViewTextBoxColumn.Name = "logIdDataGridViewTextBoxColumn";
            this.logIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.logIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // constructionCodeDataGridViewTextBoxColumn
            // 
            this.constructionCodeDataGridViewTextBoxColumn.DataPropertyName = "ConstructionCode";
            this.constructionCodeDataGridViewTextBoxColumn.HeaderText = "项目编码";
            this.constructionCodeDataGridViewTextBoxColumn.Name = "constructionCodeDataGridViewTextBoxColumn";
            this.constructionCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // constructionNameDataGridViewTextBoxColumn
            // 
            this.constructionNameDataGridViewTextBoxColumn.DataPropertyName = "ConstructionName";
            this.constructionNameDataGridViewTextBoxColumn.HeaderText = "项目名称";
            this.constructionNameDataGridViewTextBoxColumn.Name = "constructionNameDataGridViewTextBoxColumn";
            this.constructionNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logDateDataGridViewTextBoxColumn
            // 
            this.logDateDataGridViewTextBoxColumn.DataPropertyName = "LogDate";
            this.logDateDataGridViewTextBoxColumn.HeaderText = "施工日期";
            this.logDateDataGridViewTextBoxColumn.Name = "logDateDataGridViewTextBoxColumn";
            this.logDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weatherDataGridViewTextBoxColumn
            // 
            this.weatherDataGridViewTextBoxColumn.DataPropertyName = "Weather";
            this.weatherDataGridViewTextBoxColumn.HeaderText = "天气";
            this.weatherDataGridViewTextBoxColumn.Name = "weatherDataGridViewTextBoxColumn";
            this.weatherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // temperatureDataGridViewTextBoxColumn
            // 
            this.temperatureDataGridViewTextBoxColumn.DataPropertyName = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.HeaderText = "温度";
            this.temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
            this.temperatureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // constructionEventDataGridViewTextBoxColumn
            // 
            this.constructionEventDataGridViewTextBoxColumn.DataPropertyName = "ConstructionEvent";
            this.constructionEventDataGridViewTextBoxColumn.HeaderText = "突发事件";
            this.constructionEventDataGridViewTextBoxColumn.Name = "constructionEventDataGridViewTextBoxColumn";
            this.constructionEventDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // windDataGridViewTextBoxColumn
            // 
            this.windDataGridViewTextBoxColumn.DataPropertyName = "Wind";
            this.windDataGridViewTextBoxColumn.HeaderText = "风力";
            this.windDataGridViewTextBoxColumn.Name = "windDataGridViewTextBoxColumn";
            this.windDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peopleDataGridViewTextBoxColumn
            // 
            this.peopleDataGridViewTextBoxColumn.DataPropertyName = "People";
            this.peopleDataGridViewTextBoxColumn.HeaderText = "人力";
            this.peopleDataGridViewTextBoxColumn.Name = "peopleDataGridViewTextBoxColumn";
            this.peopleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // constructionDescriptionDataGridViewTextBoxColumn
            // 
            this.constructionDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ConstructionDescription";
            this.constructionDescriptionDataGridViewTextBoxColumn.HeaderText = "生产情况";
            this.constructionDescriptionDataGridViewTextBoxColumn.Name = "constructionDescriptionDataGridViewTextBoxColumn";
            this.constructionDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // securityLogDataGridViewTextBoxColumn
            // 
            this.securityLogDataGridViewTextBoxColumn.DataPropertyName = "SecurityLog";
            this.securityLogDataGridViewTextBoxColumn.HeaderText = "安全工作记录";
            this.securityLogDataGridViewTextBoxColumn.Name = "securityLogDataGridViewTextBoxColumn";
            this.securityLogDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logSource
            // 
            this.logSource.DataSource = typeof(ConstructionManagement.Model.ConstructionLog);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbConstructionNode, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtLogStart, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtLogEnd, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDelete, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdate, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnQuery, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnExport, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(925, 80);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(15, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "所属项目";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "起止日期";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbConstructionNode
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbConstructionNode, 2);
            this.cbConstructionNode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbConstructionNode.FormattingEnabled = true;
            this.cbConstructionNode.Location = new System.Drawing.Point(86, 10);
            this.cbConstructionNode.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.cbConstructionNode.Name = "cbConstructionNode";
            this.cbConstructionNode.Size = new System.Drawing.Size(550, 20);
            this.cbConstructionNode.TabIndex = 1;
            // 
            // dtLogStart
            // 
            this.dtLogStart.Location = new System.Drawing.Point(86, 50);
            this.dtLogStart.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dtLogStart.Name = "dtLogStart";
            this.dtLogStart.Size = new System.Drawing.Size(200, 21);
            this.dtLogStart.TabIndex = 2;
            // 
            // dtLogEnd
            // 
            this.dtLogEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtLogEnd.Location = new System.Drawing.Point(364, 50);
            this.dtLogEnd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dtLogEnd.Name = "dtLogEnd";
            this.dtLogEnd.Size = new System.Drawing.Size(272, 21);
            this.dtLogEnd.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(649, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(649, 45);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Location = new System.Drawing.Point(744, 5);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery.Location = new System.Drawing.Point(744, 45);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 30);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(839, 5);
            this.btnExport.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 30);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FrmConstructionLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 446);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmConstructionLog";
            this.Text = "施工日志";
            this.Load += new System.EventHandler(this.FrmConstructionLog_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.BindingSource logSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbConstructionNode;
        private System.Windows.Forms.DateTimePicker dtLogStart;
        private System.Windows.Forms.DateTimePicker dtLogEnd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constructionCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constructionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weatherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constructionEventDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn windDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constructionDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn securityLogDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExport;
    }
}