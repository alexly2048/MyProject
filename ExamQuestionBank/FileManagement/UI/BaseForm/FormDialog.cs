using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManagement.UI
{
    public  partial class FormDialog : FrmBase
    {
        public FormDialog()
        {
            InitializeComponent();
        }

        public virtual void Shower(Action action,bool isAdd, object content) { }
    }
}
