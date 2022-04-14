using CustomerUI.Model;
using CustomerUI.UI.BaseForm;
using System;
using CustomerUI.DBService.CommonService;
namespace CustomerUI.UI.Common
{
    public partial class FrmEditUser : FormDialog
    {
        public FrmEditUser(UserService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private bool isAdd = true;
        private Action action;
        private User user = new User();
        private readonly UserService service;
        private void FrmEditUser_Load(object sender, EventArgs e)
        {
            InitialUI();
        }

        private void InitialUI()
        {
            editPanel1.labelControl1.Text = "账号";
            editPanel2.labelControl1.Text = "姓名";
            editPanel3.labelControl1.Text = "密码";
            editPanel4.labelControl1.Text = "确认密码";
            editPanel3.textEdit1.Properties.PasswordChar = '*';
            editPanel4.textEdit1.Properties.PasswordChar = '*';
            if (!isAdd)
            {
                editPanel1.textEdit1.Text = user.UserId;
                editPanel2.textEdit1.Text = user.UserName;
                editPanel3.textEdit1.Text = user.Pwd;
                editPanel4.textEdit1.Text = user.Pwd;
            }
        }

        public override void Shower(Action action, bool isAdd, object content)
        {
            this.action = action;
            this.isAdd = isAdd;
            user = (User)content;

            ShowDialog();
        }
        /// <summary>
        /// 提交数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            user.UserId = editPanel1.textEdit1.Text;
            user.UserName=editPanel2.textEdit1.Text ;
            user.Pwd=editPanel3.textEdit1.Text;
            var ensure = editPanel4.textEdit1.Text;
            if (string.IsNullOrEmpty(user.UserId))
            {
                ShowMsg("请输入账号");
                return;
            }
            if (string.IsNullOrEmpty(user.UserName))
            {
                ShowMsg("请输入用户姓名");
                return;
            }
            if (string.IsNullOrEmpty(user.Pwd))
            {
                ShowMsg("请输入密码");
                return;
            }
            if (!user.Pwd.Equals(ensure))
            {
                ShowMsg("两次输入密码不一致");
                return;
            }

            if (isAdd)
            {
                service.AddUser(user);
            }
            else
            {
                service.UpdateUser(user);
            }

            ShowMsg("提交成功");
            action?.Invoke();
            Close();
        }
    }
}
