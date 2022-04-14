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
    public partial class FormEditUser : example
    {
        public FormEditUser()
        {
            InitializeComponent();
        }

        private Action action;
        private LoginUser user;
        private LoginService service = new LoginService();
        public void Shower(LoginUser user, Action action)
        {
            this.user = user;
            this.action = action;
            ShowDialog();
        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {
            if(user != null)
            {
                tId.Text = user.UserId;
                tId.ReadOnly = true;
                tName.Text = user.UserName;
                tPwd.Text = user.Pwd;
                tEnsure.Text = user.Pwd;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("是否退出当前编辑界面?","系统提示",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Close();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            user.UserName = tName.Text.Trim();
            user.Pwd = tPwd.Text.Trim();
            if (string.IsNullOrEmpty(user.UserName))
            {
                MessageBox.Show("请输入用户姓名");
                return;
            }
            if (string.IsNullOrEmpty(user.Pwd))
            {
                MessageBox.Show("请输入密码");
                return;
            }
            if (!user.Pwd.Equals(tEnsure.Text.Trim()))
            {
                MessageBox.Show("两次输入密码不一致");
                return;
            }

            service.UpdateLoginUser(user);
            MessageBox.Show("更新成功");
            action?.Invoke();
            Close();
        }
    }
}
