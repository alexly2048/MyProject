using System.ComponentModel;

namespace CustomerUI.Base
{
    public static class ConvertHelper
    {
        public static double CoverterStringToDoubleOrDefault(string num)
        {
            if (string.IsNullOrEmpty(num)) return 0;
            var r = 0d;
            if(double.TryParse(num,out r))
            {
                return 0;
            }
            return r;
        }

        public static double? ConvertToDoubleOrNull(string num)
        {
            NullableConverter converter = new NullableConverter(typeof(double?));
            var r = (double?)converter.ConvertFromString(num);
            return r;
        }
    }
}
