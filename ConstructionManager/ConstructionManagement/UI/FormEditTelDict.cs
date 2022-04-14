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
    public partial class FormEditTelDict : example
    {
        public FormEditTelDict()
        {
            InitializeComponent();
        }
        private readonly TelDictService dictService = new TelDictService();
        private Action action;
        private TelDict dict;
        private bool isAdd = true;

        private void FormEditTelDict_Load(object sender, EventArgs e)
        {
            if (!isAdd)
            {
                tName.Text = dict.NAME;
                tPhone.Text = dict.PHONE;
                tPhone1.Text = dict.PHONE1;
                tJobTitle.Text = dict.JOB_TITLE;
                tCompany.Text = dict.COMPANY;
                tRemark.Text = dict.REMARK;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            dict.NAME = tName.Text.Trim();
            dict.PHONE = tPhone.Text.Trim();
            dict.PHONE1 = tPhone1.Text.Trim();
            dict.JOB_TITLE = tJobTitle.Text.Trim();
            dict.COMPANY = tCompany.Text.Trim();
            dict.REMARK = tRemark.Text.Trim();

            if (string.IsNullOrEmpty(dict.NAME))
            {
                MessageBox.Show("请输入姓名");
                return;
            }

            if (isAdd)
            {
                dictService.AddTelDict(dict);
            }
            else
            {
                dictService.UpdateTelDict(dict);
            }
            ShowMsg("提交成功");
            action?.Invoke();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(ShowAffirm("是否退出？") == DialogResult.OK)
            {
                Close();
            }
        }

        public void Shower(Action action,bool isAdd,object content)
        {
            this.action = action;
            this.isAdd = isAdd;
            dict = (TelDict)content;
            ShowDialog();
        }
    }
}
