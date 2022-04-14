using SeaDataProcess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcess.Service
{
    public class SpectrumService
    {
        /// <summary>
        /// 频谱类型
        /// </summary>
        public SpectrumTypeEnum SpectrumType { get; set; }
        

        #region PM谱函数
        /// <summary>
        /// PM谱函数
        /// </summary>
        /// <param name="hs">有义波高（单位米(m)）</param>
        /// <param name="tz">平均跨零周期（单位秒(s)）</param>
        /// <param name="frequency">f</param>
        /// <returns></returns>
        public double PMSpectrum(double hs, double tz, double frequency)
        {
            return Math.Pow(hs, 2) 
                / (4 * Math.PI * Math.Pow(tz, 4) * Math.Pow(frequency, 5)) 
                * Math.Pow(Math.E, -(1 / Math.PI * Math.Pow(frequency * tz, -4)));
        }
        #endregion

        #region Jonswap谱函数
        /// <summary>
        /// Jonswap谱函数
        /// </summary>
        /// <param name="hs"></param>
        /// <param name="tz"></param>
        /// <param name="tp"></param>
        /// <param name="frequency"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public double JonswapSpectrum(double hs, double tz, double tp, double frequency, double r)
        {
            var kp = GetJonswapKP(r);
            var kr = GetJonswapKR(r);
            var sigma = GetJonswapsigma(frequency, tp);
            var a = GetJonswapA(tz, kp, frequency, sigma);

            return kr * Math.Pow(KB, 4) * Math.Pow(hs, 2)
                / (4 * Math.PI * Math.Pow(kp * tz, 4) * Math.Pow(frequency, 5))
                * Math.Pow(Math.E, -1 / Math.PI * Math.Pow(frequency * kp / KB * tz, -4))
                * Math.Pow(r, a);
        }

        private double GetJonswapKP(double r)
        {
            return 0.327 * Math.Pow(Math.E, -0.315 * r) + 1.17;
        }

        private double GetJonswapKR(double r)
        {
            return 1 - 0.285 * Math.Log(r);
        }

        /// <summary>
        /// 计算JONSWAP频谱函数 σ
        /// </summary>
        /// <param name="frequency">频率</param>
        /// <param name="tp">谱峰周期</param>
        /// <returns>σ 值</returns>
        private double GetJonswapsigma(double frequency, double tp)
        {
            return frequency <= (1 / tp) ? 0.07 : 0.09;
        }

        /// <summary>
        /// 计算JONSWAP频谱函数中a参数
        /// </summary>
        /// <param name="tz">平均跨零周期</param>
        /// <param name="kp"></param>
        /// <param name="f">频率</param>
        /// <param name="sigma">JONSWAP频谱函数中delat参数</param>
        /// <returns>a 值</returns>
        private double GetJonswapA(double tz, double kp, double f, double sigma)
        {
            return Math.Pow(Math.E, -Math.Pow(kp * tz * f - 1, 2) / (2 * Math.Pow(sigma, 2)));
        }

        /// <summary>
        /// 计算峰升因子r
        /// </summary>
        /// <param name="hs">有义波高</param>
        /// <param name="tz">平均跨零周期</param>
        /// <returns></returns>
        public double GetJonswapR(double hs, double tz)
        {
            var r1 =  5.55 * Math.Pow(174 * (hs / (G * Math.Pow(tz, 2))) - 1, 1 / 4);
            return r1 > 1 ? r1 : 1;
        }
        #endregion

        /// <summary>
        /// 计算频谱函数
        /// </summary>
        /// <param name="hs">有义波高（单位米m）</param>
        /// <param name="tz">平均跨零周期（tz(s))</param>
        /// <param name="tp">谱峰周期</param>
        /// <param name="spectrumType">频谱类型</param>
        /// <param name="frequency">频率</param>
        /// <param name="r">峰升因子</param>
        /// <param name="tzTpType">tztp参数类型</param>
        /// <returns>计算结果，有效精度取10位</returns>
        public double CalculateSpectrum(double hs, 
            double tz, 
            double tp, 
            double frequency, 
            double r, 
            SpectrumTypeEnum spectrumType, 
            TzTpEnum tzTpType)
        {
            if(tzTpType == TzTpEnum.Tp)
            {
                tz = tp / KP;
            }
            else
            {
                tp = KP * tz;
            }

            if(spectrumType == SpectrumTypeEnum.Jonswap)
            {
                return JonswapSpectrum(hs, tz, tp, frequency, r);
            }else if(spectrumType == SpectrumTypeEnum.PM)
            {
                return PMSpectrum(hs, tz, frequency);
            }
            else
            {
                throw new NotSupportedException("不支持的频谱类型");
            }
        }

        private const double KP = 1.41;
        private const double KB = 1.4085;
        private const double G = 9.81;
    }


    /// <summary>
    /// Tz/Tp输入类型
    /// </summary>
    public enum TzTpEnum
    {
        Tz,
        Tp
    }
}
