using Dapper.Contrib.Extensions;

namespace CustomerUI.Model.QuestionBankModel
{
    [Table("T_ANSWER")]
    public class Answer:ObjEntity
    {
       public string QUESTION_GUID { get; set; }
        public string ANSWER_CONTENT { get; set; }
    }
}
