using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp.OperationLayer.Entities
{
    public class contactCommunicationList:baseType
    {
        public Guid personelId { get; set; }
        public int communicationType { get; set; }
        public string communicationValue { get; set; }
    }
}
