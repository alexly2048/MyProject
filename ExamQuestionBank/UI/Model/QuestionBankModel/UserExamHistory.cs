using CustomerUI.Model.QuestionBankModel;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUI.Model.QuestionBankModel
{
    [Table("T_USER_EXAM_HISTORY")]
    public class UserExamHistory:BaseEntity
    {
        public string USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string USER_EXAM_GUID { get; set; }
        public int QUESTION_ORDER { get; set; }
        public string QUESTION_GUID { get; set; }
        public QuestionTypeEnum QUESTION_TYPE { get; set; }
        public string QUESTION_CONTENT { get; set; }
        public string ANSWER { get; set; }
        public double SCORE { get; set; }
        public string USER_ANSWER { get; set; }
        public double USER_SCORE { get; set; }
        public AnswerStatusEnum ANSWER_STATUS { get; set; }
    }
    public enum AnswerStatusEnum
    {
        Error = 0,
        Correct = 1,
        Undefined = 2
    }
}
