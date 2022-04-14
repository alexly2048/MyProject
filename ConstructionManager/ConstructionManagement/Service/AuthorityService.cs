using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructionManagement.Model;
using ConstructionManagement.Service;

namespace ConstructionManagement.Service
{
    public class AuthorityService : Connection
    {
        public AuthorityService()
        {
        }
        public static LoginUser LoginUser { get; set; }
        public static IList<NodeItem> MenuItems { get; set; }

        public  IList<Authority> GetAuthorities()
        {
            var sql = "SELECT ID,UserId,UserName,ItemId,ItemName,Description FROM Authority";
            var result = Query<Authority>(sql);
            return result;
        }

        public IList<string> GetAuthorityItemIds(string userId)
        {
            var sql = "SELECT ItemId FROM Authority WHERE UserId=@UserId";
            var result = Query<Authority>(sql,new { UserId = userId }).Select(x=>x.ItemId).ToList();
            return result;
        }

        public void DeleteAuthority(Authority authority)
        {
            var sql = "DELETE FROM Authority WHERE ID=@ID";
            Execute(sql, authority);
        }

        public void DeleteAuthorityByUserId(string userId)
        {
            var sql = "DELETE FROM Authority WHERE UserId=@UserId";
            Execute(sql, new { UserId=userId});
        }

        public void AddAuthority(Authority authority)
        {
            var sql = "INSERT INTO Authority (UserId,UserName,ItemId,ItemName,Description) VALUES (@UserId,@UserName,@ItemId,@ItemName,@Description)";
            Execute(sql, authority);
        }
    }
}
