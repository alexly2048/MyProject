using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagement.Model
{
    public class Notification
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string CreateDate { get; set; }
        public string ModifyDate { get; set; }
        public string Content { get; set; }
    }
}
