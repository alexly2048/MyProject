using FileManagement.Model;
using System.Collections.Generic;
using System.Linq;

namespace FileManagement.Service.DataService
{
    public class ProjectContractService
    {
        public ProjectContractService(IDatabaseService service)
        {
            this.service = service;
        }
        private readonly IDatabaseService service;

        public int AddProjectContract(ProjectContract contract)
        {
            var r = 0;
            var sql = "INSERT INTO [dbo].[CONTRACT] ([PARENT_ID],[PROJECT_NUMBER],[PROJECT_NAME],[CONTRACT_NO],[CONTRACT_NAME],[REMARK]) VALUES (@PARENT_ID,@PROJECT_NUMBER,@PROJECT_NAME,@CONTRACT_NO,@CONTRACT_NAME,@REMARK)";
            r = service.Execute(sql, contract);
            return r;
        }

        internal IEnumerable<ProjectContract> GetProjectContracts(string keyword = null)
        {
            var s = "SELECT [ID],[PARENT_ID],[PROJECT_NUMBER],[PROJECT_NAME],[CONTRACT_NO],[CONTRACT_NAME],[REMARK] FROM [dbo].[CONTRACT]";
            var r = service.Query<ProjectContract>(s);
            if (!string.IsNullOrEmpty(keyword))
                r = r.Where(e => e.PROJECT_NUMBER.Contains(keyword) || e.PROJECT_NAME.Contains(keyword));
            return r;
        }

        internal int UpdateProjectContract(ProjectContract contract)
        {
            var s = "UPDATE [dbo].[CONTRACT] SET [PARENT_ID]=@PARENT_ID,[PROJECT_NUMBER]=@PROJECT_NUMBER,[PROJECT_NAME]=@PROJECT_NAME,[CONTRACT_NO]=@CONTRACT_NO,[CONTRACT_NAME]=@CONTRACT_NAME,[REMARK]=@REMARK WHERE ID=@ID";
            var r = service.Execute(s);
            return r;
        }

        internal int DeleteProjectContract(ProjectContract data)
        {
            var s = "DELETE FROM CONTRACT WHERE ID=@ID";
            var r = service.Execute(s, data);
            return r;
        }

        public int GetProjectContractId(string projectNumber)
        {
            var s = "SELECT ID FROM CONTRACT WHERE PROJECT_NUMBER=@PROJECT_NUMBER";
            var r = service.QueryFirstOrDefault<int>(s, new { PROJECT_NUMBER = projectNumber });
            return r;
        }
    }
}
