using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUI.Model.QuestionBankModel
{
    [Table("T_QUESTION_ITEM")]
    /// <summary>
    /// 选择题选项
    /// </summary>
    public class QuestionItem:ObjEntity
    {
        public string QUESTION_GUID { get; set; }
        public int QUESTION_ORDER { get; set; }
        public string ITEM_LABEL { get; set; }
        public string ITEM_CONTENT { get; set; }
        public bool IS_ANSWER { get; set; }
    }
}
