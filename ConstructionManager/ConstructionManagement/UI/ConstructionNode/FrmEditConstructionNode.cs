using System;
using System.Globalization;
using ConstructionManagement.Model;
using ConstructionManagement.Service;

namespace ConstructionManagement.UI
{
    public partial class FrmEditConstructionNode : example
    {
        public FrmEditConstructionNode()
        {
            InitializeComponent();
            nodeService = new ConstructionNodeService();
        }

        public ConstructionNode Node { get; set; }
        public bool IsAdd { get; set; }
        ConstructionNodeService nodeService;
        public delegate void RefreshCallBack();
        public event RefreshCallBack CallBack;
        /// <summary>
        /// 新增或修改施工节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var constructionNo = txtConstructionNo.Text.Trim();
                var name = txtName.Text.Trim();

                var constructionStart = string.Empty;
                var civilConstruction = string.Empty;
                var electricStart = string.Empty;
                var electronicTransfer = string.Empty;
                var powerCut = string.Empty;
                var powerCut2 = string.Empty;
                var powerCut3 = string.Empty;
                var inOperation = string.Empty;
                var beCompleted = string.Empty;
                var closeAccount = string.Empty;
                var sendKnot = string.Empty;
                var archive = string.Empty;
                if (cbConstructionStart.Checked)
                {
                    constructionStart = dtConstructionStart.Value.ToString("yyyy-MM-dd");
                }
                if (cbCivilConstruction.Checked)
                {
                    civilConstruction = dtCivilConstruction.Value.ToString("yyyy-MM-dd");
                }
                if (cbElectricConstruction.Checked)
                {
                    electricStart = dtElectronicConstruction.Value.ToString("yyyy-MM-dd");
                }
                if (cbElectronicTransfer.Checked)
                {
                    electronicTransfer = dtElectronicTransfer.Value.ToString("yyyy-MM-dd");
                }
                if (cbPowerCut.Checked)
                {
                    powerCut = dtPowerCut.Value.ToString("yyyy-MM-dd");
                }
                if (cbPowerCut2.Checked)
                {
                    powerCut2 = dtPowerCut2.Value.ToString("yyyy-MM-dd");
                }
                if (cbPowerCut3.Checked)
                {
                    powerCut3 = dtPowerCut3.Value.ToString("yyyy-MM-dd");
                }
                if (cbOperation.Checked)
                {
                    inOperation = dtIntoOperation.Value.ToString("yyyy-MM-dd");
                }
                if (cbCompleted.Checked)
                {
                    beCompleted = dtBeCompleted.Value.ToString("yyyy-MM-dd");
                }
                if (cbCloseAccount.Checked)
                {
                    closeAccount = dtCloseAnAccount.Value.ToString("yyyy-MM-dd");
                }
                if (cbSendKnot.Checked)
                {
                    sendKnot = dtSendKnot.Value.ToString("yyyy-MM-dd");
                }
                if (cbArchive.Checked)
                {
                    archive = dtArchive.Value.ToString("yyyy-MM-dd");
                }

                var node = new ConstructionNode
                {
                    ConstructionNo = constructionNo,
                    Name = name,
                    ConstructionStart = constructionStart,
                    CivilConstruction = civilConstruction,
                    ElectricStart = electricStart,
                    ElectronicTransfer = electronicTransfer,
                    PowerCut = powerCut,
                    PowerCut2 = powerCut2,
                    PowerCut3 = powerCut3,
                    InOperation = inOperation,
                    BeCompleted = beCompleted,
                    CloseAnAccount = closeAccount,
                    SendKnot = sendKnot,
                    Archive = archive
                };


                if (IsAdd)
                {
                    nodeService.AddNode(node);
                }
                else
                {
                    node.ID = Node.ID;
                    nodeService.UpdateNode(node);
                }
                ShowMsg("编辑成功");
                CallBack?.Invoke();
                Close();

            }
            catch (Exception ex)
            {
                ShowMsg("系统异常\n" + ex.Message);
            }
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEditConstructionNode_Load(object sender, EventArgs e)
        {
            try
            {
                var node = Node;

                if (!IsAdd)
                {
                    txtConstructionNo.ReadOnly = true;
                    txtConstructionNo.Text = Node.ConstructionNo;
                    txtName.Text = Node.Name;
                    if (!string.IsNullOrEmpty(node.ConstructionStart))
                    {
                        dtConstructionStart.Value = Convert.ToDateTime(Node.ConstructionStart);
                        cbConstructionStart.Checked = true;
                    }
                    if (!string.IsNullOrEmpty(node.CivilConstruction))
                    {
                        dtCivilConstruction.Value = Convert.ToDateTime(Node.CivilConstruction);
                        cbCivilConstruction.Checked = true;
                    }
                    if (!string.IsNullOrEmpty(node.ElectricStart))
                    {
                        dtElectronicConstruction.Value = Convert.ToDateTime(Node.ElectricStart);
                        cbElectricConstruction.Checked = true;
                    }
                    if (!string.IsNullOrEmpty(node.ElectronicTransfer))
                    {
                        dtElectronicTransfer.Value = Convert.ToDateTime(Node.ElectronicTransfer);
                        cbElectronicTransfer.Checked = true;
                    }
                    if (!string.IsNullOrEmpty(node.PowerCut))
                    {
                        dtPowerCut.Value = Convert.ToDateTime(Node.PowerCut);
                        cbPowerCut.Checked = true;
                    }
                    if (!string.IsNullOrEmpty(node.PowerCut2))
                    {
                        dtPowerCut2.Value = Convert.ToDateTime(Node.PowerCut2);
                        cbPowerCut2.Checked = true;
                    }
                    if (!string.IsNullOrEmpty(node.PowerCut3))
                    {
                        dtPowerCut3.Value = Convert.ToDateTime(Node.PowerCut3);
                        cbPowerCut3.Checked = true;
                    }
                    if (!string.IsNullOrEmpty(node.InOperation))
                    {
                        dtIntoOperation.Value = Convert.ToDateTime(Node.InOperation);
                        cbOperation.Checked = true;
                    }
                    if (!string.IsNullOrEmpty(node.BeCompleted))
                    {
                        dtBeCompleted.Value = Convert.ToDateTime(Node.BeCompleted);
                        cbCompleted.Checked = true;
                    }
                    if (!string.IsNullOrEmpty(node.CloseAnAccount))
                    {
                        dtCloseAnAccount.Value = Convert.ToDateTime(Node.CloseAnAccount);
                        cbCloseAccount.Checked = true;
                    }
                    if (!string.IsNullOrEmpty(node.SendKnot))
                    {
                        dtSendKnot.Value = Convert.ToDateTime(Node.SendKnot);
                        cbSendKnot.Checked = true;
                    }
                    if (!string.IsNullOrEmpty(node.Archive))
                    {
                        dtArchive.Value = Convert.ToDateTime(Node.Archive);
                        cbArchive.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMsg("系统异常:\n" + ex.Message);
            }
        }


        private DateTime TryParseTime(string datetime)
        {
            try
            {
                var tmp = datetime;
                var format = "yyyyMMdd";
                var result = DateTime.Now;
                if (DateTime.TryParseExact(tmp, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
                {
                    return result;
                }
                else
                {
                    throw new Exception("日期转换失败");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
