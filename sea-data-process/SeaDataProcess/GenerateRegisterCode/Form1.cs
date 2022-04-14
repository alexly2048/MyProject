using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateRegisterCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private string codeContent = string.Empty;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = GlobalView.Blue;
            buttonGenerate.BackColor = GlobalView.LightBlue;
            buttonCopy.BackColor = GlobalView.LightBlue;
            buttonGenerate.ForeColor = GlobalView.White;
            buttonCopy.ForeColor = GlobalView.White;
            groupBox1.ForeColor = GlobalView.White;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            codeContent = RSACryptoHelper.EncryptAlgorith(rbRegister.Text);

            rbResult.Text = codeContent;
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(codeContent);
            MessageBox.Show(this, "复制成功", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
