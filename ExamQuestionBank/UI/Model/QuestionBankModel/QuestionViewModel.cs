using System.Collections.Generic;

namespace CustomerUI.Model.QuestionBankModel
{
    public class QuestionViewModel:BaseEntity
    {
        public Subject Subject { get; set; }
        public SubjectDescription QuestionDescription { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();
        public List<QuestionImage> QuestionImages { get; set; } = new List<QuestionImage>();
        public List<QuestionItem> QuestionItems { get; set; } = new List<QuestionItem>();
        public List<Answer> Answers { get; set; } = new List<Answer>();
        /// <summary>
        /// 针对一个描述有多个题目的，设置题目的顺序
        /// </summary>
        public int CurrentOrder { get; set; } = 0;
    }
}
