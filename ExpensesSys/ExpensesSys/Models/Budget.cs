using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSysLib.Models
{
    /// <summary>
    /// 预算
    /// </summary>
    [Table("T_Budget")]
    public class Budget:BaseEntity
    {
        public Budget()
        {
            BudgetID = Guid.NewGuid().ToString();
        }
        [ExplicitKey]
        public string BudgetID
        {
            get { return budgetID; }
            set { budgetID = value; RaisePropertyChanged(); }
        }
        public string Name
        {
            get { return name; }
            set { name = value;RaisePropertyChanged(); }
        }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal Money
        {
            get { return money; }
            set { money = value;RaisePropertyChanged(); }
        }
        /// <summary>
        /// 实际支出
        /// </summary>
        public decimal ActualExpense
        {
            get { return actualExpense; }
            set { actualExpense = value;RaisePropertyChanged(); }
        }
        /// <summary>
        /// 余额
        /// </summary>
        public decimal Surplus
        {
            get { return surplus; }
            set { surplus = value;RaisePropertyChanged(); }
        }

        public string Remark
        {
            get { return remark; }
            set { remark = value; RaisePropertyChanged(); }
        }
        /// <summary>
        /// 部门标识
        /// </summary>
        public string DepartmentID
        {
            get { return departmentID; }
            set { departmentID = value;RaisePropertyChanged(); }
        }

        private string budgetID;
        private string name;
        private decimal money;
        private decimal actualExpense;
        private decimal surplus;
        private string departmentID;
        private string remark;
    }
}
