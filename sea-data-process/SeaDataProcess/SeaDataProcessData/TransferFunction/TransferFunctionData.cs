using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcess.Data
{
    public class TransferFunctionData
    {
        /// <summary>
        /// 传递函数概率序号
        /// </summary>
        public int FreqNO { get; set; }
        public double TopStress { get; set; }
        public double BotStress { get; set; }
        public double MidStress { get; set; }
        /// <summary>
        /// 概率
        /// </summary>
        public double Frequency { get; set; }

        public double SelectedValue(TransferFunctionColEnum col)
        {
            switch ((TransferFunctionColEnum)col)
            {
                case TransferFunctionColEnum.BotStress:
                    return BotStress;
                case TransferFunctionColEnum.MidStredd:
                    return MidStress;
                case TransferFunctionColEnum.TopStress:
                    return TopStress;
                default:
                    return MidStress;
            }
        }

    }
}
