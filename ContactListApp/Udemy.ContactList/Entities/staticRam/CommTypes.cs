using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.ContactList.Entities.staticRam
{
    public class CommTypes
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public List<CommTypes> getCommTypes()
        {
            return new List<CommTypes>() {
             new CommTypes(){ Id = 1000,  Value = "Sabit Hat" },
             new CommTypes(){ Id = 1001,  Value = "GSM" },
             new CommTypes(){ Id = 1002,  Value = "İş Hat" },
             new CommTypes(){ Id = 1003,  Value = "Eposta" },
             new CommTypes(){ Id = 1004,  Value = "Çağrı Cihazı" },
             new CommTypes(){ Id = 1005,  Value = "Açık Adres" }
            };
        }
    }
}
