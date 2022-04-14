using System;
using ConstructionManagement.Model;
using ConstructionManagement.Service;

namespace ConstructionManagement.UI
{
    public partial class FrmEditPlan : example
    {
        public FrmEditPlan()
        {
            InitializeComponent();
            planService = new ConstructionPlanService();
        }
        ConstructionPlanService planService;
        public delegate void RefreshCallBack();
        public event RefreshCallBack CallBack;
        public ConstructionPlanModel PlanModel { get; set; }
        public ConstructionNode Node { get; set; }
        public bool IsAdd { get; set; }
        /// <summary>
        /// 提交修改数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var planDate = dtPlanDate.Value.ToString("yyyy-MM-dd");
                var item = txtItem.Text.Trim();
                var part = txtPart.Text.Trim();
                var civilWorks = txtCivilWorks.Text.Trim();
                var numOfPerson = txtPersons.Text.Trim();
                var leader = txtLeader.Text.Trim();
                var method = rtbMethod.Text.Trim();
                var remark = txtRemark.Text.Trim();

                if (string.IsNullOrEmpty(item))
                {
                    ShowMsg("请输入施工项目名称");
                    return;
                }
                if (string.IsNullOrEmpty(part))
                {
                    ShowMsg("请输入施工部位名称");
                    return;
                }
                var plan = new ConstructionPlanModel
                {
                    PlanDate = planDate,
                    ParentId = Node.ID,
                    ConstructionNo = Node.ConstructionNo,
                    ConstructionItem = item,
                    ConstructionPart = part,
                    CivilWorks = civilWorks,
                    NumOfPerson = numOfPerson,
                    Leader = leader,
                    ConstructionMethod = method,
                    Remark = remark
                };
                if (IsAdd)
                {
                    planService.AddConstructionPlan(plan);
                }
                else
                {
                    plan.ID = PlanModel.ID;
                    planService.UpdateConstructionPlan(plan);
                }
                ShowMsg("成功提交数据");
                CallBack?.Invoke();
                Close();
            }
            catch (Exception ex)
            {
                ShowMsg("系统异常：\n" + ex.Message);
            }
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEditPlan_Load(object sender, EventArgs e)
        {
            try
            {
                var tmp = PlanModel;
                if (!IsAdd)
                {
                    dtPlanDate.Value = Convert.ToDateTime(tmp.PlanDate);
                    txtItem.Text = tmp.ConstructionItem;
                    txtPart.Text = tmp.ConstructionPart;
                    txtCivilWorks.Text = tmp.CivilWorks;
                    txtPersons.Text = tmp.NumOfPerson;
                    txtLeader.Text = tmp.Leader;
                    rtbMethod.Text = tmp.ConstructionMethod;
                    txtRemark.Text = tmp.Remark;
                }
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
    }
}
