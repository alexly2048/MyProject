using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRegisterCode
{
    public class GlobalView
    {
        public static Color Dark
        {
            get
            {
                return Color.FromArgb(0, 23, 31);
            }
        }

        public static Color White
        {
            get
            {
                return Color.FromArgb(255, 255, 255);
            }
        }

        public static Color DarkBlue
        {
            get
            {
                return Color.FromArgb(0,52,89);
            }
        }

        public static Color Blue
        {
            get
            {
                return Color.FromArgb(0, 125, 167);
            }
        }

        public static Color LightBlue
        {
            get
            {
                return Color.FromArgb(0, 168, 232);
            }
        }
    }
}
