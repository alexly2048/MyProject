using Dapper;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DBHelper
{
    public class DatabaseService:IDatabaseService
    {
        protected readonly string serverConect = ConfigurationManager.AppSettings.Get("FileServer");

        public string ConnectString => serverConect;

        public IEnumerable<T> Query<T>(string sql,object param = null)
        {
            using(var c = new SqlConnection(serverConect))
            {
                var r =c.Query<T>(sql, param);
                return r;
            }
        }

        public int Execute(string sql,object param = null)
        {
            using(var c = new SqlConnection(serverConect))
            {
                var r = c.Execute(sql, param);
                return r;
            }
        }

        public T QueryFirstOrDefault<T>(string sql,object param = null)
        {
            using(var c = new SqlConnection(serverConect))
            {
                var r =c.QueryFirstOrDefault<T>(sql, param);
                return r;
            }
        }

        public T Get<T>(int id) where T:class
        {
            using(var c = new SqlConnection(serverConect))
            {
                var r = c.Get<T>(id);
                return r;
            }
        }

        public IEnumerable<T> GetAll<T>() where T:class
        {
            using (var c = new SqlConnection(serverConect))
            {
                IEnumerable<T> r = c.GetAll<T>();
                return r;
            }
        }


        public long Insert<T>(T obj) where T:class
        {
            using (var c = new SqlConnection(serverConect))
            {
                var r = c.Insert(obj);
                return r;
            }
        }

        public bool Update<T>(T obj) where T:class
        {
            using (var c = new SqlConnection(serverConect))
            {
                var r = c.Update(obj);
                return r;
            }
        }

        public bool Delete<T>(T obj) where T:class
        {
            using (var c = new SqlConnection(serverConect))
            {
                var r = c.Delete(obj);
                return r;
            }
        }

        public bool Delete<T>(IEnumerable<T> list) where T:class
        {
            using (var c = new SqlConnection(serverConect))
            {
                var r = c.Delete(list);
                return r;
            }
        }

        public long Insert<T>(T obj,IDbConnection connection,IDbTransaction transaction) where T:class,new()
        {
            var r = connection.Insert(obj, transaction);
            return r;
        }

        public bool Delete<T>(T obj, IDbConnection connection, IDbTransaction transaction) where T : class, new()
        {
            var r = connection.Delete(obj, transaction);
            return r;
        }

        public bool Update<T>(T obj, IDbConnection connection, IDbTransaction transaction) where T : class, new()
        {
            var r = connection.Update(obj, transaction);
            return r;
        }
    }
}
