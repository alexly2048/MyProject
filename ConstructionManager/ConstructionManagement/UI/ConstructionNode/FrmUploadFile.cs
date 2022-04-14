using ConstructionManagement;
using ConstructionManagement.Service;
using System;
using System.IO;
using System.Windows.Forms;
using ConstructionManagement.Model;

namespace ConstructionManagement.UI
{
    public partial class FrmUploadFile : example
    {
        public FrmUploadFile()
        {
            InitializeComponent();
            fileService = new ConstructionFileService();
        }
        ConstructionFileService fileService;
        public ConstructionNode ConstructionNode { get; set; }
        public string ConstructionField { get; set; }
        /// <summary>
        /// 获取文件数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                InitialData();
            }
            catch (Exception ex)
            {
                ShowMsg("系统异常：\n" + ex.Message);
            }
        }

        /// <summary>
        /// 删除选择文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dgvFiles.SelectedRows;
                if (rows.Count == 0)
                {
                    ShowMsg("请选择要删除的数据");
                    return;
                }
                var appendixFile = rows[0].DataBoundItem as AppendixFile;
                var dialog = ShowAffirm("是否删除选择的文件?");
                if (dialog == DialogResult.OK)
                {
                    fileService.DeleteAppendix(appendixFile);
                    ShowMsg("删除成功");
                    InitialData();
                }
                
                
            }
            catch (Exception ex)
            {
                ShowMsg("删除失败:\n" + ex.Message);
            }
        }

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddNewFile addFile = new FrmAddNewFile();
                addFile.ConstructionNode=ConstructionNode;
                addFile.ConstructionField = ConstructionField;
                addFile.CallBack += InitialData;
                addFile.ShowDialog();
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
        private void FrmUploadFile_Load(object sender, EventArgs e)
        {
            try
            {

                if(ConstructionField == "开工日期")
                {
                    if (CurrentUser.Authorities.Contains("A1010401"))
                    {
                        btnAdd.Enabled = true;
                    }
                    else
                    {
                        btnAdd.Enabled = false;
                    }
                    if (CurrentUser.Authorities.Contains("A1010402"))
                    {
                        btnDel.Enabled = true;
                    }
                    else
                    {
                        btnDel.Enabled = false;
                    }
                }
                if(ConstructionField == "施工前附件")
                {
                    if (CurrentUser.Authorities.Contains("A1010501"))
                    {
                        btnAdd.Enabled = true;
                    }
                    else
                    {
                        btnAdd.Enabled = false;
                    }
                    if (CurrentUser.Authorities.Contains("A1010502"))
                    {
                        btnDel.Enabled = true;
                    }
                    else
                    {
                        btnDel.Enabled = false;
                    }
                }

                dgvFiles.DataBindingComplete += DgvFiles_DataBindingComplete;
                InitialData();
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void DgvFiles_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewRow row in dgvFiles.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        private void InitialData()
        {
            var result = fileService.GetFilesByConstructionNo(ConstructionNode.ID, ConstructionField);
            var r = Helper.GetSortableBindingList<AppendixFile>(result);
            dgvFiles.DataSource = r;
        }

        /// <summary>
        /// 双击查看文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var rows = dgvFiles.SelectedRows;
                var count = rows.Count;
                if(count > 0)
                {
                    var appendix = rows[0].DataBoundItem as AppendixFile;
                    if (File.Exists(appendix.LocalFilePath))
                    {
                        var dialog = ShowAffirm("文件已存在,是否重新下载?");
                        if(dialog == DialogResult.OK)
                        {
                            fileService.DownloadFile(appendix);
                        }
                    }
                    else
                    {
                        fileService.DownloadFile(appendix);
                    }
                    System.Diagnostics.Process.Start(appendix.LocalFilePath);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
