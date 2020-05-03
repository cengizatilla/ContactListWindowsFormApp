using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.ContactList.Entities.baseType;

namespace Udemy.ContactList.Entities.contactComm
{
    public class contactComms:baseClass
    {
        public Guid contactId { get; set; }
        public int commType { get; set; }
        public string commValue { get; set; }
    }
}
