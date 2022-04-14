using ConstructionManagement;
using System;
using System.Windows.Forms;
using ConstructionManagement.Model;
using ConstructionManagement.Service;

namespace ConstructionManagement.UI
{
    public partial class FrmSubItem : example
    {
        public FrmSubItem()
        {
            InitializeComponent();

            subItemService = new ConstructionSubItemService();
        }

        private ConstructionSubItemService subItemService;
        public delegate void ItemCallBack();
        public event ItemCallBack SubItemCallBack;
        /// <summary>
        /// 施工工程量数据
        /// </summary>
        public ConstructionQuantity ConstructionQuantity { get; set; }
        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSubItem_Load(object sender, EventArgs e)
        {
            try
            {
                if (CurrentUser.Authorities.Contains("B1010401"))
                {
                    btnAdd.Enabled = true;
                }
                else
                {
                    btnAdd.Enabled = false;
                }

                if (CurrentUser.Authorities.Contains("B1010402"))
                {
                    btnUpdate.Enabled = true;
                }
                else
                {
                    btnUpdate.Enabled = false;
                }

                if (CurrentUser.Authorities.Contains("B1010403"))
                {
                    btnDel.Enabled = true;
                }
                else
                {
                    btnDel.Enabled = false;
                }

                dgvSubItems.DataBindingComplete += DgvSubItems_DataBindingComplete;
                InitialData();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void DgvSubItems_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewRow row in dgvSubItems.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        private void InitialData()
        {
            var subItems = subItemService.GetSubItemByParentId(ConstructionQuantity.ID);
            var r = Helper.GetSortableBindingList<ConstructionSubItem>(subItems);
            if (subItems == null || subItems.Count == 0)
                return;
            dgvSubItems.DataSource = r;
        }
        /// <summary>
        /// 新增子项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditSubItem editItem = new FrmEditSubItem();
                editItem.ConstructionQuantity = ConstructionQuantity;
                editItem.IsAdd = true;
                editItem.CallBack += InitialData;
                editItem.ShowDialog();
                SubItemCallBack?.Invoke();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
        /// <summary>
        /// 更新子项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dgvSubItems.SelectedRows;
                if(rows.Count > 0)
                {
                    var subItem = rows[0].DataBoundItem as ConstructionSubItem;
                    FrmEditSubItem editItem = new FrmEditSubItem();
                    editItem.ConstructionQuantity = ConstructionQuantity;
                    editItem.SubItem = subItem;
                    editItem.IsAdd = false;
                    editItem.CallBack += InitialData;
                    editItem.ShowDialog();
                    SubItemCallBack?.Invoke();
                }
                else
                {
                    ShowMsg("请选择要编辑的数据行");
                }
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dgvSubItems.SelectedRows;
                if(rows.Count > 0)
                {
                    var subItem = rows[0].DataBoundItem as ConstructionSubItem;
                    subItemService.DelSubItem(subItem);
                    ShowMsg("删除成功");
                    InitialData();
                    SubItemCallBack?.Invoke();
                }
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConstructionQuantity == null)
                {
                    ShowMsg("未指定施工项目");
                    return;
                }
                InitialData();
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void dgvSubItems_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0 && dgvSubItems.Columns["appendixImagesDataGridViewTextBoxColumn"].Index == e.ColumnIndex)
                {
                    if (!CurrentUser.Authorities.Contains("B1010404"))
                    {
                        ShowMsg("无权浏览附件图片，请联系系统管理员");
                        return;
                    }
                    var subItem = dgvSubItems.Rows[e.RowIndex].DataBoundItem as ConstructionSubItem;
                    FrmItemImage itemImage = new FrmItemImage();
                    itemImage.SubItem = subItem;
                    itemImage.ShowDialog();

                }
                if(e.RowIndex >=0 && dgvSubItems.Columns["appendixFilesDataGridViewTextBoxColumn"].Index == e.ColumnIndex)
                {
                    if (!CurrentUser.Authorities.Contains("B1010405"))
                    {
                        ShowMsg("无权浏览附件文件，请联系系统管理员");
                        return;
                    }
                    var subItem = dgvSubItems.Rows[e.RowIndex].DataBoundItem as ConstructionSubItem;
                    FrmSubItemFile itemFile = new FrmSubItemFile();
                    itemFile.SubItem = subItem;
                    itemFile.ShowDialog();
                }
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
    }
}
