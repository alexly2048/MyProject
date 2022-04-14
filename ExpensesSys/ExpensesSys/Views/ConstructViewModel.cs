using ExpensesSysLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSysLib.Views
{
    public class ConstructViewModel:BaseEntity
    {
        public ConstructViewModel()
        {
            ConstructID = Guid.NewGuid().ToString();
        }
        public string ConstructID
        {
            get { return constructID; }
            set { constructID = value; RaisePropertyChanged(); }
        }
        public string Name
        {
            get { return name; }
            set { name = value; RaisePropertyChanged(); }
        }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit
        {
            get { return unit; }
            set { unit = value; RaisePropertyChanged(); }
        }
        public double QTY
        {
            get { return qty; }
            set { qty = value; RaisePropertyChanged(); }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; RaisePropertyChanged(); }
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
        /// <summary>
        /// 承办人
        /// </summary>
        public string Contractor
        {
            get { return contractor; }
            set { contractor = value; RaisePropertyChanged(); }
        }
        /// <summary>
        /// 采购方式
        /// </summary>
        public string ProcurementMode
        {
            get { return procurementMode; }
            set { procurementMode = value; RaisePropertyChanged(); }
        }
        /// <summary>
        /// 计划完成时间
        /// </summary>
        public DateTime PlanCompletedDate
        {
            get { return planCompletedDate; }
            set { planCompletedDate = value; RaisePropertyChanged(); }
        }
        /// <summary>
        /// 支出时间
        /// </summary>
        public DateTime ActualCompletedDate
        {
            get { return actualCompletedDate; }
            set { actualCompletedDate = value; RaisePropertyChanged(); }
        }
        /// <summary>
        /// 经费审批方式
        /// </summary>
        public string ApprovalMode
        {
            get { return approvalMode; }
            set { approvalMode = value; RaisePropertyChanged(); }
        }
        public string SecondaryConstructID
        {
            get { return secondaryConstructID; }
            set { secondaryConstructID = value; RaisePropertyChanged(); }
        }
        public string OfficeID
        {
            get { return officeID; }
            set { officeID = value; RaisePropertyChanged(); }
        }
        /// <summary>
        /// 备注说明
        /// </summary>
        public string Remark
        {
            get { return remark; }
            set { remark = value; RaisePropertyChanged(); }
        }

        public string OfficeName
        {
            get { return officeName; }
            set { officeName = value; RaisePropertyChanged(); }
        }

        public string SecondaryConstructName
        {
            get { return secondaryConstructName; }
            set { secondaryConstructName = value; RaisePropertyChanged(); }
        }

        public string TopConstructID
        {
            get { return topConstructID; }
            set { topConstructID = value; RaisePropertyChanged(); }
        }
        public string TopConstructName
        {
            get { return topConstructName; }
            set { topConstructName = value; RaisePropertyChanged(); }
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

        private string constructID;
        private string name;
        private string unit;
        private double qty;
        private decimal price;
        private decimal money;
        private decimal surplus;
        private decimal actualExpense;
        private string contractor;
        private string procurementMode;
        private DateTime planCompletedDate;
        private DateTime actualCompletedDate;
        private string approvalMode;
        private string secondaryConstructID;
        private string officeID;
        private string remark;

        private string officeName;
        private string secondaryConstructName;
        private string topConstructID;
        private string topConstructName;
        private string budgetID;
        private string budgetName;
        private string departmentID;
        private string departmentName;
    }
}
