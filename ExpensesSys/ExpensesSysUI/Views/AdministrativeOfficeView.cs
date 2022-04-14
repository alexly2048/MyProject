using ExpensesSysLib.Models;
using ExpensesSysLib.Services;
using ExpensesSysLib.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSysUI.Views
{
    public class AdministrativeOfficeView:BaseEntity
    {
        public AdministrativeOfficeView()
        {
            depService = new DepartmentService();
            officeService = new AdministrativeOfficeService();

            
        }

        private readonly DepartmentService depService;
        private readonly AdministrativeOfficeService officeService;
        private ObservableCollection<AdministrativeOfficeViewModel> officeViews;
        private AdministrativeOfficeViewModel selectedOfficeView;
        private ObservableCollection<Department> departments;
        private Department selectedDepartment;
        private AdministrativeOffice addOffice;
        private string key;

        public string Key
        {
            get { return key; }
            set { key = value;RaisePropertyChanged(); }
        }
        public ObservableCollection<AdministrativeOfficeViewModel> OfficeViews
        {
            get { return officeViews; }
            set { officeViews = value;RaisePropertyChanged(); }
        }

        public AdministrativeOfficeViewModel SelectedOfficeView
        {
            get { return selectedOfficeView; }
            set { selectedOfficeView = value;RaisePropertyChanged(); }
        }

        public ObservableCollection<Department> Departments
        {
            get { return departments; }
            set { departments = value;RaisePropertyChanged(); }
        }

        public Department SelectedDepartment
        {
            get { return selectedDepartment; }
            set { selectedDepartment = value; RaisePropertyChanged(); }
        }

        public AdministrativeOffice AddOffice
        {
            get { return addOffice; }
            set { addOffice = value;RaisePropertyChanged(); }
        }

        public async Task Refresh()
        {
            var r = await officeService.QueryAdministrativeOfficesAsync(Key);
            OfficeViews = new ObservableCollection<AdministrativeOfficeViewModel>(r);
        }

        public async Task AddAdministrativeOfficeAsync()
        {
            if (addOffice == null)
                return;
            if (selectedDepartment == null)
                return;

            addOffice.DepartmentID = selectedDepartment.DepartmentID;
            await officeService.AddAdministrativeOfficeAsync(addOffice);
            await Refresh();
        }

        public async Task UpdateAdministrativeOfficeAsync()
        {
            if (selectedOfficeView == null)
                return;
            if (selectedDepartment == null)
                return;

            var office = new AdministrativeOffice
            {
                DepartmentID = selectedDepartment.DepartmentID,
                OfficeID = selectedOfficeView.OfficeID,
                Name = selectedOfficeView.Name,
                Remark = selectedOfficeView.Remark
            };
            await officeService.UpdateAdministrativeOfficeAsync(addOffice);
            await Refresh();
            SelectedDepartment = null;
        }

        public void SetSelectedDepartment()
        {
            if (selectedOfficeView == null)
                SelectedDepartment = null;
            else
                SelectedDepartment = departments.FirstOrDefault(x => x.DepartmentID.Equals(SelectedOfficeView?.DepartmentID??string.Empty));
        }

        public async Task DeleteAdministrativeOfficeAsync()
        {
            if (selectedOfficeView == null)
                return;
            await officeService.DeleteAdministrativeOfficeAsync(selectedOfficeView.OfficeID);
            await Refresh();
        }

        public async Task GetDepartments()
        {
           Departments = new ObservableCollection<Department>( await depService.QueryDepartments(string.Empty));
        }

        public async Task BeforeUpdate()
        {
            await GetDepartments();
            SetSelectedDepartment();
        }
    }
}
