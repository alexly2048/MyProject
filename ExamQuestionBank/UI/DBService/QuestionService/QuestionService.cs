using CustomerUI.Model.QuestionBankModel;
using Dapper;
using DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUI.DBService.QuestionService
{
   public class QuestionService
    {
        public QuestionService(IDatabaseService service)
        {
            this.service = service;
        }
        private readonly IDatabaseService service;

        public IEnumerable<Question> GetQuestions(string key)
        {
            var r = service.GetAll<Question>();
            return r;
        }

        public long AddQuestion(Question question,IDbConnection connection, IDbTransaction transaction)
        {
            var r = service.Insert(question, connection, transaction);
            return r;
        }

        public bool UpdateQuestion(Question question,IDbConnection connection, IDbTransaction transaction)
        {
            var r = service.Update(question, connection, transaction);
            return r;
        }

        public bool DeleteQuestion(Question question, IDbConnection connection, IDbTransaction transaction)
        {
            var r = service.Delete(question, connection, transaction);
            return r;
        }

        internal void DeleteQuestionByGuid(string guid, SqlConnection c, SqlTransaction transaction)
        {
            var s = "DELETE FROM T_QUESTION WHERE QUESTION_GUID=@QUESTION_GUID";
            c.Execute(s, new { QUESTION_GUID = guid }, transaction);
        }

        internal IEnumerable<string> GetQuestionGuidsBySubjectGuid(string guid)
        {
            var s = "SELECT QUESTION_GUID FROM T_QUESTION WHERE SUBJECT_GUID=@GUID";
            var r = service.Query<string>(s, new { GUID = guid });
            return r;
        }
    }
}
