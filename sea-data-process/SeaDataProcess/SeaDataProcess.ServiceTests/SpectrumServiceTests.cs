using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeaDataProcess.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcess.Service.Tests
{
    [TestClass()]
    public class SpectrumServiceTests
    {

        private SpectrumService spectrumService = new SpectrumService();
        [TestMethod()]
        public void PMSpectrumTest()
        {
            Assert.AreEqual(0, Math.Round(spectrumService.PMSpectrum(3.0, 7.0, 0.05), 4));
            Assert.AreEqual(0.0138, Math.Round(spectrumService.PMSpectrum(3.0, 7.0, 0.06), 4));

            Assert.AreEqual(0.8580, Math.Round(spectrumService.PMSpectrum(3.0, 7.0, 0.2), 4));
            Assert.AreEqual(0.0008, Math.Round(spectrumService.PMSpectrum(3.0, 7.0, 0.83), 4));
        }

        [TestMethod()]
        public void JonswapSpectrumTest()
        {
            Assert.AreEqual(0, Math.Round(spectrumService.JonswapSpectrum(3, 7, 9.8605, 0.05, 1), 4));
            Assert.AreEqual(0.8577, Math.Round(spectrumService.JonswapSpectrum(3, 7, 9.8605, 0.2, 1), 4));
            Assert.AreEqual(0.013, Math.Round(spectrumService.JonswapSpectrum(3, 7, 9.8605, 0.47, 1), 4));
            Assert.AreEqual(0.0042, Math.Round(spectrumService.JonswapSpectrum(3, 7, 9.8605, 0.59, 1), 4));
            Assert.AreEqual(0.0008, Math.Round(spectrumService.JonswapSpectrum(3, 7, 9.8605, 0.83, 1), 4));
        }

        [TestMethod()]
        public void CalculateSpectrumTest()
        {
            Assert.AreEqual(0, Math.Round( spectrumService.CalculateSpectrum(3.0, 7.0, 0, 0.05, 0, Data.SpectrumTypeEnum.PM, TzTpEnum.Tz),4));
            Assert.AreEqual(0.0138, Math.Round(spectrumService.CalculateSpectrum(3.0, 7.0, 0, 0.06, 0, Data.SpectrumTypeEnum.PM, TzTpEnum.Tz), 4));
            Assert.AreEqual(0.8580, Math.Round(spectrumService.CalculateSpectrum(3.0, 7.0, 0, 0.2, 0, Data.SpectrumTypeEnum.PM, TzTpEnum.Tz), 4));
            Assert.AreEqual(0.0008, Math.Round(spectrumService.CalculateSpectrum(3.0, 7.0, 0, 0.83, 0, Data.SpectrumTypeEnum.PM, TzTpEnum.Tz), 4));

            Assert.AreEqual(0, Math.Round(spectrumService.CalculateSpectrum(3, 7, 0, 0.05, 1, Data.SpectrumTypeEnum.Jonswap, TzTpEnum.Tz), 4));
            Assert.AreEqual(0.8577, Math.Round(spectrumService.CalculateSpectrum(3, 7, 0, 0.2, 1, Data.SpectrumTypeEnum.Jonswap, TzTpEnum.Tz), 4));
            Assert.AreEqual(0.013, Math.Round(spectrumService.CalculateSpectrum(3, 7, 0, 0.47, 1, Data.SpectrumTypeEnum.Jonswap, TzTpEnum.Tz), 4));
            Assert.AreEqual(0.0042, Math.Round(spectrumService.CalculateSpectrum(3, 7, 0, 0.59, 1, Data.SpectrumTypeEnum.Jonswap, TzTpEnum.Tz), 4));
            Assert.AreEqual(0.0008, Math.Round(spectrumService.CalculateSpectrum(3, 7, 0, 0.83, 1, Data.SpectrumTypeEnum.Jonswap, TzTpEnum.Tz), 4));
        }
    }
}