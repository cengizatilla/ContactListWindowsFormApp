using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp.OperationLayer.Entities
{
    public class contact:baseType
    {
        public string company { get; set; }
        public string title { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string personelNote { get; set; }
        public Guid systemUserId { get; set; }
    }
}
