using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DBHelper
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
        long Insert<T>(T obj, IDbConnection connection, IDbTransaction transaction) where T : class, new();
        bool Delete<T>(T obj, IDbConnection connection, IDbTransaction transaction) where T : class, new();
        bool Update<T>(T obj, IDbConnection connection, IDbTransaction transaction) where T : class, new();


        #region Async Method
       // Task<T> GetAllAsync<T>() where T : class;
        #endregion
    }
}
