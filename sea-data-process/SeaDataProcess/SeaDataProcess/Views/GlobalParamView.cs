using MahApps.Metro.Controls;
using Microsoft.Win32;
using SeaDataProcess.Controls;
using SeaDataProcess.Data;
using SeaDataProcess.Helper;
using SeaDataProcess.Service.Services;
using SeaDataProcess.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SeaDataProcess.Views
{
    public class GlobalParamView:BaseEntity
    {
        public static SelectSpectrumParam SpectrumParam { get; set; }
        public static IEnumerable<SeaData> SeaWaveData { get; private set; }
        public static IEnumerable<DirectionProbabilityData> DirectionProbabilityDatas { get; set; }

        private readonly SeaWaveDataService seaWaveDataService = new SeaWaveDataService();
        private readonly DirectionProbabilityTableService directionProbalilityService = new DirectionProbabilityTableService();

        public async void InitialDatas()
        {
            DirectionProbabilityDatas =  await directionProbalilityService.GetDirectionProbabilityDataFromJson();
        }

        /// <summary>
        /// 导入波浪长期分布表
        /// </summary>
        public async Task<bool> LoadSeaWaveData(MetroWindow window)
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = "Excel2007-2010|*.xlsx|Excel2003-2007|*.xls";
            dialog.RestoreDirectory = true;
            dialog.ShowDialog();
            if (!string.IsNullOrEmpty(dialog.FileName))
            {
                if (FileHelper.FileIsOpen(dialog.FileName))
                {
                    await DialogHelper.ShowAffirmative(window ,$"数据文件{dialog.FileName}被占用，请关闭文件后重试");
                    return false;
                }
                SeaWaveData = seaWaveDataService.LoadSeadWaveDatas(dialog.FileName);
                await DialogHelper.ShowAffirmative(window, $"已成功加载\n{dialog.FileName}\n波浪长期分布数据");
                return true;
            }
            else
            {
                SeaWaveData = null;
                return false;
            }
        }

        /// <summary>
        /// 导入方向概率
        /// </summary>
        public async Task LoadDirectionProbalility(MetroWindow window)
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = "csv文件|*.csv|txt文件|*.txt";
            dialog.RestoreDirectory = true;
            dialog.ShowDialog();
            if (!string.IsNullOrEmpty(dialog.FileName))
            {
                if (FileHelper.FileIsOpen(dialog.FileName))
                {
                    await DialogHelper.ShowAffirmative(window, $"数据文件{dialog.FileName}被占用，请关闭文件后重试");
                    return;
                }
                DirectionProbabilityDatas = directionProbalilityService.GetDirectionProbabilityDatas(dialog.FileName);
                // when user load direciton probability datas, save this new data into json.
                await directionProbalilityService.SaveDirectionProbabilityDataToJson(DirectionProbabilityDatas);
                await DialogHelper.ShowAffirmative(window, $"已成功加载\n{dialog.FileName}\n波浪长期分布数据");
            }
            else
            {
                SeaWaveData = null;
                return;
            }
        }


        #region 导入传递函数概率表
        private readonly TransferFunctionService transferFunctionService = new TransferFunctionService();
        private static TransferFunctionFrequencyList transferFrequencyList = null;

        public static TransferFunctionFrequencyList TransferFrequencyList
        {
            get
            {
                return transferFrequencyList;
            }
        }


        /// <summary>
        /// 传递函数概率表
        /// </summary>
        /// <returns></returns>
        public async Task<bool> LoadTransferFunctionFrequencyTable()
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "txt文件|*.txt";
            dialog.Multiselect = false;
            dialog.RestoreDirectory = true;
            dialog.ShowDialog();
            string filePath = dialog.FileName;
            if (!string.IsNullOrEmpty(filePath))
            {
                transferFrequencyList = await transferFunctionService.LoadTransferFunctionFrequency(filePath);
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 导入传递函数表

        private static IEnumerable<TransferFunctionDataList> transferFunctionDatas; // 传递函数表
        public static IEnumerable<TransferFunctionDataList> TransferFunctionDatas
        {
            get { return transferFunctionDatas; }
        }

        public static TransferFunctionColEnum? TransferFunctionCol { get; set; } // 设置传递函数计算使用的列值

        /// <summary>
        /// 从文件中加载传递函数
        /// </summary>
        /// <returns></returns>
        public async Task<bool> LoadTransferFunctionTable()
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "txt文件|*.txt";
            dialog.Multiselect = false;
            dialog.RestoreDirectory = true;
            dialog.ShowDialog();
            string filepath = dialog.FileName;
            if (!string.IsNullOrEmpty(filepath))
            {
                transferFunctionDatas = await transferFunctionService.LoadTransferFunctionDatas(filepath);
                await DialogHelper.ShowAffirmative($"已成功加载文件{filepath}中传递函数");
                return true;
            }
            else
            {
                await DialogHelper.ShowAffirmative($"传递函数导入失败");
                return false;
            }
        }

        
        #endregion

        #region 生成传递函数曲线图
        private ObservableCollection<TabItem> transferDataItems;

        public ObservableCollection<TabItem> TransferDataItems
        {
            get
            {
                return transferDataItems;
            }
            set
            {
                transferDataItems = value;
                RaisedPropertyChanged();
            }
        }

        /// <summary>
        /// 生成传递函数曲线
        /// </summary>
        public async Task GenerateTransferDataTabItems()
        {
            var r = await HandleTransferFunctionData();
            if (!r)
                return;

            var controls = new ObservableCollection<TabItem>();
            foreach (var data in transferFunctionDatas)
            {
                var item = new TabItem();
                item.Header = string.Format("{0}_{1}", "Transfer Function", data.OrderNO);
                item.TabIndex = data.OrderNO;
                var transferDataView = new TransferFunctionDataChartControlView(data);
                var control = new TransferFunctionDataChartControl(transferDataView);
                item.Content = control;
                controls.Add(item);
            }

            TransferDataItems = controls;
        }
        #endregion

        #region 处理传递函数与函数
        /// <summary>
        /// 处理传递函数值与概率问题
        /// </summary>
        /// <returns></returns>
        private async Task<bool> HandleTransferFunctionData()
        {
            if (transferFunctionDatas == null || transferFunctionDatas.Count() == 0)
            {
                await DialogHelper.ShowAffirmative("请导入传递函数数据");
                return false;
            }

            if (transferFrequencyList == null || transferFrequencyList.FrequencyList.Count == 0)
            {
                await DialogHelper.ShowAffirmative("请先导入传递函数频率数据");
                return false;
            }
            // 使用并行计算，将传递函数值与概率做匹配
            Parallel.ForEach(transferFunctionDatas, list =>
            {
                foreach (var l in list.Datas)
                {
                    var f = transferFrequencyList.FrequencyList.FirstOrDefault(x => x.FreqNO == l.FreqNO);

                    if (f == null)
                        f = transferFrequencyList.FrequencyList.FirstOrDefault(x => x.FreqNO == (l.FreqNO - 1));

                    l.Frequency = f?.Frequency ?? throw new Exception($"未能找到标号{l.FreqNO}对应的频率信息");
                }
            });

            return true;
        }

        /// <summary>
        /// 计算时小数点后保留位数
        /// </summary>
        public static int DecimalNum { get; set; } = 4;

        #endregion

        #region 记录计算相关参数
        public static double? M { get; set; }
        public static double? DeltaSigmaZero { get; set; }
        #endregion
    }
}
