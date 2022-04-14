using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts;
using LiveCharts.Charts;
using LiveCharts.Wpf;
using SeaDataProcess.Data;

namespace SeaDataProcess.Views
{
    public class TransferFunctionChartControlView:BaseEntity
    {
        public TransferFunctionChartControlView()
        {

        }

        public TransferFunctionChartControlView(IEnumerable<JointChartValues> chartValues)
        {
            if(chartValues.Any())
                Initial(chartValues);
        }

       
        private ChartValues<double> yValues;
        private ObservableCollection<string> xLabels;

        private void Initial(IEnumerable<JointChartValues> chartValues)
        {
            XLabels = new ObservableCollection<string>(chartValues.Select(x => string.Format("{0} {1}",Math.Round(x.AvgDeltaSigmaValue, 2), "MPa")));
            YValues = new ChartValues<double>(chartValues.Select(x => x.SumNValue));
        }

        private string sheetName;
        public string SheetName
        {
            get
            {
                return sheetName;
            }
            set
            {
                sheetName = value;
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
            set { xLabels = value;RaisedPropertyChanged(); }
        }

        private string xTitle;
        private string yTitle;

        public string XTitle
        {
            get { return xTitle; }
            set { xTitle = value; RaisedPropertyChanged(); }
        }

        public string YTitle
        {
            get { return yTitle; }
            set { yTitle = value; RaisedPropertyChanged(); }
        }
    }

}
