using ConstructionManagement.Model;
using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagement.Service
{
    public class FileService
    {
        public FileService()
        {
        }
        private readonly string directory = AppDomain.CurrentDomain.BaseDirectory;
        public string GetContent(string fileName)
        {
            var filePath = Path.Combine(directory, fileName);
            if (!System.IO.File.Exists(filePath)) return string.Empty;

            var content = string.Empty;
            using(FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using(StreamReader sr = new StreamReader(fs))
                {
                    content = sr.ReadToEnd();
                }
            }
            return content;
        }

        public void WriteContent(string content,string fileName)
        {
            var filePath = Path.Combine(directory, fileName);
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }

            using(FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using(StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(content);
                }
            }
        }


        public string GetShortcutTargetPath(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                WshShell shell = new WshShell();
                IWshShortcut wshShortcut = shell.CreateShortcut(filePath);
                return wshShortcut.TargetPath;
            }
            return string.Empty;
        }
    }
}
