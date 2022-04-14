using FileManagement.Model;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace FileManagement.Service.DataService
{
    public class CurrentExpenseService
    {
        public CurrentExpenseService(IDatabaseService service)
        {
            this.service = service;
        }
        private readonly IDatabaseService service;

        public int AddCurrentExpense(CurrentExpense target)
        {
            var s = "INSERT INTO [dbo].[CURRENT_EXPENSE] ([PARENT_ID],[ITEM_NAME],[REASON],[CATEGORY],[UNIT],[QUANTITY],[PRICE],[MONEY],[REMARK]) VALUES (@PARENT_ID,@ITEM_NAME,@REASON,@CATEGORY,@UNIT,@QUANTITY,@PRICE,@MONEY,@REMARK)";
            var r = service.Execute(s,target);
            return r;
        }

        public IEnumerable<CurrentExpense> GetCurrentExpenseByParentId(int parentId)
        {
            var s = "SELECT [ID],[PARENT_ID],[ITEM_NAME],[REASON],[CATEGORY],[UNIT],[QUANTITY],[PRICE],[MONEY],[REMARK]  FROM [dbo].[CURRENT_EXPENSE] WHERE PARENT_ID=@PARENT_ID";
            var r = service.Query<CurrentExpense>(s, new { PARENT_ID = parentId });
            return r;
        }

        public decimal GetCurrentExpenseSumByParentId(int parentId)
        {
            var s = "SELECT SUM(MONEY) FROM [CURRENT_EXPENSE] WHERE PARENT_ID=@PARENT_ID";
            var r = service.QueryFirstOrDefault<decimal>(s, new { PARENT_ID = parentId });
            return r;
        }

        public bool DeleteCurrentExpense(CurrentExpense target)
        {
            var r = service.Delete<CurrentExpense>(target);
            return r;
        }

        public bool DeleteCurrentExpenseByParentId(int parentId)
        {
            var r = service.Delete(new CurrentExpense { PARENT_ID = parentId });
            return r;
        }

        public bool UpdateCurrentExpense(CurrentExpense target)
        {
            var r = service.Update<CurrentExpense>(target);
            return r;
        }

        public IEnumerable<CurrentExpense> GetCurrentExpense(string keyword = null)
        {
            var r = service.GetAll<CurrentExpense>();
            if (!string.IsNullOrEmpty(keyword))
            {
                r = r.Where(x => x.ITEM_NAME.Contains(keyword) || x.CATEGORY.Contains(keyword));
            }
            return r;
        }
    }
}
