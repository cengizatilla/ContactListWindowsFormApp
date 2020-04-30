using ContactListApp.OperationLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp.OperationLayer.Services
{
    public class contactService
    {
        SqlDataReader reader;

        public int addNewRecord(contact contactData)
        {
            if (contactData == null) return 0;
            if (string.IsNullOrEmpty(contactData.firstname)) return 0;
            if (string.IsNullOrEmpty(contactData.lastname)) return 0;

            using (DataAccessLayer.contactDatabaseLogicLayer contactDatabaseLogicLayer = new DataAccessLayer.contactDatabaseLogicLayer())
            {
                return contactDatabaseLogicLayer.addNewRecord(contactData);
            }
        }

        public int updateRecord(contact contactData)
        {
            if (contactData == null) return 0;
            if (string.IsNullOrEmpty(contactData.firstname)) return 0;
            if (string.IsNullOrEmpty(contactData.lastname)) return 0;

            using (DataAccessLayer.contactDatabaseLogicLayer contactDatabaseLogicLayer = new DataAccessLayer.contactDatabaseLogicLayer())
            {
                return contactDatabaseLogicLayer.updateRecord(contactData);
            }
        }

        public List<contact> getContactListBySystemUserId(Guid systemUserId)
        {
            List<contact> listContact = new List<contact>();

            if (systemUserId == Guid.Empty) return new List<contact>();

            using (DataAccessLayer.contactDatabaseLogicLayer contactDatabaseLogicLayer = new DataAccessLayer.contactDatabaseLogicLayer())
            {
                reader = contactDatabaseLogicLayer.getContactListBySystemUserId(systemUserId);
                while (reader.Read())
                {
                    listContact.Add(new contact()
                    {
                        Id = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        company = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        title = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        firstname = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        lastname = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        personelNote = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        systemUserId = reader.IsDBNull(6) ? Guid.Empty : reader.GetGuid(6),
                        creationDate = reader.IsDBNull(7) ? DateTime.MinValue : reader.GetDateTime(7)
                    });
                }
                reader.Close();
                contactDatabaseLogicLayer.connectionManager();
                return listContact;
            }

        }

        public contact getContactDetails(Guid contactId, Guid currentSystemUser)
        {
            if (contactId == Guid.Empty) return null;
            if (currentSystemUser == Guid.Empty) return null;

            contact contactData = null;

            using (DataAccessLayer.contactDatabaseLogicLayer contactDatabaseLogicLayer = new DataAccessLayer.contactDatabaseLogicLayer())
            {
                reader = contactDatabaseLogicLayer.getContactDetails(contactId, currentSystemUser);
                while (reader.Read())
                {
                    contactData = new contact()
                    {
                        Id = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        company = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        title = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        firstname = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        lastname = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        personelNote = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        systemUserId = reader.IsDBNull(6) ? Guid.Empty : reader.GetGuid(6),
                        creationDate = reader.IsDBNull(7) ? DateTime.MinValue : reader.GetDateTime(7)
                    };
                }
                reader.Close();
                contactDatabaseLogicLayer.connectionManager();
            }

            return contactData;
        }

        public int deleteRecordByContactId(Guid contactId, Guid currentSystemUser)
        {
            if (contactId == Guid.Empty) return 0;
            if (currentSystemUser == Guid.Empty) return 0;

            using (DataAccessLayer.contactDatabaseLogicLayer contactDatabaseLogicLayer = new DataAccessLayer.contactDatabaseLogicLayer())
            {
               return contactDatabaseLogicLayer.deleteRecordByContactId(contactId, currentSystemUser);
            }




        }
    }
}
