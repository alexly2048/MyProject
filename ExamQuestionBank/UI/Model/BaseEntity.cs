using Dapper.Contrib.Extensions;

namespace CustomerUI.Model
{
    public class BaseEntity
    {
        [Key]
        public int ID { get; set; } = -1;
       // public int PARENT_ID { get; set; }

        /*
        public string REMARK1 { get; set; }
        public string REMARK2 { get; set; }
        public string REMARK3 { get; set; }
        public string REMARK4 { get; set; }
        public string REMARK5 { get; set; }
        public string REMARK6 { get; set; }
        public string REMARK7 { get; set; }
        public string REMARK8 { get; set; }
        */
    }
}
