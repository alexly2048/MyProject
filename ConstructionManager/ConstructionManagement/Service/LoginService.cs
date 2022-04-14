using ConstructionManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructionManagement.Service;

namespace ConstructionManagement.Service
{
    public class LoginService:Connection
    {
        public bool QueryLoginUser(LoginUser user)
        {
            var sql = "SELECT 1 FROM LoginUser WHERE UserId=@UserId AND Pwd=@Pwd";
            var result = Query<int>(sql,user).FirstOrDefault();
            if(result == 1)
            {
                return true;
            }
            return false;
        }

        public IList<LoginUser> GetLoginUsers(string userId="",string userName="")
        {
          
            var sql = "SELECT ID,UserId,UserName,Pwd FROM LoginUser";
            var where = string.Empty;
            if (!string.IsNullOrEmpty(userId))
            {
                where += " WHERE UserId=@UserId";

            }
            if (!string.IsNullOrEmpty(userName))
            {
                if (string.IsNullOrEmpty(where))
                {
                    where += " WHERE UserName=@UserName";
                }
                else
                {
                    where += " AND UserName=@UserName";
                }
            }
            sql += where;
            var user = new LoginUser
            {
                UserId = userId,
                UserName = userName
            };
            var results = Query<LoginUser>(sql,user);
            return results;
        }

        public void DeleteLoginUser(LoginUser user)
        {
            var sql = "DELETE FROM LoginUser WHERE ID=@ID";
            Execute(sql, user);
        }

        public void AddLoginUser(LoginUser user)
        {
            var sql = "SELECT 1 FROM LoginUser WHERE UserId=@UserId";
            var result = Query<int>(sql, user).SingleOrDefault();
            if (result == 1) throw new Exception("用户ID已存在");
            sql = "INSERT INTO LoginUser (UserId,UserName,Pwd) VALUES (@UserId,@UserName,@Pwd)";
            Execute(sql, user);
        }

        internal void UpdateLoginUser(LoginUser user)
        {
            var sql = "update LoginUser set UserId=@UserId,UserName=@UserName,Pwd=@Pwd where ID=@ID";
            Execute(sql, user);
        }
    }
}
