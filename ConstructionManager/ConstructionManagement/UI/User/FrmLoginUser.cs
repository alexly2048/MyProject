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
    public partial class FrmLoginUser : example
    {
        public FrmLoginUser()
        {
            InitializeComponent();

            loginUserService = new LoginService();
        }
        LoginService loginUserService;
        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddLoginUser frmAddLoginUser = new FrmAddLoginUser();
            frmAddLoginUser.CallBack += QueryData;
            frmAddLoginUser.ShowDialog();
        }
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dgvUser.SelectedRows;
                if(rows.Count > 0)
                {
                    var user = rows[0].DataBoundItem as LoginUser;
                    loginUserService.DeleteLoginUser(user);
                    ShowMsg("删除成功");
                    QueryData();
                }
                else
                {
                    ShowMsg("请选择要删除的数据");
                }
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        /// <summary>
        /// 用户管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dgvUser.SelectedRows;
                if (rows.Count > 0)
                {
                    var user = rows[0].DataBoundItem as LoginUser;
                    var frm = new FormEditUser();
                    frm.Shower(user, QueryData);
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

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                QueryData();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void QueryData()
        {
            var userId = txtUserId.Text.Trim();
            var userName = txtUserName.Text.Trim();
            var user = loginUserService.GetLoginUsers(userId,userName);
            dgvUser.DataSource = user;
        }

        private void FrmLoginUser_Load(object sender, EventArgs e)
        {
            if (CurrentUser.Authorities.Contains("D10101"))
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
            if (CurrentUser.Authorities.Contains("D10102"))
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
            if (CurrentUser.Authorities.Contains("D10103"))
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }
    }
}
