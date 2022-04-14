using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUI.Model.QuestionBankModel.View
{
    public class GenerateExamView
    {
        public int Order { get; set; } = 0;
        public Subject Subject { get; set; }
        public SubjectDescription Description {get;set;}
        public Question Question{ get; set; }
        public Answer Answer { get; set; }
        /// <summary>
        /// 用户输入答案
        /// </summary>
        public string UserAnswer { get; set; }
        /// <summary>
        /// 用户得分
        /// </summary>
        public double UserScore { get; set; }
        public List<QuestionItem> Items { get; set; } = new List<QuestionItem>();
        [JsonIgnore]
        public List<QuestionImage> Images { get; set; } = new List<QuestionImage>();
    }
}
