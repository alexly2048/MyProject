using ConstructionManagement.Service;
using System;
using System.IO;
using System.Windows.Forms;
using ConstructionManagement.Model;
using System.Collections.Generic;
using System.Text;

namespace ConstructionManagement.UI
{
    public partial class FrmAddNewFile : example
    {
        public FrmAddNewFile()
        {
            InitializeComponent();
            fileService = new ConstructionFileService();
        }
        ConstructionFileService fileService;
        public delegate void RefreshCallBack();
        public event RefreshCallBack CallBack;
        public ConstructionNode ConstructionNode { get; set; }
        public string ConstructionField { get; set; }
        List<string> uploadFiles = new List<string>();
        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var appendixFile = new AppendixFile();
            try
            {
                var constructionNo = txtConstructionNo.Text.Trim();
                var constructionField =txtConstructionField.Text.Trim();
                if (uploadFiles.Count == 0)
                {
                    ShowMsg("请选择上传文件");
                    return;
                }
                foreach(var f in uploadFiles)
                {
                    if (!File.Exists(f))
                    {
                        ShowMsg("上传文件不存在");
                        return;
                    }
                }
                foreach(var f in uploadFiles)
                {
                    fileService.SaveFile(ConstructionNode.ID, constructionNo, constructionField, f);
                }
                uploadFiles.Clear();
                ShowMsg("保存成功");
                CallBack?.Invoke();
                Close();

            }catch(FileNotFoundException fe)
            {
                ShowMsg($"指定文件<{fe.FileName}>不存在");
            }
            catch(Exception ex)
            {
                ShowMsg("系统异常：\n" + ex.Message);
            }
        }

        /// <summary>
        /// 选择要上传文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                uploadFiles.Clear();
                var sb = new StringBuilder();
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;
                openFileDialog.RestoreDirectory = true;
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePaths = openFileDialog.FileNames;
                    foreach(var f in filePaths)
                    {
                        uploadFiles.Add(f);
                        sb.Append(f + ";");
                    }
                    txtFilePath.Text = sb.ToString();
                }
            }
            catch (Exception)
            {
                ShowMsg("选择文件失败");
            }
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAddNewFile_Load(object sender, EventArgs e)
        {
            try
            {
                txtConstructionNo.Text = ConstructionNode.ConstructionNo;
                txtConstructionNo.ReadOnly = true;
                txtConstructionField.Text = ConstructionField;
                txtConstructionField.ReadOnly = true;
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
    }
}
