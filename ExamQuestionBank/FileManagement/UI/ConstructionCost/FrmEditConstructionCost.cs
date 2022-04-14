using DevExpress.XtraEditors.DXErrorProvider;
using FileManagement.Model;
using FileManagement.Service.BaseService;
using FileManagement.Service.DataService;
using FileManagement.UI.BaseControl;
using System;

namespace FileManagement.UI
{
    public partial class FrmEditConstructionCost : FormDialog
    {
        public FrmEditConstructionCost(ConstructionCostService service, ProjectContractService contractService)
        {
            InitializeComponent();
            this.service = service;
            this.contractService = contractService;
        }
        private ConstructionCost constructionCost = new ConstructionCost();
        private bool isAdd = true;
        private readonly ConstructionCostService service;
        private readonly ProjectContractService contractService;
        private Action callBack;
        private void FrmEditConstructionCost_Load(object sender, EventArgs e)
        {
            InitialUI();
            InitialValidationRule();
        }

        Type type = typeof(ConstructionCost);
        private void InitialUI()
        {
            editPanel1.labelControl1.Text = "工程编号";
            editPanel2.labelControl1.Text = "工程名称";
            editPanel3.labelControl1.Text = "总造价";
            editPanel4.labelControl1.Text = "设计费";
            editPanel5.labelControl1.Text = "监理费";
            editPanel6.labelControl1.Text = "试验费及检验费";
            editPanel7.labelControl1.Text = "安装工程费";
            editPanel8.labelControl1.Text = "建筑工程";
            editPanel9.labelControl1.Text = "安全文明施工费";
            editPanel10.labelControl1.Text = "其他";
            editPanel11.labelControl1.Text = "预算监理费";
            editPanel12.labelControl1.Text = "分包费";
            editPanel13.labelControl1.Text = "送审价";
            editPanel14.labelControl1.Text = "审定价";
            editPanel15.labelControl1.Text = "税率";
            editPanel16.labelControl1.Text = "管理费点";
            editPanel17.labelControl1.Text = "管理费";
            editPanel18.labelControl1.Text = "劳务";
            editPanel19.labelControl1.Text = "审定试验费及检验费";
            editPanel20.labelControl1.Text = "材料费用";
            editPanel21.labelControl1.Text = "材料税";
            editPanel22.labelControl1.Text = "日常开支费用";
            editPanel23.labelControl1.Text = "利润";


            editPanel1.textEdit1.Text = constructionCost.PROJECT_NUMBER;
            editPanel2.textEdit1.Text = constructionCost.PROJECT_NAME;
            editPanel3.textEdit1.Text = constructionCost.TOTAL_COST.ToString();
            editPanel4.textEdit1.Text = constructionCost.DESIGN_COST.ToString();
            editPanel5.textEdit1.Text = constructionCost.SUPERVISOR_COST.ToString();
            editPanel6.textEdit1.Text = constructionCost.EXPERIMENT_COST.ToString();
            editPanel7.textEdit1.Text = constructionCost.INSTALLATION_COST.ToString();
            editPanel8.textEdit1.Text = constructionCost.CONSTRUCTION_COST.ToString();
            editPanel9.textEdit1.Text = constructionCost.SAFE_CIVILIZED_COST.ToString();
            editPanel10.textEdit1.Text = constructionCost.OTHER_COST.ToString();
            editPanel11.textEdit1.Text = constructionCost.BUDGET_CONSTRUCTION_COST.ToString();
            editPanel12.textEdit1.Text = constructionCost.SUBCONTRACT_COST.ToString();
            editPanel13.textEdit1.Text = constructionCost.REVIEW_COST.ToString();
            editPanel14.textEdit1.Text = constructionCost.APPROVED_COST.ToString();
            editPanel15.textEdit1.Text = constructionCost.RATE;
            editPanel16.textEdit1.Text = constructionCost.MANAGEMENT_COST_RATE;
            editPanel17.textEdit1.Text = constructionCost.MANAGEMENT_COST.ToString();
            editPanel18.textEdit1.Text = constructionCost.LABOR_COST.ToString();
            editPanel19.textEdit1.Text = constructionCost.INSPECTION_COST.ToString();
            editPanel20.textEdit1.Text = constructionCost.MATERIAL_COST.ToString();
            editPanel21.textEdit1.Text = constructionCost.MATERIAL_TAX.ToString();
            editPanel22.textEdit1.Text = constructionCost.GENERAL_COST.ToString();
            editPanel23.textEdit1.Text = constructionCost.PROFIT.ToString();

        }

        private void InitialValidationRule()
        {
            var rule1 = new ConditionValidationRule();
            rule1.ConditionOperator = ConditionOperator.IsNotBlank;
            rule1.ErrorText = "值不能为空";
            var num = new CustomNumberValidationRule();
            num.ErrorText = "请输入数字";

            dxValidationProvider1.SetValidationRule(editPanel1.textEdit1, rule1);
            dxValidationProvider1.SetValidationRule(editPanel2.textEdit1, rule1);

        }
        public override void Shower(Action action,bool isAdd, object content)
        {
            this.isAdd = isAdd;
            if (!isAdd)
            {
                this.constructionCost = (ConstructionCost)content;
            }
            callBack = action;
            this.ShowDialog();
        }

        /// <summary>
        /// 提交数据请求
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(!dxValidationProvider1.Validate())
                return;

            constructionCost.PROJECT_NUMBER = editPanel1.textEdit1.Text.Trim();
            constructionCost.PROJECT_NAME = editPanel2.textEdit1.Text.Trim();
            constructionCost.TOTAL_COST = Convert.ToDecimal(editPanel3.textEdit1.Text.Trim());
            constructionCost.DESIGN_COST = Convert.ToDecimal(editPanel4.textEdit1.Text.Trim());
            constructionCost.SUPERVISOR_COST = Convert.ToDecimal(editPanel5.textEdit1.Text.Trim());
            constructionCost.EXPERIMENT_COST = Convert.ToDecimal(editPanel6.textEdit1.Text.Trim());
            constructionCost.INSTALLATION_COST = Convert.ToDecimal(editPanel7.textEdit1.Text.Trim());
            constructionCost.CONSTRUCTION_COST = Convert.ToDecimal(editPanel8.textEdit1.Text.Trim());
            constructionCost.SAFE_CIVILIZED_COST = Convert.ToDecimal(editPanel9.textEdit1.Text.Trim());
            constructionCost.OTHER_COST = Convert.ToDecimal(editPanel10.textEdit1.Text.Trim());
            constructionCost.BUDGET_CONSTRUCTION_COST = Convert.ToDecimal(editPanel11.textEdit1.Text.Trim());
            constructionCost.SUBCONTRACT_COST = Convert.ToDecimal(editPanel12.textEdit1.Text.Trim());
            constructionCost.REVIEW_COST = Convert.ToDecimal(editPanel13.textEdit1.Text.Trim());
            constructionCost.APPROVED_COST = Convert.ToDecimal(editPanel14.textEdit1.Text.Trim());
            constructionCost.RATE = editPanel15.textEdit1.Text.Trim();
            constructionCost.MANAGEMENT_COST_RATE = editPanel16.textEdit1.Text.Trim();
            constructionCost.MANAGEMENT_COST = Convert.ToDecimal(editPanel17.textEdit1.Text.Trim());
            constructionCost.LABOR_COST = Convert.ToDecimal(editPanel18.textEdit1.Text.Trim());
            constructionCost.INSPECTION_COST = Convert.ToDecimal(editPanel19.textEdit1.Text.Trim());
            constructionCost.MATERIAL_COST = Convert.ToDecimal(editPanel20.textEdit1.Text.Trim());
            constructionCost.MATERIAL_TAX = Convert.ToDecimal(editPanel21.textEdit1.Text.Trim());
            constructionCost.GENERAL_COST = Convert.ToDecimal(editPanel22.textEdit1.Text.Trim());
            constructionCost.PROFIT = Convert.ToDecimal(editPanel23.textEdit1.Text.Trim());

            if (isAdd)
            {
                var projectId = contractService.GetProjectContractId(constructionCost.PROJECT_NUMBER);
                constructionCost.ID = projectId;
                service.AddConstructionCost(constructionCost);
            }
            else
            {
                service.UpdateConstructionCost(constructionCost);
            }
            ShowMsg("提交成功");
            callBack?.Invoke();
            Close();
        }
    }
}
