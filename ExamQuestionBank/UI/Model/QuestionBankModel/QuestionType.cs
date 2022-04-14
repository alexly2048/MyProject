using System.Collections.Generic;

namespace CustomerUI.Model.QuestionBankModel
{
    public class QuestionType
    {
        public string DisplayText { get; set; }
        public short ValueMember { get; set; }

        public static IEnumerable<QuestionType> GetQuestionTypes()
        {
            var types = new List<QuestionType>
            {
                new QuestionType{DisplayText="单选题",ValueMember=0},
                new QuestionType{DisplayText="填空题",ValueMember=1},
                new QuestionType{DisplayText="判断题",ValueMember=2},
                new QuestionType{DisplayText="问答题",ValueMember=3},
                new QuestionType{DisplayText="多选题",ValueMember=4},
                new QuestionType{DisplayText ="作文题",ValueMember=5}
            };
            return types;
        }
    }

    /// <summary>
    /// 0：单选；1：填空；2：判断；3：问答；4：多选；5:写作
    /// </summary>
    public enum QuestionTypeEnum
    {
        Select = 0,
        FillBlank = 1,
        Judge = 2,
        Eassay = 3,
        MultiSelect = 4,
        Writing = 5
    }
}
