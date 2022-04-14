using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagement.Model
{
    public class ConstructionLog
    {
        public int ID { get; set; }
        public string LogId { get; set; }
        public string LogDate { get; set; }
        public string Weather { get; set; }
        public string Temperature { get; set; }
        public string ConstructionEvent { get; set; }
        public string Wind { get; set; }
        public string People { get; set; }
        public string ConstructionDescription { get; set; }
        public string SecurityLog { get; set; }

        public string ConstructionCode { get; set; }
        public string ConstructionName { get; set; }
    }
}
