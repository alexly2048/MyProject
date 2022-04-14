using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSysLib.Models
{
    /// <summary>
    /// 部门信息
    /// </summary>
    [Table("T_Department")]
    public class Department:BaseEntity
    {
        public Department()
        {
            DepartmentID = Guid.NewGuid().ToString();
        }
        [ExplicitKey]
        public string DepartmentID
        {
            get { return _departmentID; }
            set { _departmentID = value; RaisePropertyChanged(); }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value;RaisePropertyChanged(); }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            get { return _remark; }
            set { _remark = value; RaisePropertyChanged(); }
        }

        private string _departmentID;
        private string _name;
        private string _remark;
    }
}
