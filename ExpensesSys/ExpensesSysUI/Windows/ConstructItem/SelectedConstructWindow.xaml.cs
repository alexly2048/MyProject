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
namespace ExpensesSysUI.Windows.ConstructItem
{
    /// <summary>
    /// Interaction logic for SelectedSecondaryConstructWindow.xaml
    /// </summary>
    public partial class SelectedConstructWindow : MetroWindow
    {
        public SelectedConstructWindow()
        {
            InitializeComponent();
        }
        public SelectedConstructWindow(ConstructItemView view)
        {
            InitializeComponent();
            _view = view;
            DataContext = _view;

        }
        private ConstructItemView _view;

        private async void btnQuery_Click(object sender, RoutedEventArgs e)
        {
            await _view.RefreshConstructAsync();
        }

        private async void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            if(_view.SelectedConstruct == null)
            {
                await DialogHelper.ShowAffirmative("请选择所属项目");
                return;
            }
            Close();
        }
    }
}
