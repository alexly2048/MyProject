using ConstructionManagement.Model;
using ConstructionManagement.Service;
using System;
using System.Windows.Forms;
using ConstructionManagement;

namespace ConstructionManagement.UI
{
    public partial class FrmLogin : example
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        LoginService loginService = new LoginService();
        AuthorityService authorityService = new AuthorityService();
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var dialog = ShowAffirm("是否退出登录？");
            if(dialog == DialogResult.OK)
            {
                Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var user = txtUserId.Text.ToString();
                var pwd = txtPwd.Text.Trim();
                if (string.IsNullOrEmpty(user))
                {
                    ShowMsg("请选择登录用户");
                    return;
                }
                if (string.IsNullOrEmpty(pwd))
                {
                    ShowMsg("请输入密码");
                    return;
                }

                var loginUser = new LoginUser
                {
                    UserId = user,
                    Pwd = pwd
                };

                var result = loginService.QueryLoginUser(loginUser);
                if(result == false)
                {
                    ShowMsg("用户名或密码错误");
                    return;
                }
                this.DialogResult = DialogResult.OK;
                var authories = authorityService.GetAuthorityItemIds(loginUser.UserId);
                CurrentUser.User = loginUser;
                CurrentUser.Authorities = authories;
                Close();                
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
    }
}
