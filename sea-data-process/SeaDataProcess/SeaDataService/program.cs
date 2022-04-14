using SeaDataProcess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcess.Service
{
    class program
    {
        static void Main()
        {
            try
            {
                var path = @"E:\6_Assignment\sea-data-process\Documents\OriginalData.xlsx";
                var data = ExcelHelper.LoadSeaFromFile(path);

                var service = new TransferFunctionService();
                var file = @"E:\6_Assignment\sea-data-process\Documents\tranfer_functions.txt";
                var data1 = service.LoadTransferFunctionDatas(file);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            
        }
    }
}
