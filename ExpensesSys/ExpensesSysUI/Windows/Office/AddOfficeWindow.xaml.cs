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
    public partial class AddOfficeWindow : MetroWindow
    {
        public AddOfficeWindow()
        {
            InitializeComponent();
        }

        public AddOfficeWindow(AdministrativeOfficeView view)
        {
            InitializeComponent();
            _view = view;
            DataContext = _view;
        }
        private AdministrativeOfficeView _view;

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_view.AddOffice.Name))
            {
                await DialogHelper.ShowAffirmative(this, "请输入科室名称");
                return;
            }
            if(_view.SelectedDepartment == null)
            {
                await DialogHelper.ShowAffirmative(this, "请选择所属部门");
                return;
            }
            await _view.AddAdministrativeOfficeAsync();
            await DialogHelper.ShowAffirmative(this, "新增成功");
            Close();
        }
    }
}
