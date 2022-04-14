using Dapper.Contrib.Extensions;

namespace CustomerUI.Model.QuestionBankModel
{
    /// <summary>
    /// 需V_EXAM_BANK联合查询
    /// </summary>
    [Table("V_USER_EXAM")]
    public class DisplayUserExam
    {
        public long ID { get; set; }
        public string USER_EXAM_GUID { get; set; }
        public string EXAM_GUID { get; set; }
        public string USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string GRADE_CODE { get; set; }
        public string GRADE_NAME { get; set; }
        public string COURSE_CODE { get; set; }
        public string COURSE_NAME { get; set; }
        public bool IS_ENABLE { get; set; }
        public bool IS_COMPLETE { get; set; }
        public string CREATE_DATE { get; set; }
        public string COMPLETE_DATE { get; set; }
    }
}
