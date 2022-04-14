using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcess.Data
{
    /// <summary>
    /// 方向概率数据类
    /// </summary>
    public class DirectionProbabilityData
    {
        /// <summary>
        /// 方向名称
        /// </summary>
        public string DirectionName { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// 概率(%)
        /// </summary>
        public double Percentage { get; set; }

        public double DecimalPercentage
        {
            get
            {
                return Percentage / 100;
            }
        }
    }
}
