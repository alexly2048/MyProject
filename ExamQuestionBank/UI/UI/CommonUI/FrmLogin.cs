using CustomerUI.Model;
using CustomerUI.UI.BaseForm;
using CustomerUI.DBService.CommonService;
using System;
using System.Windows.Forms;

namespace CustomerUI.UI.Common
{
    public partial class FrmLogin : FormBase
    {
        public FrmLogin(UserService service,
            AppHost appHost)
        {
            InitializeComponent();
            this.service = service;
            this.appHost = appHost;
        }
        private readonly UserService service;
        private readonly AppHost appHost;
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                UserId = textEdit1.Text.Trim(),
                Pwd = textEdit2.Text.Trim()
            };

            if (string.IsNullOrEmpty(user.UserId))
            {
                ShowMsg("请输入账号");
                return;
            }
            if (string.IsNullOrEmpty(user.Pwd))
            {
                ShowMsg("请输入用户密码");
                return;
            }

            var r = service.GetUserByUserId(user);
            if (r == null)
            {
                ShowMsg("用户名或密码错误");
                return;
            }
            if (!r.Pwd.Equals(user.Pwd))
            {
                ShowMsg("用户名或密码错误");
                return;
            }

            AppHost.CurrentUser = r;
            appHost.GetCurrentUserAuthorities();
            DialogResult = DialogResult.OK;
            Close();
        }
        /// <summary>
        /// 退出登录事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (ShowAffirm("是否退出？") == DialogResult.OK)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
    }
}
