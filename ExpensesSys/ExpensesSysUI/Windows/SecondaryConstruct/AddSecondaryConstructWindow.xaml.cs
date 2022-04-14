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
    public partial class AddSecondaryConstructWindow : MetroWindow
    {
        public AddSecondaryConstructWindow()
        {
            InitializeComponent();
        }

        public AddSecondaryConstructWindow(SecondaryConstructView view)
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

        private async void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_view.AddSecondaryConstruct.Name))
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
            await _view.AddSecondaryConstructAsync();
            await DialogHelper.ShowAffirmative(this, "新增成功");
            Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _view.AddSecondaryConstruct.Surplus = _view.AddSecondaryConstruct.Money - _view.AddSecondaryConstruct.ActualExpense;
        }

        private async void cbDepartments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            await _view.SetBudgetsAsync();
        }

        private async void cbBudgets_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            await _view.SetTopConstructsAsync();
        }
    }
}
