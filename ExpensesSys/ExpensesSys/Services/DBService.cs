using Dapper;
using Dapper.Contrib.Extensions;
using ExpensesSysLib.Helper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSysLib.Services
{
    public class DBService
    {
        public DBService()
        {
        }
        public async Task<IEnumerable<T>> QueryAsync<T>(string sql, object param = null)
        {
            using(var c = new SQLiteConnection(DBHelper.GetSQLiteConnectString()))
            {
                return await c.QueryAsync<T>(sql, param);
            }
        }

        public async Task<int> ExecuteAsync(string sql, object param = null)
        {
            using(var c = new SQLiteConnection(DBHelper.GetSQLiteConnectString()))
            {
                return await c.ExecuteAsync(sql, param);
            }
        }

        public async Task<IEnumerable<T>> QueryAllAsync<T>() where T:class, new()
        {
            using(var c = new SQLiteConnection(DBHelper.GetSQLiteConnectString()))
            {
                return await c.GetAllAsync<T>();
            }
        }

        public async Task<bool> UpdateAsync<T>(T entity) where T : class, new()
        {
            using (var c = new SQLiteConnection(DBHelper.GetSQLiteConnectString()))
            {
                return await c.UpdateAsync(entity);
            }
        }

        public async Task<long> InsertAsync<T>(T entity) where T : class, new()
        {
            using (var c = new SQLiteConnection(DBHelper.GetSQLiteConnectString()))
            {
                return await c.InsertAsync<T>(entity);
            }
        }

        public async Task<bool> DeleteAsync<T>(T entity) where T : class, new()
        {
            using (var c = new SQLiteConnection(DBHelper.GetSQLiteConnectString()))
            {
                return await c.DeleteAsync<T>(entity);
            }
        }
    }
}
