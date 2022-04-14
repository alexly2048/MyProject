using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement.Model
{
    public class ProjectContract:BaseEntity
    {
        public string PROJECT_NUMBER { get; set; }
        public string PROJECT_NAME { get; set; }
        public string CONTRACT_NO { get; set; }
        public string CONTRACT_NAME { get; set; }
        public string APPENDIX_FILE { get; set; } = "点击查看附件";
        public string REMARK { get; set; }

    }
}
