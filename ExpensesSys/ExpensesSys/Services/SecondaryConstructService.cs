using ExpensesSysLib.Models;
using ExpensesSysLib.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSysLib.Services
{
    public class SecondaryConstructService
    {
        public SecondaryConstructService()
        {
            service = new DBService();
        }
        private readonly DBService service;

        public async Task<IEnumerable<SecondaryConstructViewModel>> QuerySecondaryConstructsAsync(string key)
        {
            var sql = "select SC.SecondaryConstructID,SC.Name,SC.Money,SC.ActualExpense,SC.Surplus,SC.Remark,SC.TopConstructID,TC.Name as 'TopConstructName',TC.BudgetID, BU.Name as 'BudgetName',BU.DepartmentID, DE.Name as 'DepartmentName' from T_SecondaryConstructCategory SC inner join T_TopConstructCategory TC on SC.TopConstructID = TC.TopConstructID inner join T_Budget BU on TC.BudgetID = BU.BudgetID inner join T_Department DE on BU.DepartmentID = DE.DepartmentID";
            var r = await service.QueryAsync<SecondaryConstructViewModel>(sql);
            if (!string.IsNullOrEmpty(key))
                r = r.Where(x => x.Name.Contains(key) || x.TopConstructName.Contains(key) || x.BudgetName.Contains(key) || x.DepartmentName.Contains(key));
            return r;
        }

        public async Task<long> AddSecondaryConstructAsync(SecondaryConstructCategory secondaryConstruct)
        {
            return await service.InsertAsync(secondaryConstruct);
        }

        public async Task<bool> UpdateSecondaryConstructAsync(SecondaryConstructCategory secondaryConstruct)
        {
            return await service.UpdateAsync(secondaryConstruct);
        }

        public async Task<int> DeleteSecondaryConstructAsync(string id)
        {
            var sql = "delete from T_SecondaryConstructCategory where SecondaryConstructID=@SecondaryConstructID";
            return await service.ExecuteAsync(sql, new { SecondaryConstructID = id });
        }
    }
}
