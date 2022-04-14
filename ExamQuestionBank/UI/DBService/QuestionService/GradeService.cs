using CustomerUI.Model.QuestionBankModel;
using DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUI.DBService.QuestionService
{
    public class GradeService
    {
        public GradeService(IDatabaseService service)
        {
            this.service = service;
        }
        private readonly IDatabaseService service;

        public IEnumerable<Grade> GetGrades(string key)
        {
            var r = service.GetAll<Grade>();
            if (!string.IsNullOrEmpty(key))
            {
                r = r.Where(x => x.GRADE_CODE.Contains(key) || x.GRADE_NAME.Contains(key));
            }
            return r;
        }

        public long AddGrade(Grade grade)
        {
            if (CheckGradeExists(grade.GRADE_CODE))
                throw new Exception($"年级编号{grade.GRADE_CODE}已存在");
            var r = service.Insert(grade);
            return r;
        }

        public bool DeleteGrade(Grade grade)
        {
            if (CheckGradeInUse(grade.GRADE_CODE))
            {
                throw new Exception($"年级编号{grade.GRADE_CODE}在使用中，无法删除");
            }
            var r = service.Delete(grade);
            return r;
        }

        public bool UpdateGrade(Grade grade)
        {
            var r = service.Update(grade);
            return r;
        }



        public bool CheckGradeExists(string gradeCode)
        {
            var s = "SELECT 1 FROM T_GRADE WHERE GRADE_CODE=@GRADE_CODE";
            var r = service.QueryFirstOrDefault<int?>(s, new { GRADE_CODE = gradeCode });
            if (r.HasValue && r == 1)
                return true;
            return false;
        }

        public bool CheckGradeInUse(string gradeCode)
        {
            var s = "SELECT 1 FROM T_SUBJECT WHERE GRADE_CODE=@GRADE_CODE";
            var r = service.QueryFirstOrDefault<int?>(s, new { GRADE_CODE = gradeCode });
            if (r.HasValue && r == 1)
                return true;
            return false;
        }
    }
}
