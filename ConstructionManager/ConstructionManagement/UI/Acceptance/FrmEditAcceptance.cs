using System;
using System.Windows.Forms;
using ConstructionManagement.Model;
using ConstructionManagement.Service;

namespace ConstructionManagement.UI
{
    public partial class FrmEditAcceptance : example
    {
        public FrmEditAcceptance()
        {
            InitializeComponent();

            acceptanceService = new AcceptanceService();
        }
        private AcceptanceService acceptanceService;
        public Acceptance Acceptance { get; set; }
        public ProjectKindEnum ProjectKind { get; set; }
        public bool IsAdd { get; set; }
        public delegate void EditAcceptanceRefresh();
        public event EditAcceptanceRefresh EditAcceptanceCallBack;

        private ConstructionNodeService nodeService = new ConstructionNodeService();
        /// <summary>
        /// 提交修改数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var projectNo = cbConstructionCode.SelectedValue?.ToString();
                var projectName = cbConstructionName.Text?.ToString();
                var itemName = txtItemName.Text.Trim();
                var feature = txtFeature.Text.Trim();
                var unit = txtUnit.Text.Trim();
                var remark = txtRemark1.Text.Trim();
                var remark2 = txtRemark2.Text.Trim();
                var remark3 = txtRemark3.Text.Trim();
                var question = txtQuestion.Text.Trim();
                var description = txtDescription.Text.Trim();
                var rectify = txtRectify.Text.Trim();

                if (string.IsNullOrEmpty(itemName))
                {
                    ShowMsg("请输入子目名称");
                }

                var acceptance = new Acceptance
                {
                    ProjectNo = projectNo,
                    ProjectName = projectName,
                    ProjectKind = ProjectKind,
                    ItemName = itemName,
                    ItemFeature = feature,
                    ItemUnit = unit,
                    Remark1 = remark,
                    Remark2 = remark2,
                    Remark3 = remark3,
                    Question = question,
                    Description = description,
                    Rectify = rectify
                };

                if (IsAdd)
                {
                    acceptanceService.AddAcceptance(acceptance);
                }
                else
                {
                    acceptance.ID = Acceptance.ID;
                    acceptanceService.UpdateAcceptance(acceptance);
                }
                ShowMsg("成功提交数据");
                EditAcceptanceCallBack?.Invoke();
                Close();
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void FrmEditAcceptance_Load(object sender, EventArgs e)
        {
            try
            {

                var nodes = nodeService.GetConstructionNodes();
                cbConstructionName.DataSource = nodes;
                cbConstructionName.DisplayMember = "Name";
                cbConstructionName.ValueMember = "ConstructionNo";
                cbConstructionName.SelectedIndex = -1;

                cbConstructionCode.DataSource = nodes;
                cbConstructionCode.DisplayMember = "ConstructionNo";
                cbConstructionCode.ValueMember = "ConstructionNo";
                cbConstructionCode.SelectedIndex = -1;

                if (ProjectKind == ProjectKindEnum.Middle)
                {
                    Text = "中间验收-项目编辑";
                }
                else
                {
                    Text = "竣工验收-项目编辑";
                }
                    
                if(!IsAdd)
                {
                    var tmp = Acceptance;
                    cbConstructionName.SelectedValue = tmp.ProjectNo;
                    cbConstructionCode.SelectedValue = tmp.ProjectNo;
                    txtItemName.Text = tmp.ItemName;
                    txtFeature.Text = tmp.ItemFeature;
                    txtUnit.Text = tmp.ItemUnit;
                    txtRemark1.Text = tmp.Remark1;
                    txtRemark2.Text = tmp.Remark2;
                    txtRemark3.Text = tmp.Remark3;
                    txtQuestion.Text = tmp.Question;
                    txtDescription.Text = tmp.Description;
                    txtRectify.Text = tmp.Rectify;
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbConstructionName_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                var code = cbConstructionName.SelectedValue?.ToString();
                if (!string.IsNullOrEmpty(code))
                {
                    cbConstructionCode.SelectedValue = code;
                }
                else
                {
                    cbConstructionCode.SelectedIndex = -1;
                }
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
    }
}
