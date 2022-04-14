using System.Collections.Generic;

namespace CustomerUI.Model.QuestionBankModel.View
{
    public class ExamView
    {
        public List<GenerateExamView> GenerateExamViews { get; set; } = new List<GenerateExamView>();
        public ExamBank ExamBank { get; set; }
        public User User { get; set; }
        public double TotalScore { get; set; }

        public double SingleSelectScore { get; set; }
        public double MultiSelectScore { get; set; }
        public double JudgeScore { get; set; }

        public void CalculateScore()
        {
            var singleSelectScore = 0d;
            var multiSelectScore = 0d;
            var judgeScore = 0d;
            foreach (var v in GenerateExamViews)
            {
                var answer = v.Answer?.ANSWER_CONTENT?.ToString() ?? string.Empty;
                if (string.IsNullOrEmpty(answer))
                    continue;
                switch (v.Question.QUESTION_TYPE)
                {
                    case QuestionTypeEnum.Select:
                        if (v.Answer.ANSWER_CONTENT.Contains(v.UserAnswer.ToUpper()))
                        {
                            v.UserScore = v.Question.SCORE;
                            singleSelectScore += v.UserScore;
                        }
                            
                        break;
                    case QuestionTypeEnum.MultiSelect:
                        v.UserScore = CalculateMultiSelect(v, answer);
                        multiSelectScore += v.UserScore;
                        break;
                    case QuestionTypeEnum.Judge:
                        if (v.Answer.ANSWER_CONTENT.Contains(v.UserAnswer))
                        {
                            v.UserScore = v.Question.SCORE;
                            judgeScore += v.UserScore;
                        }                            
                        break;
                    default:
                        break;
                }
            }

            SingleSelectScore = singleSelectScore;
            MultiSelectScore = multiSelectScore;
            JudgeScore = judgeScore;
        }

        private double CalculateMultiSelect(GenerateExamView view,string answer)
        {
            var count = 0;
            var score = 0d;
            var a = answer.Split(',');
            var answers = new List<string>();
            answers.AddRange(a);
            if (string.IsNullOrEmpty(view.UserAnswer))
                return score;
            var us = view.UserAnswer.Split(',');
            foreach(var u in us)
            {
                if (answers.Contains(u))
                {
                    score += 0.5;                   
                    count++;
                }
            }
            if (count == answers.Count && us.Length == answers.Count) 
            {
                score = view.Question.SCORE;
            }
            if (count != us.Length)
                score = 0;
            return score;
        }
    }
}
