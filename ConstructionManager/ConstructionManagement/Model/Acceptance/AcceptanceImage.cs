using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagement.Model
{
    public class AcceptanceImage
    {
        public int ID { get; set; }
        public int ParentId { get; set; }
        public string ProjectNo { get; set; }
        public string FileName { get; set; }
        public string FullFileName { get; set; }
        public string RemoteFilePath { get; set; }
        public string Description { get; set; }
        public ImageKindEnum ImageKind { get; set; }
    }

    public enum ImageKindEnum
    {
        Problem = 0,
        Rectify = 1
    }
}
