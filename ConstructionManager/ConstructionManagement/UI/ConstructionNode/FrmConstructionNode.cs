using ConstructionManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ConstructionManagement.Model;
using ConstructionManagement.Service;
using ConstructionManagement.UI;

namespace ConstructionManagement.UI
{
    public partial class FrmConstructionNode : example
    {
        /// <summary>
        /// 施工节点窗口
        /// </summary>
        public FrmConstructionNode()
        {
            InitializeComponent();

            nodeService = new ConstructionNodeService();
        }
        ConstructionNodeService nodeService;

        /// <summary>
        /// 刷新数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                InitialData();
            }catch(Exception ex)
            {
                ShowMsg("系统异常：\n" + ex.Message);
            }
        }

        private void InitialData()
        {
            var result = nodeService.GetConstructionNodes();
            var r = Helper.GetSortableBindingList<ConstructionNode>(result);
            dgvConstruction.DataSource = r;
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
                FrmEditConstructionNode frmEdit = new FrmEditConstructionNode();
                frmEdit.IsAdd = true;
                frmEdit.CallBack += InitialData;
                frmEdit.ShowDialog();
            }
            catch (Exception ex)
            {
                ShowMsg("系统异常:\n" + ex.Message);
            }
        }

        /// <summary>
        /// 更新选择的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var result = dgvConstruction.SelectedRows.Count;
                var rows = dgvConstruction.SelectedRows;
                if (result > 0)
                {
                    var node = rows[0].DataBoundItem as ConstructionNode;
                    FrmEditConstructionNode frmEditNode = new FrmEditConstructionNode();
                    frmEditNode.IsAdd = false;
                    frmEditNode.Node = node;
                    frmEditNode.CallBack += InitialData;
                    frmEditNode.ShowDialog();
                }
                else
                {
                    ShowMsg("请选择要编辑的数据");
                }
            }catch(Exception ex)
            {
                ShowMsg("系统异常：\n" + ex.Message);
            }
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConstructionNode_Load(object sender, EventArgs e)
        {
            try
            {
                if (CurrentUser.Authorities.Contains("A10101"))
                {
                    btnAdd.Enabled = true;
                }
                else
                {
                    btnAdd.Enabled = false;
                }
                if (CurrentUser.Authorities.Contains("A10102"))
                {
                    btnUpdate.Enabled = true;
                }
                else
                {
                    btnUpdate.Enabled = false;
                }
                if (CurrentUser.Authorities.Contains("A10103"))
                {
                    btnDel.Enabled = true;
                }
                else
                {
                    btnDel.Enabled = false;
                }

                dgvConstruction.DataBindingComplete += DgvConstruction_DataBindingComplete;
                InitialData();               
            }
            catch(Exception ex)
            {
                ShowMsg("系统异常:\n" + ex.Message);
            }
        }

        private void DgvConstruction_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvConstruction.Rows)
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString();
                }
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }


        /// <summary>
        /// 查看开工审批附件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvConstruction_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgvConstruction.Columns["fileBeforeConstructionDataGridViewTextBoxColumn"].Index == e.ColumnIndex)
                {
                    if (!CurrentUser.Authorities.Contains("A10105"))
                    {
                        ShowMsg("无权浏览开工日期附件，请联系系统管理员");
                        return;
                    }
                    var node = dgvConstruction.Rows[e.RowIndex].DataBoundItem as ConstructionNode;
                    FrmUploadFile frmUpload = new FrmUploadFile();
                    frmUpload.ConstructionField = "施工前附件";
                    frmUpload.ConstructionNode = node;
                    frmUpload.ShowDialog();
                }

                if (e.RowIndex >= 0 && dgvConstruction.Columns["constructionPlanDataGridViewTextBoxColumn"].Index == e.ColumnIndex)
                {
                    if (!CurrentUser.Authorities.Contains("A10106"))
                    {
                        ShowMsg("无权浏览开工日期附件，请联系系统管理员");
                        return;
                    }
                    var node = dgvConstruction.Rows[e.RowIndex].DataBoundItem as ConstructionNode;
                    FrmConstructionPlan constructionPlan = new FrmConstructionPlan();
                    constructionPlan.Node = node;
                    constructionPlan.ShowDialog();
                }

                if (e.RowIndex >= 0 && dgvConstruction.Columns["constructionStartDataGridViewTextBoxColumn"].Index == e.ColumnIndex)
                {
                    if (!CurrentUser.Authorities.Contains("A10104"))
                    {
                        ShowMsg("无权浏览开工日期附件，请联系系统管理员");
                        return;
                    }
                    var node = dgvConstruction.Rows[e.RowIndex].DataBoundItem as ConstructionNode;
                    FrmUploadFile frmUpload = new FrmUploadFile();
                    frmUpload.ConstructionField = "开工日期";
                    frmUpload.ConstructionNode = node;
                    frmUpload.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dgvConstruction.SelectedRows;
                if(rows.Count > 0)
                {
                    var node = rows[0].DataBoundItem as ConstructionNode;
                    var dialog = ShowAffirm("是否删除所选项目？该操作将会删除该项目所有相关信息");
                    if(dialog == DialogResult.OK)
                    {
                        nodeService.DelConstructionNode(node);
                        ShowMsg("删除成功");
                        InitialData();
                    }                   
                }
                else
                {
                    ShowMsg("请选择要删除的数据");
                }
                
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
    }
}
