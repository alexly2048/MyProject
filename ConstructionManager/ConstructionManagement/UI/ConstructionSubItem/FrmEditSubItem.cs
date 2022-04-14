using System;
using ConstructionManagement.Model;
using ConstructionManagement.Service;

namespace ConstructionManagement.UI
{
    public partial class FrmEditSubItem : example
    {
        public FrmEditSubItem()
        {
            InitializeComponent();

            subItemService = new ConstructionSubItemService();
        }
        ConstructionSubItemService subItemService;
        public ConstructionSubItem SubItem {get; set;}
        public ConstructionQuantity ConstructionQuantity { get; set; }
        public delegate void RefreshCallback();
        public event RefreshCallback CallBack;
        public bool IsAdd { get; set; }
        /// <summary>
        /// 提交修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var itemName = txtItemName.Text.Trim();
                var feature = txtFeature.Text.Trim();
                var unit = txtUnit.Text.Trim();
                var part = txtPart.Text.Trim();
                var workDone = txtWorkDone.Text.Trim();
                var completeDate = dtCompleteDate.Value.ToString("yyyy-MM-dd");

                if (string.IsNullOrEmpty(itemName))
                {
                    ShowMsg("请输入项目名称");
                    return;
                }

                if (string.IsNullOrEmpty(workDone))
                    workDone = "0";
                else
                {
                    double d;
                    if(!double.TryParse(workDone, out d))
                    {
                        ShowMsg("工作完成量应输入数字或为空");
                        return;
                    }
                    
                }

                var subItem = new ConstructionSubItem
                {                    
                    ItemName = itemName,
                    Feature = feature,
                    Unit = unit,
                    Part = part,
                    WorkDone = workDone,
                    DoneDate = completeDate
                };

                if (IsAdd)
                {
                    subItem.ParentId = ConstructionQuantity.ID;
                    subItemService.AddSubItem(subItem);
                }
                else
                {
                    subItem.ID = SubItem.ID;
                    subItem.ParentId = ConstructionQuantity.ID;
                    subItemService.UpdateSubItem(subItem);
                }
                ShowMsg("编辑成功");
                CallBack?.Invoke();
                Close();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEditSubItem_Load(object sender, EventArgs e)
        {
            try
            {
                var tmp = SubItem;
                if(IsAdd)
                {
                    txtItemName.Text = ConstructionQuantity.ItemName;
                    txtFeature.Text = ConstructionQuantity.ItemFeature;
                    txtUnit.Text = ConstructionQuantity.ItemUnit;
                }
                else
                {
                    txtItemName.Text = tmp.ItemName;
                    txtFeature.Text = tmp.Feature;
                    txtUnit.Text = tmp.Unit;
                    txtPart.Text = tmp.Part;
                    txtWorkDone.Text = tmp.WorkDone;
                    dtCompleteDate.Value = DateTime.Parse(tmp.DoneDate);
                }
                txtItemName.ReadOnly = true;
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
                Close();
            }
        }
    }
}
