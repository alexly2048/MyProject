using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcess.Data
{
    public class TransferFunctionDataList
    {
        public TransferFunctionDataList()
        {
            Datas = new List<TransferFunctionData>();
        }
        public int OrderNO { get; set; }
        public List<TransferFunctionData> Datas { get; set; }

        public TransferFunctionColEnum SelectedCol { get; set; } // 选择使用哪一列作为计算数据

        /// <summary>
        /// 利用差值发计算G(frequency)的值
        /// </summary>
        /// <param name="frequency"></param>
        /// <returns></returns>
        public double CalculateG(double frequency)
        {
            var list = Datas.OrderBy(x => x.Frequency).ToList();
            // if has equal value, return value directly
            var equal_value = list.FirstOrDefault(x => x.Frequency == frequency);
            if (equal_value != null)
                return Math.Round(equal_value.SelectedValue(SelectedCol), 10);

            var min_freq = list.Min(x => x.Frequency);
            var max_freq = list.Max(x => x.Frequency);
            if (frequency <= min_freq)
                return Math.Round(list.FirstOrDefault(x => x.Frequency == min_freq).SelectedValue(SelectedCol),10);
            
            if (frequency >= max_freq)
                return Math.Round(list.FirstOrDefault(x => x.Frequency == max_freq).SelectedValue(SelectedCol),10);

            var last_min = list.LastOrDefault(x => x.Frequency < frequency);
            var first_max = list.FirstOrDefault(x => x.Frequency > frequency);

            if(last_min == null)
            {
                return Math.Round(first_max.SelectedValue(SelectedCol) / first_max.Frequency * frequency);
            }else if(first_max == null)
            {
                return Math.Round(last_min.SelectedValue(SelectedCol) / last_min.Frequency * frequency, 10);
            }
            else // 插值法求值
            {
                var f = (first_max.SelectedValue(SelectedCol) - last_min.SelectedValue(SelectedCol)) /
                    (first_max.Frequency - last_min.Frequency); // 求斜率

                ///    var c = ((first_max.SelectedValue(SelectedCol) + last_min.SelectedValue(SelectedCol))
                ///            - f * (first_max.Frequency + last_min.Frequency)) / 2;
                // 利用斜率和已知的前一个值，求插值
                return f * (frequency - last_min.Frequency) + last_min.SelectedValue(SelectedCol);
                // return f * frequency + c;
            }
        }
    }

    public enum TransferFunctionColEnum
    {
        TopStress,
        BotStress,
        MidStredd
    }
}
