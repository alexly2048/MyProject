using SeaDataProcess.Data;
using SeaDataProcess.Helper;
using SeaDataProcess.Service;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcess.Services
{
    /// <summary>
    /// 传递函数数据加载服务
    /// </summary>
    public class TransferFunctionService
    {
        private const string DELIMITER = "###################";
        private const string START_NEW = "RAO";
        /// <summary>
        /// 加载传递函数，文件中包含 N 个joint数据
        /// 对应长期分布表中 N 个sheet
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public async Task<IEnumerable<TransferFunctionDataList>> LoadTransferFunctionDatas(string filepath)
        {
            if (!File.Exists(filepath))
            {
                throw new FileNotFoundException(filepath);
            }

            if (FileHelper.FileIsOpen(filepath))
            {
                throw new FileLoadException("文件已打开，请关闭文件后重试");
            }

            var tmp_list = new BlockingCollection<TransferFunctionDataList>();
            using (var reader = new StreamReader(filepath))
            {
                var sb = new StringBuilder();
                string line = string.Empty;
                // 读取每行数据
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    if (line.StartsWith(START_NEW)) // 判断本行中是否包含RAO字段
                    {
                        sb.AppendLine(DELIMITER); // 如果包含 RAO 字段，添加分表标志
                    }
                    sb.AppendLine(line);
                }

                var raos = sb.ToString().Split(new string[] { DELIMITER }, StringSplitOptions.RemoveEmptyEntries);
                // parallel handle content of RAO
                Parallel.ForEach(raos,
                    rao =>
                    {
                        var lines = rao.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                        var list = new TransferFunctionDataList();
                        foreach (var l in lines)
                        {
                            // 解析标题， 用英文空格作为分隔符
                            var cols = l.Split(new char[] { ' ','\t' }, StringSplitOptions.RemoveEmptyEntries);
                            if (cols[0].Equals(START_NEW))
                            {
                                list.OrderNO = int.Parse(cols[3].Trim('#')); // 获取分割后的第四个字段，获取数字
                            }
                            else
                            {
                                int order;
                                switch (cols.Length)
                                {
                                    
                                    case 4:
                                        if (int.TryParse(cols[0], out order))
                                        {
                                            var data = new TransferFunctionData
                                            {
                                                FreqNO = order,
                                                TopStress = double.Parse(cols[1]),
                                                BotStress = double.Parse(cols[2]),
                                                MidStress = double.Parse(cols[3])
                                            };
                                            GlobalParam.StressCount = 3;
                                            list.Datas.Add(data);
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                        break;
                                    case 3:
                                        if (int.TryParse(cols[0], out order))
                                        {
                                            var data = new TransferFunctionData
                                            {
                                                FreqNO = order,
                                                TopStress = double.Parse(cols[1]),
                                                BotStress = double.Parse(cols[2])
                                            };
                                            GlobalParam.StressCount = 2;
                                            list.Datas.Add(data);
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                        break;
                                    case 2:
                                        if (int.TryParse(cols[0], out order))
                                        {
                                            var data = new TransferFunctionData
                                            {
                                                FreqNO = order,
                                                TopStress = double.Parse(cols[1])
                                            };
                                            GlobalParam.StressCount = 1;
                                            list.Datas.Add(data);
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                        break;
                                    default:
                                        throw new FormatException("导入数据格式错误");
                                }
                            }
                        }
                        tmp_list.Add(list);
                    });
            }
            return tmp_list;
        }


        /// <summary>
        /// 从文件中加载传递函数概率表
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public async Task<TransferFunctionFrequencyList> LoadTransferFunctionFrequency(string filepath)
        {
            if (!File.Exists(filepath))
            {
                throw new FileNotFoundException(filepath);
            }

            if (FileHelper.FileIsOpen(filepath))
            {
                throw new FileLoadException("文件已打开，请关闭文件后重试");
            }

            var list = new TransferFunctionFrequencyList();
            using (var sr = new StreamReader(filepath))
            {
                string line;
                int no;
                double freq;
                while ((line = await sr.ReadLineAsync()) != null)
                {
                    if (string.IsNullOrEmpty(line))
                        continue;

                    var row = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    if (int.TryParse(row[0].Trim(), out no) &&
                        double.TryParse(row[1].Trim(), out freq))
                    {
                        var f = new TransferFunctionFrequencyData
                        {
                            FreqNO = no,
                            Frequency = freq
                        };
                        list.FrequencyList.Add(f);
                    }
                }
            }
            return list;
        }
    }
}
