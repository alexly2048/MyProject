using SeaDataProcess.Data;
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
using SeaDataProcess.Service;

namespace SeaDataProcess.UI
{
    /// <summary>
    /// Interaction logic for SelectTransferFunctionColWindow.xaml
    /// </summary>
    public partial class SelectTransferFunctionColWindow : MetroWindow
    {
        public SelectTransferFunctionColWindow()
        {
            InitializeComponent();
        }

        public TransferFunctionColEnum? SelectedCol { get; private set; } = null; // default null, the user selects nothing.

        /// <summary>
        /// 退出当前选择界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var dialog = await DialogHelper.ShowAffirmativeAndNegative("是否退出当前选择界面？");
            if (dialog == MahApps.Metro.Controls.Dialogs.MessageDialogResult.Affirmative)
            {
                Close();
            }
            else
            {
                this.Show();
            }
        }
        /// <summary>
        /// 选择列值并退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            if(rbTopStress.IsChecked != null &&
                ((bool)rbTopStress.IsChecked))
            {
                SelectedCol = TransferFunctionColEnum.TopStress;
                Close();
            }
            else if(rbBotStress.IsChecked != null &&
                ((bool)rbBotStress.IsChecked))
            {
                SelectedCol = TransferFunctionColEnum.BotStress;
                Close();
            }
            else if(rbMidStress.IsChecked != null &&
                ((bool)rbMidStress.IsChecked))
            {
                SelectedCol = TransferFunctionColEnum.MidStredd;
                Close();
            }
            else
            {
                SelectedCol = null;
                this.Hide();
                await DialogHelper.ShowAffirmative("未选择计算所需列值,请选择计算列值");
                this.Show();
            }
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if(GlobalParam.StressCount == 1)
            {
                rbTopStress.IsChecked = true;
                rbMidStress.IsEnabled = false;
                rbBotStress.IsEnabled = false;
            }else if(GlobalParam.StressCount == 2)
            {
                rbTopStress.IsChecked = true;
                rbBotStress.IsEnabled = false;
            }
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as RadioButton;
            if (btn.Name.Equals("rbTopStress"))
            {
                rbBotStress.IsChecked = false;
                rbMidStress.IsChecked = false;
            }else if(btn.Name.Equals("rbBotStress"))
            {
                rbTopStress.IsChecked = false;
                rbMidStress.IsChecked = false;
            }
            else
            {
                rbTopStress.IsChecked = false;
                rbBotStress.IsChecked = false;
            }
        }
    }
}
