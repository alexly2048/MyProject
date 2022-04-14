using ExpensesSysLib.Models;
using ExpensesSysLib.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSysUI.Views
{
    public class DepartmentView:BaseEntity
    {
        public DepartmentView()
        {
            _service = new DepartmentService();
        }
        private string _key;
        private ObservableCollection<Department> _departments;
        private DepartmentService _service;
        private Department _selectedDepartment;
        private Department _addDepartment;
        public string Key
        {
            get { return _key; }
            set { _key = value; RaisePropertyChanged(); }
        }

        public ObservableCollection<Department> Departments
        {
            get { return _departments; }
            set { _departments = value;RaisePropertyChanged(); }
        }

        public Department SelectedDepartment
        {
            get { return _selectedDepartment; }
            set { _selectedDepartment = value; RaisePropertyChanged(); }
        }

        internal async Task UpdateDepartmentAsync()
        {
            await _service.UpdateDepartmentAsync(SelectedDepartment);
            await Refresh();
        }

        public Department AddDepartment
        {
            get { return _addDepartment; }
            set { _addDepartment = value; RaisePropertyChanged(); }
        }

        public async Task Refresh()
        {
            var r = await _service.QueryDepartments(Key);
            Departments = new ObservableCollection<Department>(r);
        }

        public async Task AddDepartmentAsync()
        {
            if (AddDepartment == null)
                return;

            await _service.InsertDepartmentAsync(AddDepartment);
           await Refresh();
        }


        public async Task<bool> DeleteDepartmentAsync()
        {
            if(SelectedDepartment == null)
            {
                await DialogHelper.ShowAffirmative("请选择需要删除的数据");
                return false;
            }
            var r = await _service.DeleteDepartmentAsync(SelectedDepartment);
            await Refresh();
            return r;
        }

    }
}
