using ExpensesSysLib.Services;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSysLib.Helper
{
    public class ActualExpenseHelper
    {
        public static async Task CalcActualExpenseAsync()
        {
            var service = new DBService();
            var construct = "select ConstructID,sum(ActualExpense) as 'Total' from T_ConstructItem group by ConstructID";
            var secondary = "select SecondaryConstructID,sum(ActualExpense) as 'Total' from T_Construct group by SecondaryConstructID";
            var top = "select TopConstructID,sum(ActualExpense) as 'Total' from T_SecondaryConstructCategory group by TopConstructID";
            var budget = "select BudgetID,sum(ActualExpense) as 'Total' from T_TopConstructCategory group by BudgetID";

            var updateConstruct = "update T_Construct set ActualExpense=@ActualExpense,Surplus=Money-@Expense where ConstructID=@ID";
            var updateSecondary = "update T_SecondaryConstructCategory set ActualExpense=@ActualExpense,Surplus=Money-@Expense where SecondaryConstructID=@ID";
            var updateTop = "update T_TopConstructCategory set ActualExpense=@ActualExpense,Surplus=Money-@Expense where TopConstructID=@ID";
            var updateBudget = "update T_Budget set ActualExpense=@ActualExpense,Surplus=Money-@Expense where BudgetID=@ID";

            using (var c = new SQLiteConnection(DBHelper.GetSQLiteConnectString()))
            {
                var constructExpense = await service.QueryAsync<dynamic>(construct);
                foreach (var r in constructExpense)
                    await service.ExecuteAsync(updateConstruct, new { ActualExpense = r.Total, Expense = r.Total, ID = r.ConstructID });

                var secondaryExpense = await service.QueryAsync<dynamic>(secondary);
                foreach (var r in secondaryExpense)
                    await service.ExecuteAsync(updateSecondary, new { ActualExpense = r.Total, Expense = r.Total, ID = r.SecondaryConstructID });

                var topExpense = await service.QueryAsync<dynamic>(top);
                foreach (var r in topExpense)
                    await service.ExecuteAsync(updateTop, new { ActualExpense = r.Total, Expense = r.Total, ID = r.TopConstructID });

                var budgetExpense = await service.QueryAsync<dynamic>(budget);
                foreach (var r in budgetExpense)
                    await service.ExecuteAsync(updateBudget, new { ActualExpense = r.Total, Expense = r.Total, ID = r.BudgetID });
            }
        }
    }
}
