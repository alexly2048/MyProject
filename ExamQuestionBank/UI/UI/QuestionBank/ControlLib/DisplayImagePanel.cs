using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerUI.Model.QuestionBankModel;
using DevExpress.XtraEditors;
using IOCService.Service;

namespace CustomerUI.UI.QuestionBank.ControlLib
{
    public partial class DisplayImagePanel : UserControl
    {
        public DisplayImagePanel()
        {
            InitializeComponent();
        }

        public void DisplayImages(List<QuestionImage> images)
        {
            ClearContent();
            var local = images;
            var count = local.Count();
            var index = 0;
            if(index < count)
            {
                firstPic.Image = new Bitmap(local[index].IMAGE);
                index++;
            }
            if(index < count)
            {
                secondPic.Image = new Bitmap(local[index].IMAGE);
                index++;
            }
            if(index < count)
            {
                thirdPic.Image = new Bitmap(local[index].IMAGE);
            }

        }

        private void ClearContent()
        {
            firstPic.Image = null;
            secondPic.Image = null;
            thirdPic.Image = null;
        }

        private void firstPic_DoubleClick(object sender, EventArgs e)
        {
            var edit = sender as PictureEdit;
            var image = edit.Image;
            if (image == null) return;
            var frm = AppContainer.Resolve<FormDisplayImage>();
            frm.ShowWindow(null, true, image);
        }
    }
}
