using ConstructionManagement;
using System;
using System.Windows.Forms;
using ConstructionManagement.Model;
using ConstructionManagement.Service;

namespace ConstructionManagement.UI
{
    public partial class FrmConstructionOverallSchedule : example
    {
        public FrmConstructionOverallSchedule()
        {
            InitializeComponent();

            overallScheduleService = new ConstructionOverallScheduleService();

        }
        ConstructionOverallScheduleService overallScheduleService;
        /// <summary>
        /// 加载数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConstructionOverallSchedule_Load(object sender, EventArgs e)
        {
            try
            {
                dgvSchedule.DataBindingComplete += DgvSchedule_DataBindingComplete;
                InitialData();
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void DgvSchedule_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewRow row in dgvSchedule.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        /// <summary>
        /// 重新加载数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                InitialData();
            }
            catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void InitialData()
        {
            var schedules = overallScheduleService.GetOverallSchedules();
            var r = Helper.GetSortableBindingList<ConstructionOverallSchedule>(schedules);
            dgvSchedule.DataSource = r;
        }

        #region Absolete
        /*
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditSchedule editSchedule = new FrmEditSchedule();
                editSchedule.IsAdd = true;
                editSchedule.ShowDialog();
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSchedule.DataSource == null) return;
                var rows = dgvSchedule.SelectedRows;
                if(rows.Count > 0)
                {
                    var schedule = rows[0].DataBoundItem as ConstructionOverallSchedule;
                    FrmEditSchedule editSchedule = new FrmEditSchedule();
                    editSchedule.IsAdd = false;
                    editSchedule.OverallSchedule = schedule;
                    editSchedule.ShowDialog();
                }
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSchedule.DataSource == null) return;
                var rows = dgvSchedule.SelectedRows;
                if(rows.Count > 0)
                {
                    var schedule = rows[0].DataBoundItem as ConstructionOverallSchedule;
                    var dialog = ShowAffirm("是否删除选定数据");
                    if(dialog == DialogResult.OK)
                    {
                        overallScheduleService.DeleteSchedule(schedule);
                    }
                    ShowMsg("删除成功");
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
        */
        #endregion
        private void dgvSchedule_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0 && dgvSchedule.Columns["projectNameDataGridViewTextBoxColumn"].Index == e.ColumnIndex)
                {
                    if (!CurrentUser.Authorities.Contains("B101"))
                    {
                        ShowMsg("缺少打开权限");
                        return;
                    }
                    var overallSchedule = dgvSchedule.Rows[e.RowIndex].DataBoundItem as ConstructionOverallSchedule;
                    var frmQuantity = new FrmConstructionQuantity();
                    frmQuantity.OverallSchedule = overallSchedule;
                    frmQuantity.ShowDialog();
                }
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
    }
}
