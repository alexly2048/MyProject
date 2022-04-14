using System;
using System.Collections.Generic;
using System.Linq;
using ConstructionManagement.Model;

namespace ConstructionManagement.Service
{
    public class ConstructionQuantityService : Connection
    {
        public ConstructionQuantityService() : base()
        {
            subItemService = new ConstructionSubItemService();
        }
        private ConstructionSubItemService subItemService;
        public IList<ConstructionQuantity> GetConstructionQuantity(int parentId)
        {
            try
            {
                string query = "SELECT ID,ParentId,ConstructionNo,ItemName,ItemFeature,ItemUnit,DesignNum,ModifyNum,AllOfProcess,Reminder FROM ConstructionQuantity WHERE ParentId=@ParentId";
                var result = Query<ConstructionQuantity>(query, new { ParentId = parentId });
                foreach (var r in result)
                {
                    var subItems = subItemService.GetSubItemByParentId(r.ID);
                    if (subItems == null || subItems.Count == 0)
                    {
                        continue;
                    }
                    var workDone = subItems.Sum(x => Convert.ToDecimal(x.WorkDone??"0"));
                    r.AllOfProcess = workDone.ToString();
                    r.Reminder = (Convert.ToDecimal(r.DesignNum ??"0") + Convert.ToDecimal(r.ModifyNum ?? "0") - workDone).ToString();
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AddConstructionQuantity(ConstructionQuantity quantity)
        {
            try
            {
                var insert = "INSERT INTO ConstructionQuantity(ParentId,ConstructionNo,ItemName,ItemFeature,ItemUnit,DesignNum,ModifyNum,AllOfProcess,Reminder) VALUES (@ParentId,@ConstructionNo,@ItemName,@ItemFeature,@ItemUnit,@DesignNum,@ModifyNum,@AllOfProcess,@Reminder)";
                var tmp = quantity;
                var r = Execute(insert, tmp);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DelQuantity(ConstructionQuantity quantity)
        {
            try
            {
                if (quantity == null) throw new ArgumentNullException(nameof(quantity));
                string delQuantity = "DELETE FROM ConstructionQuantity WHERE ID=@ID";
                var tmp = quantity;
                Execute(delQuantity, new { ID = quantity.ID });
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        ConstructionSubItemService itemService = new ConstructionSubItemService();
        /// <summary>
        /// 删除施工工程量指定父节点数据
        /// </summary>
        /// <param name="parentId"></param>
        public void DelQuantityByParentId(int parentId)
        {
            try
            {
                var query = "select ID from ConstructionQuantity WHERE ParentId=@ParentId";
                var result = Query<int>(query, new { ParentId = parentId });
                foreach(var r in result)
                {
                    itemService.DelSubItemByParentId(r);
                }
                
                var delQuantity = "DELETE FROM ConstructionQuantity WHERE ParentId=@ParentId";
                Execute(delQuantity, new { ParentId = parentId });
            }
            catch (Exception)
            {
                throw;
            }     
        }

        public void UpdateConstructionQuantity(ConstructionQuantity quantity)
        {
            try
            {
                string update = "UPDATE ConstructionQuantity SET ConstructionNo=@ConstructionNo,ItemName=@ItemName,ItemFeature=@ItemFeature,ItemUnit=@ItemUnit,DesignNum=@DesignNum,ModifyNum=@ModifyNum,AllOfProcess=@AllOfProcess,Reminder=@Reminder WHERE ID=@ID";
                var r = Execute(update, quantity);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
