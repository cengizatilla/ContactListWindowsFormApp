using ContactListApp.OperationLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp.OperationLayer.Services
{
    public class contactCommunicationService
    {
        SqlDataReader reader;

        public int createRecord(contactCommunicationList communicationData)
        {
            if (communicationData == null) return 0;
            if (string.IsNullOrEmpty(communicationData.communicationValue)) return 0;

            using (DataAccessLayer.contactCommunicationDatabaseLogicLayer contactCommunicationDatabaseLogicLayer = new DataAccessLayer.contactCommunicationDatabaseLogicLayer())
            {
                return contactCommunicationDatabaseLogicLayer.createRecord(communicationData);
            }
        }

        public int updateRecord(contactCommunicationList communicationData)
        {
            if (communicationData == null) return 0;
            if (string.IsNullOrEmpty(communicationData.communicationValue)) return 0;

            using (DataAccessLayer.contactCommunicationDatabaseLogicLayer contactCommunicationDatabaseLogicLayer = new DataAccessLayer.contactCommunicationDatabaseLogicLayer())
            {
                return contactCommunicationDatabaseLogicLayer.updateRecord(communicationData);
            }
        }

        public int deleteRecordById(Guid Id)
        {
            using (DataAccessLayer.contactCommunicationDatabaseLogicLayer contactCommunicationDatabaseLogicLayer = new DataAccessLayer.contactCommunicationDatabaseLogicLayer())
            {
                return contactCommunicationDatabaseLogicLayer.deleteRecordById(Id);
            }
        }

        public List<contactCommunicationList> getAllRecords(Guid systemUserId)
        {
            List<contactCommunicationList> contactCommunicationDataList = new List<contactCommunicationList>();
            using (DataAccessLayer.contactCommunicationDatabaseLogicLayer contactCommunicationDatabaseLogicLayer = new DataAccessLayer.contactCommunicationDatabaseLogicLayer())
            {
                reader = contactCommunicationDatabaseLogicLayer.getAllRecords(systemUserId);
                while (reader.Read())
                {
                    contactCommunicationDataList.Add(new contactCommunicationList()
                    {
                        Id = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        personelId = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1),
                        communicationType = reader.IsDBNull(2) ? 0 : reader.GetInt32(2),
                        communicationValue = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        creationDate = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4)
                    });
                }
                reader.Close();
                contactCommunicationDatabaseLogicLayer.connectionManager();
            }
            return contactCommunicationDataList;
        }

        public contactCommunicationList getRecordById(Guid systemUserId,Guid Id)
        {
           contactCommunicationList contactCommunicationData = null;
            using (DataAccessLayer.contactCommunicationDatabaseLogicLayer contactCommunicationDatabaseLogicLayer = new DataAccessLayer.contactCommunicationDatabaseLogicLayer())
            {
                reader = contactCommunicationDatabaseLogicLayer.getRecordById(systemUserId,Id);
                while (reader.Read())
                {
                    contactCommunicationData = new contactCommunicationList()
                    {
                        Id = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        personelId = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1),
                        communicationType = reader.IsDBNull(2) ? 0 : reader.GetInt32(2),
                        communicationValue = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        creationDate = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4)
                    };
                }
                reader.Close();
                contactCommunicationDatabaseLogicLayer.connectionManager();
            }
            return contactCommunicationData;
        }
    }
}
