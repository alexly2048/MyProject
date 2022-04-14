using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MahApps.Metro.Controls;
namespace ExpensesSysUI.Controls
{
    public class MyDateTimePicker:DateTimePicker
    {
        protected override string GetValueForTextBox()
        {
            return SelectedDateTime?.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
