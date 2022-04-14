namespace ConstructionManagement.Model
{
    public class ConstructionNode:BaseEntity
    {
        public string ConstructionNo { get; set; }
        public string Name { get; set; }
        public string ConstructionStart { get; set; }
        public string CivilConstruction { get; set; }
        public string ElectricStart { get; set; }
        public string ElectronicTransfer { get; set; }
        public string PowerCut { get; set; }
        public string PowerCut2 { get; set; }
        public string PowerCut3 { get; set; }
        public string InOperation { get; set; }
        public string BeCompleted { get; set; }
        public string CloseAnAccount { get; set; }
        public string SendKnot { get; set; }
        public string Archive { get; set; }
        public string FileBeforeConstruction { get; set; } = @"施工前附件";
        public string ConstructionPlan { get; set; } = @"施工计划";
    }
}
