using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonService
{
    public static class CustomerHelper
    {
        public static string GetGuid()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }

        public static string ToJson<T>(this T obj)
        {
            var r = JsonConvert.SerializeObject(obj);
            return r;
        }

        public static T ToObject<T>(this string source)
        {
            var r = JsonConvert.DeserializeObject<T>(source);
            return r;
        }
    }
}
