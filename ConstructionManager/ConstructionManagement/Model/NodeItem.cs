using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagement.Model
{
    public class NodeItem
    {
        public int ID { get; set; }
        public int OrderNo { get; set; }      
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public string ParentId { get; set; }
        public string Description { get; set; }

        public bool IsChecked { get; set; } = false;
        public IList<NodeItem> Children {
            get { return children; }
            set { children = value; }
        }


        private IList<NodeItem> children = new List<NodeItem>();
    }
}
