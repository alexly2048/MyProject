using DevExpress.XtraEditors.DXErrorProvider;
using FileManagement.Model;
using FileManagement.Service.BaseService;
using FileManagement.Service.DataService;
using System;

namespace FileManagement.UI
{
    public partial class FrmEditCurrentExpense : FormDialog
    {
        public FrmEditCurrentExpense(CurrentExpenseService service)
        {
            InitializeComponent();
            this.service = service;
        }
        private CurrentExpenseService service;
        private bool isAdd = false;
        private CurrentExpense currentExpense = new CurrentExpense();
        private Action callBack;
        private void FrmEditCurrentExpense_Load(object sender, EventArgs e)
        {
            InitialUI();
            InitialValidation();
        }

        private void InitialUI()
        {
            editPanel1.labelControl1.Text = "项目";
            editPanel2.labelControl1.Text = "原由";
            editPanel3.labelControl1.Text = "类别";
            editPanel4.labelControl1.Text = "单位";
            editPanel5.labelControl1.Text = "数量";
            editPanel6.labelControl1.Text = "单价";
            editPanel7.labelControl1.Text = "合价";
            editPanel8.labelControl1.Text = "备注";

            if (!isAdd)
            {
                editPanel1.textEdit1.Text = currentExpense.ITEM_NAME;
                editPanel2.textEdit1.Text = currentExpense.REASON;
                editPanel3.textEdit1.Text = currentExpense.CATEGORY;
                editPanel4.textEdit1.Text = currentExpense.UNIT;
                editPanel5.textEdit1.Text = currentExpense.QUANTITY.ToString();
                editPanel6.textEdit1.Text = currentExpense.PRICE.ToString();
                editPanel7.textEdit1.Text = currentExpense.MONEY.ToString();
                editPanel8.textEdit1.Text = currentExpense.REMARK;
            }
        }

        private void InitialValidation()
        {
            ConditionValidationRule empty = new ConditionValidationRule();
            empty.ConditionOperator = ConditionOperator.IsNotBlank;
            empty.ErrorText = "值不能为空";

            CustomNumberValidationRule numRule = new CustomNumberValidationRule();
            numRule.ErrorText = "请输入数字";

            dxValidationProvider1.SetValidationRule(editPanel1.textEdit1, empty);
            dxValidationProvider1.SetValidationRule(editPanel4.textEdit1, empty);
            dxValidationProvider1.SetValidationRule(editPanel5.textEdit1, numRule);
            dxValidationProvider1.SetValidationRule(editPanel6.textEdit1, numRule);
            dxValidationProvider1.SetValidationRule(editPanel7.textEdit1, numRule);
        }

        public override void Shower(Action action, bool isAdd, object content)
        {
            base.Shower(action, isAdd, content);
            this.callBack = action;
            this.isAdd = isAdd;
            this.currentExpense =(CurrentExpense)content;
            ShowDialog();
        }
        /// <summary>
        /// 提交数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;

            currentExpense.ITEM_NAME = editPanel1.textEdit1.Text;
            currentExpense.REASON = editPanel2.textEdit1.Text;
            currentExpense.CATEGORY = editPanel3.textEdit1.Text;
            currentExpense.UNIT = editPanel4.textEdit1.Text;
            currentExpense.QUANTITY = Convert.ToDecimal(editPanel5.textEdit1.Text);
            currentExpense.PRICE = Convert.ToDecimal(editPanel6.textEdit1.Text);
            currentExpense.MONEY = Convert.ToDecimal(editPanel7.textEdit1.Text);
            currentExpense.REMARK = editPanel8.textEdit1.Text;

            if (isAdd)
            {
                service.AddCurrentExpense(currentExpense);
            }
            else
            {
                service.UpdateCurrentExpense(currentExpense);
            }
            ShowMsg("提交成功");
            callBack?.Invoke();
            Close();
        }
    }
}
