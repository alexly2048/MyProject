using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcess.Data
{
    /// <summary>
    /// 存储一个Joint表中的计算结果
    /// </summary>
    public class JointCalculateResult
    {
        public string TableName { get; set; }
        public int SheetIndex { get; set; }
        public List<StepData> StepDataList
        {
            get
            {
                return stepDataList;
            }
            set
            {
                stepDataList = value;
            }
        }

        private List<StepData> stepDataList = new List<StepData>();

        /// <summary>
        /// 计算完成后，对最后计算结果，按照5MPa的间隔进行汇总
        /// </summary>
        /// <returns></returns>
        public IEnumerable<JointChartValues> GetJointChartValues()
        {
            // 不能在此处进行汇总
            //    return StepDataList.GroupBy(x => x.Range)
            //                .Select(x => new JointChartValues
            //                {
            //                    Range = x.Key,
            //                    AvgDeltaSigmaValue = x.Average(n=>n.DeltaSigmaValue),
            //                    SumNValue = x.Sum(n => n.NValue)
            //                });

            return StepDataList.Select(x => new JointChartValues
            {
                Range = x.DeltaSigmaValue,
                AvgDeltaSigmaValue = x.DeltaSigmaValue,
                SumNValue = x.NValue
            });
        }
                
    }
    /// <summary>
    /// 存储汇总结果 
    /// </summary>
    public class JointChartValues:BaseEntity
    {
        private double deltaSigmaValue;
        private double nValue;
        private double range;

        public double Range
        {
            get
            {
                return range;
            }
            set
            {
                range = value;
                RaisedPropertyChanged();
            }
        }

        public double AvgDeltaSigmaValue
        {
            get
            {
                return deltaSigmaValue;
            }
            set
            {
                deltaSigmaValue = value;
                RaisedPropertyChanged();
            }
        }
        public double SumNValue
        {
            get
            {
                return nValue;
            }
            set
            {
                nValue = value;
                RaisedPropertyChanged();
            }
        }
    }
}
