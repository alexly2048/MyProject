using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagement.Model
{
    /// <summary>
    /// 权限分配表
    /// </summary>
    public class Authority
    {
        public int ID { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
    }
}
