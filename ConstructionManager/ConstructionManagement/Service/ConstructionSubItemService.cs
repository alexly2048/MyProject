using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructionManagement.Model;

namespace ConstructionManagement.Service
{
    public class ConstructionSubItemService:Connection
    {
        public ConstructionSubItemService() : base()
        {

        }

        public IList<ConstructionSubItem> GetSubItemByParentId(int parentId)
        {
            try
            {
                var query = "SELECT ID,ParentId,ItemName,Feature,Unit,Part,WorkDone,DoneDate FROM ConstructionSubItem WHERE ParentId=@ParentId";
                var result = Query<ConstructionSubItem>(query, new { ParentId = parentId });
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        string subItemExists = "SELECT 1 FROM ConstructionSubItem WHERE Guid=@Guid AND ItemUID=@ItemUID";
        public void AddSubItem(ConstructionSubItem subItem)
        {
            try
            {
                string insert = "INSERT INTO dbo.ConstructionSubItem (ParentId,ItemName,Feature,Unit,Part,WorkDone,DoneDate) VALUES (@ParentId,@ItemName,@Feature,@Unit,@Part,@WorkDone,@DoneDate)";
                var r = Execute(insert, subItem);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateSubItem(ConstructionSubItem subItem)
        {
            try
            {
                string update = "UPDATE ConstructionSubItem SET ItemName=@ItemName,Feature=@Feature,Unit=@Unit,Part=@Part,WorkDone=@WorkDone,DoneDate=@DoneDate WHERE ID=@ID AND ParentId=@ParentId";
                var r = Execute(update, subItem);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DelSubItem(ConstructionSubItem subItem)
        {
            try
            {
                string del = "DELETE FROM ConstructionSubItem WHERE ID=@ID AND ParentID=@ParentId";
                var r = Execute(del, new { ID = subItem.ID, ParentId = subItem.ParentId });
            }
            catch (Exception)
            {
                throw;
            }
        }

        SubItemFileService subItemFileService = new SubItemFileService();
        SubItemImageService subItemImageService = new SubItemImageService();
        public void DelSubItemByParentId(int parentId)
        {
            try
            {
                var query = "SELECT ID FROM ConstructionSubItem WHERE ParentId=@ParentId";
                var results = Query<int>(query, new { ParentId = parentId });
                foreach(var r in results)
                {
                    subItemFileService.DeleteSubItemFileByParentId(r);
                    subItemImageService.DelSubItemImageByParentId(r);
                }

                var del = "DELETE FROM ConstructionSubItem WHERE ParentId=@ParentId";
                Execute(del, new { ParentId = parentId });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
