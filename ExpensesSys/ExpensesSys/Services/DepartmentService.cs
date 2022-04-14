using ExpensesSysLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSysLib.Services
{
    public class DepartmentService
    {
        public DepartmentService()
        {
            _service = new DBService();
        }
        private readonly DBService _service;

        public async Task<IEnumerable<Department>> QueryDepartments(string key)
        {
            var r = await _service.QueryAllAsync<Department>();
            if (!string.IsNullOrEmpty(key))
            {
                return r.Where(x => x.Name.Contains(key) || x.Remark.Contains(key));
            }
            return r;
        }

        public async Task<long> InsertDepartmentAsync(Department department)
        {
            return await _service.InsertAsync(department);
        }

        public async Task<bool> UpdateDepartmentAsync(Department department)
        {
            return await _service.UpdateAsync(department);
        }

        public async Task<bool> DeleteDepartmentAsync(Department department)
        {
            return await _service.DeleteAsync(department);
        }
    }
}
