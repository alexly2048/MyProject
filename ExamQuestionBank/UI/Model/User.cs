using Dapper.Contrib.Extensions;

namespace CustomerUI.Model
{
    [Table("Users")]
    public class User:BaseEntity
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Pwd { get; set; }
    }
}