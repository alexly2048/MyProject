using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSysLib.Models
{
    /// <summary>
    /// 一级项目类别
    /// </summary>
    [Table("T_TopConstructCategory")]
    public class TopConstructCategory:BaseEntity
    {
        public TopConstructCategory()
        {
            TopConstructID = Guid.NewGuid().ToString();
        }
        [ExplicitKey]
        public string TopConstructID
        {
            get { return topConstructID; }
            set { topConstructID = value;  RaisePropertyChanged(); }
        }
        public string Name
        {
            get { return name; }
            set { name = value;RaisePropertyChanged(); }
        }
        public decimal Money
        {
            get { return money; }
            set { money = value;RaisePropertyChanged(); }
        }
        public decimal Surplus
        {
            get { return surplus; }
            set { surplus = value;RaisePropertyChanged(); }
        }
        /// <summary>
        /// 实际支出
        /// </summary>
        public decimal ActualExpense
        {
            get { return actualExpense; }
            set { actualExpense = value;RaisePropertyChanged(); }
        }
        public string BudgetID
        {
            get { return budgetID; }
            set { budgetID = value;RaisePropertyChanged(); }
        }

        public string Remark
        {
            get { return remark; }
            set { remark = value;RaisePropertyChanged(); }
        }

        private string topConstructID;
        private string name;
        private decimal money;
        private decimal actualExpense;
        private decimal surplus;
        private string budgetID;
        private string remark;
    }
}
