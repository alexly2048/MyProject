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
    public partial class EditConstructWindow : MetroWindow
    {
        public EditConstructWindow()
        {
            InitializeComponent();
        }

        public EditConstructWindow(ConstructView view)
        {
            InitializeComponent();
            _view = view;
            DataContext = _view;
        }
        private ConstructView _view;

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_view.SelectedConstruct.Name))
            {
                await DialogHelper.ShowAffirmative(this, "请输入二级项目类别名称");
                return;
            }
            if(_view.SelectedSecondaryConstruct == null)
            {
                await DialogHelper.ShowAffirmative(this, "请选择项目类别");
                return;
            }
            if (_view.SelectedOffice == null)
            {
                await DialogHelper.ShowAffirmative(this, "请选择科室");
                return;
            }

            await _view.UpdateConstructAsync();
            await DialogHelper.ShowAffirmative(this, "更新成功");
            await ActualExpenseHelper.CalcActualExpenseAsync();
            Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_view.SelectedConstruct == null)
                return;
            _view.SelectedConstruct.Surplus = _view.SelectedConstruct.Money - _view.SelectedConstruct.ActualExpense;
        }

        private async void bntSelectSecondaryConstruct_Click(object sender, RoutedEventArgs e)
        {
            if (_view.SelectedOffice == null)
            {
                await DialogHelper.ShowAffirmative(this, "请先选择科室");
            }
            var win = new SelectedSecondaryConstructWindow(_view);
            win.Owner = this;
            win.ShowDialog();
        }

        private async void cbOffices_SelectedChanged(object sender, SelectionChangedEventArgs e)
        {
            await _view.RefreshSecondaryConstructAsync();
        }
    }
}
