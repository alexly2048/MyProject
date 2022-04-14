using SeaDataProcess.Data;
using SeaDataProcess.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcess.Views
{
    public class SelectSpectrumParam
    {
        /// <summary>
        /// 用户是否点击确认按钮
        /// </summary>
        public bool Selected { get; set; } = false;
        /// <summary>
        /// 频谱函数类型
        /// </summary>
        public SpectrumTypeEnum SpectrumType { get; set; }

        /// <summary>
        /// 峰升因子r
        /// 用于JONSWAP谱计算
        /// </summary>
        public double R { get; set; }

        /// <summary>
        /// 用户选择的周期类型, Tz or Tp
        /// </summary>
        public TzTpEnum TzTpType
        {
            get;set;
        }

        /// <summary>
        /// 波浪方向数量
        /// value: [1-16]
        /// </summary>
        public int NumOfND { get; set; }
    }
}
