using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagement.Model
{
    public class ConstructionSubItem:BaseEntity
    {
        public string ItemName { get; set; }
        public string Feature { get; set; }
        public string Unit { get; set; }
        public string Part { get; set;}
        public string WorkDone { get; set; }
        public string DoneDate { get; set; }

        public string AppendixImages { get; set; }
        public string AppendixFiles { get; set; }
    }
}
