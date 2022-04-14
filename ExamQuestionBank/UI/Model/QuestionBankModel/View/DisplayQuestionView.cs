using Dapper.Contrib.Extensions;
using DevExpress.Utils.DPI;

namespace CustomerUI.Model.QuestionBankModel
{
    [Table("V_QUESTIONS")]
    public class DisplayQuestionView
    {
        [ExplicitKey]
        public string SUBJECT_GUID { get; set; }
        public SubjectTypeEnum SUBJECT_TYPE { get; set; }
        /// <summary>
        /// 问题类型
        /// </summary>
        public QuestionTypeEnum QUESTION_TYPE { get; set; }
        /// <summary>
        /// 问题guid
        /// </summary>
        public string QUESTION_GUID { get; set; }
        /// <summary>
        /// 问题
        /// </summary>
        public string QUESTION_CONTENT { get; set; }
        /// <summary>
        /// 问题分数
        /// </summary>
        public int SCORE { get; set; }

        public int SUBJECT_ID { get; set; }
        public int QUESTION_ID { get; set; }
        public int DESCRIPTION_ID { get; set; }
        public int ANSWER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public string ANSWER_CONTENT { get; set; }
        public string COURSE_CODE { get; set; } // 课程编号
        public string COURSE_NAME { get; set; } //课程名称

        public int DIFFICULTY_LEVEL { get; set; } //难易程度
        public string GRADE_CODE { get; set; }
        public string GRADE_NAME { get; set; }
        public bool IS_ENABLE { get; set; }
        [Write(false)]
        public string IMAGE { get; set; } = "图片";
        [Write(false)]
        public string SELECT_ITEMS { get; set; } = "选择项";
    }
}
