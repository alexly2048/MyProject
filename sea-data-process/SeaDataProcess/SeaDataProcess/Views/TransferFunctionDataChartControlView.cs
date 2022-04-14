using LiveCharts;
using SeaDataProcess.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcess.Views
{
    public class TransferFunctionDataChartControlView:BaseEntity
    {

        public TransferFunctionDataChartControlView()
        {

        }

        public TransferFunctionDataChartControlView(TransferFunctionDataList transferDataList)
        {
            if (transferDataList != null && transferDataList.Datas.Count != 0)
                Initial(transferDataList);
        }

        private ChartValues<double> yValues;
        private ObservableCollection<string> xLabels;

        private void Initial(TransferFunctionDataList transferDataList)
        {
            var xs = new ObservableCollection<string>();
            var ys = new ChartValues<double>();
            for (double i = 0.01; i <= 1; i = i + 0.01)
            {
                xs.Add(Math.Round(i, 2).ToString());
                ys.Add(transferDataList.CalculateG(i));
            }
            XLabels = xs;
            YValues = ys;
            OrderNO = "#" + transferDataList.OrderNO.ToString();
        }

        private string orderNO;
        public string OrderNO
        {
            get
            {
                return orderNO;
            }
            set
            {
                orderNO = value;
                RaisedPropertyChanged();
            }
        }

        /// <summary>
        /// Y轴数值
        /// </summary>
        public ChartValues<double> YValues
        {
            get { return yValues; }
            set { yValues = value; RaisedPropertyChanged(); }
        }
        /// <summary>
        /// x轴显示的坐标
        /// </summary>
        public ObservableCollection<string> XLabels
        {
            get { return xLabels; }
            set { xLabels = value; RaisedPropertyChanged(); }
        }
    }
}
