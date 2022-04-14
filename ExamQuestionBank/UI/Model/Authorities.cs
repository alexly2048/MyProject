using Dapper.Contrib.Extensions;

namespace CustomerUI.Model
{
    [Table("Authorities")]
    public class Authorities:BaseEntity
    {
        /// <summary>
        /// 用户账号
        /// </summary>
        public string USER_ID { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string USER_NAME { get; set; }
        /// <summary>
        /// 条目ID
        /// </summary>
        public string ITEM_ID { get; set; }
        /// <summary>
        /// 条目名称
        /// </summary>
        public string ITEM_NAME { get; set; }
        /// <summary>
        /// 权限类型
        /// 主要用于文件上传界面，区分上传文件类型
        /// 用于打开文件上传窗体时使用
        /// </summary>
        public string ITEM_TYPE { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string DESCRIPTION { get; set; }
    }
}