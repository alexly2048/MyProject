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
using SeaDataProcess.UI;
using SeaDataProcess.Views;

namespace SeaDataProcess.Controls
{
    /// <summary>
    /// Interaction logic for LoadTransferFunctionControl.xaml
    /// </summary>
    public partial class LoadTransferFunctionControl : MetroContentControl
    {
        public LoadTransferFunctionControl()
        {
            InitializeComponent();
        }

        private GlobalParamView paramView = new GlobalParamView();

        /// <summary>
        /// 加载传递函数频率表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnTransferFrequecy_Click(object sender, RoutedEventArgs e)
        {
            
            var r = await paramView.LoadTransferFunctionFrequencyTable();
            if (r)
            {
                await DialogHelper.ShowAffirmative("成功导入传递函数频率数据");
                
            }
            else
            {
                await DialogHelper.ShowAffirmative("传递函数频率数据导入失败");
            }
        }

        /// <summary>
        /// 传递函数表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnTransferFunctions_Click(object sender, RoutedEventArgs e)
        {
            var r = await paramView.LoadTransferFunctionTable(); // load transfer funciton datas.
            if (!r)
                return;

            var selectWindow = new SelectTransferFunctionColWindow();
            selectWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            selectWindow.Owner = App.Current.MainWindow;
            selectWindow.ShowDialog();
            GlobalParamView.TransferFunctionCol = selectWindow.SelectedCol;

            btnTransferFunctionChart_Click(null, null);
        }

        /// <summary>
        /// 传递函数曲线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnTransferFunctionChart_Click(object sender, RoutedEventArgs e)
        {
            tabTransferFunctionChart.Items.Clear();

            // 传递函数图表
            await paramView.GenerateTransferDataTabItems();
            if (paramView.TransferDataItems.Any())
            {
                var items = paramView.TransferDataItems.OrderBy(x => x.TabIndex).ToList();
                foreach (var item in items)
                {
                    tabTransferFunctionChart.Items.Add(item);
                }
            }
        }
    }
}
