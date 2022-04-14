using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagement.Model
{
    [Table("T_TEL_DICT")]
    public class TelDict
    {
        [Key]
        public long? ID { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string NAME { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string PHONE { get; set; }
        /// <summary>
        /// 电话1
        /// </summary>
        public string PHONE1 { get; set; }
        /// <summary>
        /// 职务
        /// </summary>
        public string JOB_TITLE { get; set; }
        /// <summary>
        /// 公司
        /// </summary>
        public string COMPANY { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string REMARK { get; set; }
    }
}
