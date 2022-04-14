namespace ConstructionManagement.Model
{
    /// <summary>
    /// 施工总体进度
    /// </summary>
    public class ConstructionOverallSchedule:BaseEntity
    {
        /// <summary>
        /// 项目编码
        /// </summary>
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectSchedule { get; set; }       
    }
}
