using ConstructionManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using ConstructionManagement.Service;

namespace ConstructionManagement.Service
{
    public class NotificationService : Connection
    {
        internal void AddNotification(Notification notification)
        {
            var sql = "INSERT INTO Notification (Title,CreateDate,ModifyDate,Content) VALUES (@Title,@CreateDate,@ModifyDate,@Content)";
            Execute(sql, notification);
        }

        internal void UpdateNotification(Notification notification)
        {
            var sql = "UPDATE Notification SET Title=@Title,ModifyDate=@ModifyDate,Content=@Content WHERE ID=@ID";
            Execute(sql, notification);
        }

        internal IList<Notification> GetNotifications()
        {
            var sql = "SELECT ID,Title,Content,CreateDate,ModifyDate FROM Notification";
            var result = Query<Notification>(sql).OrderByDescending(x=>x.ModifyDate).ToList();
            return result;
        }

        internal void DeleteNotification(Notification notification)
        {
            var sql = "DELETE FROM Notification WHERE ID=@ID";
            Execute(sql, notification);
        }

        internal Notification GetNewNotification()
        {
            var sql = "SELECT TOP 1 ID,Title,Content,CreateDate,ModifyDate FROM Notification ORDER BY ModifyDate desc";
            var result = Query<Notification>(sql).FirstOrDefault();
            return result;
        }
    }
}
