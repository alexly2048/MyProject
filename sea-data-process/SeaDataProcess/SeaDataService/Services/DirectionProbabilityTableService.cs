using SeaDataProcess.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SeaDataProcess.Helper;

namespace SeaDataProcess.Service.Services
{
    public class DirectionProbabilityTableService
    {
        public DirectionProbabilityTableService()
        {
            direction_probability = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "direction_probability_data.dll");
        }
        private readonly string direction_probability = string.Empty;
        /// <summary>
        /// 用户选择方向概率文件，加载方向概率数据
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="delimiter"></param>
        /// <returns></returns>
        public IEnumerable<DirectionProbabilityData> GetDirectionProbabilityDatas(
            string filepath,
            char delimiter = ',')
        {
            if (!File.Exists(filepath))
            {
                throw new FileNotFoundException("方向概率文件{filepath}不存在\n请选择方向概率文件");
            }

            var probabilities = new List<DirectionProbabilityData>();
            using(var sr = new StreamReader(filepath))
            {
                string content;
                while((content=sr.ReadLine()) != null)
                {
                    if (string.IsNullOrEmpty(content))
                        continue;

                    string[] cts = content.Split(delimiter);
                    if(cts.Length != 3)
                    {
                        throw new FormatException("传递函数文件格式错误，应该为<Direction,NO,percentage>");
                    }

                    int index;
                    double probability;
                    if(!int.TryParse(cts[1], out index) || !double.TryParse(cts[2], out probability))
                    {
                        continue; // 跳过异常数据，不做处理，因为可能包含标题
                    }

                    var data = new DirectionProbabilityData
                    {
                        DirectionName = cts[0],
                        Index = index,
                        Percentage = probability
                    };
                    probabilities.Add(data);
                }
            }
            // 是否需要对导入概率的个数进行校验？
            return probabilities;
        }

        /// <summary>
        /// 从json文件中加载方向概率数据
        /// </summary>
        /// <returns>方向概率数据</returns>
        public async Task<IEnumerable<DirectionProbabilityData>> GetDirectionProbabilityDataFromJson()
        {
            if (!File.Exists(direction_probability))
            {
                return null;
            }

            if (FileHelper.FileIsOpen(direction_probability))
            {
                throw new FileLoadException("文件已打开，请关闭文件后重试");
            }

            using(var sr = new StreamReader(direction_probability))
            {
                var content = await sr.ReadToEndAsync();
                return JsonConvert.DeserializeObject<List<DirectionProbabilityData>>(content);
            }
        }

        /// <summary>
        /// 保存方向概率数据，保存格式json
        /// </summary>
        /// <param name="datas">方向概率数据</param>
        /// <returns></returns>
        public async Task SaveDirectionProbabilityDataToJson(IEnumerable<DirectionProbabilityData> datas)
        {
            if (File.Exists(direction_probability))
            {
                File.Delete(direction_probability);
            }
            using(var sw = new StreamWriter(direction_probability))
            {
                await sw.WriteAsync(JsonConvert.SerializeObject(datas));
            }
        }
    }
}
