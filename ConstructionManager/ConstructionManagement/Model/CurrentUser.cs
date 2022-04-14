using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagement.Model
{
    public class CurrentUser
    {
        public static LoginUser User { get; set; }
        public static IList<string> Authorities { get; set; }
    }
}
