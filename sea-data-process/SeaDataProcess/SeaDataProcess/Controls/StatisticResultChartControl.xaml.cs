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
using SeaDataProcess.Views;
using LiveCharts.Charts;
using LiveCharts.Wpf;

namespace SeaDataProcess.Controls
{
    /// <summary>
    /// Interaction logic for TransferFunctionChartControl.xaml
    /// </summary>
    public partial class StatisticResultChartControl : MetroContentControl
    {
        public StatisticResultChartControl()
        {
            InitializeComponent();
        }

        public CartesianChart TransferChart
        {
            get
            {
                return transferChart;
            }
        }

        public StatisticResultChartControl(TransferFunctionChartControlView view)
        {
            InitializeComponent();
            this.view = view;

            var maxY = view.YValues.Max();
            axisY.MaxValue = maxY + Math.Round(maxY / 10);
        }

        private TransferFunctionChartControlView view;

        private void TransferFunctionChartControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = view;
        }

        internal void UpdateChart()
        {
            transferChart.Update(true, true);
        }
    }
}
