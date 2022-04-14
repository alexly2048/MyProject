using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using FileManagement.Model;
using FileManagement.Service;
using FileManagement.Service.DataService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManagement.UI
{
    public partial class FrmContract : FrmBase
    {
        public FrmContract(ProjectContractService service)
        {
            InitializeComponent();

            contractService = service;
        }
        private readonly ProjectContractService contractService;
        /// <summary>
        /// 双击行事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hitInfo = gridView1.CalcHitInfo(new Point(e.X, e.Y));
            if(e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                if (hitInfo.InRowCell && hitInfo.Column.Name.Equals("colAPPENDIX_FILE"))
                {
                    ShowMsg(hitInfo.Column.Name);
                }
            }
        }
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            QueryData();
        }

        private void QueryData()
        {
            var keyword = textEdit1.Text.Trim();
            var contracts = contractService.GetProjectContracts(keyword);
            contractSource.DataSource = contracts;
        }

        private void FrmContract_Load(object sender, EventArgs e)
        {
            gridView1.CustomDrawRowIndicator += (s,arg)=> GridView_CustomDrawRowIndicator_Event(s,arg);
            gridView1.TopRowChanged += (s, arg) => TopRowChanged_Event(s, arg);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var editFrm = AppContainer.Resove<FrmEditProjectContract>();
            editFrm.Shower(QueryData,true, null);
        }
        /// <summary>
        /// 修改选中的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var index = gridView1.GetSelectedRows();
            if (index.Any())
            {
                var data = gridView1.GetRow(index[0]) as ProjectContract;
                var editFrm = AppContainer.Resove<FrmEditProjectContract>();
                editFrm.Shower(QueryData,false, data);
            }
            else
            {
                ShowMsg("请选择要编辑的数据");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var index = gridView1.GetSelectedRows();
            if (index.Any())
            {
                var data = gridView1.GetRow(index[0]) as ProjectContract;
                contractService.DeleteProjectContract(data);
            }
            else
            {
                ShowMsg("请选择要删除的数据");
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var view = sender as GridView;
            var ea = e as MouseEventArgs;
            var hitInfo = view.CalcHitInfo(ea.Location);
            if(ea.Button == MouseButtons.Left && hitInfo.InRowCell && hitInfo.Column.Name.Equals("colAPPENDIX_FILE"))
            {
                
            }
        }
    }
}
