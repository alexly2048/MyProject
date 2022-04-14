using ExpensesSysLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSysLib.Views
{
    public class SecondaryConstructViewModel:BaseEntity
    {
        public SecondaryConstructViewModel()
        {
            SecondaryConstructID = Guid.NewGuid().ToString();
        }
        public string SecondaryConstructID
        {
            get { return secondaryConstructID; }
            set { secondaryConstructID = value; RaisePropertyChanged(); }
        }
        public string Name
        {
            get { return name; }
            set { name = value; RaisePropertyChanged(); }
        }
        public decimal Money
        {
            get { return money; }
            set { money = value; RaisePropertyChanged(); }
        }
        public decimal Surplus
        {
            get { return surplus; }
            set { surplus = value; RaisePropertyChanged(); }
        }
        /// <summary>
        /// 实际支出
        /// </summary>
        public decimal ActualExpense
        {
            get { return actualExpense; }
            set { actualExpense = value; RaisePropertyChanged(); }
        }

        public string Remark
        {
            get { return remark; }
            set { remark = value; RaisePropertyChanged(); }
        }

        public string TopConstructID
        {
            get { return topConstructID; }
            set { topConstructID = value;RaisePropertyChanged(); }
        }

        public string TopConstructName
        {
            get { return topConstructName; }
            set { topConstructName = value;RaisePropertyChanged(); }
        }

        public string BudgetID
        {
            get { return budgetID; }
            set { budgetID = value; RaisePropertyChanged(); }
        }

        public string BudgetName
        {
            get { return budgetName; }
            set { budgetName = value; RaisePropertyChanged(); }
        }
        public string DepartmentID
        {
            get { return departmentID; }
            set { departmentID = value; RaisePropertyChanged(); }
        }
        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; RaisePropertyChanged(); }
        }

        private string secondaryConstructID;
        private string name;
        private decimal money;
        private decimal actualExpense;
        private decimal surplus;
        private string topConstructID;
        private string topConstructName;
        private string budgetID;
        private string budgetName;
        private string departmentID;
        private string departmentName;
        private string remark;
    }
}
