using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagement.Model
{
    public class Memo
    {
        public int ID { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string CreateDate { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }
    }
}
