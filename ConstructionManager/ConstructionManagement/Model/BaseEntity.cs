namespace ConstructionManagement.Model
{
    public class BaseEntity
    {
        /// <summary>
        /// 自增ID
        /// </summary>
        public  int ID { get; set; }
        /// <summary>
        /// 唯一标志符
        /// </summary>
        public int ParentId { get; set; }
    }
}
