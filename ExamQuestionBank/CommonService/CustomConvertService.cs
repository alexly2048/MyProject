using System.ComponentModel;

namespace CommonService
{
    public static class CustomConvertService
    {
        private static readonly NullableConverter decimalConvert = new NullableConverter(typeof(decimal?));
        public static decimal? ToDecimalOrNull(this string source)
        {
            var r = decimalConvert.ConvertFrom(source);
            return (decimal?)r;
        }
    }
}
