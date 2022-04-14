namespace ConstructionManagement.UI
{
    partial class FormTelDict
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvTelDict = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONE1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBTITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPANYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEMARKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelDict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvTelDict, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(826, 476);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdate, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDelete, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(826, 40);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(20, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "关键字";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(69, 8);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(421, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(526, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Location = new System.Drawing.Point(631, 5);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(736, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvTelDict
            // 
            this.dgvTelDict.AllowUserToAddRows = false;
            this.dgvTelDict.AllowUserToDeleteRows = false;
            this.dgvTelDict.AutoGenerateColumns = false;
            this.dgvTelDict.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTelDict.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelDict.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.pHONEDataGridViewTextBoxColumn,
            this.pHONE1DataGridViewTextBoxColumn,
            this.jOBTITLEDataGridViewTextBoxColumn,
            this.cOMPANYDataGridViewTextBoxColumn,
            this.rEMARKDataGridViewTextBoxColumn});
            this.dgvTelDict.DataSource = this.bindingSource1;
            this.dgvTelDict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTelDict.Location = new System.Drawing.Point(3, 43);
            this.dgvTelDict.Name = "dgvTelDict";
            this.dgvTelDict.ReadOnly = true;
            this.dgvTelDict.RowTemplate.Height = 23;
            this.dgvTelDict.Size = new System.Drawing.Size(820, 430);
            this.dgvTelDict.TabIndex = 1;
            this.dgvTelDict.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTelDict_DataBindingComplete);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(ConstructionManagement.Model.TelDict);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pHONEDataGridViewTextBoxColumn
            // 
            this.pHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.HeaderText = "电话";
            this.pHONEDataGridViewTextBoxColumn.Name = "pHONEDataGridViewTextBoxColumn";
            this.pHONEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pHONE1DataGridViewTextBoxColumn
            // 
            this.pHONE1DataGridViewTextBoxColumn.DataPropertyName = "PHONE1";
            this.pHONE1DataGridViewTextBoxColumn.HeaderText = "电话1";
            this.pHONE1DataGridViewTextBoxColumn.Name = "pHONE1DataGridViewTextBoxColumn";
            this.pHONE1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jOBTITLEDataGridViewTextBoxColumn
            // 
            this.jOBTITLEDataGridViewTextBoxColumn.DataPropertyName = "JOB_TITLE";
            this.jOBTITLEDataGridViewTextBoxColumn.HeaderText = "职务";
            this.jOBTITLEDataGridViewTextBoxColumn.Name = "jOBTITLEDataGridViewTextBoxColumn";
            this.jOBTITLEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOMPANYDataGridViewTextBoxColumn
            // 
            this.cOMPANYDataGridViewTextBoxColumn.DataPropertyName = "COMPANY";
            this.cOMPANYDataGridViewTextBoxColumn.HeaderText = "公司";
            this.cOMPANYDataGridViewTextBoxColumn.Name = "cOMPANYDataGridViewTextBoxColumn";
            this.cOMPANYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEMARKDataGridViewTextBoxColumn
            // 
            this.rEMARKDataGridViewTextBoxColumn.DataPropertyName = "REMARK";
            this.rEMARKDataGridViewTextBoxColumn.HeaderText = "备注";
            this.rEMARKDataGridViewTextBoxColumn.Name = "rEMARKDataGridViewTextBoxColumn";
            this.rEMARKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormTelDict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 476);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormTelDict";
            this.Text = "通讯录";
            this.Load += new System.EventHandler(this.FormTelDict_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelDict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvTelDict;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONE1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBTITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPANYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEMARKDataGridViewTextBoxColumn;
    }
}