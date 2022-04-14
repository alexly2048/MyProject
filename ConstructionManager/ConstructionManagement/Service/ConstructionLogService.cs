using ConstructionManagement.Model;
using System;
using System.Collections.Generic;

namespace ConstructionManagement.Service
{
    public class ConstructionLogService : Connection
    {
        public  IList<ConstructionLog> GetConstructionLogs(string constructionCode, string start, string end)
        {
            var sql = "SELECT ID,LogDate,Weather,Temperature,ConstructionEvent,Wind,People,ConstructionDescription,SecurityLog,ConstructionCode,ConstructionName FROM ConstructionLog";
            var where = string.Empty;
            if (!string.IsNullOrEmpty(constructionCode))
            {
                where += " WHERE ConstructionCode=@ConstructionCode";
            }
            if (!string.IsNullOrEmpty(start))
            {
                var s = new DateTime();
                if(DateTime.TryParse(start,out s))
                {
                    if (!string.IsNullOrEmpty(where))
                    {
                        where += " AND LogDate>=@BeginDate";
                    }
                    else
                    {
                        where += " WHERE LogDate>=@BeginDate";
                    }
                }
            }
            if (!string.IsNullOrEmpty(end))
            {
                var s = new DateTime();
                if (DateTime.TryParse(end, out s))
                {
                    if (!string.IsNullOrEmpty(where))
                    {
                        where += " AND LogDate<=@EndDate";
                    }
                    else
                    {
                        where += " WHERE LogDate<=@EndDate";
                    }
                }
            }

            sql += where;
            var result = Query<ConstructionLog>(sql, new { ConstructionCode = constructionCode, BeginDate = start, EndDate = end });
            return result;
        }

        public void DeleteConstructionLog(ConstructionLog log)
        {
            var sql = "DELETE FROM ConstructionLog WHERE ID=@ID";
            Execute(sql, log);
        }

        public void AddConstructionLog(ConstructionLog log)
        {
            var sql = "INSERT INTO ConstructionLog (ConstructionCode,ConstructionName,LogDate,Weather,Temperature,ConstructionEvent,Wind,People,ConstructionDescription,SecurityLog) VALUES (@ConstructionCode,@ConstructionName,@LogDate,@Weather,@Temperature,@ConstructionEvent,@Wind,@People,@ConstructionDescription,@SecurityLog)";
            Execute(sql, log);
        }

        public void UpdateConstruction(ConstructionLog log)
        {
            var sql = "UPDATE ConstructionLog SET ConstructionCode=@ConstructionCode,ConstructionName=@ConstructionName,LogDate=@LogDate,Weather=@Weather,Temperature=@Temperature,ConstructionEvent=@ConstructionEvent,Wind=@Wind,People=@People,ConstructionDescription=@ConstructionDescription,SecurityLog=@SecurityLog WHERE ID=@ID";
            Execute(sql, log);
        }

        public void DeleteConstructionLogByCode(string code)
        {
            try
            {
                var sql = "DELETE FROM ConstructionLog WHERE ConstructionCode=@ConstructionCode";
                Execute(sql, new { ConstructionCode = code });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
