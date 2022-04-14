namespace ConstructionManagement.UI
{
    partial class FrmConstructionNode
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
            System.Windows.Forms.BindingSource BindingSourceNode;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupConstruction = new System.Windows.Forms.GroupBox();
            this.dgvConstruction = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constructionNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constructionStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.civilConstructionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.electricStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.electronicTransferDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerCutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerCut2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerCut3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inOperationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beCompletedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeAnAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendKnotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileBeforeConstructionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constructionPlanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            BindingSourceNode = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(BindingSourceNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupConstruction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConstruction)).BeginInit();
            this.SuspendLayout();
            // 
            // BindingSourceNode
            // 
            BindingSourceNode.DataSource = typeof(ConstructionManagement.Model.ConstructionNode);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupConstruction);
            this.splitContainer1.Size = new System.Drawing.Size(1005, 393);
            this.splitContainer1.SplitterDistance = 37;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnUpdate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRefresh, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1005, 37);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Location = new System.Drawing.Point(770, 5);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 27);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(690, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 27);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDel.Location = new System.Drawing.Point(850, 5);
            this.btnDel.Margin = new System.Windows.Forms.Padding(5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(70, 27);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Location = new System.Drawing.Point(930, 5);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(70, 27);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupConstruction
            // 
            this.groupConstruction.Controls.Add(this.dgvConstruction);
            this.groupConstruction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupConstruction.Location = new System.Drawing.Point(0, 0);
            this.groupConstruction.Name = "groupConstruction";
            this.groupConstruction.Size = new System.Drawing.Size(1005, 352);
            this.groupConstruction.TabIndex = 0;
            this.groupConstruction.TabStop = false;
            this.groupConstruction.Text = "施工进度";
            // 
            // dgvConstruction
            // 
            this.dgvConstruction.AllowUserToAddRows = false;
            this.dgvConstruction.AllowUserToDeleteRows = false;
            this.dgvConstruction.AutoGenerateColumns = false;
            this.dgvConstruction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConstruction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvConstruction.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvConstruction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConstruction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.constructionNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.constructionStartDataGridViewTextBoxColumn,
            this.civilConstructionDataGridViewTextBoxColumn,
            this.electricStartDataGridViewTextBoxColumn,
            this.electronicTransferDataGridViewTextBoxColumn,
            this.powerCutDataGridViewTextBoxColumn,
            this.powerCut2DataGridViewTextBoxColumn,
            this.powerCut3DataGridViewTextBoxColumn,
            this.inOperationDataGridViewTextBoxColumn,
            this.beCompletedDataGridViewTextBoxColumn,
            this.closeAnAccountDataGridViewTextBoxColumn,
            this.sendKnotDataGridViewTextBoxColumn,
            this.archiveDataGridViewTextBoxColumn,
            this.fileBeforeConstructionDataGridViewTextBoxColumn,
            this.constructionPlanDataGridViewTextBoxColumn});
            this.dgvConstruction.DataSource = BindingSourceNode;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConstruction.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvConstruction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConstruction.Location = new System.Drawing.Point(3, 17);
            this.dgvConstruction.Name = "dgvConstruction";
            this.dgvConstruction.ReadOnly = true;
            this.dgvConstruction.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConstruction.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvConstruction.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConstruction.RowTemplate.Height = 23;
            this.dgvConstruction.Size = new System.Drawing.Size(999, 332);
            this.dgvConstruction.TabIndex = 0;
            this.dgvConstruction.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConstruction_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "序号";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // constructionNoDataGridViewTextBoxColumn
            // 
            this.constructionNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.constructionNoDataGridViewTextBoxColumn.DataPropertyName = "ConstructionNo";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.constructionNoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.constructionNoDataGridViewTextBoxColumn.HeaderText = "编号";
            this.constructionNoDataGridViewTextBoxColumn.Name = "constructionNoDataGridViewTextBoxColumn";
            this.constructionNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.constructionNoDataGridViewTextBoxColumn.Width = 54;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nameDataGridViewTextBoxColumn.HeaderText = "名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // constructionStartDataGridViewTextBoxColumn
            // 
            this.constructionStartDataGridViewTextBoxColumn.DataPropertyName = "ConstructionStart";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.constructionStartDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.constructionStartDataGridViewTextBoxColumn.HeaderText = "开工日期";
            this.constructionStartDataGridViewTextBoxColumn.Name = "constructionStartDataGridViewTextBoxColumn";
            this.constructionStartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // civilConstructionDataGridViewTextBoxColumn
            // 
            this.civilConstructionDataGridViewTextBoxColumn.DataPropertyName = "CivilConstruction";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.civilConstructionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.civilConstructionDataGridViewTextBoxColumn.HeaderText = "土建施工";
            this.civilConstructionDataGridViewTextBoxColumn.Name = "civilConstructionDataGridViewTextBoxColumn";
            this.civilConstructionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // electricStartDataGridViewTextBoxColumn
            // 
            this.electricStartDataGridViewTextBoxColumn.DataPropertyName = "ElectricStart";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.electricStartDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.electricStartDataGridViewTextBoxColumn.HeaderText = "电气施工";
            this.electricStartDataGridViewTextBoxColumn.Name = "electricStartDataGridViewTextBoxColumn";
            this.electricStartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // electronicTransferDataGridViewTextBoxColumn
            // 
            this.electronicTransferDataGridViewTextBoxColumn.DataPropertyName = "ElectronicTransfer";
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.electronicTransferDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.electronicTransferDataGridViewTextBoxColumn.HeaderText = "电子化移交";
            this.electronicTransferDataGridViewTextBoxColumn.Name = "electronicTransferDataGridViewTextBoxColumn";
            this.electronicTransferDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // powerCutDataGridViewTextBoxColumn
            // 
            this.powerCutDataGridViewTextBoxColumn.DataPropertyName = "PowerCut";
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.powerCutDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.powerCutDataGridViewTextBoxColumn.HeaderText = "停电时间1";
            this.powerCutDataGridViewTextBoxColumn.Name = "powerCutDataGridViewTextBoxColumn";
            this.powerCutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // powerCut2DataGridViewTextBoxColumn
            // 
            this.powerCut2DataGridViewTextBoxColumn.DataPropertyName = "PowerCut2";
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.powerCut2DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.powerCut2DataGridViewTextBoxColumn.HeaderText = "停电时间2";
            this.powerCut2DataGridViewTextBoxColumn.Name = "powerCut2DataGridViewTextBoxColumn";
            this.powerCut2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // powerCut3DataGridViewTextBoxColumn
            // 
            this.powerCut3DataGridViewTextBoxColumn.DataPropertyName = "PowerCut3";
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.powerCut3DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.powerCut3DataGridViewTextBoxColumn.HeaderText = "停电时间3";
            this.powerCut3DataGridViewTextBoxColumn.Name = "powerCut3DataGridViewTextBoxColumn";
            this.powerCut3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inOperationDataGridViewTextBoxColumn
            // 
            this.inOperationDataGridViewTextBoxColumn.DataPropertyName = "InOperation";
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inOperationDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.inOperationDataGridViewTextBoxColumn.HeaderText = "投运时间";
            this.inOperationDataGridViewTextBoxColumn.Name = "inOperationDataGridViewTextBoxColumn";
            this.inOperationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // beCompletedDataGridViewTextBoxColumn
            // 
            this.beCompletedDataGridViewTextBoxColumn.DataPropertyName = "BeCompleted";
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.beCompletedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.beCompletedDataGridViewTextBoxColumn.HeaderText = "竣工时间";
            this.beCompletedDataGridViewTextBoxColumn.Name = "beCompletedDataGridViewTextBoxColumn";
            this.beCompletedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // closeAnAccountDataGridViewTextBoxColumn
            // 
            this.closeAnAccountDataGridViewTextBoxColumn.DataPropertyName = "CloseAnAccount";
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.closeAnAccountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.closeAnAccountDataGridViewTextBoxColumn.HeaderText = "结算时间";
            this.closeAnAccountDataGridViewTextBoxColumn.Name = "closeAnAccountDataGridViewTextBoxColumn";
            this.closeAnAccountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sendKnotDataGridViewTextBoxColumn
            // 
            this.sendKnotDataGridViewTextBoxColumn.DataPropertyName = "SendKnot";
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sendKnotDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.sendKnotDataGridViewTextBoxColumn.HeaderText = "送结时间";
            this.sendKnotDataGridViewTextBoxColumn.Name = "sendKnotDataGridViewTextBoxColumn";
            this.sendKnotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // archiveDataGridViewTextBoxColumn
            // 
            this.archiveDataGridViewTextBoxColumn.DataPropertyName = "Archive";
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.archiveDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.archiveDataGridViewTextBoxColumn.HeaderText = "归档";
            this.archiveDataGridViewTextBoxColumn.Name = "archiveDataGridViewTextBoxColumn";
            this.archiveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fileBeforeConstructionDataGridViewTextBoxColumn
            // 
            this.fileBeforeConstructionDataGridViewTextBoxColumn.DataPropertyName = "FileBeforeConstruction";
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fileBeforeConstructionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.fileBeforeConstructionDataGridViewTextBoxColumn.HeaderText = "施工前附件";
            this.fileBeforeConstructionDataGridViewTextBoxColumn.Name = "fileBeforeConstructionDataGridViewTextBoxColumn";
            this.fileBeforeConstructionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // constructionPlanDataGridViewTextBoxColumn
            // 
            this.constructionPlanDataGridViewTextBoxColumn.DataPropertyName = "ConstructionPlan";
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.constructionPlanDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.constructionPlanDataGridViewTextBoxColumn.HeaderText = "计划";
            this.constructionPlanDataGridViewTextBoxColumn.Name = "constructionPlanDataGridViewTextBoxColumn";
            this.constructionPlanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmConstructionNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 393);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmConstructionNode";
            this.Text = "施工节点";
            this.Load += new System.EventHandler(this.FrmConstructionNode_Load);
            ((System.ComponentModel.ISupportInitialize)(BindingSourceNode)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupConstruction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConstruction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupConstruction;
        private System.Windows.Forms.DataGridView dgvConstruction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constructionNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constructionStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn civilConstructionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn electricStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn electronicTransferDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerCutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerCut2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerCut3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inOperationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beCompletedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeAnAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sendKnotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn archiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileBeforeConstructionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constructionPlanDataGridViewTextBoxColumn;
    }
}