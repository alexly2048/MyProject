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
    public class DirectionProbabilityTableServiceTests
    {
        private DirectionProbabilityTableService directioin_probability_service = new DirectionProbabilityTableService();
        [TestMethod()]
        public void GetDirectionProbabilityDatasTest()
        {
            string direction_probability = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestDatas", "Direction_Probability.csv");
            var datas = directioin_probability_service.GetDirectionProbabilityDatas(direction_probability);

            Assert.AreEqual(16, datas.Count());

            Assert.AreEqual(1, datas.FirstOrDefault(x => x.DirectionName.Equals("N")).Index);
            Assert.AreEqual(0.37, datas.FirstOrDefault(x => x.Index == 1).Percentage);
            Assert.AreEqual(16, datas.FirstOrDefault(x => x.DirectionName.Equals("NNW")).Index);
            Assert.AreEqual(0.17, datas.FirstOrDefault(x => x.Index == 16).Percentage);
            Assert.AreEqual(8, datas.FirstOrDefault(x => x.DirectionName.Equals("SSE")).Index);
            Assert.AreEqual(10.3, datas.FirstOrDefault(x => x.Index == 8).Percentage);

            Assert.ThrowsException<FileNotFoundException>(()=>directioin_probability_service.GetDirectionProbabilityDatas(@"C:\"));
        }


        [TestMethod()]
        public async Task GetDirectionProbabilityDataFromJsonTest()
        {
            string direction_probability_json = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "direction_probability_data.dll");
            string direction_probability = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestDatas", "Direction_Probability.csv");
            var datas = directioin_probability_service.GetDirectionProbabilityDatas(direction_probability);

            await directioin_probability_service.SaveDirectionProbabilityDataToJson(datas);
            Assert.IsTrue(File.Exists(direction_probability_json));

            var json_datas = await directioin_probability_service.GetDirectionProbabilityDataFromJson();

            Assert.AreEqual(1, json_datas.FirstOrDefault(x => x.DirectionName.Equals("N")).Index);
            Assert.AreEqual(0.37, json_datas.FirstOrDefault(x => x.Index == 1).Percentage);
            Assert.AreEqual(16, json_datas.FirstOrDefault(x => x.DirectionName.Equals("NNW")).Index);
            Assert.AreEqual(0.17, json_datas.FirstOrDefault(x => x.Index == 16).Percentage);
            Assert.AreEqual(8, json_datas.FirstOrDefault(x => x.DirectionName.Equals("SSE")).Index);
            Assert.AreEqual(10.3, json_datas.FirstOrDefault(x => x.Index == 8).Percentage);
        }


    }
}