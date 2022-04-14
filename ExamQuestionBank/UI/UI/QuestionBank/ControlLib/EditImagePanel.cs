using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraEditors;

namespace CustomerUI.UI.QuestionBank.ControlLib
{
    public partial class EditImagePanel : UserControl
    {
        public EditImagePanel()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = "JPG图片|*.jpg|PNG图片|*.png|BMP图片|*.bmp|其他文件|*.*";
            dialog.RestoreDirectory = true;
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                var file = dialog.FileName;
                tFileName.Text = file;

                if (!File.Exists(file))
                {
                    XtraMessageBox.Show($"文件{file}不存在");
                    return;
                }

                using (var fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                {
                    var bitmap = new Bitmap(fs);
                    var t = new Bitmap(bitmap);
                    displayPic.Image = bitmap;
                }
            }    
        }

        public void DisplayImage(Image image)
        {
            var i = new Bitmap(image);
            displayPic.Image = i;
            tFileName.Text = string.Empty;
        }

        public void ClearImage()
        {
            tFileName.Text = string.Empty;
            displayPic.Image = null;
        }
    }
}
