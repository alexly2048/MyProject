using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement.Model
{
    /// <summary>
    /// 日常费用开支
    /// </summary>
    [Table("CURRENT_EXPENSE")]
    public class CurrentExpense:BaseEntity
    {
        /// <summary>
        /// 项目
        /// </summary>
        public string ITEM_NAME { get; set; }
        /// <summary>
        /// 原因
        /// </summary>
        public string REASON { get; set; }
        /// <summary>
        /// 类别
        /// </summary>
        public string CATEGORY { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string UNIT { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal QUANTITY { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal PRICE { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal MONEY { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string REMARK { get; set; }
    }
}
