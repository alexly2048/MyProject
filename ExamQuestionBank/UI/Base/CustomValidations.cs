using DevExpress.XtraEditors.DXErrorProvider;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CustomerUI.Base
{
    public class NumberValidation:ValidationRule
    {
        public override bool Validate(Control control, object value)
        {
            string pattern = @"^(-?\d+)(\.\d+)?";
            bool r = false;
            r = Regex.IsMatch(pattern, value.ToString());
            return r;
        }
    }

    public class CustomNumberValidationRule : ValidationRule
    {
        public CustomNumberValidationRule()
        {
            regex = new Regex(reg);
        }
        private string reg = @"^[+-]?\d*[.]?\d*$";
        private Regex regex;
        public override bool Validate(Control control, object value)
        {
            string str = (string)value;
            if (string.IsNullOrEmpty(str))
                return false;
            var r = regex.IsMatch(str);
            return r;
        }
    }

    /// <summary>
    /// 如果用户输入空字符串，返回true
    /// </summary>
    public class CustomOnlyNumberValidationRule : ValidationRule
    {
        public CustomOnlyNumberValidationRule()
        {
            regex = new Regex(reg);
        }
        private string reg = @"^[+-]?\d*[.]?\d*$";
        private Regex regex;
        public override bool Validate(Control control, object value)
        {
            string str = (string)value;
            if (string.IsNullOrEmpty(str))
                return true;
            var r = regex.IsMatch(str);
            return r;
        }
    }
}
