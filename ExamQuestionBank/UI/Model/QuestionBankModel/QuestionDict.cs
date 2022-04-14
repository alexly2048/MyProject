using System.Collections.Generic;

namespace CustomerUI.Model.QuestionBankModel
{
    public class QuestionDict
    {
        public static Dictionary<SubjectTypeEnum, string> SubjectTypeDict = new Dictionary<SubjectTypeEnum, string>
        {
            {SubjectTypeEnum.Select,"单选题" },
            {SubjectTypeEnum.MultiSelect,"多选题" },
            {SubjectTypeEnum.Judge,"判断题" },
            {SubjectTypeEnum.FillBlank,"填空题" },
            {SubjectTypeEnum.Reader,"阅读理解题" },
            {SubjectTypeEnum.Eassay,"问答题" },
            {SubjectTypeEnum.Writing,"写作" }
        };

        public static Dictionary<QuestionTypeEnum, string> QuestionTypeDict = new Dictionary<QuestionTypeEnum, string>
        {
            {QuestionTypeEnum.Select,"单选题" },
            {QuestionTypeEnum.MultiSelect,"多选题" },
            {QuestionTypeEnum.Judge,"判断题" },
            {QuestionTypeEnum.FillBlank,"填空题" },
            {QuestionTypeEnum.Eassay,"问答题" },
            {QuestionTypeEnum.Writing,"写作" }
        };
    }
}
