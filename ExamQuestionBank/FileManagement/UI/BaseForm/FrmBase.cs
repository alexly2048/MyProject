using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace FileManagement.UI
{
    public partial class FrmBase : DevExpress.XtraEditors.XtraForm
    {
        public FrmBase()
        {
            InitializeComponent();
        }


        protected void ShowMsg(string msg,string title = "")
        {
            XtraMessageBox.Show(msg, title);
        }

        protected DialogResult ShowAffirm(string msg,string caption = "")
        {
            return XtraMessageBox.Show(msg, caption, MessageBoxButtons.OKCancel);
        }

        protected void ShowWarning(string msg,string caption = "")
        {
            XtraMessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        protected void TopRowChanged_Event(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null) return;
            var r = view.TopRowIndex;
            var count = r + 30;
            if (count == 0)
            {
                count = 30;
            }
            Graphics graphics = new Control().CreateGraphics();
            SizeF sizeF = new SizeF();
            sizeF = graphics.MeasureString(count.ToString(), view.Appearance.Row.Font);
            view.IndicatorWidth = Convert.ToInt32(sizeF.Width) + 20;
        }

        /// <summary>
        /// 显示行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridView_CustomDrawRowIndicator_Event(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle > -1)
            {
                var content = (e.RowHandle + 1).ToString();
                e.Info.DisplayText = content;
            }
        }
    }
}