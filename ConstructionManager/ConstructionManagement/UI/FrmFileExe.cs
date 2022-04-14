using ConstructionManagement.Model;
using ConstructionManagement.Service;
using Newtonsoft.Json;
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
    public partial class FrmFileExe : example
    {
        public FrmFileExe()
        {
            InitializeComponent();
        }

        private void FrmFileExe_Load(object sender, EventArgs e)
        {
            try
            {
                QueryData();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
        public delegate void EditShortcutRefresh();
        public event EditShortcutRefresh Callback;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dgvShortcuts.SelectedRows;
                if (rows.Count > 0)
                {
                    var f = rows[0].DataBoundItem as FileShortcut;
                    var index = fileShortcuts.FindIndex(x => x.FilePath.Equals(f.FilePath));
                    fileShortcuts.RemoveAt(index);
                    var content = JsonConvert.SerializeObject(fileShortcuts);
                    fileService.WriteContent(content, fileName);

                    QueryData();
                    Callback?.Invoke();
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
        FileService fileService = new FileService();
        List<FileShortcut> fileShortcuts;
        string fileName = "fileExeConfig.json";
        private void QueryData()
        {
            fileShortcuts = new List<FileShortcut>();
            var content = fileService.GetContent(fileName);
            if (string.IsNullOrEmpty(content)) return;

            fileShortcuts = JsonConvert.DeserializeObject<List<FileShortcut>>(content);
            dgvShortcuts.DataSource = fileShortcuts;
        }
    }
}
