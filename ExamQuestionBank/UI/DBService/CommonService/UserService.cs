using CustomerUI.Model;
using DBHelper;
using System.Collections.Generic;
using System.Linq;

namespace CustomerUI.DBService.CommonService
{
    public class UserService
    {
        public UserService(IDatabaseService service)
        {
            this.service = service;
        }

        private readonly IDatabaseService service;

        public IEnumerable<User> Query(string keyword)
        {
            var r = service.GetAll<User>();
            if (!string.IsNullOrEmpty(keyword))
            {
                r = r.Where(x => x.UserId.Contains(keyword) || x.UserName.Contains(keyword));
            }
            return r;
        }

        public User GetUserByUserId(User user)
        {
            var s = "SELECT * FROM USERS WHERE UserId=@UserId";
            var r = service.QueryFirstOrDefault<User>(s, user);
            return r;
        }

        public long AddUser(User user)
        {
            return service.Insert(user);
        }

        public bool UpdateUser(User user)
        {
            return service.Update(user);
        }

        public bool DeleteUser(User user)
        {
            return service.Delete(user);
        }
    }
}