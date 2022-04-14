using ConstructionManagement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagement
{
    public class Helper
    {
        public static SortableBindingList<T> GetSortableBindingList<T>(IList<T> datas) where T:class
        {
            var result = new SortableBindingList<T>();
            foreach(var r in datas)
            {
                result.Add(r);
            }
            return result;
        }
    }
}
