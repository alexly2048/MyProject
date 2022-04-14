using CustomerUI.DBService.CommonService;
using CustomerUI.Model;
using CustomerUI.UI.BaseForm;
using IOCService.Service;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CustomerUI.UI.Common
{
    public partial class FrmAuthority : FormBase
    {
        public FrmAuthority(AuthoritiesService authorityService)
        {
            InitializeComponent();

            this.authorityService = authorityService;
        }
        private readonly AuthoritiesService authorityService;
        private void FrmAuthority_Load(object sender, EventArgs e)
        {
            gridView1.CustomDrawRowIndicator += GridView_CustomDrawRowIndicator_Event;
            gridView1.TopRowChanged += TopRowChanged_Event;

            buttonPanel1.btnAdd.Text = "设置权限";
            buttonPanel1.btnAdd.Click += BtnAdd_Click;
            buttonPanel1.btnDelete.Click += BtnDelete_Click;
            buttonPanel1.btnQuery.Click += BtnQuery_Click;
            buttonPanel1.btnUpdate.Click += BtnUpdate_Click;
        }

        private void SetUserAuthority()
        {
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("M101")))
            {
                buttonPanel1.btnAdd.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("M102")))
            {
                buttonPanel1.btnUpdate.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("M103")))
            {
                buttonPanel1.btnDelete.Enabled = false;
            }
        }

        /// <summary>
        /// 更新用户权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var rows = gridView1.GetSelectedRows();
            if(rows.Length > 0)
            {
                var data = gridView1.GetRow(rows[0]) as Authorities;
                var frm = AppContainer.Resolve<FrmFunctionItem>();
                frm.Shower(QueryData, false, data);
            }
            else
            {
                ShowMsg("请选择要更新用户");
            }
        }
        /// <summary>
        /// 查询用户权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            QueryData();
        }

        private void QueryData()
        {
            var key = buttonPanel1.textKeyword.Text.Trim();
            var r = authorityService.GetAuthorities(key);
            authoritySource.DataSource = r;
        }
        /// <summary>
        /// 删除某一个权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var rows = gridView1.GetSelectedRows();
            if(rows.Length > 0)
            {
                var data = gridView1.GetRow(rows[0]) as Authorities;
                
                if(ShowAffirm("是否删除选择的数据？") == DialogResult.OK)
                {
                    authorityService.DeleteAuthority(data);
                    ShowMsg("删除成功");
                    QueryData();
                }
            }
            else
            {
                ShowMsg("请选择要删除的数据");
            }
        }
        /// <summary>
        /// 设置用户权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var frm = AppContainer.Resolve<FrmFunctionItem>();
            var c = new Authorities();
            frm.Shower(QueryData, true, c);
        }
    }
}
