using Dapper.Contrib.Extensions;

namespace CustomerUI.Model.QuestionBankModel
{
    [Table("T_GRADE")]
    public class Grade:BaseEntity
    {
        public string GRADE_CODE { get; set; }
        public string GRADE_NAME { get; set; }
    }
}
