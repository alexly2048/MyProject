namespace ConstructionManagement.UI
{
    partial class FrmAcceptance
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvAcceptance = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rectifyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptanceSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcceptance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptanceSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvAcceptance, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnQuery);
            this.flowLayoutPanel1.Controls.Add(this.btnDel);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(694, 43);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(614, 5);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(5);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 30);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "刷新";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(529, 5);
            this.btnDel.Margin = new System.Windows.Forms.Padding(5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 30);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(444, 5);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(359, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvAcceptance
            // 
            this.dgvAcceptance.AllowUserToAddRows = false;
            this.dgvAcceptance.AllowUserToDeleteRows = false;
            this.dgvAcceptance.AutoGenerateColumns = false;
            this.dgvAcceptance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAcceptance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAcceptance.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAcceptance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcceptance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.questionDataGridViewTextBoxColumn,
            this.rectifyDataGridViewTextBoxColumn});
            this.dgvAcceptance.DataSource = this.acceptanceSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAcceptance.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAcceptance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAcceptance.Location = new System.Drawing.Point(3, 52);
            this.dgvAcceptance.Name = "dgvAcceptance";
            this.dgvAcceptance.ReadOnly = true;
            this.dgvAcceptance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAcceptance.RowTemplate.Height = 23;
            this.dgvAcceptance.Size = new System.Drawing.Size(694, 371);
            this.dgvAcceptance.TabIndex = 1;
            this.dgvAcceptance.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAcceptance_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProjectNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "项目编号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProjectName";
            this.dataGridViewTextBoxColumn3.HeaderText = "项目名称";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn4.HeaderText = "子目名称";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ItemFeature";
            this.dataGridViewTextBoxColumn5.HeaderText = "项目特征";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ItemUnit";
            this.dataGridViewTextBoxColumn6.HeaderText = "单位";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Remark1";
            this.dataGridViewTextBoxColumn7.HeaderText = "备注1";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Remark2";
            this.dataGridViewTextBoxColumn8.HeaderText = "备注2";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Remark3";
            this.dataGridViewTextBoxColumn9.HeaderText = "备注3";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn10.HeaderText = "说明";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // questionDataGridViewTextBoxColumn
            // 
            this.questionDataGridViewTextBoxColumn.DataPropertyName = "Question";
            this.questionDataGridViewTextBoxColumn.HeaderText = "问题部位说明";
            this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            this.questionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rectifyDataGridViewTextBoxColumn
            // 
            this.rectifyDataGridViewTextBoxColumn.DataPropertyName = "Rectify";
            this.rectifyDataGridViewTextBoxColumn.HeaderText = "整改部位说明";
            this.rectifyDataGridViewTextBoxColumn.Name = "rectifyDataGridViewTextBoxColumn";
            this.rectifyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // acceptanceSource
            // 
            this.acceptanceSource.DataSource = typeof(ConstructionManagement.Model.Acceptance);
            // 
            // FrmAcceptance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 426);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmAcceptance";
            this.Text = "验收";
            this.Load += new System.EventHandler(this.FrmAcceptance_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcceptance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptanceSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvAcceptance;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemFeatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource acceptanceSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rectifyDataGridViewTextBoxColumn;
    }
}