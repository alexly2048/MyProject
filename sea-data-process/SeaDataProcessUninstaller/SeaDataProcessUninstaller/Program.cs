using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcessUninstaller
{
    class Program
    {
        static void Main(string[] args)
        {
            string root = System.Environment.SystemDirectory;
            string uninstallPath = root + @"\msiexec.exe ";
            System.Diagnostics.Process.Start(uninstallPath, "/x {5AE0EE84-490D-4380-BB2B-0CEE61B6AA6B}");
        }
    }
}
