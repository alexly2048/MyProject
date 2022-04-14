using DevExpress.Xpo.DB.Helpers;
using FileManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement.Service.DataService
{
    public class ClientService
    {
        public ClientService(IDatabaseService service)
        {
            this.service = service;
        }
        private readonly IDatabaseService service;

        public int AddClient(Client client)
        {
            var s = "INSERT INTO [dbo].[CLIENT] ([PARENT_ID],[PROJECT_NUMBER],[PROJECT_NAME],[INSTALLATION_MATERIAL],[POWER_CUT],[ADD_MATERIAL],[RETURN_MATERIAL]) VALUES (@PARENT_ID,@PROJECT_NUMBER,@PROJECT_NAME,@INSTALLATION_MATERIAL,@POWER_CUT,@ADD_MATERIAL,@RETURN_MATERIAL)";
            var r = service.Execute(s, client);
            return r;

        }

        public int UpdateClient(Client client)
        {
            var s = "UPDATE [dbo].[CLIENT] SET [PARENT_ID]=@PARENT_ID,[PROJECT_NUMBER]=@PROJECT_NUMBER,[PROJECT_NAME]=@PROJECT_NAME,[INSTALLATION_MATERIAL]=@INSTALLATION_MATERIAL,[POWER_CUT]=@POWER_CUT,[ADD_MATERIAL]=@ADD_MATERIAL,[RETURN_MATERIAL]=@RETURN_MATERIAL WHERE ID=@ID";
            var r = service.Execute(s, client);
            return r;
        }

        public IEnumerable<Client> GetClients(string keyword = null)
        {
            var s = "SELECT [ID],[PARENT_ID],[PROJECT_NUMBER],[PROJECT_NAME],[INSTALLATION_MATERIAL],[POWER_CUT],[ADD_MATERIAL],[RETURN_MATERIAL] FROM [dbo].[CLIENT]";
            var r = service.Query<Client>(s);
            if (!string.IsNullOrEmpty(keyword))
                r = r.Where(e => e.PROJECT_NAME.Contains(keyword) || e.PROJECT_NUMBER.Contains(keyword));
             return r;
        }

        public int DeleteClient(Client client)
        {
            return DeleteClientById(client.ID);
        }

        public int DeleteClientById(int id)
        {
            var s = "DELETE FROM CLIENT WHERE ID=@ID";
            var r = service.Execute(s, new { ID = id });
            return r;
        }

        public int DeleteClientByParentId(int parentId)
        {
            var s = "DELETE FROM CLIENT WHERE PARENT_ID=@PARENT_ID";
            var r = service.Execute(s, new {PARENT_ID = parentId });
            return r;
        }
    }
}
