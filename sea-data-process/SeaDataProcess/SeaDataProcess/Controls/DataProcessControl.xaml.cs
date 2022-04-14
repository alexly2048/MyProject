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
    /// Interaction logic for DataProcessControl.xaml
    /// </summary>
    public partial class DataProcessControl : MetroContentControl
    {
        public DataProcessControl()
        {
            InitializeComponent();
        }

        private readonly DataProcessControlView calculateView = new DataProcessControlView();
        
        /// <summary>
        /// 在计算之前，必须加载三张表的数据
        /// 必须输入四个参数
        /// created by liyan
        /// at 2021-05-13
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            // 1. 获取参数
            if(GlobalParamView.SpectrumParam == null)
            {
                await DialogHelper.ShowAffirmative("请在基础参数配置界面设置基础参数");
                return;
            }
            // 2. 方向概率
            if(GlobalParamView.DirectionProbabilityDatas == null)
            {
                await DialogHelper.ShowAffirmative("请在菜单中选择导入波浪长期分布概率");
                return;
            }
            // 3. 长期分布
            if(GlobalParamView.SeaWaveData == null)
            {
                await DialogHelper.ShowAffirmative("请在菜单中选择导入波浪长期分布数据");
                return;
            }
            var validation = await GetFourParams();
            if (!validation)
            {
                await DialogHelper.ShowAffirmative("请在本界面左侧输入计算所需参数");
                return;
            }

            if(!(await calculateView.Calculate()))
            {
                await DialogHelper.ShowAffirmative("计算失败");
            }

            tabChart.Items.Clear();
            // 向控件中添加图表
            if (calculateView.TabControlItems.Any())
                foreach (var item in calculateView.TabControlItems)
                {
                    tabChart.Items.Add(item);
                }
            else
                MessageBox.Show("统计结果为0");

            btnStatistic.IsEnabled = true;
        }

        /// <summary>
        /// 获取四个参数
        /// created by liyan
        /// at 2021-05-13
        /// </summary>
        /// <returns></returns>
        private async Task<bool> GetFourParams()
        {
            double value;

            #region 获取裂纹增长参数
            if (double.TryParse(tM.Text, out value))
            {
                if(value<1 || value > 10)
                {
                    await DialogHelper.ShowAffirmative("裂纹增长参数取值范围：[1-10],请重新输入");
                    return false;
                }
            }
            else
            {
                await DialogHelper.ShowAffirmative("请输入裂纹增长参数");
                return false;
            }
            calculateView.M = value;
            GlobalParamView.M = value;
            #endregion

            #region 获取应力幅阈值
            if (double.TryParse(tSigma0.Text, out value))
            {
                if (value < 0 || value > 300)
                {
                    await DialogHelper.ShowAffirmative("应力幅阈值取值范围：[0-300),请重新输入");
                    return false;
                }
            }
            else
            {
                await DialogHelper.ShowAffirmative("请输入应力幅阈值");
                return false;
            }
            calculateView.DeltaSigmaZero = value;
            GlobalParamView.DeltaSigmaZero = value;
            #endregion

            #region 应力幅步长，sigmaD
            if (double.TryParse(tD.Text, out value))
            {
                if (value <= 0 || value > 100)
                {
                    await DialogHelper.ShowAffirmative("应力幅步长取值范围：[0-100),请重新输入");
                    return false;
                }
            }
            else
            {
                await DialogHelper.ShowAffirmative("请输入应力幅步长");
                return false;
            }
            calculateView.SigmaD = value;
            #endregion

            #region 频率步长
            if (double.TryParse(tFD.Text, out value))
            {
                if (value <= 0 || value > 1)
                {
                    await DialogHelper.ShowAffirmative("频率步长取值范围：[0.01-1],请重新输入");
                    return false;
                }
            }
            else
            {
                await DialogHelper.ShowAffirmative("请输入频率步长");
                return false;
            }
            calculateView.FD = value;
            #endregion

            return true; // if all validation passed, the return true.
        }

        /// <summary>
        /// Export image to word
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnExport_Click(object sender, RoutedEventArgs e)
        {
            if (await calculateView.ExportToWord()) 
            {
                await DialogHelper.ShowAffirmative("导出成功");
            };
            
        }

        /// <summary>
        /// 结果整理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStatistic_Click(object sender, RoutedEventArgs e)
        {
            calculateView.GenerateStastisticChart();
            tabChart.Items.Clear();

            if (calculateView.StatisticResultItem == null)
            {
                MessageBox.Show("没有要统计的数据");
                return;
            }

            tabChart.Items.Add(calculateView.StatisticResultItem);

            tabChart.Focus();
            tabChart.SelectedIndex = 0;
            btnExport.IsEnabled = true; // 结果统计完成后，允许导出
        }

        private void DataProcessControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = calculateView;
            btnStatistic.IsEnabled = false;
            btnExport.IsEnabled = false;

            if (GlobalParamView.M.HasValue)
                tM.Text = GlobalParamView.M.ToString();
            if (GlobalParamView.DeltaSigmaZero.HasValue)
                tSigma0.Text = GlobalParamView.DeltaSigmaZero.ToString();
        }

    }
}
