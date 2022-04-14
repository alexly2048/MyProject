using Dapper.Contrib.Extensions;

namespace CustomerUI.Model.QuestionBankModel
{
    [Table("T_USER_EXAM")]
    public class UserExam:BaseEntity
    {
        public string USER_EXAM_GUID { get; set; }
        public string USER_ID { get; set; }
        public string EXAM_GUID { get; set; }
        public bool IS_COMPLETE { get; set; }
        public bool IS_ENABLE { get; set; }
        public string CREATE_DATE { get; set; }
        public string COMPLETE_DATE { get; set; }
    }
}
