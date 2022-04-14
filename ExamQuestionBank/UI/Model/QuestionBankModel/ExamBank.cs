using Dapper.Contrib.Extensions;

namespace CustomerUI.Model.QuestionBankModel
{
    [Table("T_EXAM_BANK")]
    public class ExamBank:BaseEntity
    {
        /// <summary>
        /// 课程编码
        /// </summary>
        public string COURSE_CODE { get; set; }
        /// <summary>
        /// 年级编码
        /// </summary>
        public string GRADE_CODE { get; set; }
        /// <summary>
        /// 试卷GUID
        /// </summary>
        public string EXAM_GUID { get; set; }
        /// <summary>
        /// 大题题目类型
        /// </summary>
        public SubjectTypeEnum SUBJECT_TYPE { get; set; }
        /// <summary>
        /// 非常简单题目数量
        /// </summary>
        public int VERY_EASY { get; set; } = 0;
        /// <summary>
        /// 简单题目数量
        /// </summary>
        public int EASY { get; set; } = 0;
        /// <summary>
        /// 普通题目数量
        /// </summary>
        public int COMMON { get; set; } = 0;
        /// <summary>
        /// 难题
        /// </summary>
        public int DIFFICULTY { get; set; } = 0;
        /// <summary>
        /// 非常难题目数量
        /// </summary>
        public int VERY_DIFFICULTY { get; set; } = 0;
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IS_ENABLE { get; set; }
    }
}
