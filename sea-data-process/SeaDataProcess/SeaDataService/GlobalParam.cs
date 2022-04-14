using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcess.Service
{
    public class GlobalParam
    {
        /// <summary>
        /// 小数点后保留的位数
        /// 默认保留4位
        /// </summary>
        public static int DecimalNum { get; set; } = 4;

        /// <summary>
        /// 导入的传递函数列数
        /// </summary>
        public static int StressCount { get; set; }
    }
}
