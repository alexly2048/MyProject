using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUI.Model
{
    [Table("T_USER_EXAM_SCORE")]
    public class UserExamScore:BaseEntity
    {
        public string USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string USER_EXAM_GUID { get; set; }
        public double SINGLE_SELECT_SCORE { get; set; } = 0;
        public double MULTI_SELECT_SCORE { get; set; } = 0;
        public double JUDGE_SCORE { get; set; } = 0;
        public double READER_SCORE { get; set; } = 0;
        public double EASSAY_SCORE { get; set; } = 0;
        public double WRITING_SCORE { get; set; } = 0;
        public double FILL_BANK_SCORE { get; set; }
        public double TOTAL_SCORE { get; set; } = 0;
    }
}
