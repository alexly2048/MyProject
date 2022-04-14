using Dapper.Contrib.Extensions;

namespace CustomerUI.Model.QuestionBankModel
{
    [Table("T_SUBJECT_DESCRIPTION")]
    public class SubjectDescription:ObjEntity
    {
        public string SUBJECT_GUID { get; set; }
        public string DESCRIPTION { get; set; }

    }
}
