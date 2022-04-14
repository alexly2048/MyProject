using CustomerUI.UI.BaseForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerUI.UI.QuestionBank
{
    public partial class FormDisplayImage : FormBase
    {
        public FormDisplayImage()
        {
            InitializeComponent();
        }

        private Image image;
        public override void ShowWindow(Action action, bool isAdd, object content)
        {
            image = (Image)content;
            Show();
        }

        private void FormDisplayImage_Load(object sender, EventArgs e)
        {
            if (image == null) return;
            displayPic.Image = image;
        }
    }
}
