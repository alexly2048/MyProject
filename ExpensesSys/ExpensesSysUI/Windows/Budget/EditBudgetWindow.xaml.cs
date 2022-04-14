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
    public partial class EditBudgetWindow : MetroWindow
    {
        public EditBudgetWindow()
        {
            InitializeComponent();
        }

        public EditBudgetWindow(BudgetView view)
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

        private async void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_view.SelectedBudget.Name))
            {
                await DialogHelper.ShowAffirmative(this, "请输入预算科目名称");
                return;
            }
            if(_view.SelectedDepartment == null)
            {
                await DialogHelper.ShowAffirmative(this, "请选择所属部门");
                return;
            }
            await _view.UpdateBudgetAsync();
            await DialogHelper.ShowAffirmative(this, "更新成功");
            Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_view.SelectedBudget == null)
                return;
            _view.SelectedBudget.Surplus = _view.SelectedBudget.Money - _view.SelectedBudget.ActualExpense;
        }
    }
}
