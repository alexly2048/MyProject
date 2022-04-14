using ExpensesSysLib.Models;
using ExpensesSysLib.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSysLib.Services
{
    public class ConstructService
    {
        public ConstructService()
        {
            service = new DBService();
        }
        private readonly DBService service;

        public async Task<IEnumerable<ConstructViewModel>> QueryConstructsAsync(string key)
        {
            var sql = "select CI.ConstructID,CI.Name,CI.Unit,CI.QTY,CI.Price,CI.Money,CI.Surplus,CI.ActualExpense,CI.Contractor,CI.ProcurementMode,CI.PlanCompletedDate,CI.ActualCompletedDate,CI.ApprovalMode,CI.Remark,CI.OfficeID,AD.Name as 'OfficeName', SC.SecondaryConstructID,SC.Name as 'SecondaryConstructName',SC.TopConstructID,TC.Name as 'TopConstructName',TC.BudgetID, BU.Name as 'BudgetName',BU.DepartmentID, DE.Name as 'DepartmentName' from T_Construct CI inner join T_SecondaryConstructCategory SC on CI.SecondaryConstructID = SC.SecondaryConstructID inner join T_TopConstructCategory TC on SC.TopConstructID = TC.TopConstructID inner join T_Budget BU on TC.BudgetID = BU.BudgetID inner join T_Department DE on BU.DepartmentID = DE.DepartmentID inner join T_AdministrativeOffice AD on CI.OfficeID = AD.OfficeID";

            var r = await service.QueryAsync<ConstructViewModel>(sql);
            if (!string.IsNullOrEmpty(key))
            {
                r = r.Where(x => x.Name.Contains(key) ||
                            x.SecondaryConstructName.Contains(key) ||
                            x.TopConstructName.Contains(key) ||
                            x.OfficeName.Contains(key) ||
                            x.DepartmentName.Contains(key));
            }
            return r; 
        }

        public async Task<long> AddConstructAsync(Construct construct)
        {
            return await service.InsertAsync(construct);
        }

        public async Task<bool> UpdateConstructAsync(Construct item)
        {
            return await service.UpdateAsync(item);
        }

        public async Task<int> DeleteConstructAsync(string id)
        {
            var sql = "delete from T_Construct where ConstructID=@ConstructID";
            return await service.ExecuteAsync(sql, new { ConstructItemID = id });
        }
    }
}
