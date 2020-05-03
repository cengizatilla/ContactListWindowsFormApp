using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.ContactList.Entities.contactComm;
using Udemy.ContactList.Operation.databaseLogicLayer;

namespace Udemy.ContactList.Operation.Services
{
    public class contactCommService
    {
        public int addNewComm(Guid contactId, int commType, string commValue)
        {
            if (contactId == Guid.Empty || commType == 0 || string.IsNullOrEmpty(commValue)) return 0;

            contactComms data = new contactComms()
            {
                id = Guid.NewGuid(),
                commType = commType,
                commValue = commValue,
                contactId = contactId,
                createDate = DateTime.Now
            };

            using (contactCommDatabaseLogicLayer commDatabaseLogicLayer = new contactCommDatabaseLogicLayer())
            {
                return commDatabaseLogicLayer.addNewComm(data);
            }
        }

        public List<contactComms> getContactAllComm(Guid contactId)
        {
            List<contactComms> dataList = new List<contactComms>();

            if (contactId == Guid.Empty) return null;

            using (contactCommDatabaseLogicLayer commDatabaseLogicLayer = new contactCommDatabaseLogicLayer())
            {
                SqlDataReader reader = commDatabaseLogicLayer.getContactAllComm(contactId);
                while (reader.Read())
                {
                    dataList.Add(new contactComms()
                    {
                        id = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        contactId = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1),
                        commType = reader.IsDBNull(2) ? 0 : reader.GetInt32(2),
                        commValue = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        createDate = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4)
                    });
                }
                reader.Close();
                commDatabaseLogicLayer.connectionWizard();
            }
            return dataList;
        }

        public contactComms getContactCommId(Guid contactCommId)
        {
            contactComms data = new contactComms();

            if (contactCommId == Guid.Empty) return null;

            using (contactCommDatabaseLogicLayer contactCommDatabase = new contactCommDatabaseLogicLayer())
            {
                SqlDataReader reader = contactCommDatabase.getContactCommId(contactCommId);
                while (reader.Read())
                {
                    data.id = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0);
                    data.contactId = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1);
                    data.commType = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                    data.commValue = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                }
                reader.Close();
                contactCommDatabase.connectionWizard();
            }

            return data;
        }

        public int deleteContactComm(Guid commId)
        {
            int result = 0;
            if (commId == Guid.Empty) return 0;

            using (contactCommDatabaseLogicLayer contactCommDatabase = new contactCommDatabaseLogicLayer())
            {
                result = contactCommDatabase.deleteContactComm(commId);
            }

            return result;
        }

        public int updateContactComm(Guid id, int commType, string commValue)
        {
            int resultInt = 0;
            
            if (id == Guid.Empty || commType == 0 || string.IsNullOrEmpty(commValue)) return 0;

            contactComms updateData = new contactComms();
            updateData.id = id;
            updateData.commType = commType;
            updateData.commValue = commValue;

            using (contactCommDatabaseLogicLayer contactCommDatabase = new contactCommDatabaseLogicLayer())
            {
                resultInt = contactCommDatabase.updateContactComm(updateData);
            }

            return resultInt;
        }
    }
}
