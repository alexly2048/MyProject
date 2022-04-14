using CustomerUI.Model.QuestionBankModel;
using DBHelper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUI.DBService.QuestionService
{
    public class SubjectDescriptionService
    {
        public SubjectDescriptionService(IDatabaseService service)
        {
            this.service = service;
        }
        private IDatabaseService service;

        internal void AddQuestionDescription(SubjectDescription questionDescription, SqlConnection c, SqlTransaction transaction)
        {
            service.Insert(questionDescription, c, transaction);
        }

        internal long AddQuestionDescription(SubjectDescription subjectDescription)
        {
            var r = service.Insert(subjectDescription);
            return r;
        }

        internal void UpdateQuestionDescription(SubjectDescription questionDescription, SqlConnection c, SqlTransaction transaction)
        {
            service.Update(questionDescription, c, transaction);
        }

        internal SubjectDescription GetSubjectDescription(string subjectGuid)
        {
            var s = "SELECT ID,SUBJECT_GUID,DESCRIPTION FROM T_SUBJECT_DESCRIPTION WHERE SUBJECT_GUID=@SUBJECT_GUID";
            var r = service.QueryFirstOrDefault<SubjectDescription>(s, new { SUBJECT_GUID = subjectGuid }) ;
            return r;
        }

        internal bool UpdateQuestionDescription(SubjectDescription subjectDescription)
        {
            var r = service.Update(subjectDescription);
            return r;
        }
        internal void DeleteQuestionDescription(SubjectDescription questionDescription, SqlConnection c, SqlTransaction transaction)
        {
            service.Delete(questionDescription, c, transaction);
        }

        internal void DeleteQuestionDescription(SubjectDescription subjectDescription)
        {
            service.Delete(subjectDescription);
        }

        internal IEnumerable<SubjectDescription> GetSubjectDescriptions()
        {
            var r = service.GetAll<SubjectDescription>();
            return r;
        }

        internal SubjectDescription GetDescriptionBySubjectGuid(string guid)
        {
            var r = GetSubjectDescriptions();
            var f = r.FirstOrDefault(x => x.SUBJECT_GUID.Equals(guid));
            return f;
        }
    }
}
