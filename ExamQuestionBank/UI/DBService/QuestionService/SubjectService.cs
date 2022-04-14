using CustomerUI.Model.QuestionBankModel;
using Dapper;
using DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUI.DBService.QuestionService
{
    public class SubjectService
    {
        public SubjectService(IDatabaseService service)
        {
            this.service = service;
        }
        private readonly IDatabaseService service;
        public long AddSubject( Subject subject, IDbConnection connection, IDbTransaction transaction)
        {
            var r = service.Insert(subject, connection, transaction);
            return r;
        }

        public bool DeleteSubject(Subject subject,IDbConnection connection, IDbTransaction transaction)
        {
            var r = service.Delete(subject, connection, transaction);
            return r;
        }

        public void DeleteSubjectByGuid(string guid, IDbConnection connection, IDbTransaction transaction)
        {
            var s = "DELETE FROM T_SUBJECT WHERE SUBJECT_GUID=@GUID";
            var r = connection.Execute(s, new { GUID = guid }, transaction);
        }

        public IEnumerable<Subject> GetSubjects()
        {
            var r = service.GetAll<Subject>();
            return r;
        }

        public IEnumerable<Subject> GetSubjectByGradeAndDifficulty(string gradeCode,string courseCode)
        {
            var s = "SELECT * FROM T_SUBJECT WHERE GRADE_CODE=@GRADE_CODE AND COURSE_CODE=@COURSE_CODE AND IS_ENABLE=1";
            var r = service.Query<Subject>(s, new { GRADE_CODE = gradeCode, COURSE_CODE = courseCode});
            return r;
        }

        public bool UpdateSubject(Subject subject, IDbConnection connection, IDbTransaction transaction)
        {
            var r = service.Update(subject, connection, transaction);
            return r;
        }
    }
}
