using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUI.Model.QuestionBankModel
{
    [Table("T_COURSE")]
    public class Course:BaseEntity
    {
        /// <summary>
        /// 学科编号
        /// </summary>
        public string COURSE_CODE { get; set; }
        /// <summary>
        /// 学科名称
        /// </summary>
        public string COURSE_NAME { get; set; }
    }
}
