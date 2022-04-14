using ExpensesSysLib.Models;
using ExpensesSysLib.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSysLib.Services
{
    public class ConstructItemService
    {
        public ConstructItemService()
        {
            service = new DBService();
        }
        private readonly DBService service;

        public async Task<IEnumerable<ConstructItemViewModel>> QueryConstructItemsAsync()
        {
            var sql = "select CI.ConstructItemID,CI.Name,CI.Unit,CI.QTY,CI.Price,CI.Money,CI.Surplus,CI.ActualExpense,CI.Contractor,CI.ProcurementMode,CI.PlanCompletedDate,CI.ActualCompletedDate,CI.ApprovalMode,CI.Remark,CO.OfficeID,AD.Name as 'OfficeName',CO.ConstructID,CO.Name as 'ConstructName', SC.SecondaryConstructID,SC.Name as 'SecondaryConstructName',SC.TopConstructID,TC.Name as 'TopConstructName',TC.BudgetID, BU.Name as 'BudgetName',BU.DepartmentID, DE.Name as 'DepartmentName' from T_ConstructItem CI inner join T_Construct CO on CI.ConstructID = CO.ConstructID inner join T_SecondaryConstructCategory SC on CO.SecondaryConstructID = SC.SecondaryConstructID inner join T_TopConstructCategory TC on SC.TopConstructID = TC.TopConstructID inner join T_Budget BU on TC.BudgetID = BU.BudgetID inner join T_Department DE on BU.DepartmentID = DE.DepartmentID inner join T_AdministrativeOffice AD on CO.OfficeID = AD.OfficeID";
            return await service.QueryAsync<ConstructItemViewModel>(sql);
        }

        public async Task<long> AddConstructItemAsync(ConstructItem item)
        {
            return await service.InsertAsync(item);
        }

        public async Task<bool> UpdateConstructItemAsync(ConstructItem item)
        {
            return await service.UpdateAsync(item);
        }

        public async Task<int> DeleteConstructItemAsync(string id)
        {
            var sql = "delete from T_ConstructItem where ConstructItemID=@ConstructItemID";
            return await service.ExecuteAsync(sql, new { ConstructItemID = id });
        }
    }
}
