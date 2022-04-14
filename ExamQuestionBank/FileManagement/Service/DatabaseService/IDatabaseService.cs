using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement.Service
{
    public interface IDatabaseService
    {
        IEnumerable<T> Query<T>(string sql, object param = null);
        int Execute(string sql, object param = null);
        T QueryFirstOrDefault<T>(string sql, object param = null);
        string ConnectString { get;}

        T Get<T>(int id) where T:class;
        IEnumerable<T> GetAll<T>() where T : class;
        long Insert<T>(T obj) where T : class;
        bool Update<T>(T obj) where T : class;
        bool Delete<T>(T obj) where T : class;
        bool Delete<T>(IEnumerable<T> list) where T : class;
    }
}
