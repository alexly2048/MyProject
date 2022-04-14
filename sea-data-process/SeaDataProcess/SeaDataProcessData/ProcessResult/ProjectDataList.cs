using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcess.Data
{
    /// <summary>
    /// 存储一个项目的计算结果
    /// </summary>
    public class ProjectDataList
    {
        private List<JointCalculateResult> tableList = new List<JointCalculateResult>();
        public List<JointCalculateResult> TableList
        {
            get { return tableList;}
            set { tableList = value; }
        }
    }
}
