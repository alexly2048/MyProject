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
    public partial class FrmCurrentExpense : FormDialog
    {
        public FrmCurrentExpense(CurrentExpenseService currentService)
        {
            InitializeComponent();

            this.currentService = currentService;
        }
        private CurrentExpenseService currentService;
        private Action action;
        private void FrmCurrentExpense_Load(object sender, EventArgs e)
        {
            InitialUI();
        }
        private ConstructionCost constructionCost;
        private void InitialUI()
        {
            gridView1.TopRowChanged += TopRowChanged_Event;
            gridView1.CustomDrawRowIndicator += GridView_CustomDrawRowIndicator_Event;

            buttonPanel1.btnAdd.Click += BtnAdd_Click;
            buttonPanel1.btnDelete.Click += BtnDelete_Click;
            buttonPanel1.btnQuery.Click += BtnQuery_Click;
            buttonPanel1.btnUpdate.Click += BtnUpdate_Click;
        }

        private void QueryData()
        {
            var r = currentService.GetCurrentExpenseByParentId(constructionCost.ID);
            currentSource.DataSource = r;
            action?.Invoke();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var rows = gridView1.GetSelectedRows();
            if (rows.Count() > 0)
            {
                var data = gridView1.GetRow(rows[0]) as CurrentExpense;

                var frm = AppContainer.Resove<FrmEditCurrentExpense>();
                frm.Shower(QueryData, false, data);
            }
            else
            {
                ShowMsg("请选择要删除的数据");
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
                var data = gridView1.GetRow(rows[0]) as CurrentExpense;
                var dialog = ShowAffirm("是否删除所选数据？");
                if(dialog == DialogResult.OK)
                {
                    currentService.DeleteCurrentExpense(data);
                    ShowMsg("删除成功");
                    QueryData();
                }
            }
            else
            {
                ShowMsg("请选择要删除的数据");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var frm = AppContainer.Resove<FrmEditCurrentExpense>();
            var current = new CurrentExpense
            {
                PARENT_ID = constructionCost.ID
            };
            frm.Shower(QueryData, true, current);
        }

        public override void Shower(Action action, bool isAdd, object content)
        {
            constructionCost = (ConstructionCost)content;
            this.action = action;
            ShowDialog();
        }
    }
}
