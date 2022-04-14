using System;
using ConstructionManagement.Model;
using ConstructionManagement.Service;

namespace ConstructionManagement.UI
{
    public partial class FrmEditConstructionQuantity : example
    {
        public FrmEditConstructionQuantity()
        {
            InitializeComponent();

            quantityService = new ConstructionQuantityService();
        }
        private ConstructionQuantityService quantityService;
        public ConstructionQuantity Quantity { get; set; }
        public ConstructionOverallSchedule OverallSchedule { get; set; }
        public bool IsAdd { get; set; }
        public delegate void EditQuantityCallBack();
        public event EditQuantityCallBack QuantityCallBack;
        /// <summary>
        /// 提交用户修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var constructionNo = txtConstructionNo.Text.Trim();
                var itemName = txtItemName.Text.Trim();
                var feature = txtFeature.Text.Trim();
                var unit = txtUnit.Text.Trim();
                var designNum = txtDesignNum.Text.Trim();
                var modifyNum = txtModify.Text.Trim();
                var overall = txtOverall.Text.Trim();
                var reminder = txtReminder.Text.Trim();

                if (string.IsNullOrEmpty(constructionNo))
                {
                    ShowMsg("请输入项目编码");
                    return;
                }
                if (string.IsNullOrEmpty(itemName))
                {
                    ShowMsg("请输入子目名称");
                    return;
                }
                if (string.IsNullOrEmpty(designNum))
                {
                    ShowMsg("请输入设计总量");
                    return;
                }
                if (string.IsNullOrEmpty(modifyNum))
                {
                    modifyNum = "0";
                }

                if (!IsDecimal(designNum))
                {
                    ShowMsg("设计数量为整数");
                    return;
                }
                if (!IsDecimal(modifyNum))
                {
                    ShowMsg("变更数量必须为整数");
                    return;
                }

                var quantity = new ConstructionQuantity
                {
                    ConstructionNo = constructionNo,
                    ItemName = itemName,
                    ItemFeature = feature,
                    ItemUnit = unit,
                    DesignNum = designNum,
                    ModifyNum = modifyNum,
                    AllOfProcess = overall,
                    Reminder = reminder,
                    ParentId = OverallSchedule.ID
                };

                if (IsAdd)
                {
                    quantityService.AddConstructionQuantity(quantity);
                }
                else
                {
                    quantity.ID = Quantity.ID;
                    quantityService.UpdateConstructionQuantity(quantity);
                }
                ShowMsg("保存成功");
                QuantityCallBack?.Invoke();
                Close();
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEditConstructionQuantity_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsAdd)
                {
                    txtConstructionNo.Text = OverallSchedule.ProjectCode;
                }
                else
                {
                    txtConstructionNo.Text = Quantity.ConstructionNo;
                    txtItemName.Text = Quantity.ItemName;
                    txtFeature.Text = Quantity.ItemFeature;
                    txtUnit.Text = Quantity.ItemUnit;
                    txtDesignNum.Text = Quantity.DesignNum;
                    txtModify.Text = Quantity.ModifyNum;
                    txtOverall.Text = Quantity.AllOfProcess;
                    txtReminder.Text = Quantity.Reminder;
                }
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private bool IsDecimal(string input)
        {
            decimal r = 0;
            if(decimal.TryParse(input,out r))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
