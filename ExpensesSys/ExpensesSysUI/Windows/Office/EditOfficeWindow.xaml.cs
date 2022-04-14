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
    public partial class EditOfficeWindow : MetroWindow
    {
        public EditOfficeWindow()
        {
            InitializeComponent();
        }

        public EditOfficeWindow(AdministrativeOfficeView view)
        {
            InitializeComponent();
            _view = view;
            DataContext = _view;
        }
        private AdministrativeOfficeView _view;

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private async void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_view.SelectedOfficeView.Name))
            {
                await DialogHelper.ShowAffirmative(this, "请输入科室名称");
                return;
            }
            if (_view.SelectedDepartment == null)
            {
                await DialogHelper.ShowAffirmative(this, "请选择所属部门");
                return;
            }
            await _view.UpdateAdministrativeOfficeAsync();
            await DialogHelper.ShowAffirmative(this, "更新成功");
            Close();
        }
    }
}
