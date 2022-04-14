using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagement.Model
{
    public class SubItemFile:BaseEntity
    {
        public string FileName { get; set; }
        public string FullFileName { get; set; }
        public string FileType { get; set; }
        public string RemoteFilePath { get; set; }
        public string LocalPath { get; set; }
        public string Description { get; set; }
    }
}
