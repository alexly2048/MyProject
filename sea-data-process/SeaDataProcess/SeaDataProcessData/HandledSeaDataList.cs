using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcess.Data
{
    public class HandledSeaDataList
    {
        public string SheetName { get; set; }
        public List<HandledSeaData> HandledDatas { get; set; } = new List<HandledSeaData>();
    }
}
