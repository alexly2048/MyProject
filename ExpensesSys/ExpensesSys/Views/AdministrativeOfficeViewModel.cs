using ExpensesSysLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSysLib.Views
{
    public class AdministrativeOfficeViewModel:BaseEntity
    {

        public AdministrativeOfficeViewModel()
        {
            OfficeID = Guid.NewGuid().ToString();
        }

        public string OfficeID
        {
            get { return officeID; }
            set { officeID = value; RaisePropertyChanged(); }
        }
        public string Name
        {
            get { return name; }
            set { name = value; RaisePropertyChanged(); }
        }
        public string Remark
        {
            get { return remark; }
            set { remark = value; RaisePropertyChanged(); }
        }
        public string DepartmentID
        {
            get { return departmentID; }
            set { departmentID = value; RaisePropertyChanged(); }
        }

        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value;RaisePropertyChanged(); }
        }

        private string officeID;
        private string name;
        private string remark;
        private string departmentID;
        private string departmentName { get; set; }
    }
}
