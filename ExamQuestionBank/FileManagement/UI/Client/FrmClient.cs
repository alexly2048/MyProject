using DevExpress.XtraBars.Docking.Paint;
using DevExpress.XtraGrid.Views.Grid;
using FileManagement.Model;
using FileManagement.Service;
using FileManagement.Service.DataService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManagement.UI
{
    public partial class FrmClient : FrmBase
    {
        public FrmClient(ClientService clientService)
        {
            InitializeComponent();
            this.clientService = clientService;
        }
        private readonly ClientService clientService;

        private void FrmClient_Load(object sender, EventArgs e)
        {
            gridView1.CustomDrawRowIndicator += (s, arg) => GridView_CustomDrawRowIndicator_Event(s, arg);
            gridView1.TopRowChanged += TopRowChanged_Event;

            buttonPanel1.btnAdd.Click += BtnAdd_Click;
            buttonPanel1.btnDelete.Click += BtnDelete_Click;
            buttonPanel1.btnQuery.Click += BtnQuery_Click;
            buttonPanel1.btnUpdate.Click += BtnUpdate_Click;
        }

        private void QueryData()
        {
            var keyword = buttonPanel1.textKeyword.Text.Trim();
            var r = clientService.GetClients(keyword);
            clientSource.DataSource = r;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var rows = gridView1.GetSelectedRows();
            if (rows.Count() > 0)
            {
                var data = gridView1.GetRow(rows[0]) as Client;
                var frm = AppContainer.Resove<FrmEditClient>();
                frm.Shower(QueryData, false, data);
            }
            else
            {
                ShowMsg("请选择要更新的数据");
                return;
            }
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            QueryData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var rows = gridView1.GetSelectedRows();
            if(rows.Count() > 0)
            {
                var data = gridView1.GetRow(rows[0]) as Client;
                var dialog = ShowAffirm("是否要删除选择的数据？", "系统提示");
                if(dialog == DialogResult.OK)
                {
                    clientService.DeleteClient(data);
                    ShowMsg("已删除选定数据");
                    QueryData();
                }
            }
            else
            {
                ShowMsg("请选择要删除的数据");
                return;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var frm = AppContainer.Resove<FrmEditClient>();
            frm.Shower(QueryData, true, null);
        }
    }
}
