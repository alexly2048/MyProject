using System.Collections.Generic;
/// <summary>
/// 权限类
/// </summary>
namespace CustomerUI.Model
{
    public class FunctionItem
    {
        public long ID { get; set; }
        public int OrderNo { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public string ParentId { get; set; }
        public string Description { get; set; }
        public bool IsChecked { get; set; } = false;
        public IList<FunctionItem> Children
        {
            get { return children; }
            set { children = value; }
        }


        private IList<FunctionItem> children = new List<FunctionItem>();
    }
}
