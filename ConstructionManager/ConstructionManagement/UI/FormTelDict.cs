using ConstructionManagement.Model;
using ConstructionManagement.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructionManagement.UI
{
    public partial class FormTelDict : example
    {
        public FormTelDict()
        {
            InitializeComponent();
        }
        private readonly TelDictService dictService = new TelDictService();
        private void FormTelDict_Load(object sender, EventArgs e)
        {
            try
            {
                QueryData();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                QueryData();
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void QueryData()
        {
            var key = textBox1.Text.Trim();
            var r = dictService.GetTelDicts(key);
            if (r.Any())
            {
                bindingSource1.DataSource = r;
            }
            else{
                bindingSource1.DataSource = null;
            }
        }

        private void dgvTelDict_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvTelDict.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new FormEditTelDict();
                var c = new TelDict();
                frm.Shower(QueryData, true, c);
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dgvTelDict.SelectedRows;
                if(rows.Count > 0)
                {
                    var data = rows[0].DataBoundItem as TelDict;
                    var frm = new FormEditTelDict();
                    frm.Shower(QueryData, false, data);
                }
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dgvTelDict.SelectedRows;
                if (rows.Count > 0)
                {
                    var data = rows[0].DataBoundItem as TelDict;
                    if (ShowAffirm("是否删除选择的数据？") == DialogResult.OK)
                    {
                        dictService.DeleteTelDict(data);
                        ShowMsg("删除成功");
                        QueryData();
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
    }
}
