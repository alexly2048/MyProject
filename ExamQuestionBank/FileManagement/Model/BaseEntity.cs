using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement.Model
{
    public class BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public int PARENT_ID { get; set; }
    }
}
