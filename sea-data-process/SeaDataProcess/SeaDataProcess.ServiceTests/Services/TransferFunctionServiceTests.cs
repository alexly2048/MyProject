using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeaDataProcess.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcess.Services.Tests
{
    [TestClass()]
    public class TransferFunctionServiceTests
    {
        private TransferFunctionService transferFunctionService = new TransferFunctionService();
        [TestMethod()]
        public async Task LoadTransferFunctionFrequencyTest()
        {
            string freq_path = Path.Combine(AppContext.BaseDirectory, "TestDatas", "freq.txt");
            var freqs = await transferFunctionService.LoadTransferFunctionFrequency(freq_path);

            Assert.AreEqual(28, freqs.FrequencyList.Count());
            Assert.AreEqual(2.0268, freqs.FrequencyList.FirstOrDefault(x => x.FreqNO == 1).Frequency);
            Assert.AreEqual(1.4661, freqs.FrequencyList.FirstOrDefault(x => x.FreqNO == 6).Frequency);
            Assert.AreEqual(0.7854, freqs.FrequencyList.FirstOrDefault(x => x.FreqNO == 13).Frequency);
            Assert.AreEqual(0.4833, freqs.FrequencyList.FirstOrDefault(x => x.FreqNO == 20).Frequency);
            Assert.AreEqual(0.1795, freqs.FrequencyList.FirstOrDefault(x => x.FreqNO == 28).Frequency);
        }

        [TestMethod()]
        public async Task LoadTransferFunctionDatasTest()
        {
            var transfer_function_path = Path.Combine(AppContext.BaseDirectory, "TestDatas", "joint_16_direction.txt");
            var funcs = await transferFunctionService.LoadTransferFunctionDatas(transfer_function_path);

            Assert.AreEqual(16, funcs.Count());
          
            #region Validate OrderNo
            for (int i = 0; i < 16; i++)
            {
                Assert.IsTrue(funcs.Any(x => x.OrderNO == (i + 1)));
            }
            #endregion

            Assert.AreEqual(0.6523, funcs.FirstOrDefault(x => x.OrderNO == 1).Datas.FirstOrDefault(x => x.FreqNO == 1).TopStress);
            Assert.AreEqual(0.4693, funcs.FirstOrDefault(x => x.OrderNO == 1).Datas.FirstOrDefault(x => x.FreqNO == 1).BotStress);
            Assert.AreEqual(0.5595, funcs.FirstOrDefault(x => x.OrderNO == 1).Datas.FirstOrDefault(x => x.FreqNO == 1).MidStress);

        }
    }
}