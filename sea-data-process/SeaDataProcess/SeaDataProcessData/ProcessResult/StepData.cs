using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcess.Data
{
    /// <summary>
    /// complete one process step, store the final result
    /// 表中每个单元格的计算结果
    /// 如果单元格值为0，不进行计算
    /// </summary>
    public class StepData
    {
        public double DeltaSigmaValue { get; set; }
        public double NValue { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
        public int Order { get; set; }

        /// <summary>
        /// 将计算结果按照5MPa间隔分类汇总
        /// </summary>
        public int Range
        {
            get
            {
                return (int)Math.Floor(DeltaSigmaValue) % 5;
            }
        }
    }
}
