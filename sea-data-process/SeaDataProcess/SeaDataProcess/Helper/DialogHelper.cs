using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SeaDataProcess
{
    public class DialogHelper
    {
        private static MetroDialogSettings settingOKCancel = new MetroDialogSettings
        {
            AffirmativeButtonText = "确认",
            NegativeButtonText = "取消",           
        };

        private static MetroDialogSettings settingOK = new MetroDialogSettings
        {
            AffirmativeButtonText = "确认"
        };

        public static async Task<MessageDialogResult> ShowAffirmativeAndNegative( string msg, string title = "系统提示")
        {
            return await((MetroWindow)Application.Current.MainWindow).ShowMessageAsync(title,
                msg,
                MessageDialogStyle.AffirmativeAndNegative, settingOKCancel);
        }

        public static async Task<MessageDialogResult> ShowAffirmativeAndNegative(MetroWindow window, string msg, string title = "系统提示")
        {
            return await window.ShowMessageAsync(title,
                msg,
                MessageDialogStyle.AffirmativeAndNegative, settingOKCancel);
        }

        public static async Task ShowAffirmative(string msg, string title="系统提示")
        {
             await ((MetroWindow)Application.Current.MainWindow).ShowMessageAsync(title,
                msg,
                MessageDialogStyle.Affirmative, settingOK);
        }

        public static async Task ShowAffirmative(MetroWindow window, string msg, string title = "系统提示")
        {
            await window.ShowMessageAsync(title,
               msg,
               MessageDialogStyle.Affirmative, settingOK);
        }

        public static async Task ShowCustomerDialog(CustomDialog dialog)
        {
            await ((MetroWindow)Application.Current.MainWindow).ShowMetroDialogAsync(dialog);
        }
    }
}
