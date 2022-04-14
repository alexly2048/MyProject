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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using ExpensesSysLib.Models;
using ExpensesSysUI.Windows;

namespace ExpensesSysUI.Controls
{
    /// <summary>
    /// Interaction logic for DepartmentControl.xaml
    /// </summary>
    public partial class DepartmentControl : MetroContentControl
    {
        public DepartmentControl()
        {
            InitializeComponent();

            _view = new DepartmentView();
            DataContext = _view;
        }
        private DepartmentView _view;
        private async void btnQuery_Click(object sender, RoutedEventArgs e)
        {
            await _view.Refresh();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            _view.AddDepartment = new Department();
            var win = new AddDepartmentWindow(_view);
            win.Owner = App.Current.MainWindow;
            win.ShowDialog();
        }

        private async void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if(_view.SelectedDepartment == null)
            {
                await DialogHelper.ShowAffirmative("请选择要更新的数据");
                return;
            }
            var win = new EditDepartmentWindow(_view);
            win.Owner = App.Current.MainWindow;
            win.ShowDialog();
        }

        private async void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            await _view.DeleteDepartmentAsync();
        }
    }
}
