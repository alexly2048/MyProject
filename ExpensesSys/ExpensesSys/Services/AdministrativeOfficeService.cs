using ExpensesSysLib.Models;
using ExpensesSysLib.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSysLib.Services
{
    public class AdministrativeOfficeService
    {
        public AdministrativeOfficeService()
        {
            service = new DBService();
        }
        private readonly DBService service;

        public async Task<IEnumerable<AdministrativeOfficeViewModel>> QueryAdministrativeOfficesAsync(string key)
        {
            var sql = "select AO.OfficeID,AO.Name,AO.Remark,AO.DepartmentID,DE.Name as 'DepartmentName' from T_AdministrativeOffice AO inner join T_Department DE on AO.DepartmentID = DE.DepartmentID";
            var r =await service.QueryAsync<AdministrativeOfficeViewModel>(sql);
            if (!string.IsNullOrEmpty(key))
                r = r.Where(x => x.Name.Contains(key) || x.DepartmentName.Contains(key));
            return r;
        }

        public async Task<int> DeleteAdministrativeOfficeAsync(string officeID)
        {
            var sql = "delete from T_AdministrativeOffice where OfficeID=@OfficeID";
            return await service.ExecuteAsync(sql, new { OfficeID = officeID });
        }

        public async Task<bool> UpdateAdministrativeOfficeAsync(AdministrativeOffice office)
        {
            return await service.UpdateAsync(office);
        }

        public async Task<long> AddAdministrativeOfficeAsync(AdministrativeOffice office)
        {
            return await service.InsertAsync(office);
        }

        public async Task<IEnumerable<AdministrativeOffice>> QueryAdministrativeOfficesAsync()
        {
            return await service.QueryAsync<AdministrativeOffice>("select * from T_AdministrativeOffice");
        }
    }
}
