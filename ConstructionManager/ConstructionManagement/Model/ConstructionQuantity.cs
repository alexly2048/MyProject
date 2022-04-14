using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagement.Model
{
    /// <summary>
    /// 施工工程量
    /// </summary>
    public class ConstructionQuantity:BaseEntity
    {
        public string ItemName { get; set; }
        public string ItemFeature { get; set; }
        public string ItemUnit { get; set; }
        public string DesignNum { get; set; }
        public string ModifyNum { get; set; }
        public string AllOfProcess { get; set; }
        public string Reminder { get; set; }

        /// <summary>
        /// 施工总体进度项目编码
        /// </summary>
        public string ConstructionNo { get; set; }
    }
}
