using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ConstructionManagement.Model;
using ConstructionManagement.Service;
using Spire.Pdf.Exporting.XPS.Schema;

namespace ConstructionManagement.UI
{
    public partial class FrmEditItemImage : example
    {
        public FrmEditItemImage()
        {
            InitializeComponent();
            imageService = new SubItemImageService();
        }
        public ConstructionSubItem SubItem { get; set; }
        SubItemImageService imageService;
        public delegate void ItemImageRefresh();
        public ItemImageRefresh ItemImageCallBack;
        List<string> uploadFiles = new List<string>();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var desc = txtDesc.Text.Trim();
                if (uploadFiles.Count == 0)
                {
                    ShowMsg("请选择要上传的文件");
                    return;
                }
                foreach(var f in uploadFiles)
                {
                    if (!File.Exists(f))
                    {
                        ShowMsg("文件不存在");
                        return;
                    }
                }
                foreach(var f in uploadFiles)
                {
                    imageService.AddSubImage(SubItem.ID, f, desc);
                }
                uploadFiles.Clear();
                ShowMsg("保存成功");
                ItemImageCallBack?.Invoke();
                Close();
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void FrmEditItemImage_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectedFile_Click(object sender, EventArgs e)
        {
            try
            {
                uploadFiles.Clear();
                var sb = new StringBuilder();
                var dialog =new OpenFileDialog();
                dialog.RestoreDirectory = true;
                dialog.Multiselect = true;
                dialog.Filter = "jpg图片|*.jpg|bmp文件|*.bmp|PNG文件|*.png|其他文件|*.*";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    var tmps = dialog.FileNames;
                    foreach(var t in tmps)
                    {
                        uploadFiles.Add(t);
                        sb.Append(t + ";");
                    }
                    txtPath.Text = sb.ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
