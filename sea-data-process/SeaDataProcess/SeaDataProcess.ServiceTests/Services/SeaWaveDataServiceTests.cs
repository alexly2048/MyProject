using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeaDataProcess.Service.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcess.Service.Services.Tests
{
    [TestClass()]
    public class SeaWaveDataServiceTests
    {
        private SeaWaveDataService seaWaveService = new SeaWaveDataService();
        private string path = Path.Combine(AppContext.BaseDirectory, "TestDatas", "SeaWaveData_16_Directions.xlsx");
        /// <summary>
        /// 测试从Excel表中加载波浪长期分布数据
        /// </summary>
        [TestMethod()]
        public  void LoadSeadWaveDatasTest()
        {
            var waveDatas =  seaWaveService.LoadSeadWaveDatas(path).ToList();

            // 16个方向的数据
            Assert.AreEqual(16, waveDatas.Count());

            var table_1 = waveDatas[0];           
            var table_2 = waveDatas[1];
            var table_3 = waveDatas[2];
            var table_4 = waveDatas[3];
            var table_5 = waveDatas[4];
            var table_6 = waveDatas[5];
            var table_7 = waveDatas[6];
            var table_8 = waveDatas[7];
            var table_9 = waveDatas[8];
            var table_10 = waveDatas[9];
            var table_11 = waveDatas[10];
            var table_12 = waveDatas[11];
            var table_13 = waveDatas[12];
            var table_14 = waveDatas[13];
            var table_15 = waveDatas[14];
            var table_16 = waveDatas[15];

            Assert.AreEqual(28, table_1.Data.Rows.Count);
            Assert.AreEqual(22, table_1.Data.Columns.Count);
            Assert.AreEqual(28, table_2.Data.Rows.Count);
            Assert.AreEqual(22, table_2.Data.Columns.Count);
            Assert.AreEqual(28, table_3.Data.Rows.Count);
            Assert.AreEqual(22, table_3.Data.Columns.Count);
            Assert.AreEqual(28, table_4.Data.Rows.Count);
            Assert.AreEqual(22, table_4.Data.Columns.Count);
            Assert.AreEqual(28, table_5.Data.Rows.Count);
            Assert.AreEqual(22, table_5.Data.Columns.Count);
            Assert.AreEqual(28, table_6.Data.Rows.Count);
            Assert.AreEqual(22, table_6.Data.Columns.Count);
            Assert.AreEqual(28, table_7.Data.Rows.Count);
            Assert.AreEqual(22, table_7.Data.Columns.Count);
            Assert.AreEqual(28, table_8.Data.Rows.Count);
            Assert.AreEqual(22, table_8.Data.Columns.Count);
            Assert.AreEqual(28, table_9.Data.Rows.Count);
            Assert.AreEqual(22, table_9.Data.Columns.Count);
            Assert.AreEqual(28, table_10.Data.Rows.Count);
            Assert.AreEqual(22, table_10.Data.Columns.Count);
            Assert.AreEqual(28, table_11.Data.Rows.Count);
            Assert.AreEqual(22, table_11.Data.Columns.Count);
            Assert.AreEqual(28, table_12.Data.Rows.Count);
            Assert.AreEqual(22, table_12.Data.Columns.Count);
            Assert.AreEqual(28, table_13.Data.Rows.Count);
            Assert.AreEqual(22, table_13.Data.Columns.Count);
            Assert.AreEqual(28, table_14.Data.Rows.Count);
            Assert.AreEqual(22, table_14.Data.Columns.Count);
            Assert.AreEqual(28, table_15.Data.Rows.Count);
            Assert.AreEqual(22, table_15.Data.Columns.Count);
            Assert.AreEqual(28, table_16.Data.Rows.Count);
            Assert.AreEqual(22, table_16.Data.Columns.Count);
        }
    }
}