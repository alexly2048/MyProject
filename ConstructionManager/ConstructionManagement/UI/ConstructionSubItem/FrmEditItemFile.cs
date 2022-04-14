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
using ConstructionManagement.Model;
using ConstructionManagement.Service;

namespace ConstructionManagement.UI
{
    public partial class FrmEditItemFile : example
    {
        public FrmEditItemFile()
        {
            InitializeComponent();
            fileService = new SubItemFileService();
        }
        private SubItemFileService fileService;
        public ConstructionSubItem SubItem { get; set; }
        public delegate void ItemFileRefresh();
        public event ItemFileRefresh ItemFileCallBack;
        List<string> uploadFiles = new List<string>();
        private void FrmEditItemFile_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var desc = txtDesc.Text.Trim();
                if (uploadFiles.Count == 0)
                {
                    ShowMsg("请选择要上传的文件");
                }
                foreach(var f in uploadFiles)
                {
                    fileService.AddItemFile(SubItem.ID, f, desc);
                }
                uploadFiles.Clear();
                ShowMsg("新增成功");
                ItemFileCallBack?.Invoke();
                Close();
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                uploadFiles.Clear();
                var sb = new StringBuilder();
                var dialog = new OpenFileDialog();
                dialog.RestoreDirectory = true;
                dialog.Multiselect = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var tmps = dialog.FileNames;
                    foreach(var t in tmps)
                    {
                        uploadFiles.Add(t);
                        sb.Append(t + ";");
                    }
                    txtFilePath.Text = sb.ToString();
                }
            }
            catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
    }
}
