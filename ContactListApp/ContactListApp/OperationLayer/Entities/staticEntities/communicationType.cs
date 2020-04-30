using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp.OperationLayer.Entities.staticEntities
{
    public class communicationType
    {
        public int communicationTypeId { get; set; }
        public string values { get; set; }

        public static List<communicationType> getCommunicationTypeList()
        {
            return new List<communicationType>() {
             new communicationType(){ communicationTypeId = 717770001, values = "Sabit Telefon" },
             new communicationType(){ communicationTypeId = 717770002, values = "GSM" },
             new communicationType(){ communicationTypeId = 717770003, values = "Açık Adres" },
             new communicationType(){ communicationTypeId = 717770004, values = "Eposta" },
            };
        }
    }
}
