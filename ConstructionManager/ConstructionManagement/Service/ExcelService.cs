using ConstructionManagement.Model;
using Spire.Xls;
using Spire.Xls.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagement.Service
{
    public class ExcelService
    {
        public ExcelService()
        {

        }

        private string directory = AppDomain.CurrentDomain.BaseDirectory;

        public void PrintConstructionLog(ConstructionLog log)
        {
            try
            {
                var filePath = Path.Combine(directory, "ConstructionLog.xlsx");
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("打印模板文件不存在");
                }
                Workbook workBook = new Workbook();
                workBook.LoadFromFile(filePath);
                Worksheet sheet = workBook.Worksheets[0];

                sheet.Range["B3"].Text = log.LogDate??string.Empty;
                sheet.Range["E3"].Text = log.Weather ?? string.Empty;
                sheet.Range["H3"].Text = log.Temperature ?? string.Empty;
                sheet.Range["B4"].Text = log.ConstructionEvent ?? string.Empty;
                sheet.Range["E4"].Text = log.Wind ?? string.Empty;
                sheet.Range["H4"].Text = log.People ?? string.Empty;
                sheet.Range["A6"].Text = log.ConstructionDescription ?? string.Empty;
                sheet.Range["A36"].Text = log.SecurityLog ?? string.Empty;

                sheet.PageSetup.PaperSize = PaperSizeType.PaperA4;
                sheet.PageSetup.PrintArea = "A1:I52";
                workBook.PrintDocument.Print();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SaveConstructionLog(ConstructionLog log, string exportPath)
        {
            try
            {
                var filePath = Path.Combine(directory, "ConstructionLog.xlsx");
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("打印模板文件不存在");
                }
                using (Workbook workBook = new Workbook())
                {
                    workBook.LoadFromFile(filePath);
                    Worksheet sheet = workBook.Worksheets[0];
                    sheet.Range["B3"].Text = log.LogDate?? string.Empty;
                    sheet.Range["E3"].Text = log.Weather ?? string.Empty;
                    sheet.Range["H3"].Text = log.Temperature ?? string.Empty;
                    sheet.Range["B4"].Text = log.ConstructionEvent ?? string.Empty;
                    sheet.Range["E4"].Text = log.Wind ?? string.Empty;
                    sheet.Range["H4"].Text = log.People ?? string.Empty;
                    sheet.Range["A6"].Text = log.ConstructionDescription ?? string.Empty;
                    sheet.Range["A36"].Text = log.SecurityLog ?? string.Empty;
                    workBook.SaveToFile(exportPath);
                }
                
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
