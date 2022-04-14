using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUI.Model.QuestionBankModel
{
    [Table("T_USER_EXAM_RESULT")]
    public class UserExamResult:BaseEntity
    {
        public string USER_ID { get; set; }
        public string USER_EXAM_GUID { get; set; }
        public decimal SCORE { get; set; }
        public string EXAM_CONTENT { get; set; }
    }
}
