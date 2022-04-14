using Microsoft.Win32;
using NPOI.XWPF.UserModel;
using SeaDataProcess.Controls;
using SeaDataProcess.Data;
using SeaDataProcess.Service;
using SeaDataProcess.Service.Services;
using SeaDataProcess.Services;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using NPOI.Util;
using System.Windows;
using LiveCharts;
using LiveCharts.Wpf;

namespace SeaDataProcess.Views
{
    public class DataProcessControlView : BaseEntity
    {
        private SpectrumService spectrumService = new SpectrumService();
        private ProjectDataList projectDataList = new ProjectDataList(); // 存储所有Sheet计算结果
        private ObservableCollection<TabItem> tabControlItems = new ObservableCollection<TabItem>();

        public ObservableCollection<TabItem> TabControlItems
        {
            get
            {
                return tabControlItems;
            }
            set
            {
                tabControlItems = value;
                RaisedPropertyChanged();
            }
        }

        /// <summary>
        /// 裂纹增长参数
        /// value: [1-10]
        /// </summary>
        public double M { get; set; } = -1;
        /// <summary>
        /// 应力幅阈值
        /// value: [0-300]
        /// </summary>
        public double DeltaSigmaZero { get; set; } = -1;
        /// <summary>
        /// 应力幅步长
        /// value: (0-100]
        /// </summary>
        public double SigmaD { get; set; } = 1; // default sigma_d = 1Mpa;
        /// <summary>
        /// 频率步长
        /// value: [0.01-1]
        /// </summary>
        public double FD { get; set; } = 0.01;



        public const double FD_MIN_VALUE = 0.03;
        public const double FD_MAX_VALUE = 0.8;

        /// <summary>
        /// 计算最终数据
        /// </summary>
        /// <param name="globalParam"></param>
        public async Task<bool> Calculate()
        {
            var original_data = GlobalParamView.SeaWaveData; // 波浪长期分布数据
            projectDataList.TableList.Clear();
            statisticResultItem = null; // 计算时，清空统计计算结果

            var transferFunctionDatas = GlobalParamView.TransferFunctionDatas.ToList(); // 传递函数
            var transferFrequencyList = GlobalParamView.TransferFrequencyList; // 传递函数概率

            if (transferFunctionDatas == null || transferFunctionDatas.Count() == 0)
            {
                await DialogHelper.ShowAffirmative("请先导入传递函数数据");
                return false;
            }

            if (transferFrequencyList.FrequencyList == null || !transferFrequencyList.FrequencyList.Any())
            {
                await DialogHelper.ShowAffirmative("请先导入传递函数频率数据");
                return false;
            }

            if (M == -1)
            {
                await DialogHelper.ShowAffirmative("请先设置M值");
                return false;
            }
            if (DeltaSigmaZero == -1)
            {
                await DialogHelper.ShowAffirmative("请先输入∆σ0值");
                return false;
            }

            // 处理Joint数据表和Frequency数据表，将Frequency数据添加到Joint数据表中
            if (!(await HandleTransferFunctionData(transferFunctionDatas, transferFrequencyList)))
                return false;

            var stepList = new BlockingCollection<JointCalculateResult>();

            // parallel handle the original data
            Parallel.ForEach(original_data, data =>
            {

                var first_col = data.Data.Columns[0];
                var second_col = data.Data.Columns[1];

                var current_transfer = transferFunctionDatas.FirstOrDefault(t => t.OrderNO == data.OrderNO); // 获取对应的传递函数表
                if (current_transfer == null)
                    current_transfer = transferFunctionDatas.FirstOrDefault(t => t.OrderNO == data.Index);
                if (current_transfer == null)
                    throw new Exception($"未能找到波浪长期分布表{data.Name}对应的传递函数");
                if (!GlobalParamView.TransferFunctionCol.HasValue)  // 判断用户是否选择使用的传递函数值
                    throw new Exception($"请选择计算所需传递函数的列值");

                current_transfer.SelectedCol = (TransferFunctionColEnum)GlobalParamView.TransferFunctionCol;

                // start the calculate the real data
                var list = new JointCalculateResult();
                list.TableName = data.Name;
                list.SheetIndex = data.Index;

                // 处理一个表中的数据
                for (int i = 0; i < data.Data.Rows.Count; i++) // 行
                {
                    for (int j = 2; j < data.Data.Columns.Count; j++) // 列
                    {
                        var probability = double.Parse(data.Data.Rows[i][j].ToString());  // 波浪长期分布表中概率
                        if (probability == 0)
                            continue;

                        #region 计算Hs(m)
                        double hs;
                        double tmp_hs_low = -999, tmp_hs_hight = -999;
                        if (double.TryParse(data.Data.Rows[i][0].ToString(), out tmp_hs_low) &&
                            double.TryParse(data.Data.Rows[i][1].ToString(), out tmp_hs_hight))
                        {
                            hs = (tmp_hs_low + tmp_hs_hight) / 2;
                        }
                        else if (double.TryParse(data.Data.Rows[i][0].ToString(), out tmp_hs_low))
                        {
                            hs = tmp_hs_low;
                        }
                        else if (double.TryParse(data.Data.Rows[i][1].ToString(), out tmp_hs_hight))
                        {
                            hs = tmp_hs_hight;
                        }
                        else
                        {
                            continue;
                        }
                        #endregion

                        var tptz_cols = data.Data.Columns[j].ColumnName.ToString().Split(new char[] { '-', '>', '<' }, StringSplitOptions.RemoveEmptyEntries);

                        #region 计算TpTz
                        double tptz;
                        if (!double.TryParse(tptz_cols[0], out tptz))
                            continue;

                        if (tptz_cols.Length == 1)
                        {
                            tptz = double.Parse(tptz_cols[0]);
                        }
                        else
                        {
                            tptz = (double.Parse(tptz_cols[0]) +
                                        double.Parse(tptz_cols[1])) / 2;
                        }
                        #endregion

                        // calculate T
                        var direction_probability = GlobalParamView.DirectionProbabilityDatas.FirstOrDefault(x => x.Index == data.Index); // 根据Index获取方向概率
                        if (direction_probability == null)
                            throw new Exception($"未能找到表{data.Name}的方向概率");
                        double T = 365 * 24 * 60 * 60 * probability * direction_probability.DecimalPercentage / 100;

                        #region 积分求m0, m2, Te
                        // calculate S_ηη (0.01)，G（0.01）S_σσ（0.01）
                        double s_sigma_sum = 0;
                        double s_sigma_power = 0;

                        for (double fd = FD_MIN_VALUE; fd <= FD_MAX_VALUE; fd = fd + FD)
                        {
                            double s_ni = spectrumService.CalculateSpectrum(hs,
                                tptz,
                                tptz,
                                fd,
                                GlobalParamView.SpectrumParam.R,
                                GlobalParamView.SpectrumParam.SpectrumType,
                                GlobalParamView.SpectrumParam.TzTpType); // 有效精度4位

                            double g = Math.Round( current_transfer.CalculateG(fd), Service.GlobalParam.DecimalNum); // 有效精度4位

                            s_sigma_sum += Math.Round( g * g * s_ni, Service.GlobalParam.DecimalNum);

                            s_sigma_power += Math.Round( (g * g * s_ni) *  fd * fd, Service.GlobalParam.DecimalNum);
                        }

                        double m0 = s_sigma_sum * Math.Round(FD, Service.GlobalParam.DecimalNum);
                        double m2 = s_sigma_power * Math.Round(FD, Service.GlobalParam.DecimalNum);
                        double te = Math.Sqrt(m0 / m2);
                        #endregion

                        #region 计算p(σ), Δσe, N
                        // step 6, 7, 8, calculate ∆σ_e
                        // calculate limit max
                        double sigma_u = Math.Sqrt(8 * m0 * Math.Log(3 * 60 * 60 / te)); // 计算积分上限

                        double delta_sigma_e_sum = 0; // 有效应力幅积分
                        double delta_sigma_e_denominator_sum = 0;
                        double ns_sum = 0; // 有效次数积分
                        double delta_sigma_e = 0; // 应力幅

                        if (DeltaSigmaZero > sigma_u)
                            continue;

                        // 有效应力幅
                        if (DeltaSigmaZero <= sigma_u)
                        {
                            for (double sigma = DeltaSigmaZero; sigma <= sigma_u; sigma = sigma + SigmaD)
                            {
                                // 分子
                                delta_sigma_e_sum += Math.Round( sigma / (4 * m0)
                                                    * Math.Exp(-sigma * sigma / 8 / m0)
                                                    * Math.Pow(sigma, M), Service.GlobalParam.DecimalNum);
                                // 分母
                                delta_sigma_e_denominator_sum += Math.Round( sigma / (4 * m0)
                                                    * Math.Exp( -sigma * sigma / 8 / m0), Service.GlobalParam.DecimalNum);
                            }
                            delta_sigma_e = Math.Pow(delta_sigma_e_sum / delta_sigma_e_denominator_sum, 1 / M);
                        }
                        // 有效次数
                        for (double sigma = 0; sigma <= DeltaSigmaZero; sigma = sigma + SigmaD)
                        {
                            ns_sum += Math.Round( sigma / (4 * m0) * Math.Exp(-sigma * sigma / 8 / m0), Service.GlobalParam.DecimalNum);
                        }


                        double ns = T / te * (1 - ns_sum * SigmaD);
                        if ((3 * 60 * 60 / te * (1 - ns_sum * SigmaD)) < 1) // ns计算数值小于1时，= 0
                            ns = 0;
                        //    double n = T / ns;
                        #endregion
                        var step = new StepData
                        {
                            Row = i,
                            Col = j,
                            DeltaSigmaValue = double.IsNaN(delta_sigma_e) ? 0 : delta_sigma_e,
                            NValue = Math.Round(ns)
                        };
                        if(step.DeltaSigmaValue > 0)
                            list.StepDataList.Add(step);
                    }
                }

                // 去除不包含 有效数据 或 NVaue全部等于0 或 有效应力幅等于0 的数据
                if(list.StepDataList.Count != 0 && !list.StepDataList.All(x=>x.DeltaSigmaValue == 0 || x.NValue == 0))
                    stepList.Add(list);
            });


            projectDataList.TableList = stepList.ToList(); // store all result

            // 根据计算结果，生成图表
            GenerateJointChartTabItems();

            return true;
        }


        /// <summary>
        /// 生成图表控件
        /// </summary>
        private void GenerateJointChartTabItems()
        {
            if (projectDataList.TableList.Count == 0)
            {
                TabControlItems = new ObservableCollection<TabItem>();
                return;
            }
                

            var list = projectDataList.TableList;
            var controls = new ObservableCollection<TabItem>();
            foreach (var joint in list)
            {
                var item = new TabItem();
                item.Header = joint.TableName;

                var chartView = new TransferFunctionChartControlView(joint.GetJointChartValues());
                var chartControl = new TransferFunctionChartControl(chartView);
                item.Content = chartControl;

                controls.Add(item);
            }

            // 设置图表控件
            TabControlItems = controls;
        }

        #region 按照用户设置间隔统计数据
        private double statisticStep = 5;
        public double StatisticStep
        {
            get
            {
                return statisticStep;
            }
            set
            {
                statisticStep = value;
                RaisedPropertyChanged();
            }
        }

        private TabItem statisticResultItem;
        public TabItem StatisticResultItem
        {
            get { return statisticResultItem; }
            set
            {
                statisticResultItem = value;
            }
        }

        private ObservableCollection<JointChartValues> statisticResults;
        private ObservableCollection<JointChartValues> StatistcResults
        {
            get { return statisticResults; }
            set { statisticResults = value; RaisedPropertyChanged(); }
        }

        /// <summary>
        /// 按照统计间隔进行统计汇总
        /// </summary>
        public void GenerateStastisticChart()
        {
            if (projectDataList.TableList.Count == 0)
            {
                statisticResultItem = null;
                return;
            }
                
            if (StatisticStep <= 0)
                return;
            // 将所有Table中的计算结果进行汇总
            var list = projectDataList.TableList.SelectMany(x => x.StepDataList).ToList();
            // 找到最小应力幅值
            var min_delta_sigma_value = list.Min(x => x.DeltaSigmaValue);
            // 找到最大应力幅值
            var max_delta_sigma_value = list.Max(x => x.DeltaSigmaValue);
            // 计算开始的最小间隔序号
            var min_step = Math.Floor(list.Min(x => x.DeltaSigmaValue) / StatisticStep);
            // 找到最大的序号
            var max_step = Math.Floor(list.Max(x => x.DeltaSigmaValue) / StatisticStep);
            // 计算所需的步数
            var step_count = max_step - min_step + 1;

            var chartValues = new List<JointChartValues>();
            for (double i = min_step; i < min_step + step_count; i++)
            {
                // 查找每个区间内的数值
                var rangs = list.Where(x => x.DeltaSigmaValue >= i * StatisticStep && x.DeltaSigmaValue < (i + 1) * StatisticStep)
                                .ToList();
                if (rangs.Count() == 0)
                    continue;

                double n_sum_denominator = 0;
                double n_sum_molecule = 0;

                n_sum_molecule = rangs.Sum(x => Math.Pow(x.DeltaSigmaValue, M) * x.NValue);
                n_sum_denominator = rangs.Sum(x => x.NValue);

                if (n_sum_denominator == 0) // 如果NValue等于0时，忽略，进行下一个计算
                    continue;

                var chartValue = new JointChartValues
                {
                    // 计算应力幅平均值
                    AvgDeltaSigmaValue = Math.Round(Math.Pow(n_sum_molecule / n_sum_denominator, 1/M),2),
                    // 计算N的和
                    SumNValue = Math.Round( n_sum_denominator, 2),
                    Range = i
                };
                chartValues.Add(chartValue);
            }

            chartValues = chartValues.OrderBy(x => x.AvgDeltaSigmaValue).ToList();
            StatistcResults = new ObservableCollection<JointChartValues>(chartValues);

            var item = new TabItem();
            item.Header = "统计结果";

            var chartView = new TransferFunctionChartControlView(chartValues);
            var chartControl = new StatisticResultChartControl(chartView);
            item.Content = chartControl;

            StatisticResultItem = item;
        }
        #endregion 


        private string exportPath = Path.Combine(AppContext.BaseDirectory, "ExportDir");
        /// <summary>
        /// 处理传递函数值与概率问题
        /// </summary>
        /// <returns></returns>
        private async Task<bool> HandleTransferFunctionData(List<TransferFunctionDataList> transferFunctionDatas, TransferFunctionFrequencyList transferFrequencyList)
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
            // parallel handling the transfer function data
            Parallel.ForEach(transferFunctionDatas, list =>
            {
                foreach (var l in list.Datas)
                {
                    var f = transferFrequencyList.FrequencyList.FirstOrDefault(x => x.FreqNO == l.FreqNO);
                    if (f == null)
                        f = transferFrequencyList.FrequencyList.FirstOrDefault(x => x.FreqNO == (l.FreqNO - 1));

                    l.Frequency =f?.Frequency ?? throw new Exception($"未能找到标号{l.FreqNO}对应的频率信息");
                }
            });

            return true;
        }


        #region Export Images
        public async Task<bool> ExportToWord()
        {
            if (StatisticResultItem == null || StatistcResults.Count == 0)
            {
                await DialogHelper.ShowAffirmative("没有要导出的数据");
                return false;
            }

            var dialog = new SaveFileDialog();
            dialog.Filter = "Word2010|*.docx|All Files|*.*";
            var r = dialog.ShowDialog();
            if (r.HasValue && (bool)r)
            {
                var file_name = dialog.FileName;
                if (string.IsNullOrEmpty(file_name))
                {
                    await DialogHelper.ShowAffirmative("请输入文件名");
                    return false;
                }
                else
                {
                    XWPFDocument doc = new XWPFDocument();
                    // create doc

                    XWPFParagraph paramContent = doc.CreateParagraph();
                    paramContent.Alignment = ParagraphAlignment.LEFT;
                    var paramRun = paramContent.CreateRun();

                    var sb = new StringBuilder();
                    if(GlobalParamView.SpectrumParam.SpectrumType == SpectrumTypeEnum.Jonswap)
                    {
                        sb.Append(string.Format("海浪谱类型=Jonswap,峰升因子r={0};", GlobalParamView.SpectrumParam.R));
                    }
                    else
                    {
                        sb.Append("海浪谱类型=PM；");
                    }
                    var total_n = projectDataList.TableList.Sum(x => x.StepDataList.Sum(y => y.NValue));
                    sb.Append(string.Format("T={0}s； N={1}； 裂纹增长参数m={2}; 应力幅阈值={3}Mpa; 应力幅统计间隔={4}Mpa",
                        365 * 24 * 60 * 60,Math.Round(total_n),M,DeltaSigmaZero,StatisticStep));
                    paramRun.SetText(sb.ToString());

                    #region 导出统计数据
                    var cols = 3; // 列数
                    var rows = StatistcResults.Count + 1; // 行数
                    var table = doc.CreateTable(rows, cols);

                    // 设置表格宽度
                    table.Width = 1000 * cols;
                    table.SetColumnWidth(0, 1000);
                    table.SetColumnWidth(1, 1000);
                    table.SetColumnWidth(2, 1000);
                    // 设置标题
                    table.GetRow(0).GetCell(0).SetText("序号");
                    table.GetRow(0).GetCell(1).SetText("应力幅(MPa)");
                    table.GetRow(0).GetCell(2).SetText("次数");

                    // 设置内容
                    for (int i = 0; i < statisticResults.Count; i++)
                    {
                        table.GetRow(i + 1).GetCell(0).SetText((i + 1).ToString());
                        table.GetRow(i + 1).GetCell(1).SetText(StatistcResults[i].AvgDeltaSigmaValue.ToString());
                        table.GetRow(i + 1).GetCell(2).SetText(StatistcResults[i].SumNValue.ToString());
                    }
                    #endregion

                    #region Obselete
                    /*
                    var item = (StatisticResultChartControl)StatisticResultItem.Content;
                    var rect = VisualTreeHelper.GetDescendantBounds(item);
                    DrawingVisual dv = new DrawingVisual();
                    using (DrawingContext ctx = dv.RenderOpen())
                    {
                        VisualBrush brush = new VisualBrush(item);
                        ctx.DrawRectangle(brush, null, new System.Windows.Rect(rect.Size));
                    }
                    int width = (int)item.ActualWidth;
                    int height = (int)item.ActualHeight;

                    RenderTargetBitmap bitmap = new RenderTargetBitmap(width, height, 96, 96, PixelFormats.Pbgra32);
                    bitmap.Render(dv);

                    PngBitmapEncoder encoder = new PngBitmapEncoder();
                    
                    encoder.Frames.Add(BitmapFrame.Create(bitmap));

                    if (!Directory.Exists(exportPath))
                        Directory.CreateDirectory(exportPath);

                    if (File.Exists(filePath))
                        File.Delete(filePath);
                    using (var fs = new FileStream(filePath, FileMode.CreateNew, FileAccess.Write))
                    {
                        encoder.Save(fs);
                        fs.Flush();
                    }
                    */
                    #endregion

                    if (!Directory.Exists(exportPath))
                        Directory.CreateDirectory(exportPath);
                    var filePath = Path.Combine(exportPath, "tmp.png");
                    
                    ExportToPng(Path.Combine(exportPath, filePath));
                                   
                    XWPFParagraph p = doc.CreateParagraph();
                    p.Alignment = ParagraphAlignment.LEFT;
                    XWPFRun run = p.CreateRun();

                    using (var png = System.Drawing.Image.FromFile(filePath))
                    {
                        using (var bp = new Bitmap(png.Width, png.Height))
                        {
                            bp.SetResolution(png.HorizontalResolution, png.VerticalResolution);

                            using (var g = Graphics.FromImage(bp))
                            {
                                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
                                g.Clear(System.Drawing.Color.White);
                                
                                g.DrawImageUnscaled(png, 0, 0);
                            }

                            using (var ms = new MemoryStream())
                            {
                                bp.Save(ms, ImageFormat.Jpeg);
                                ms.Seek(0, SeekOrigin.Begin);
                                run.AddPicture(ms, (int)PictureType.JPEG, "Statistic Picture", 600 * 9525, 350 * 9525);
                            }
                        }
                    }

                    // save content to docx.
                    using (var fs = new FileStream(file_name, FileMode.CreateNew, FileAccess.Write))
                    {
                        doc.Write(fs);
                    }
                    return true;
                }
            }
            else
            {
                return false;
            }

        }

        public void ExportToPng(string fileName)
        {
            var r =(System.Windows.Media.Color)Application.Current.FindResource("MahApps.Colors.Accent");
            var myChart = new LiveCharts.Wpf.CartesianChart
            {
                DisableAnimations = true,
                Width =600,
                Height = 350,
                SeriesColors = new ColorsCollection {r}
            };

            var columnSeries = new ColumnSeries();          
            columnSeries.Values = new ChartValues<double>(StatistcResults.Select(x => x.SumNValue));
            columnSeries.Title = "次数（N）";
            columnSeries.Foreground = new SolidColorBrush(System.Windows.Media.Colors.Black);
            columnSeries.DataLabels = false;
            myChart.Series = new SeriesCollection()
            {
                columnSeries
            };

            var axisX = new Axis();
            axisX.Title = "应力幅（MPa）";
            axisX.Labels = StatistcResults.Select(x => x.AvgDeltaSigmaValue.ToString()).ToList();
            axisX.Foreground = new SolidColorBrush(System.Windows.Media.Colors.Black);
        //    axisY.Separator.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Black);

            myChart.AxisX.Add(axisX);
            var maxY = StatistcResults.Max(x => x.SumNValue);            
            var axisY = new Axis();
            axisY.Title = "次数（N）";
            axisY.MaxValue = maxY + Math.Round(maxY / 10);
            axisY.MinValue = 0;
            axisY.Foreground = new SolidColorBrush(System.Windows.Media.Colors.Black);
            axisY.Separator.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Black);
        //    axisY.Separator.Step = Math.Round(maxY / 10);
            myChart.AxisY.Add(axisY);

            var viewbox = new Viewbox();
            viewbox.Child = myChart;
            viewbox.Measure(myChart.RenderSize);
            viewbox.Arrange(new System.Windows.Rect(new System.Windows.Point(0, 0), myChart.RenderSize));
            myChart.Update(true, true);
            viewbox.UpdateLayout();

            SaveToPng(myChart, fileName);
        }

        private void SaveToPng(FrameworkElement visual, string fileName)
        {
            var encoder = new PngBitmapEncoder();
            EncoderVisual(visual, fileName, encoder);
        }

        private void EncoderVisual(FrameworkElement visual, string fileName, BitmapEncoder encoder)
        {
            var bitmap = new RenderTargetBitmap((int)visual.ActualWidth, (int)visual.ActualHeight, 96, 96, PixelFormats.Pbgra32);
            bitmap.Render(visual);
            var frame = BitmapFrame.Create(bitmap);
            encoder.Frames.Add(frame);
            if (File.Exists(fileName))
                File.Delete(fileName);

            using (var stream = File.Create(fileName))
                encoder.Save(stream);
        }
        #endregion
    }
}
