using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSysLib.Models
{
    /// <summary>
    /// 二级项目类别
    /// </summary>
    [Table("T_SecondaryConstructCategory")]
    public class SecondaryConstructCategory:BaseEntity
    {
        public SecondaryConstructCategory()
        {
            SecondaryConstructID = Guid.NewGuid().ToString();
        }
        [ExplicitKey]
        public string SecondaryConstructID
        {
            get { return secondaryConstructID; }
            set { secondaryConstructID = value; RaisePropertyChanged(); }
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
        public decimal ActualExpense
        {
            get { return actualExpense; }
            set { actualExpense = value;RaisePropertyChanged(); }
        }

        public string TopConstructID
        {
            get { return topConstructID; }
            set { topConstructID = value;RaisePropertyChanged(); }
        }
        public string Remark 
        {
            get { return remark; }
            set { remark = value;RaisePropertyChanged(); }
        }

        private string secondaryConstructID;
        private string name;
        private decimal money;
        private decimal surplus;
        private decimal actualExpense;
        private string topConstructID;
        private string remark;
    }
}
