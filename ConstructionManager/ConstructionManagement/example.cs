using System;
using System.Windows.Forms;
using Sunisoft.IrisSkin;
namespace ConstructionManagement
{
    public partial class example : Form
    {
        public example()
        {
            InitializeComponent();
            //     this.skinEngine1.SkinFile = "Skins\\vista1_green.ssk";
            this.skinEngine1.SkinFile = "Skins\\visita1_green.ssk";
        }


        protected void ShowMsg(string msg)
        {
            MessageBox.Show(msg);
        }

        protected DialogResult ShowAffirm(string msg)
        {
            var result = MessageBox.Show(msg, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            return result;
        }

        
        
    }
}
