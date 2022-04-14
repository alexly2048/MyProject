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
namespace ExpensesSysUI.Windows
{
    /// <summary>
    /// Interaction logic for AddTopConstructWindow.xaml
    /// </summary>
    public partial class EditSecondaryConstructWindow : MetroWindow
    {
        public EditSecondaryConstructWindow()
        {
            InitializeComponent();
        }

        public EditSecondaryConstructWindow(SecondaryConstructView view)
        {
            InitializeComponent();
            _view = view;
            DataContext = _view;
        }
        private SecondaryConstructView _view;

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_view.SelectedSecondaryConstruct.Name))
            {
                await DialogHelper.ShowAffirmative(this, "请输入二级项目类别名称");
                return;
            }
            if(_view.SelectedDepartment == null)
            {
                await DialogHelper.ShowAffirmative(this, "请选择所属部门");
                return;
            }
            if (_view.SelectedBudget == null)
            {
                await DialogHelper.ShowAffirmative(this, "请选择所属预算科目");
                return;
            }
            if(_view.SelectedTopConstruct == null)
            {
                await DialogHelper.ShowAffirmative(this, "请选择一级项目类别");
            }
            await _view.UpdateSecondaryConstructAsync();
            await DialogHelper.ShowAffirmative(this, "更新成功");
            Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_view.SelectedSecondaryConstruct == null)
                return;
            _view.SelectedSecondaryConstruct.Surplus = _view.SelectedSecondaryConstruct.Money - _view.SelectedSecondaryConstruct.ActualExpense;
        }

        bool flag = true;
        private async void cbDepartments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (flag)
            {
                flag = false;
                return;
            }
            await _view.SetBudgetsAsync();
        }

        private async void cbBudgets_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (flag)
            {
                flag = false;
                return;
            }
            await _view.SetTopConstructsAsync();
        }
    }
}
