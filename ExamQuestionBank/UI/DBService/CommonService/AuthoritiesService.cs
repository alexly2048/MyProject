using CustomerUI.Model;
using DBHelper;
using System.Collections.Generic;
using System.Linq;

namespace CustomerUI.DBService.CommonService
{
    public class AuthoritiesService
    {
        public AuthoritiesService(IDatabaseService service)
        {
            this.service = service;
        }
        private readonly IDatabaseService service;

        public IEnumerable<Authorities> GetAuthorities(string keyword)
        {
            var sql = "SELECT ID,USER_ID,USER_NAME,ITEM_ID,ITEM_NAME,ITEM_TYPE,DESCRIPTION FROM Authorities";
            var r = service.Query<Authorities>(sql);


            if (!string.IsNullOrEmpty(keyword))
            {
                r = r.Where(x => x.USER_ID.Contains(keyword) ||
                            x.USER_NAME.Contains(keyword) ||
                            x.ITEM_NAME.Contains(keyword) ||
                            x.ITEM_ID.Contains(keyword));
            }
            return r;
        }

        public IEnumerable<string> GetAuthorityItemIds(string userId)
        {
            var sql = "SELECT ITEM_ID FROM Authorities WHERE USER_ID=@UserId";
            var result =service.Query<string>(sql, new { UserId = userId });
            return result;
        }

        public IEnumerable<Authorities> GetAuthoritiesByUserId(string userId)
        {
            var sql = "SELECT ID,USER_ID,USER_NAME,ITEM_ID,ITEM_NAME,ITEM_TYPE,DESCRIPTION FROM Authorities WHERE USER_ID=@USER_ID";
            var r = service.Query<Authorities>(sql, new { USER_ID = userId });
            return r;
        }

        public bool DeleteAuthority(Authorities authority)
        {
            var sql = "DELETE FROM Authorities WHERE ID=@ID";
            var r = service.Execute(sql,authority);
            return true;
        }

        public void DeleteAuthorityByUserId (string userId)
        {
            var sql = "DELETE FROM Authorities WHERE USER_ID=@UserId";
            var r =service.Execute(sql, new { UserId = userId });
        }

        public long AddAuthority(Authorities authority)
        {
            var sql = "INSERT INTO Authorities (USER_ID,USER_NAME,ITEM_ID,ITEM_NAME,ITEM_TYPE,DESCRIPTION) VALUES (@USER_ID,@USER_NAME,@ITEM_ID,@ITEM_NAME,@ITEM_TYPE,@DESCRIPTION)";
            var r = service.Execute(sql,authority);
            return r;
        }
    }
}
