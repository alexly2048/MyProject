using ConstructionManagement.Service;
using System;
using System.IO;
using System.Windows.Forms;

namespace ConstructionManagement.UI
{
    public partial class FrmValidatePwd : example
    {
        public FrmValidatePwd()
        {
            InitializeComponent();
        }

        private readonly NotificationInfoService infoService = new NotificationInfoService();
        private void FrmValidatePwd_Load(object sender, EventArgs e)
        {
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var pwd = tPwd.Text.Trim();
            if (string.IsNullOrEmpty(pwd))
            {
                ShowMsg("请输入密码");
                return;
            }
            var r = ValidateNotificationPwd(pwd);
            if (r)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Cancel;
            Close();
        }
        private bool ValidateNotificationPwd(string pwd)
        {
            var no = infoService.GetNotification();
            return no.CONTENT.Equals(pwd);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
