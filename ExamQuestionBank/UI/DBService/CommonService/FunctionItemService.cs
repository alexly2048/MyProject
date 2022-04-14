using CustomerUI.Model;
using DBHelper;
using System.Collections.Generic;

namespace CustomerUI.DBService.CommonService
{
    public class FunctionItemService
    {
        public FunctionItemService(IDatabaseService service)
        {
            this.service = service;
        }
        private readonly IDatabaseService service;

        public IEnumerable<FunctionItem> GetFunctionItems()
        {
            var s = "SELECT * FROM FunctionItem";
            var r = service.Query<FunctionItem>(s);
            return r;
        }
    }
}
