using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ExpensesSysLib.Helper
{
    public class DBHelper
    {
         private DBHelper()
        {
            
        }
        private static string path = Path.Combine(AppContext.BaseDirectory,"data.dll");

        public static bool CheckDBExists()
        {
            return File.Exists(path);
        }

        public static string GetSQLiteConnectString()
        {
            var builder = new SQLiteConnectionStringBuilder
            {
                DataSource = path,
                Version = 3,
            };
            return builder.ToString();
        }

        public static async void CreateTables()
        {
            if (CheckDBExists())
                return;
            var department = "create table T_Department(" +
                "DepartmentID nvarchar(150) not null primary key," +
                "Name nvarchar(50) not null unique," +
                "Remark nvarchar(200));";

            var office = "create table T_AdministrativeOffice(" +
                "OfficeID nvarchar(150) not null primary key," +
                "Name nvarchar(50) not null unique," +
                "Remark nvarchar(200)," +
                "DepartmentID nvarchar(150) not null references T_Department(DepartmentID));";

            var budget = "create table T_Budget(" +
                "BudgetID nvarchar(150) not null primary key," +
                "Name nvarchar(50) not null unique," +
                "Money decimal not null," +
                "ActualExpense decimal," +
                "Surplus decimal," +
                "Remark nvarchar(200)," +
                "DepartmentID nvarchar(150) not null references T_Department(DepartmentID));";

            var top = "create table T_TopConstructCategory(" +
                "TopConstructID nvarchar(150) not null primary key," +
                "Name nvarchar(50) not null unique," +
                "Money deciman not null," +
                "ActualExpense decimal," +
                "Surplus decimal," +
                "Remark nvarchar(200)," +
                "BudgetID nvarchar(150) not null references T_Budget(BudgetID));";

            var secondary = "create table T_SecondaryConstructCategory(" +
                "SecondaryConstructID nvarchar(150) not null primary key," +
                "Name nvarchar(50) not null unique," +
                "Money deciman not null," +
                "ActualExpense decimal," +
                "Surplus decimal," +
                "Remark nvarchar(200)," +
                "TopConstructID nvarchar(150) not null references T_TopConstructCategory(TopConstructID));";

            var construct = "create table T_Construct(" +
                "ConstructID nvarchar(150) not null primary key," +
                "Name nvarchar(50) not null," +
                "Unit nvarchar(50) not null," +
                "QTY double," +
                "Price decimal," +
                "Money decimal," +
                "Surplus decimal," +
                "ActualExpense decimal," +
                "Contractor nvarchar(5)," +
                "ProcurementMode nvarchar(50)," +
                "PlanCompletedDate date," +
                "ActualCompletedDate date," +
                "ApprovalMode nvarchar(50)," +
                "Remark nvarchar(200)," +
                "SecondaryConstructID nvarchar(150) not null references T_SecondaryConstructCategory(SecondaryConstructID)," +
                "OfficeID nvarchar(150) not null references T_AdministrativeOffice(OfficeID));";

            var item = "create table T_ConstructItem(" +
                "ConstructItemID nvarchar(150) not null primary key," +
                "Name nvarchar(50) not null," +
                "Unit nvarchar(50) not null," +
                "QTY double," +
                "Price decimal," +
                "Money decimal," +
                "Surplus decimal," +
                "ActualExpense decimal," +
                "Contractor nvarchar(5)," +
                "ProcurementMode nvarchar(50)," +
                "PlanCompletedDate date," +
                "ActualCompletedDate date," +
                "ApprovalMode nvarchar(50)," +
                "Remark nvarchar(200)," +
                "ConstructID nvarchar(150) not null references T_Construct(ConstructID));";

            using (var c = new SQLiteConnection(GetSQLiteConnectString()))
            {
                c.Open();
                var department_command = new SQLiteCommand(department, c);
                await department_command.ExecuteNonQueryAsync();
                var office_command = new SQLiteCommand(office, c);
                await office_command.ExecuteNonQueryAsync();
                var budget_command = new SQLiteCommand(budget, c);
                await budget_command.ExecuteNonQueryAsync();
                var top_command = new SQLiteCommand(top, c);
                await top_command.ExecuteNonQueryAsync();
                var secondary_command = new SQLiteCommand(secondary, c);
                await secondary_command.ExecuteNonQueryAsync();
                var construct_command = new SQLiteCommand(construct, c);
                await construct_command.ExecuteNonQueryAsync();
                var item_command = new SQLiteCommand(item, c);
                await item_command.ExecuteNonQueryAsync();
            }
        }
    }
}
