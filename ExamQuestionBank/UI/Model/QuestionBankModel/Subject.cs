using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUI.Model.QuestionBankModel
{
    /// <summary>
    /// 试卷题目
    /// </summary>
    [Table("T_SUBJECT")]
    public class Subject:BaseEntity
    {
        /// <summary>
        /// 大题编号
        /// </summary>
        public string SUBJECT_GUID { get; set; }
        /// <summary>
        /// 科目
        /// </summary>
        public string COURSE_CODE { get; set; }
        /// <summary>
        /// 考题所属年级
        /// </summary>
        public string GRADE_CODE { get; set; }
        /// <summary>
        /// 题目难易程度，供分为5级别
        /// </summary>
        public DifficultyLevelEnum DIFFICULTY_LEVEL { get; set; }
        /// <summary>
        /// 是否启用题目
        /// </summary>
        public bool IS_ENABLE { get; set; }

        public SubjectTypeEnum SUBJECT_TYPE { get; set; }

        
    }

    /// <summary>
    /// 0：单选；1：填空；2：判断；3：问答；4：多选；5:作文;6:阅读理解
    /// </summary>
    public enum SubjectTypeEnum
    {
        Select = 0,
        FillBlank = 1,
        Judge = 2,
        Eassay = 3,
        MultiSelect = 4,
        Writing = 5,
        Reader = 6
    }


}
