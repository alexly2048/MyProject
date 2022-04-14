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
using ExpensesSysUI.Views;
using MahApps.Metro.Controls;
namespace ExpensesSysUI.Windows
{
    /// <summary>
    /// Interaction logic for AddDepartmentWindow.xaml
    /// </summary>
    public partial class EditDepartmentWindow : MetroWindow
    {
        public EditDepartmentWindow()
        {
            InitializeComponent();
        }

        public EditDepartmentWindow(DepartmentView view)
        {
            InitializeComponent();
            _view = view;
            DataContext = _view;
        }
        private DepartmentView _view;

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private async void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_view.SelectedDepartment.Name))
            {
                await DialogHelper.ShowAffirmative(this, "请输入部门名称");
                return;
            }
            await _view.UpdateDepartmentAsync();
            await DialogHelper.ShowAffirmative(this, "更新成功");
            Close();
        }
    }
}
