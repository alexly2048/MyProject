using ConstructionManagement.Model;
using ConstructionManagement.Service;
using System;
using ConstructionManagement;

namespace ConstructionManagement.UI
{
    public partial class FrmEditNotification : example
    {
        public FrmEditNotification()
        {
            InitializeComponent();
        }
        public Notification Notification { get; set; }
        public bool IsAdd { get; set; }
        public delegate void EditRefresh();
        public event EditRefresh CallBack;
        private NotificationService notificationService = new NotificationService();
        private void FrmEditNodification_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsAdd)
                {
                    txtTitle.Text = Notification.Title;
                    rtbContent.Text = Notification.Content;
                }
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var title = txtTitle.Text.Trim();
                var content = rtbContent.Text.Trim();
                if (string.IsNullOrEmpty(title))
                {
                    ShowMsg("请输入标题");
                    return;
                }
                if (string.IsNullOrEmpty(content))
                {
                    ShowMsg("请输入内容");
                    return;
                }

                if (IsAdd)
                {
                    var notification = new Notification
                    {
                        Title = title,
                        Content = content,
                        CreateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        ModifyDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    };
                    notificationService.AddNotification(notification);
                }
                else
                {
                    var notification = new Notification
                    {
                        ID = Notification.ID,
                        Title = title,
                        Content = content,
                        ModifyDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    };
                    notificationService.UpdateNotification(notification);
                }
                ShowMsg("提交成功");
                CallBack?.Invoke();
                Close();

            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
    }
}
