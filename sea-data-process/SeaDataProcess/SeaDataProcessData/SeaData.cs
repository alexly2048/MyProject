using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcess.Data
{
    /// <summary>
    /// 波浪长期分布表数据
    /// </summary>
    public class SeaData
    {
        /// <summary>
        /// 方向名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 一个方向上的数据
        /// </summary>
        public DataTable Data { get; set; }
        /// <summary>
        /// 数据代表的sheet的位置， start with 0
        /// </summary>
        public int Index { get; set; }

        public int OrderNO
        {
            get
            {
                int order = -1;
                int.TryParse(Name.Split('-')[0], out order);
                return order;
            }
        }
    }

}
