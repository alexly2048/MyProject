using ConstructionManagement;
using System;
using System.Windows.Forms;
using ConstructionManagement.Model;
using ConstructionManagement.Service;

namespace ConstructionManagement.UI
{
    public partial class FrmAcceptance : example
    {
        public FrmAcceptance()
        {
            InitializeComponent();

            acceptanceService = new AcceptanceService();
        }
        AcceptanceService acceptanceService;
        public ProjectKindEnum ProjectKind { get; set; }
        private void FrmAcceptance_Load(object sender, EventArgs e)
        {
            try
            {
                if(ProjectKind == ProjectKindEnum.Middle)
                {
                    if (CurrentUser.Authorities.Contains("C10101"))
                    {
                        btnAdd.Enabled = true;
                    }
                    else
                    {
                        btnAdd.Enabled = false;
                    }
                    if (CurrentUser.Authorities.Contains("C10102"))
                    {
                        btnUpdate.Enabled = true;
                    }
                    else
                    {
                        btnUpdate.Enabled = false;
                    }
                    if (CurrentUser.Authorities.Contains("C10103"))
                    {
                        btnDel.Enabled = true;
                    }
                    else
                    {
                        btnDel.Enabled = false;
                    }
                    this.Text = "中间验收";
                }
                else
                {
                    if (CurrentUser.Authorities.Contains("C10201"))
                    {
                        btnAdd.Enabled = true;
                    }
                    else
                    {
                        btnAdd.Enabled = false;
                    }
                    if (CurrentUser.Authorities.Contains("C10202"))
                    {
                        btnUpdate.Enabled = true;
                    }
                    else
                    {
                        btnUpdate.Enabled = false;
                    }
                    if (CurrentUser.Authorities.Contains("C10203"))
                    {
                        btnDel.Enabled = true;
                    }
                    else
                    {
                        btnDel.Enabled = false;
                    }
                    this.Text = "竣工验收";
                }

                dgvAcceptance.DataBindingComplete += DgvAcceptance_DataBindingComplete;
                InitialData();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void DgvAcceptance_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           foreach(DataGridViewRow row in dgvAcceptance.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        private void InitialData()
        {
            try
            {
                var acceptances = acceptanceService.GetAcceptances(ProjectKind);
                var r = Helper.GetSortableBindingList<Acceptance>(acceptances);
                if(acceptances.Count > 0)
                {
                    dgvAcceptance.DataSource = r;
                }
                else
                {
                    dgvAcceptance.DataSource = null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 新增施工验收子目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditAcceptance editAcceptance = new FrmEditAcceptance();
                editAcceptance.ProjectKind = ProjectKind;
                editAcceptance.IsAdd = true;
                editAcceptance.EditAcceptanceCallBack += InitialData;
                editAcceptance.ShowDialog();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
        /// <summary>
        /// 修改施工验收子项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAcceptance.DataSource == null) return;
                var rows = dgvAcceptance.SelectedRows;
                if(rows.Count > 0)
                {
                    var acceptance = rows[0].DataBoundItem as Acceptance;
                    FrmEditAcceptance editAcceptance = new FrmEditAcceptance();
                    editAcceptance.ProjectKind = ProjectKind;
                    editAcceptance.Acceptance = acceptance;
                    editAcceptance.IsAdd = false;
                    editAcceptance.EditAcceptanceCallBack += InitialData;
                    editAcceptance.ShowDialog();
                }
                else
                {
                    ShowMsg("请选择要编辑的行数据");
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
                InitialData();
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
                if (dgvAcceptance.DataSource == null) return;

                var rows = dgvAcceptance.SelectedRows;
                if(rows.Count > 0)
                {

                    var dialog = ShowAffirm("是否要删除选择的数据？\n将删除相关所有数据");
                    if (dialog == DialogResult.Cancel)
                        return;
                    var acceptance = rows[0].DataBoundItem as Acceptance;
                    acceptanceService.DelAcceptance(acceptance);
                    ShowMsg("删除成功");
                    InitialData();
                }
                else
                {
                    ShowMsg("请选择要删除的数据");
                }
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAcceptance_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FrmAcceptanceImage acceptanceImage = new FrmAcceptanceImage();
                if (e.RowIndex >= 0 && dgvAcceptance.Columns["questionDataGridViewTextBoxColumn"].Index == e.ColumnIndex)
                {                   
                    acceptanceImage.ImageKind = ImageKindEnum.Problem;
                    var row = dgvAcceptance.Rows[e.RowIndex];
                    var acceptance = row.DataBoundItem as Acceptance;
                    acceptanceImage.Acceptance = acceptance;
                    acceptanceImage.ShowDialog();
                }
                if(e.RowIndex >= 0 && dgvAcceptance.Columns["rectifyDataGridViewTextBoxColumn"].Index == e.ColumnIndex)
                {
                    acceptanceImage.ImageKind = ImageKindEnum.Rectify;
                    var row = dgvAcceptance.Rows[e.RowIndex];
                    var acceptance = row.DataBoundItem as Acceptance;
                    acceptanceImage.Acceptance = acceptance;
                    acceptanceImage.ShowDialog();
                }                         
            }
            catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
    }
}
