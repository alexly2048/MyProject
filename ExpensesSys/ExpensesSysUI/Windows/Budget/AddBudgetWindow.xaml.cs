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
    /// Interaction logic for AddDepartmentWindow.xaml
    /// </summary>
    public partial class AddBudgetWindow : MetroWindow
    {
        public AddBudgetWindow()
        {
            InitializeComponent();
        }

        public AddBudgetWindow(BudgetView view)
        {
            InitializeComponent();
            _view = view;
            DataContext = _view;
        }
        private BudgetView _view;

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_view.AddBudget.Name))
            {
                await DialogHelper.ShowAffirmative(this, "请输入预算科目名称");
                return;
            }
            if(_view.SelectedDepartment == null)
            {
                await DialogHelper.ShowAffirmative(this, "请选择所属部门");
                return;
            }
            await _view.AddBudgetAsync();
            await DialogHelper.ShowAffirmative(this, "新增成功");
            Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _view.AddBudget.Surplus = _view.AddBudget.Money - _view.AddBudget.ActualExpense;
        }
    }
}
