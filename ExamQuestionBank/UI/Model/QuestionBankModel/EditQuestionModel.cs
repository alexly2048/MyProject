using System.Collections.Generic;

namespace CustomerUI.Model.QuestionBankModel
{
    public class EditQuestionModel
    {
        public Subject Subject { get; set; }
        public Question Question { get; set; }
        public List<QuestionItem> Items { get; set; } = new List<QuestionItem>();
        public Answer Answer { get; set; }

        public int CurrentOrder { get; set; } = 0;
    }
}
