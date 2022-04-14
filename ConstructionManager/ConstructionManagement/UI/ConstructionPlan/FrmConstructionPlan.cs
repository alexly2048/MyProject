using ConstructionManagement;
using System;
using System.Windows.Forms;
using ConstructionManagement.Model;
using ConstructionManagement.Service;

namespace ConstructionManagement.UI
{
    public partial class FrmConstructionPlan : example
    {
        public FrmConstructionPlan()
        {
            InitializeComponent();

            planService = new ConstructionPlanService();
        }
        ConstructionPlanService planService;
        public ConstructionNode Node { get; set; }

        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConstructionPlan_Load(object sender, EventArgs e)
        {
            try
            {
                if (CurrentUser.Authorities.Contains("A1010601"))
                {
                    btnAdd.Enabled = true;
                }
                else
                {
                    btnAdd.Enabled = false;
                }

                if (CurrentUser.Authorities.Contains("A1010602"))
                {
                    btnUpdate.Enabled = true;
                }
                else
                {
                    btnUpdate.Enabled = false;
                }

                if (CurrentUser.Authorities.Contains("A1010603"))
                {
                    btnDel.Enabled = true;
                }
                else
                {
                    btnDel.Enabled = false;
                }


                dgvPlan.DataBindingComplete += DgvPlan_DataBindingComplete;
                InitialData();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void DgvPlan_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewRow row in dgvPlan.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        private void InitialData()
        {
            var result = planService.QueryByParentId(Node.ID);
            var r = Helper.GetSortableBindingList<ConstructionPlanModel>(result);
            dgvPlan.DataSource = r;
        }

        /// <summary>
        /// 新增施工节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var constructionNo = Node.ConstructionNo;
                FrmEditPlan editPlan = new FrmEditPlan();
                editPlan.Node = Node;
                editPlan.IsAdd = true;
                editPlan.CallBack += InitialData;
                editPlan.ShowDialog();
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        /// <summary>
        /// 更新施工方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var item = dgvPlan.SelectedRows;
                if(item.Count == 0)
                {
                    ShowMsg("请选择要编辑的数据");
                    return;
                }
                var plan = item[0].DataBoundItem as ConstructionPlanModel;
                FrmEditPlan editPlan = new FrmEditPlan();
                editPlan.PlanModel = plan;
                editPlan.IsAdd = false;
                editPlan.Node = Node;
                editPlan.CallBack += InitialData;
                editPlan.ShowDialog();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        /// <summary>
        /// 删除施工计划数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dgvPlan.SelectedRows;
                if(rows.Count == 0)
                {
                    ShowMsg("请选择要删除的数据");
                    return;
                }

                var plan = rows[0].DataBoundItem as ConstructionPlanModel;
                planService.DeletePlan(plan);
                ShowMsg("删除成功");
                InitialData();

            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        /// <summary>
        /// 获取指定ConstructionNode数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                InitialData();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void dgvPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0 && dgvPlan.Columns["constructionMethodDataGridViewTextBoxColumn"].Index == e.ColumnIndex)
                {

                    var tmp = dgvPlan.Rows[e.RowIndex].DataBoundItem as ConstructionPlanModel;
                    FrmConstructionMethod frmMethod = new FrmConstructionMethod();
                    frmMethod.Plan = tmp;
                    frmMethod.CallBack += InitialData;
                    frmMethod.ShowDialog();
                }
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
    }
}
