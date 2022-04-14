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
using SeaDataProcess.Views;

namespace SeaDataProcess.UI
{
    /// <summary>
    /// Interaction logic for SelectSpectrumTypeWindow.xaml
    /// </summary>
    public partial class SelectSpectrumTypeWindow : MetroWindow
    {
        public SelectSpectrumTypeWindow()
        {
            InitializeComponent();

            SelectParam = new SelectSpectrumParam();
        }

        public SelectSpectrumParam SelectParam { get; set; }

        private GlobalParamView globalParam = new GlobalParamView();

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
        //    this.Hide(); // hide this dialog firstly
        //    var dialog = await DialogHelper.ShowAffirmativeAndNegative("是否退出当前界面?");
        //    if(dialog == MessageDialogResult.Affirmative)
        //    {
                Close();
        //    }
        //    else
        //    {
        //        this.Show();
        //    }
            
        }

        /// <summary>
        /// 用户确认，验证输入参数
        /// created by liyan
        /// at 2021-05-13
        /// qq: 314452354
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            if(!(rbJONSWAP.IsChecked.HasValue || rbPM.IsChecked.HasValue))
            {
                this.Hide();
                await DialogHelper.ShowAffirmative("请选择频谱类型");
                this.Show();
                return;
            }

            if(!(rbTp.IsChecked.HasValue || rbTz.IsChecked.HasValue))
            {
                this.Hide();
                await DialogHelper.ShowAffirmative("请选择周期类型");
                this.Show();
                return;
            }

            int numOfND;
            if(int.TryParse(tbNumOfND.Text, out numOfND))
            {
                if(numOfND <= 0)
                {
                    this.Hide();
                    await DialogHelper.ShowAffirmative("波浪方向数量应输入正整数");
                    this.Show();
                    return;
                }
            }
            else
            {
                this.Hide();
                await DialogHelper.ShowAffirmative("请输入波浪方向数量");
                this.Show();
                return;
            }
            SelectParam.NumOfND = numOfND;


            // check the spectrum type
            if (((bool)rbJONSWAP.IsChecked))
            {
                double r;
                if(!double.TryParse(tbR.Text, out r))
                {
                    Hide();
                    await DialogHelper.ShowAffirmative("选择JONSWAP谱函数时，必须输入峰升因子r");
                    Show();
                    return;
                }
                else
                {
                    if(r <= 1 && r >= 5)
                    {
                        Hide();
                        await DialogHelper.ShowAffirmative("峰升因子r取值范围是：1-5");
                        Show();
                        return;
                    }
                }

                SelectParam.R = r; // if the user enter the value of r, set the value.
                SelectParam.SpectrumType = Data.SpectrumTypeEnum.Jonswap;
            }
            else
            {
                SelectParam.SpectrumType = Data.SpectrumTypeEnum.PM;
            }

            // 判断用户选择的周期类型
            if (((bool)rbTp.IsChecked))
            {
                SelectParam.TzTpType = Service.TzTpEnum.Tp;
            }
            else
            {
                SelectParam.TzTpType = Service.TzTpEnum.Tz;
            }

            SelectParam.Selected = true;
            GlobalParamView.SpectrumParam = SelectParam;
            Close();
        }

        private void rbPM_Checked(object sender, RoutedEventArgs e)
        {
            if(tbR != null)
            tbR.IsEnabled = false;
        }

        private void rbJONSWAP_Checked(object sender, RoutedEventArgs e)
        {
            if(tbR != null)
            tbR.IsEnabled = true;
        }

        private void SelectSpectrumTypeWindow_Loaded(object sender, RoutedEventArgs e)
        {
         //   var brush = new ImageBrush();
         //   brush.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Resources/background.jpg"));
         //   brush.Opacity = 0.5;
         //   this.Background = brush;

            if (rbPM.IsChecked.HasValue && ((bool)rbPM.IsChecked) && tbR != null)
            {
                tbR.IsEnabled = false;
            }

            if (GlobalParamView.SpectrumParam == null)
                return;

            // Initial Params
            tbNumOfND.Text = GlobalParamView.SpectrumParam.NumOfND.ToString();
            if(GlobalParamView.SpectrumParam.SpectrumType == Data.SpectrumTypeEnum.PM)
            {
                rbPM.IsChecked = true;
            }else if(GlobalParamView.SpectrumParam.SpectrumType == Data.SpectrumTypeEnum.Jonswap)
            {
                rbJONSWAP.IsChecked = true;
                tbR.Text = GlobalParamView.SpectrumParam.R.ToString();
            }

            if(GlobalParamView.SpectrumParam.TzTpType == Service.TzTpEnum.Tp)
            {
                rbTp.IsChecked = true;
            }else if(GlobalParamView.SpectrumParam.TzTpType == Service.TzTpEnum.Tz)
            {
                rbTz.IsChecked = true;
            }

            
        }

        /// <summary>
        /// 导入波浪长期分布表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnWaveData_Click(object sender, RoutedEventArgs e)
        {
            await globalParam.LoadSeaWaveData(this);
        }

        /// <summary>
        /// 导入方向概率
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnDirectionProbalility_Click(object sender, RoutedEventArgs e)
        {
            await globalParam.LoadDirectionProbalility(this);
        }

        private void rbTp_Checked(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
