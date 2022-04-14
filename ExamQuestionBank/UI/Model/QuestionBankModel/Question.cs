using Dapper.Contrib.Extensions;

namespace CustomerUI.Model.QuestionBankModel
{
    [Table("T_QUESTION")]
    public class Question:ObjEntity
    {
        public string SUBJECT_GUID { get; set; }
        /// <summary>
        /// 问题类型
        /// </summary>
        public QuestionTypeEnum QUESTION_TYPE { get; set; }
        /// <summary>
        /// 问题guid
        /// </summary>
        public string QUESTION_GUID { get; set; }
        /// <summary>
        /// 问题
        /// </summary>
        public string QUESTION_CONTENT { get; set; }
        /// <summary>
        /// 问题分数
        /// </summary>
        public int SCORE { get; set; }
    }


    public enum WithImageEnum
    {
        None=0,
        Yes=1
    }
    /// <summary>
    /// 选择题答案
    /// 0：错误；1：正确
    /// </summary>
    public enum JudgeAnswerEnum
    {
        Error = 0,
        Correct = 1
    }
}
