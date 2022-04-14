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
    public partial class FormEditNotificationPwd : example
    {
        public FormEditNotificationPwd()
        {
            InitializeComponent();
        }
        private readonly NotificationInfoService infoService = new NotificationInfoService();
        private void FormEditNotificationPwd_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var ori = tOriginal.Text.Trim();
            var pwd = tNew.Text.Trim();
            var en = tEnsure.Text.Trim();
            if (string.IsNullOrEmpty(ori))
            {
                MessageBox.Show("请输入原始密码");
                return;
            }
            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("请输入新的密码");
                return;
            }
            if (string.IsNullOrEmpty(en))
            {
                MessageBox.Show("请输入确认密码");
                return;
            }
            if (!pwd.Equals(en))
            {
                MessageBox.Show("两次输入密码不一致");
                return;
            }

            var no = infoService.GetNotification();
            if (!no.CONTENT.Equals(ori))
            {
                MessageBox.Show("输入的原始密码与原密码不一致");
                return;
            }
            infoService.UpdateNotificationPwd(en);
            MessageBox.Show("更新成功");
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("是否退出当前编辑界面？") == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
