using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagement.Model
{
    public class ConstructionPlanModel:BaseEntity
    {
        public ConstructionPlanModel()
        {        
        }
        public string ConstructionNo { get; set; }
        public string PlanDate { get; set; }
        public string ConstructionItem { get; set; }
        public string ConstructionPart { get; set; }
        public string CivilWorks { get; set; }
        public string NumOfPerson { get; set; }
        public string Leader { get; set; }
        public string ConstructionMethod { get; set; }
        public string Remark { get; set; }
    }
}
