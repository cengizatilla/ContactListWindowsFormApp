using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.ContactList.Entities.baseType;

namespace Udemy.ContactList.Entities.contact
{
    public class contacts: baseClass
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string company { get; set; }
        public string title { get; set; }
        public string personelNote { get; set; }
        public Guid systemUserId { get; set; }
    }
}
