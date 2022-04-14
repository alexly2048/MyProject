using ExpensesSysLib.Models;
using ExpensesSysLib.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSysLib.Services
{
    public class TopConstructService
    {
        public TopConstructService()
        {
            service = new DBService();
        }
        private readonly DBService service;

        public async Task<IEnumerable<TopConstructViewModel>> QueryTopConstructViews(string key)
        {
            var sql = "select TC.TopConstructID,TC.Name,TC.Money,TC.ActualExpense,TC.Surplus,TC.Remark,TC.BudgetID,BU.Name as 'BudgetName', BU.DepartmentID,DE.Name as 'DepartmentName' from T_TopConstructCategory TC inner join T_Budget BU on TC.BudgetID = BU.BudgetID inner join T_Department DE on BU.DepartmentID = DE.DepartmentID";
            var r = await service.QueryAsync<TopConstructViewModel>(sql);
            if (!string.IsNullOrEmpty(key))
                r = r.Where(x => x.Name.Contains(key) || x.BudgetName.Contains(key) || x.DepartmentName.Contains(key));
            return r;
        }

        public async Task<long> AddTopConstructCategory(TopConstructCategory topConstruct)
        {
            return await service.InsertAsync(topConstruct);
        }

        public async Task<bool> UpdateTopConstructCategory(TopConstructCategory topConstruct)
        {
            return await service.UpdateAsync(topConstruct);
        }

        public async Task<int> DeleteTopConstructCategory(string topID)
        {
            var sql = "delete from T_TopConstructCategory where TopConstructID=@TopConstructID";
            return await service.ExecuteAsync(sql, new { TopConstructID = topID });
        }

        public async Task<IEnumerable<TopConstructCategory>> QueryTopConstructs(string budgetID)
        {
            var sql = "select * from T_TopConstructCategory where BudgetID=@BudgetID";
            return await service.QueryAsync<TopConstructCategory>(sql, new { BudgetID = budgetID });
        }
    }
}
