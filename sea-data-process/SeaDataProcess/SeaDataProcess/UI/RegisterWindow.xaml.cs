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
using MahApps.Metro.Controls.Dialogs;
using SeaDataProcess.Service;

namespace SeaDataProcess.UI
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : MetroWindow
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private async void btnExit_Click(object sender, RoutedEventArgs e)
        {
            var r = await DialogHelper.ShowAffirmativeAndNegative(this, "是否确定退出?");
            if (r == MessageDialogResult.Affirmative)
            {
                Environment.Exit(0);
            }
        }

        private async void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbRegisterContent.Text))
            {
                await DialogHelper.ShowAffirmative(this, "请输入注册码");
                return;
            }

            await ValidateRegisterService.ResiterCode(tbRegisterContent.Text);
            Close();
        }
    }
}
