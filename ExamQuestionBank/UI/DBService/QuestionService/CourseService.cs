using CustomerUI.Model.QuestionBankModel;
using DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerUI.DBService.QuestionService
{
    public class CourseService
    {
        public CourseService(IDatabaseService service)
        {
            this.service = service;
        }
        IDatabaseService service;

        public IEnumerable<Course> GetCourses(string key)
        {
            var r = service.GetAll<Course>();
            if (!string.IsNullOrEmpty(key))
            {
                r = r.Where(x => x.COURSE_CODE.Contains(key) || x.COURSE_NAME.Contains(key));
            }
            return r;
        }

        public long AddCourse(Course course)
        {
            if (IsExists(course))
                throw new Exception("课程编号或课程名称已存在，无法新增");
            var r = service.Insert(course);
            return r;
        }

        public bool DeleteCourse(Course course)
        {
            if (InUsed(course))
                throw new Exception("课程信息在使用中，无法删除");
            var r = service.Delete(course);
            return r;
        }

        public bool UpdateCourse(Course course)
        {
            var r = service.Update(course);
            return r;
        }

        private bool InUsed(Course course)
        {
            var s = "SELECT 1 FROM T_SUBJECT WHERE COURSE_CODE=@COURSE_CODE";
            var r = service.QueryFirstOrDefault<int?>(s,course);
            if (r.HasValue && r == 1)
                return true;
            return false;
        }

        private bool IsExists(Course course)
        {
            var s = "SELECT 1 FROM T_COURSE WHERE COURSE_CODE=@COURSE_CODE OR COURSE_NAME=@COURSE_NAME";
            var r = service.QueryFirstOrDefault<int?>(s,course);
            if (r.HasValue && r == 1)
                return true;
            return false;
        }
    }
}
