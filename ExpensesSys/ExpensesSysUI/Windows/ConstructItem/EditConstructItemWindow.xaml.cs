using ExpensesSysUI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using ExpensesSysUI.Windows.ConstructItem;
using ExpensesSysLib.Helper;

namespace ExpensesSysUI.Windows
{
    /// <summary>
    /// Interaction logic for AddTopConstructWindow.xaml
    /// </summary>
    public partial class EditConstructItemWindow : MetroWindow
    {
        public EditConstructItemWindow()
        {
            InitializeComponent();
        }

        public EditConstructItemWindow(ConstructItemView view)
        {
            InitializeComponent();
            _view = view;
            DataContext = _view;
        }
        private ConstructItemView _view;

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_view.SelectedConstructItem.Name))
            {
                await DialogHelper.ShowAffirmative(this, "请输入项目明细名称");
                return;
            }
            if(_view.SelectedConstruct == null)
            {
                await DialogHelper.ShowAffirmative(this, "请选择所属项目");
                return;
            }

            await _view.UpdateConstructItemAsync();
            await DialogHelper.ShowAffirmative(this, "更新成功");
            await ActualExpenseHelper.CalcActualExpenseAsync();
            Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_view.SelectedConstructItem == null)
                return;
            _view.SelectedConstructItem.Surplus = _view.SelectedConstructItem.Money - _view.SelectedConstructItem.ActualExpense;
        }

        private void btnSelectConstruct(object sender, RoutedEventArgs e)
        {

            var win = new SelectedConstructWindow(_view);
            win.Owner = this;
            win.ShowDialog();
        }
    }
}
