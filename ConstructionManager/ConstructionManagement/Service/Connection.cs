using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace ConstructionManagement.Service
{
    public class Connection
    {
        
        public Connection()
        {
            ConnectionString = GetConnectionString();
        }
        protected string ConnectionString = string.Empty;
        protected string GetConnectionString()
        {
            try
            {
                var connection = System.Configuration.ConfigurationManager.AppSettings["ManagerServer"];
                return connection;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IList<T> Query<T>(string sql,object param =null)
        {
            try
            {
                using(var connection = new SqlConnection(ConnectionString))
                {
                    var result = connection.Query<T>(sql, param).ToList();
                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Execute(string sql,object param)
        {
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    var result = connection.Execute(sql, param);
                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
