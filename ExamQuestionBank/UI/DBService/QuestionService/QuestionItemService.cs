using CustomerUI.Model.QuestionBankModel;
using Dapper;
using DBHelper;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUI.DBService.QuestionService
{
    public class QuestionItemService
    {
        public QuestionItemService(IDatabaseService service)
        {
            this.service = service;
        }
        private readonly IDatabaseService service;

        internal void AddQuestionItem(QuestionItem i, SqlConnection c, SqlTransaction transaction)
        {
            service.Insert(i, c, transaction);
        }

        internal void UpdateQuestionItem(QuestionItem i, SqlConnection c, SqlTransaction transaction)
        {
            service.Update(i, c, transaction);
        }

        internal void DeleteQuestionItem(QuestionItem i, SqlConnection c, SqlTransaction transaction)
        {
            service.Delete(i, c, transaction);
        }

        internal IEnumerable<QuestionItem> GetQuestionItemsByGuid(string guid)
        {
            var s = "SELECT * FROM T_QUESTION_ITEM WHERE QUESTION_GUID=@QUESTION_GUID";
            var r = service.Query<QuestionItem>(s, new { QUESTION_GUID = guid });
            return r;
        }

        internal void DeleteQuestionItemByGuid(string guid, SqlConnection c, SqlTransaction transaction)
        {
            var s = "DELETE FROM T_QUESTION_ITEM WHERE QUESTION_GUID=@QUESTION_GUID";
            c.Execute(s, new { QUESTION_GUID = guid },transaction);
        }

        internal IEnumerable<QuestionItem> GetQuestionItems()
        {
            var r = service.GetAll<QuestionItem>();
            return r;
        }
    }
}
