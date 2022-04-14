using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUI.Model.QuestionBankModel
{
    public class QuestionDifficulty
    {
        public string DisplayText { get; set; }
        public string ValueMember { get; set; }

        public static IList<QuestionDifficulty> GetQuestionDifficulties()
        {
            var r = new List<QuestionDifficulty>
            {
                new QuestionDifficulty{DisplayText="非常简单",ValueMember = "0"},
                new QuestionDifficulty{DisplayText="简单",ValueMember = "1"},
                new QuestionDifficulty{DisplayText="一般",ValueMember = "2"},
                new QuestionDifficulty{DisplayText="困难",ValueMember = "3"},
                new QuestionDifficulty{DisplayText="非常困难",ValueMember = "4"},
            };
            return r;
        }
    }

    public enum DifficultyLevelEnum
    {
        VeryEasy = 0,
        Easy = 1,
        Common = 2,
        Difficulty = 3,
        VeryDifficulty = 4
    }
}
