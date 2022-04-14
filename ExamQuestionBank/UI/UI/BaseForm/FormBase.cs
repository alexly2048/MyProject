using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;

namespace CustomerUI.UI.BaseForm
{
    public partial class FormBase : DevExpress.XtraEditors.XtraForm
    {
        public FormBase()
        {
            InitializeComponent();
        }
        protected void ShowMsg(string msg,string title = "系统提示")
        {
            XtraMessageBox.Show(msg, title);
        }

        protected DialogResult ShowAffirm(string msg,string caption = "系统提示")
        {
            return XtraMessageBox.Show(msg, caption, MessageBoxButtons.OKCancel);
        }

        protected void ShowWarning(string msg,string caption = "警告")
        {
            XtraMessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        protected void SetColumnRepMemoEdit(GridControl control)
        {
            var view = control.MainView as GridView;
            foreach(GridColumn c in view.Columns)
            {
                var repMemo = new RepositoryItemMemoEdit();
                repMemo.WordWrap = true;
                repMemo.ReadOnly = true;
                repMemo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                repMemo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                control.RepositoryItems.Add(repMemo);
                c.ColumnEdit = repMemo;
            }           
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

        public virtual void ShowWindow(Action action, bool isAdd, object content)
        {
            Show();
        }
    }
}