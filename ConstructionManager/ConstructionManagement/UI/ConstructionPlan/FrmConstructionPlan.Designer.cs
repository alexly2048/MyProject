namespace ConstructionManagement.UI
{
    partial class FrmConstructionPlan
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
            System.Windows.Forms.BindingSource BindingSourcePlan;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constructionNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constructionItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constructionPartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.civilWorksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constructionMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bntRefresh = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            BindingSourcePlan = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(BindingSourcePlan)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BindingSourcePlan
            // 
            BindingSourcePlan.DataSource = typeof(ConstructionManagement.Model.ConstructionPlanModel);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.06865F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.93135F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 454);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPlan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "施工计划";
            // 
            // dgvPlan
            // 
            this.dgvPlan.AllowUserToAddRows = false;
            this.dgvPlan.AllowUserToDeleteRows = false;
            this.dgvPlan.AutoGenerateColumns = false;
            this.dgvPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPlan.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.colParentId,
            this.constructionNoDataGridViewTextBoxColumn,
            this.planDateDataGridViewTextBoxColumn,
            this.constructionItemDataGridViewTextBoxColumn,
            this.constructionPartDataGridViewTextBoxColumn,
            this.civilWorksDataGridViewTextBoxColumn,
            this.numOfPersonDataGridViewTextBoxColumn,
            this.leaderDataGridViewTextBoxColumn,
            this.constructionMethodDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dgvPlan.DataSource = BindingSourcePlan;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlan.Location = new System.Drawing.Point(3, 17);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPlan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPlan.RowTemplate.Height = 23;
            this.dgvPlan.Size = new System.Drawing.Size(748, 383);
            this.dgvPlan.TabIndex = 0;
            this.dgvPlan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlan_CellClick);
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
            // constructionNoDataGridViewTextBoxColumn
            // 
            this.constructionNoDataGridViewTextBoxColumn.DataPropertyName = "ConstructionNo";
            this.constructionNoDataGridViewTextBoxColumn.HeaderText = "施工节点编号";
            this.constructionNoDataGridViewTextBoxColumn.Name = "constructionNoDataGridViewTextBoxColumn";
            this.constructionNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // planDateDataGridViewTextBoxColumn
            // 
            this.planDateDataGridViewTextBoxColumn.DataPropertyName = "PlanDate";
            this.planDateDataGridViewTextBoxColumn.HeaderText = "日期";
            this.planDateDataGridViewTextBoxColumn.Name = "planDateDataGridViewTextBoxColumn";
            this.planDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // constructionItemDataGridViewTextBoxColumn
            // 
            this.constructionItemDataGridViewTextBoxColumn.DataPropertyName = "ConstructionItem";
            this.constructionItemDataGridViewTextBoxColumn.HeaderText = "施工项目";
            this.constructionItemDataGridViewTextBoxColumn.Name = "constructionItemDataGridViewTextBoxColumn";
            this.constructionItemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // constructionPartDataGridViewTextBoxColumn
            // 
            this.constructionPartDataGridViewTextBoxColumn.DataPropertyName = "ConstructionPart";
            this.constructionPartDataGridViewTextBoxColumn.HeaderText = "施工部位";
            this.constructionPartDataGridViewTextBoxColumn.Name = "constructionPartDataGridViewTextBoxColumn";
            this.constructionPartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // civilWorksDataGridViewTextBoxColumn
            // 
            this.civilWorksDataGridViewTextBoxColumn.DataPropertyName = "CivilWorks";
            this.civilWorksDataGridViewTextBoxColumn.HeaderText = "工程量";
            this.civilWorksDataGridViewTextBoxColumn.Name = "civilWorksDataGridViewTextBoxColumn";
            this.civilWorksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numOfPersonDataGridViewTextBoxColumn
            // 
            this.numOfPersonDataGridViewTextBoxColumn.DataPropertyName = "NumOfPerson";
            this.numOfPersonDataGridViewTextBoxColumn.HeaderText = "人数";
            this.numOfPersonDataGridViewTextBoxColumn.Name = "numOfPersonDataGridViewTextBoxColumn";
            this.numOfPersonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leaderDataGridViewTextBoxColumn
            // 
            this.leaderDataGridViewTextBoxColumn.DataPropertyName = "Leader";
            this.leaderDataGridViewTextBoxColumn.HeaderText = "工作负责人";
            this.leaderDataGridViewTextBoxColumn.Name = "leaderDataGridViewTextBoxColumn";
            this.leaderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // constructionMethodDataGridViewTextBoxColumn
            // 
            this.constructionMethodDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.constructionMethodDataGridViewTextBoxColumn.DataPropertyName = "ConstructionMethod";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.constructionMethodDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.constructionMethodDataGridViewTextBoxColumn.HeaderText = "施工方法";
            this.constructionMethodDataGridViewTextBoxColumn.Name = "constructionMethodDataGridViewTextBoxColumn";
            this.constructionMethodDataGridViewTextBoxColumn.ReadOnly = true;
            this.constructionMethodDataGridViewTextBoxColumn.Width = 79;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "备注";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.bntRefresh, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDel, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdate, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(754, 39);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // bntRefresh
            // 
            this.bntRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntRefresh.Location = new System.Drawing.Point(674, 5);
            this.bntRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.bntRefresh.Name = "bntRefresh";
            this.bntRefresh.Size = new System.Drawing.Size(75, 29);
            this.bntRefresh.TabIndex = 0;
            this.bntRefresh.Text = "刷新";
            this.bntRefresh.UseVisualStyleBackColor = true;
            this.bntRefresh.Click += new System.EventHandler(this.bntRefresh_Click);
            // 
            // btnDel
            // 
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDel.Location = new System.Drawing.Point(589, 5);
            this.btnDel.Margin = new System.Windows.Forms.Padding(5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 29);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Location = new System.Drawing.Point(504, 5);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 29);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(419, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmConstructionPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 454);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmConstructionPlan";
            this.Text = "施工计划";
            this.Load += new System.EventHandler(this.FrmConstructionPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(BindingSourcePlan)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bntRefresh;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn planIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn constructionNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constructionItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constructionPartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn civilWorksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constructionMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
    }
}