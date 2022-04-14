using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement.Model
{
    /// <summary>
    /// 日期格式：yyyy-MM-dd
    /// </summary>
    public class Client:BaseEntity
    {
        /// <summary>
        /// 工程编号
        /// </summary>
        public string PROJECT_NUMBER { get; set; }
        /// <summary>
        /// 工程名称
        /// </summary>
        public string PROJECT_NAME { get; set; }
        /// <summary>
        /// 报装资料
        /// </summary>
        public string INSTALLATION_MATERIAL { get; set; }
        /// <summary>
        /// 停电
        /// </summary>
        public string POWER_CUT { get; set; }
        /// <summary>
        /// 增资
        /// </summary>
        public string ADD_MATERIAL { get; set; }
        /// <summary>
        /// 退料
        /// </summary>
        public string RETURN_MATERIAL { get; set; }
    }
}
