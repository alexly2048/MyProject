using CustomerUI.Model.QuestionBankModel;
using Dapper.Contrib.Extensions;
using DBHelper;
using DevExpress.XtraBars;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUI.DBService.QuestionService
{
    public class ExamBankService
    {
        public ExamBankService(IDatabaseService service)
        {
            this.service = service;
        }
        private readonly IDatabaseService service;

        public IEnumerable<DisplayExamBank> GetExamBanks(string key)
        {
            var r = service.GetAll<DisplayExamBank>();
            if (!string.IsNullOrEmpty(key))
            {
                r = r.Where(x => x.COURSE_CODE.Contains(key) ||
                        x.COURSE_NAME.Contains(key) ||
                        x.GRADE_CODE.Contains(key) ||
                        x.GRADE_NAME.Contains(key));
            }
            return r;
        }

        public IEnumerable<ExamBank> GetExamBanksByExamGuid(string guid)
        {
            var r = service.GetAll<ExamBank>();
            r = r.Where(x => x.EXAM_GUID.Equals(guid));
            return r;
        }

        public bool AddExamBank(IList<ExamBank> exams)
        {
            var local = exams;
            using(var c = new SqlConnection(service.ConnectString))
            {
                c.Open();
                var transaction = c.BeginTransaction();
                try
                {
                    foreach(var e in local)
                    {
                        c.Insert(e, transaction);
                    }
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
            return true;
        }

        public bool UpdateExamBank(IList<ExamBank> exams)
        {
            var local = exams;
            using(var c = new SqlConnection(service.ConnectString))
            {
                c.Open();
                var transaction = c.BeginTransaction();
                try
                {
                    foreach(var e in local)
                    {
                        c.Update(e, transaction);
                    }
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
            return true;
        }

        public bool DeleteExamBank(IList<ExamBank> exams)
        {
            var local = exams;
            using(var c = new SqlConnection(service.ConnectString))
            {
                var transaction = c.BeginTransaction();
                try
                {
                    foreach(var e in local)
                    {
                        c.Delete(e, transaction);
                    }
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
            return true;
        }

        internal void DeleteExamBankByGuid(string guid)
        {
            var s = "DELETE FROM T_EXAM_BANK WHERE EXAM_GUID=@EXAM_GUID";
            var r = service.Execute(s, new { EXAM_GUID = guid });
        }
    }
}
