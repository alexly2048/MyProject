using CustomerUI.Model.QuestionBankModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUI.Model
{
    public class SearchItemView
    {
        public string Keyword { get; set; }
        public QuestionTypeEnum? QuestionType { get; set; }
    }
}
