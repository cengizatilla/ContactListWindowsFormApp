using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.ContactList.Entities.contact;
using Udemy.ContactList.Entities.staticRam;
using Udemy.ContactList.Operation.databaseLogicLayer;

namespace Udemy.ContactList.Operation.Services
{
    public class contactService
    {
        public int addNewContact(string firstName, string lastName, string companyName, string title, string personelNote)
        {
            int resultInt = 0;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName)) return 0;

            contacts newRecord = new contacts();
            newRecord.id = Guid.NewGuid();
            newRecord.firstName = firstName;
            newRecord.lastName = lastName;
            newRecord.company = companyName;
            newRecord.title = title;
            newRecord.personelNote = personelNote;
            newRecord.createDate = DateTime.Now;
            newRecord.systemUserId = applicationStatics.currentSystemUser.id;

            using (contactDatabaseLogicLayer contactDatabase = new contactDatabaseLogicLayer())
            {
                resultInt = contactDatabase.addNewContact(newRecord);
            }

            return resultInt;
        }

        public List<contacts> getAllRecordsBySystemUserId()
        {
            List<contacts> dataList = new List<contacts>();

            using (contactDatabaseLogicLayer contactDatabase = new contactDatabaseLogicLayer())
            {
                SqlDataReader reader = contactDatabase.getAllRecordsBySystemUserId(applicationStatics.currentSystemUser.id);
                while (reader.Read())
                {
                    contacts temp = new contacts();
                    temp.id = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0);
                    temp.firstName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    temp.lastName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                    temp.company = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    temp.title = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    temp.systemUserId = reader.IsDBNull(5) ? Guid.Empty : reader.GetGuid(5);
                    temp.createDate = reader.IsDBNull(6) ? DateTime.MinValue : reader.GetDateTime(6);
                    temp.personelNote = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);

                    dataList.Add(temp);
                }
                reader.Close();
                contactDatabase.connectionWizard();
            }

            return dataList;
        }

        public contacts getRecordByContactId( Guid contactId)
        {
            contacts data = new contacts();

            using (contactDatabaseLogicLayer contactDatabase = new contactDatabaseLogicLayer())
            {
                SqlDataReader reader = contactDatabase.getRecordByContactId(applicationStatics.currentSystemUser.id, contactId);
                while (reader.Read())
                {
                    data.id = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0);
                    data.firstName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    data.lastName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                    data.company = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    data.title = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    data.systemUserId = reader.IsDBNull(5) ? Guid.Empty : reader.GetGuid(5);
                    data.createDate = reader.IsDBNull(6) ? DateTime.MinValue : reader.GetDateTime(6);
                    data.personelNote = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                }
                reader.Close();
                contactDatabase.connectionWizard();
            }

            return data;
        }


        public int deleteRecordByID(Guid contactId)
        {
            if (contactId == Guid.Empty) return 0;

            using (contactDatabaseLogicLayer contactDatabase = new contactDatabaseLogicLayer())
            {
                return contactDatabase.deleteRecordByID(contactId);
            }
        }

        public int updateContact(Guid id,string firstName , string lastName, string company, string title, string personelNote)
        {

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName)) return 0;

            contacts updateData = new contacts();
            updateData.id = id;
            updateData.firstName = firstName;
            updateData.lastName = lastName;
            updateData.company = company;
            updateData.title = title;
            updateData.personelNote = personelNote;

            using (contactDatabaseLogicLayer contactDatabase = new contactDatabaseLogicLayer())
            {
                return contactDatabase.updateContact(updateData);
            }

        }
    }
}
