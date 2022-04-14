using ConstructionManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagement.Service
{
    public class NotificationInfoService:Connection
    {

        private const string KEY = "NOTIFICATION_PWD";
        public NotificationInfo GetNotification()
        {
            var s = "SELECT * FROM T_NOTIFICATION_INFO WHERE KEYWORD=@KEYWORD";
            var r = Query<NotificationInfo>(s, new { KEYWORD = KEY }).FirstOrDefault();
            if(r == null) throw new Exception("通知信息密码信息不存在");
            return r;
        }

        public void UpdateNotificationPwd(string pwd)
        {
            var s = "UPDATE T_NOTIFICATION_INFO SET CONTENT=@CONTENT WHERE KEYWORD=@KEYWORD";
            var r = Execute(s, new { CONTENT = pwd, KEYWORD = KEY });
        }
    }
}
