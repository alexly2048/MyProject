using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementComputerInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string content = string.Empty;
        private string base64 = string.Empty;

        private void buttonGetInfos_Click(object sender, EventArgs e)
        {
            rbInfo.Text = ComputerManager.GetInfo();
            content = ComputerManager.GetInfo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = GlobalView.Blue;
            buttonGenerate.BackColor = GlobalView.LightBlue;
            buttonGetInfos.BackColor = GlobalView.LightBlue;
            buttonCopy.BackColor = GlobalView.LightBlue;
            buttonGetInfos.ForeColor = GlobalView.White;
            buttonGenerate.ForeColor = GlobalView.White;
            buttonCopy.ForeColor = GlobalView.White;
            groupBox1.ForeColor = GlobalView.White;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(content));
            rbInfo.Text = base64;
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(base64);
            MessageBox.Show(this,"复制成功", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
