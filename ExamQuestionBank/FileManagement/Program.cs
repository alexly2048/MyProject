using Autofac;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using FileManagement.Service.BaseService;
using FileManagement.UI;
using System;
using System.Windows.Forms;
using IOCService.Service;
using CustomerUI.UI.Common;
namespace FileManagement
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += Application_ThreadException;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Bezier);

            RegisterService.Register();
            var frmLogin = AppContainer.Container.Resolve<FrmLogin>();
            var r = frmLogin.ShowDialog();
            if(r == DialogResult.Cancel)
            {
                return;
            }
            var frmMain = AppContainer.Container.Resolve<FrmMain>();
            Application.Run(new FrmMain());
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                var exception = e.ExceptionObject as Exception;
                XtraMessageBox.Show("系统发生未处理的异常：\n" + exception.Message, "系统提示");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            try
            {
                XtraMessageBox.Show("系统发生未处理的异常：\n" + e.Exception.Message, "系统提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}
