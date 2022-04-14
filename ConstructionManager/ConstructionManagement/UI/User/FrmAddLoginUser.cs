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
    public partial class FrmAddLoginUser : example
    {
        public FrmAddLoginUser()
        {
            InitializeComponent();

            loginUserService = new LoginService();
        }
        LoginService loginUserService;
        public delegate void AddLoginUserRefresh();
        public event AddLoginUserRefresh CallBack;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var userId = txtUserId.Text.Trim();
                var userName = txtUserName.Text.Trim();
                var pwd = txtPwd.Text.Trim();

                if (string.IsNullOrEmpty(userId))
                {
                    ShowMsg("请输入用户ID");
                    return;
                }
                if (string.IsNullOrEmpty(userName))
                {
                    ShowMsg("请输入用户名");
                    return;
                }
                if (string.IsNullOrEmpty(pwd))
                {
                    ShowMsg("请输入密码");
                    return;
                }

                var user = new LoginUser
                {
                    UserId = userId,
                    UserName = userName,
                    Pwd = pwd
                };

                loginUserService.AddLoginUser(user);
                ShowMsg("提交成功");
                CallBack?.Invoke();
                Close();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
    }
}
