using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp.OperationLayer.Entities
{
    public class systemUserLoginLog: baseType
    {
        public Guid userId { get; set; }
        public bool status { get; set; }
        public string message { get; set; }
    }
}
