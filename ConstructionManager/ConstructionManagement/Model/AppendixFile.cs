namespace ConstructionManagement.Model
{
    public class AppendixFile:BaseEntity
    {
        /// <summary>
        /// 文件序号
        /// </summary>
        public int FileOrder { get; set; }
        /// <summary>
        /// 开工节点编号
        /// </summary>
        public string ConstructionNo { get; set; }
        /// <summary>
        /// 所属字段
        /// </summary>
        public string ConstructionField { get; set; }
        /// <summary>
        /// 文件名称
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// 文件名
        /// </summary>
        public string FullFileName { get; set; }
        /// <summary>
        /// 文件上传日期
        /// </summary>
        public string CreateDate { get; set; }
        /// <summary>
        /// 文件类型
        /// </summary>
        public string FileType { get; set; }
        /// <summary>
        /// 文件大小
        /// </summary>
        public string FileSize { get; set; }
        /// <summary>
        /// 存储路径
        /// </summary>
        public string RemoteFilePath { get; set; }
        /// <summary>
        /// 本地下载文件
        /// </summary>
        public string LocalFilePath { get; set; }
    }
}
