using ConstructionManagement.Model;
using ConstructionManagement.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructionManagement.UI
{
    public partial class FrmConstructionLog : example
    {
        public FrmConstructionLog()
        {
            InitializeComponent();
        }

        ConstructionNodeService constructionNodeService = new ConstructionNodeService();
        ConstructionLogService logService = new ConstructionLogService();
        ExcelService excelService = new ExcelService();
        private void FrmConstructionLog_Load(object sender, EventArgs e)
        {
            try
            {

                if (!CurrentUser.Authorities.Contains("A10201"))
                {
                    btnAdd.Enabled = false;
                }
                if (!CurrentUser.Authorities.Contains("A10202"))
                {
                    btnUpdate.Enabled = false;
                }
                if (!CurrentUser.Authorities.Contains("A10203"))
                {
                    btnDelete.Enabled = false;
                }
                if (!CurrentUser.Authorities.Contains("A10204"))
                {
                    btnExport.Enabled = false;
                }


                var constructionNodes = constructionNodeService.GetConstructionNodes();
                cbConstructionNode.DataSource = constructionNodes;
                cbConstructionNode.DisplayMember = "Name";
                cbConstructionNode.ValueMember = "ConstructionNo";
                cbConstructionNode.SelectedIndex = -1;
                dtLogStart.Text = string.Empty;
                dtLogEnd.Text = string.Empty;
                QueryData();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void QueryData()
        {
            var constructionCode = cbConstructionNode.SelectedValue?.ToString();
            var start = dtLogStart.Value.ToString("yyyy-MM-dd");
            var end = dtLogEnd.Value.ToString("yyyy-MM-dd");

            var logs = logService.GetConstructionLogs(constructionCode, start, end);
            logs = logs.OrderByDescending(x => x.LogDate).ToList();
            dgvLogs.DataSource = logs;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                QueryData();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditConstructionLog editLog = new FrmEditConstructionLog();
                editLog.IsAdd = true;
                editLog.IsPrint = false;
                editLog.CallBack += QueryData;
                editLog.ShowDialog();
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
                var rows = dgvLogs.SelectedRows;
                if (rows.Count > 0)
                {
                    var log = rows[0].DataBoundItem as ConstructionLog;
                    FrmEditConstructionLog editLog = new FrmEditConstructionLog();
                    editLog.Log = log;
                    editLog.IsAdd = false;
                    editLog.IsPrint = false;
                    editLog.CallBack += QueryData;
                    editLog.ShowDialog();
                }
                else
                {
                    ShowMsg("请选择要更新的数据");
                }
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dgvLogs.SelectedRows;
                if(rows.Count > 0)
                {
                    var log = rows[0].DataBoundItem as ConstructionLog;
                    logService.DeleteConstructionLog(log);
                    ShowMsg("删除成功");
                    QueryData();
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

        private void dgvLogs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var log =dgvLogs.Rows[e.RowIndex].DataBoundItem as ConstructionLog;
                    FrmEditConstructionLog editLog = new FrmEditConstructionLog();
                    editLog.Log = log;
                    editLog.IsAdd = false;
                    editLog.IsPrint = true;
                    editLog.CallBack += QueryData;
                    editLog.ShowDialog();
                }
                else
                {
                    ShowMsg("请选择要更新的数据");
                }
            }
            catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dgvLogs.SelectedRows;
                if(rows.Count > 0)
                {

                    FolderBrowserDialog browserDialog = new FolderBrowserDialog();
                    var baseDirectory = string.Empty;
                    if(browserDialog.ShowDialog() == DialogResult.OK)
                    {
                        baseDirectory = browserDialog.SelectedPath;
                    }
                    if (string.IsNullOrEmpty(baseDirectory))
                    {
                        ShowMsg("请选择要导出的文件夹");
                        return;
                    }


                    var index = 0;
                    foreach(DataGridViewRow row in rows)
                    {
                        index++;
                        var log = row.DataBoundItem as ConstructionLog;

                        var filePath =log.ConstructionName+ "_"+log.LogDate+"_"+ index.ToString()+ ".xlsx";
                        filePath = Path.Combine(baseDirectory, filePath);
                        if (File.Exists(filePath))
                        {
                            var dialog = ShowAffirm($"文件{filePath}已存在，是否继续？");
                            if(dialog == DialogResult.OK)
                            {
                                File.Delete(filePath);
                                excelService.SaveConstructionLog(log, filePath);
                            }
                        }
                        else
                        {
                            excelService.SaveConstructionLog(log, filePath);
                        }
                        

                    }
                    ShowMsg("保存成功");
                }
                else
                {
                    ShowMsg("请选择要导出的数据");
                }
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
    }
}
