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
    public partial class AddDepartmentWindow : MetroWindow
    {
        public AddDepartmentWindow()
        {
            InitializeComponent();
        }

        public AddDepartmentWindow(DepartmentView view)
        {
            InitializeComponent();
            _view = view;
            DataContext = _view;
        }
        private DepartmentView _view;

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_view.AddDepartment.Name))
            {
                await DialogHelper.ShowAffirmative(this, "请输入部门名称");
                return;
            }
            await _view.AddDepartmentAsync();
            await DialogHelper.ShowAffirmative(this, "新增成功");
            Close();
        }
    }
}
