using CustomerUI.Model;
using CustomerUI.UI.BaseForm;
using IOCService.Service;
using System;
using System.Linq;
using System.Windows.Forms;
using CustomerUI.DBService.CommonService;

namespace CustomerUI.UI.Common
{
    public partial class FrmUser : FormBase
    {
        public FrmUser(UserService service)
        {
            InitializeComponent();
            this.service = service;
        }
        private readonly UserService service;
        private void FrmUser_Load(object sender, EventArgs e)
        {
            buttonPanel1.btnUpdate.Text = "管理";

            buttonPanel1.btnAdd.Click += BtnAdd_Click;
            buttonPanel1.btnDelete.Click += BtnDelete_Click;
            buttonPanel1.btnQuery.Click += BtnQuery_Click;
            buttonPanel1.btnUpdate.Click += BtnUpdate_Click;

            gridView1.CustomDrawRowIndicator += GridView_CustomDrawRowIndicator_Event;
            gridView1.TopRowChanged += TopRowChanged_Event;
            SetUserAuthorities();
            QueryData();
        }
        /// <summary>
        /// 设置权限
        /// </summary>
        private void SetUserAuthorities()
        {
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("L101")))
            {
                buttonPanel1.btnAdd.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("L102")))
            {
                buttonPanel1.btnUpdate.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("L103")))
            {
                buttonPanel1.btnDelete.Enabled = false;
            }
        }

        /// <summary>
        /// 用户管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var rows = gridView1.GetSelectedRows();
            if(rows.Length > 0)
            {
                var data = gridView1.GetRow(rows[0]) as User;
                var frm = AppContainer.Resolve<FrmEditUser>();
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.Shower(QueryData, false, data);
            }
            else
            {
                ShowMsg("请选择要更新的数据");
            }
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            QueryData();
        }

        private void QueryData()
        {
            var keyword = buttonPanel1.textKeyword.Text.Trim();
            var r = service.Query(keyword);
            if (r.Any())
            {
                userSource.DataSource = r;
            }
            else
            {
                userSource.DataSource = null;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var rows = gridView1.GetSelectedRows();
            if (rows.Length > 0)
            {
                var data = gridView1.GetRow(rows[0]) as User;
                if(ShowAffirm("是否删除选择的用户数据？") == DialogResult.OK)
                {
                    var r = service.DeleteUser(data);
                    if (r)
                    {
                        ShowMsg("删除成功");
                        QueryData();
                    }
                    else
                    {
                        ShowMsg("删除失败");
                    }
                }
            }
            else
            {
                ShowMsg("请选择要删除的数据");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var frm = AppContainer.Resolve<FrmEditUser>();
            var c = new User();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Shower(QueryData, true, c);
        }
    }
}
