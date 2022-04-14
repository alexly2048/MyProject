using ExpensesSysLib.Models;
using ExpensesSysLib.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSysLib.Services
{
    public class BudgetService
    {
        public BudgetService()
        {
            service = new DBService();
        }
        private readonly DBService service;

        public async Task<IEnumerable<BudgetViewModel>> QueryBudgetViews(string key)
        {
            var sql = "select BU.BudgetID,BU.Name,Bu.Money,Bu.ActualExpense,Bu.Surplus,BU.Remark,Bu.DepartmentID,DE.Name as 'DepartmentName' from T_Budget BU inner join T_Department DE on BU.DepartmentID = DE.DepartmentID";
           var r = await service.QueryAsync<BudgetViewModel>(sql);
            if (!string.IsNullOrEmpty(key))
                r = r.Where(x => x.Name.Contains(key) || x.DepartmentName.Contains(key));
            return r;
        }

        public async Task<long> AddBudgetAsync(Budget budget)
        {
            return await service.InsertAsync(budget);
        }

        public async Task<bool> UpdateBudgetAsync(Budget budget)
        {
            return await service.UpdateAsync(budget);
        }

        public async Task<int> DeleteBudgetAsync(string budgetID)
        {
            var sql = "delete from T_Budget where BudgetID = @BudgetID";
            return await service.ExecuteAsync(sql, new { BudgetID = budgetID });
        }

        public async Task<IEnumerable<Budget>> QueryBudgetByDepID(string departmentID)
        {
            var sql = "select * from T_Budget where DepartmentID=@DepartmentID";
            return await service.QueryAsync<Budget>(sql, new { DepartmentID = departmentID });
        }
    }
}
