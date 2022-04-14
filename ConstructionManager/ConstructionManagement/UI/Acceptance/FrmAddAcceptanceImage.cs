using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ConstructionManagement.Model;
using ConstructionManagement.Service;
using Spire.Pdf.Exporting.XPS.Schema;

namespace ConstructionManagement.UI
{
    public partial class FrmAddAcceptanceImage : example
    {
        public FrmAddAcceptanceImage()
        {
            InitializeComponent();

            imageService = new AcceptanceImageService();
        }
        AcceptanceImageService imageService;
        public Acceptance Acceptance { get; set; }
        public ImageKindEnum ImageKind { get; set; }
        public delegate void EditImageRefresh();
        public event EditImageRefresh CallBack;

        private List<string> filePaths = new List<string>();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var filePath = txtFilePath.Text.Trim();
                var description = rtbDescription.Text.Trim();
                if (filePaths.Count == 0)
                {
                    ShowMsg("请选择要上传的文件");
                }
                foreach(var f in filePaths)
                {
                    imageService.SaveFileToServer(Acceptance, f, ImageKind, description);
                }
                
                ShowMsg("成功提交文件");
                filePaths.Clear();
                CallBack?.Invoke();
                Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                filePaths.Clear();
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.RestoreDirectory = true;
                openFile.Multiselect = true;
                var sb = new StringBuilder();
                if(openFile.ShowDialog() == DialogResult.OK)
                {
                    var files = openFile.FileNames;
                    foreach (var f in files)
                    {
                        filePaths.Add(f);
                        sb.Append(f + ";");
                    }

                    txtFilePath.Text = sb.ToString();
                }               
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
