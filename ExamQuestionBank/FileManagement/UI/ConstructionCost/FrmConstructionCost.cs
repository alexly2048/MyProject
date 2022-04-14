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
    public partial class FrmConstructionCost : FrmBase
    {
        public FrmConstructionCost(ConstructionCostService service)
        {
            InitializeComponent();
            this.service = service;
        }
        private readonly ConstructionCostService service;
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConstructionCost_Load(object sender, EventArgs e)
        {
            gridView1.TopRowChanged +=(s,arg)=> TopRowChanged_Event(s,arg);
            gridView1.CustomDrawRowIndicator += (s,arg)=> GridView_CustomDrawRowIndicator_Event(s,arg);
            buttonPanel1.btnAdd.Click += BtnAdd_Click;
            buttonPanel1.btnQuery.Click += BtnQuery_Click;
            buttonPanel1.btnDelete.Click += BtnDelete_Click;
            buttonPanel1.btnUpdate.Click += BtnUpdate_Click;
        }
        /// <summary>
        /// 更新造价
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var row = gridView1.GetSelectedRows();
            if (row.Any())
            {
                var cost = gridView1.GetRow(row[0]) as ConstructionCost;
                var frm = AppContainer.Resove<FrmEditConstructionCost>();
                frm.Shower(QueryData, true, null);
            }
            else
            {
                ShowMsg("请选择要更新的数据");
            }
        }
        /// <summary>
        /// 删除造价
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 查询造价
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            QueryData();
        }
        /// <summary>
        /// 新增造价
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var frm = AppContainer.Resove<FrmEditConstructionCost>();
            frm.Shower(QueryData,true,null);
        }

        private void QueryData()
        {
            var keyword = buttonPanel1.textKeyword.Text.Trim();
            var r = service.GetConstructionCosts(keyword);
            if(!r.Any())
            {
                MessageBox.Show("未查询到任何数据");
            }
            constructionCostSource.DataSource = r;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var view = sender as GridView;
            var arg = e as MouseEventArgs;
            var hitInfo = view.CalcHitInfo(arg.Location);
            if (arg.Button == MouseButtons.Left)
            {
                if (hitInfo.InRowCell && hitInfo.Column.Name.Equals("colGENERAL_COST"))
                {
                    var data = view.GetRow(hitInfo.RowHandle) as ConstructionCost;
                    var frm = AppContainer.Resove<FrmCurrentExpense>();
                    frm.Shower(QueryData, false, data);
                }
            }
        }
    }
}
