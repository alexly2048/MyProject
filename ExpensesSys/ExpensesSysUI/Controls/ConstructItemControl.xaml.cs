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
    public partial class ConstructItemControl : MetroContentControl
    {
        public ConstructItemControl()
        {
            InitializeComponent();

            _view = new ConstructItemView();
            DataContext = _view;
        }
        private ConstructItemView _view;
        private async void btnQuery_Click(object sender, RoutedEventArgs e)
        {
            await _view.Refresh();
        }

        private async void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            _view.AddConstructItem = new ConstructItem();
            await _view.RefreshBindingSourcesAsync();
            var win = new AddConstructItemWindow(_view);
            win.Owner = App.Current.MainWindow;
            win.ShowDialog();
        }

        private async void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if(_view.SelectedConstructItem == null)
            {
                await DialogHelper.ShowAffirmative("请选择要更新的数据");
                return;
            }
            await _view.RefreshBindingSourcesAsync();
            var win = new EditConstructItemWindow(_view);
            win.Owner = App.Current.MainWindow;
            win.ShowDialog();
        }

        private async void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            await _view.DeleteConstructItemAsync();
            await DialogHelper.ShowAffirmative("删除成功");
        }

        private async void btnExport_Click(object sender, RoutedEventArgs e)
        {
            if(_view.ConstructItems == null || _view.ConstructItems.Count == 0)
            {
                await DialogHelper.ShowAffirmative("无需要导出的数据");
                return;
            }
            await _view.ExportToExcel();
        }
    }
}
