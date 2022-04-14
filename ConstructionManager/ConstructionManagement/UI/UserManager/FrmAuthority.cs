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
    public partial class FrmAuthority : example
    {
        public FrmAuthority()
        {
            InitializeComponent();
        }

        AuthorityService authorityService = new AuthorityService();
        private void FrmAuthority_Load(object sender, EventArgs e)
        {
            try
            {
                if (CurrentUser.Authorities.Contains("D10201"))
                {
                    btnAdd.Enabled = true;
                }
                else
                {
                    btnAdd.Enabled = false;
                }
                if (CurrentUser.Authorities.Contains("D10202"))
                {
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnDelete.Enabled = false;
                }
                if (CurrentUser.Authorities.Contains("D10203"))
                {
                    btnUpdate.Enabled = true;
                }
                else
                {
                    btnUpdate.Enabled = false;
                }

                QueryData();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dgvAuthority.SelectedRows;
                if(rows.Count > 0)
                {
                    var authority = rows[0].DataBoundItem as Authority;
                    authorityService.DeleteAuthority(authority);
                    ShowMsg("删除成功");
                    QueryData();
                }
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                QueryData();
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
                var rows = dgvAuthority.SelectedRows;
                if(rows.Count > 0)
                {
                    var user = rows[0].DataBoundItem as Authority;
                    FrmMenuItem frmMenuItem = new FrmMenuItem();
                    frmMenuItem.IsAdd = false;
                    frmMenuItem.Authority = user;
                    frmMenuItem.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        public void QueryData()
        {
            var result = authorityService.GetAuthorities();
            dgvAuthority.DataSource = result;
        }

        /// <summary>
        /// 设置权限界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMenuItem frmItem = new FrmMenuItem();
                frmItem.IsAdd = true;
                frmItem.ShowDialog();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
    }
}
