using ConstructionManagement.Model;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace ConstructionManagement.Service
{
    public class TelDictService:Connection
    {
        public TelDictService() : base()
        {

        }

        public IEnumerable<TelDict> GetTelDicts(string key)
        {
            using(var c = new SqlConnection(ConnectionString))
            {
                var s = "SELECT * FROM T_TEL_DICT";
                var r = c.Query<TelDict>(s);
                if (!string.IsNullOrEmpty(key))
                {
                    r = r.Where(x => x.NAME.Contains(key) ||
                            x.PHONE.Contains(key) ||
                            x.JOB_TITLE.Contains(key) ||
                            x.COMPANY.Contains(key));
                }
                return r;
            }
        }

        public long AddTelDict(TelDict dict)
        {
            using(var c = new SqlConnection(ConnectionString))
            {
                var s = "INSERT INTO T_TEL_DICT (NAME,PHONE,PHONE1,JOB_TITLE,COMPANY,REMARK) VALUES (@NAME,@PHONE,@PHONE1,@JOB_TITLE,@COMPANY,@REMARK)";
                var r = c.Execute(s,dict);
                return r;
            }
        }

        public bool UpdateTelDict(TelDict dict)
        {
            using(var c = new SqlConnection(ConnectionString))
            {
                var r = c.Update(dict);
                return r;
            }
        }

        public bool DeleteTelDict(TelDict dict)
        {
            using(var c = new SqlConnection(ConnectionString))
            {
                var r = c.Delete(dict);
                return r;
            }
        }



    }
}
