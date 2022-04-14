using ConstructionManagement;
using System;
using System.Linq;
using System.Windows.Forms;
using ConstructionManagement.Model;
using ConstructionManagement.Service;

namespace ConstructionManagement.UI
{
    public partial class FrmConstructionQuantity : example
    {
        public FrmConstructionQuantity()
        {
            InitializeComponent();
            quantityService = new ConstructionQuantityService();
        }
        ConstructionQuantityService quantityService;   
        public ConstructionOverallSchedule OverallSchedule { get; set; }

        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConstructionQuantity_Load(object sender, EventArgs e)
        {
            try
            {
                if (CurrentUser.Authorities.Contains("B10101"))
                {
                    btnAdd.Enabled = true;
                }
                else
                {
                    btnAdd.Enabled = false;
                }

                if (CurrentUser.Authorities.Contains("B10102"))
                {
                    btnUpdate.Enabled = true;
                }
                else
                {
                    btnUpdate.Enabled = false;
                }

                if (CurrentUser.Authorities.Contains("B10103"))
                {
                    btnDel.Enabled = true;
                }
                else
                {
                    btnDel.Enabled = false;
                }


                dgvQuantity.DataBindingComplete += DgvQuantity_DataBindingComplete;
                InitialData();   
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void DgvQuantity_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           foreach(DataGridViewRow row in dgvQuantity.Rows)
            {
                row.HeaderCell.Value += (row.Index + 1).ToString();
            }
        }

        private void InitialData()
        {
            try
            {
                var result = quantityService.GetConstructionQuantity(OverallSchedule.ID);
                var r = Helper.GetSortableBindingList<ConstructionQuantity>(result);
                if (result.Count() == 0)
                {
                    dgvQuantity.DataSource = null;
                    return;
                }            
                dgvQuantity.DataSource = r;
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        /// <summary>
        /// 新增施工汇总header数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditConstructionQuantity frmEditQuantity = new FrmEditConstructionQuantity();
                frmEditQuantity.OverallSchedule = OverallSchedule;
                frmEditQuantity.IsAdd = true;
                frmEditQuantity.QuantityCallBack += InitialData;
                frmEditQuantity.ShowDialog();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        /// <summary>
        /// 修改选中的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvQuantity.DataSource == null) return;
                var rows = dgvQuantity.SelectedRows;
                if(rows.Count > 0)
                {
                    var quantity = rows[0].DataBoundItem as ConstructionQuantity;
                    FrmEditConstructionQuantity frmEditQuantity = new FrmEditConstructionQuantity();
                    frmEditQuantity.OverallSchedule = OverallSchedule;
                    frmEditQuantity.Quantity = quantity;
                    frmEditQuantity.IsAdd = false;
                    frmEditQuantity.QuantityCallBack += InitialData;
                    frmEditQuantity.ShowDialog();
                }
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        /// <summary>
        /// 删除明细数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvQuantity.DataSource == null) return;

                var rows = dgvQuantity.SelectedRows;
                if (rows.Count > 0)
                {
                    var quantity = rows[0].DataBoundItem as ConstructionQuantity;
                    
                    if(ShowAffirm("是否确认删除信息") == DialogResult.OK)
                    {
                        quantityService.DelQuantity(quantity);
                        ShowMsg("删除成功");
                    }
                }
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitialData();
        }

        private void dgvQuantity_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0 && dgvQuantity.Columns["itemNameDataGridViewTextBoxColumn"].Index == e.ColumnIndex)
                {
                    if (!CurrentUser.Authorities.Contains("B10104"))
                    {
                        ShowMsg("无权浏览施工子项，请联系系统管理员");
                        return;
                    }
                    var quantity = dgvQuantity.Rows[e.RowIndex].DataBoundItem as ConstructionQuantity;
                    FrmSubItem frmSubItem = new FrmSubItem();
                    frmSubItem.ConstructionQuantity = quantity;
                    frmSubItem.SubItemCallBack += InitialData;
                    frmSubItem.ShowDialog();
                }
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
    }
}
