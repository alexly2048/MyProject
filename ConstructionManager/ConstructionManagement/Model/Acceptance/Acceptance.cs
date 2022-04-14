using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagement.Model
{
    /// <summary>
    /// 中间验收数据表
    /// </summary>
    public class Acceptance
    {
        public int ID { get; set; }
        public string ProjectNo { get; set; }
        public ProjectKindEnum ProjectKind { get; set; }
        public string ProjectName { get; set; }
        public string ItemName { get; set;}
        public string ItemFeature { get; set; }
        public string ItemUnit { get; set; }
        public string Remark1 { get; set; }
        public string Remark2 { get; set; }
        public string Remark3 { get; set; }
        public string Description { get; set; }

        public string Question { get; set; }
        public string Rectify { get; set; }
    }

    public enum ProjectKindEnum
    {
        Middle = 1,
        Final = 2
    }


}
