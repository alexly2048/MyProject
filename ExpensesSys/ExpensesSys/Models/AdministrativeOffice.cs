using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSysLib.Models
{
    /// <summary>
    /// 科室
    /// </summary>
    [Table("T_AdministrativeOffice")]
    public class AdministrativeOffice:BaseEntity
    {
        public AdministrativeOffice()
        {
            OfficeID = Guid.NewGuid().ToString();
        }
        [ExplicitKey]
        public string OfficeID
        {
            get { return officeID; }
            set { officeID = value; RaisePropertyChanged(); }
        }
        public string Name
        {
            get { return name; }
            set { name = value;RaisePropertyChanged(); }
        }
        public string Remark
        {
            get { return remark; }
            set { remark = value; RaisePropertyChanged(); }
        }
        public string DepartmentID
        {
            get { return departmentID; }
            set { departmentID = value;RaisePropertyChanged(); }
        }

        private string officeID;
        private string name;
        private string remark;
        private string departmentID;
    }
}
