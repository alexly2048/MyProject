using ConstructionManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructionManagement.Service
{
    public class MenuItemService:Connection
    {
        public MenuItemService() : base()
        {

        }

        public IList<NodeItem> GetMenuItems()
        {
            var sql = "SELECT ID,OrderNo,ItemId,ItemName,ItemType,ParentId,Description FROM MenuItem";
            var result = Query<NodeItem>(sql);
            return result;
        }
    }
}
