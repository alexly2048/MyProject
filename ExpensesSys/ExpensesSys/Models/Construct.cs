using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSysLib.Models
{
    [Table("T_Construct")]
    public class Construct:BaseEntity
    {
        public Construct()
        {
            ConstructID = Guid.NewGuid().ToString();
        }

        [ExplicitKey]
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
        public DateTime? PlanCompletedDate
        {
            get { return planCompletedDate; }
            set { planCompletedDate = value; RaisePropertyChanged(); }
        }
        /// <summary>
        /// 支出时间
        /// </summary>
        public DateTime? ActualCompletedDate
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
        private DateTime? planCompletedDate = DateTime.Now;
        private DateTime? actualCompletedDate = DateTime.Now;
        private string approvalMode;
        private string secondaryConstructID;
        private string officeID;
        private string remark;
    }
}
