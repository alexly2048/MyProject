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
using ConstructionManagement;

namespace ConstructionManagement.UI
{
    public partial class FrmNotification : example
    {
        public FrmNotification()
        {
            InitializeComponent();
        }
        NotificationService notificationService = new NotificationService();
        private void FrmNotification_Load(object sender, EventArgs e)
        {
            try
            {
                InitialData();
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditNotification editNotification = new FrmEditNotification();
                editNotification.IsAdd = true;
                editNotification.CallBack += InitialData;
                editNotification.ShowDialog();
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dgvNotification.SelectedRows;
                if (rows.Count > 0)
                {
                    var notification = rows[0].DataBoundItem as Notification;
                 //   notificationService.DeleteNotification(notification);
                    FrmEditNotification editNotification = new FrmEditNotification();
                    editNotification.Notification = notification;
                    editNotification.IsAdd = false;
                    editNotification.CallBack += InitialData;
                    editNotification.ShowDialog();
                }
                else
                {
                    ShowMsg("请选择要更新的数据");
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
                var rows = dgvNotification.SelectedRows;
                if(rows.Count > 0)
                {
                    var notification = rows[0].DataBoundItem as Notification;
                    notificationService.DeleteNotification(notification);
                    ShowMsg("删除成功");
                    InitialData();
                }
                else
                {
                    ShowMsg("请选择要删除的数据");
                }
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                InitialData();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void InitialData()
        {
            var result = notificationService.GetNotifications();
            dgvNotification.DataSource = result;
        }
    }
}
