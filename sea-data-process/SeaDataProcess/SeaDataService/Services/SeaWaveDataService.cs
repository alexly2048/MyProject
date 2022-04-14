using SeaDataProcess.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcess.Service.Services
{
    public class SeaWaveDataService
    {
        /// <summary>
        /// 根据用户选择文件
        /// 加载波浪长期分布表
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public IEnumerable<SeaData> LoadSeadWaveDatas(string filepath)
        {
            if (!File.Exists(filepath))
                throw new FileNotFoundException(nameof(filepath));

            return ExcelHelper.LoadSeaFromFile(filepath);
        }
    }
}
