using SeaDataProcess.Service;
using SeaDataProcess.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SeaDataProcess
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            try
            {               
                MessageBox.Show(e.Exception.Message);
                e.Handled = true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var main = new MainWindow();

            var validateResult = ValidateRegisterService.ValidateRegister();
            while (!validateResult.Item1)
            {
                MessageBox.Show("验证失败，请重新输入注册码");
                var frm = new RegisterWindow();
                frm.ShowDialog();

                validateResult = ValidateRegisterService.ValidateRegister();
            }

            main.Show();
        }
    }
}
