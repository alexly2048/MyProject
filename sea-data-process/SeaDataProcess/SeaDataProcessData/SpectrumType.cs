using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcess.Data
{
    public class SpectrumType:BaseEntity
    {
        private string Name { get; set; }
    }

    /// <summary>
    /// 频谱类型
    /// </summary>
    public enum SpectrumTypeEnum
    {
        PM,
        Jonswap
    }
}
