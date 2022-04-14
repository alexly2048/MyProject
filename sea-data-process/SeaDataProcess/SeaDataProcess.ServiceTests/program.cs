using SeaDataProcess.Service.Services.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcess.ServiceTests
{
    class program
    {
        public static void Main()
        {
            var test = new SeaWaveDataServiceTests();
            test.LoadSeadWaveDatasTest();
        }
    }
}
