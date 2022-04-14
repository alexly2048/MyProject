using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using SeaDataProcess.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcess.Service
{
    public class ExcelHelper
    {
        private static IWorkbook CreateWorkbook(string filePath, Stream stream)
        {
            var extension = Path.GetExtension(filePath);
            if (extension.Equals(".xlsx"))
            {
                return new XSSFWorkbook(stream);
            }
            else if(extension.Equals(".xls"))
            {
                return new HSSFWorkbook(stream);
            }
            else
            {
                throw new NotSupportedException("仅支持以.xls或.xlsx结尾的文件");
            }
        }


        /// <summary>
        /// 从Excel表中添加波浪长期分布表
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static IEnumerable<SeaData> LoadSeaFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(nameof(filePath));
            }

            var datas = new List<SeaData>();
            using(var fs = File.OpenRead(filePath))
            {
                var workbook = CreateWorkbook(filePath,fs);
                var sheetCount = workbook.NumberOfSheets; // 忽略掉最后两个汇总sheet

                for(int i = 0; i < sheetCount; i++)
                {
                    // 通过sheet名称中是否包含 - 判断是否是原始数据
                    var sheet = workbook.GetSheetAt(i);
                    if (!sheet.SheetName.Contains("-"))
                        continue;

                    var seaData = new SeaData();
                    var table = new DataTable();
                    
                    var headRow = sheet.FirstRowNum;
                    var heads = sheet.GetRow(headRow + 2);
                    for(int h = heads.FirstCellNum; h < heads.LastCellNum - 1; h++) // 创建Table标题，忽略最后一列数据
                    {
                        table.Columns.Add(heads.Cells[h]?.ToString() ?? throw new ArgumentNullException($"数据表{sheet.SheetName}中缺少Tp周期"));
                    }
                    for (int j = headRow + 3; j < sheet.LastRowNum - 1; j++) // 导入数据，忽略最后一行汇总数据
                    {
                        var row = sheet.GetRow(j);
                        var dataRow = table.NewRow();
                        for(int c = row.FirstCellNum; c < row.LastCellNum - 1;c++) // 忽略最后一列数据
                        {
                            dataRow[c] = row.Cells[c]?.ToString()??"0";
                            
                        }
                        table.Rows.Add(dataRow.ItemArray);
                    }
                    seaData.Name = sheet.SheetName;
                    seaData.Data = table;
                    seaData.Index = i + 1;
                    datas.Add(seaData);
                }
            }
            return datas;
            
        }
    }
}
