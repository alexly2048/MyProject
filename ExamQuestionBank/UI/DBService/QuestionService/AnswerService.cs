using CustomerUI.Model.QuestionBankModel;
using Dapper;
using DBHelper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUI.DBService.QuestionService
{
    public class AnswerService
    {
        public AnswerService(IDatabaseService service)
        {
            this.service = service;
        }

        private readonly IDatabaseService service;

        internal void AddAnswer(Answer a, SqlConnection c, SqlTransaction transaction)
        {
            service.Insert(a, c, transaction);
        }

        internal void UpdateAnswer(Answer a, SqlConnection c, SqlTransaction transaction)
        {
            service.Update(a, c, transaction);
        }

        internal void DeleteAnswer(Answer a, SqlConnection c, SqlTransaction transaction)
        {
            service.Delete(a, c, transaction);
        }

        internal void DeleteAnswerByGuid(string guid, SqlConnection c, SqlTransaction transaction)
        {
            var s = "DELETE FROM T_ANSWER WHERE QUESTION_GUID=@QUESTION_GUID";
            c.Execute(s, new { QUESTION_GUID = guid }, transaction);
        }

        internal IEnumerable<Answer> GetAnswers()
        {
            var r = service.GetAll<Answer>();
            return r;
        }
    }
}
