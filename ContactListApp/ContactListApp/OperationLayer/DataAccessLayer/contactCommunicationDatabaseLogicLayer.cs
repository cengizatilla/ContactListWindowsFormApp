using ContactListApp.OperationLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp.OperationLayer.DataAccessLayer
{
    public class contactCommunicationDatabaseLogicLayer : databaseLogicLayer
    {

        public int createRecord(contactCommunicationList contactCommunicationListData)
        {
            command = new SqlCommand("addNewCommunication", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add("@Id", System.Data.SqlDbType.UniqueIdentifier).Value = contactCommunicationListData.Id;
            command.Parameters.Add("@personelId", System.Data.SqlDbType.UniqueIdentifier).Value = contactCommunicationListData.personelId;
            command.Parameters.Add("@communicationType", System.Data.SqlDbType.Int).Value = contactCommunicationListData.communicationType;
            command.Parameters.Add("@communicationValue", System.Data.SqlDbType.NVarChar).Value = contactCommunicationListData.communicationValue;
            command.Parameters.Add("@creationDate", System.Data.SqlDbType.DateTime).Value = contactCommunicationListData.creationDate;

            connectionManager();
            int returnIntValue = command.ExecuteNonQuery();
            connectionManager();
            return returnIntValue;
        }

        public int updateRecord(contactCommunicationList contactCommunicationListData)
        {
            command = new SqlCommand("updateCommunication", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add("@Id", System.Data.SqlDbType.UniqueIdentifier).Value = contactCommunicationListData.Id;
            command.Parameters.Add("@communicationType", System.Data.SqlDbType.Int).Value = contactCommunicationListData.communicationType;
            command.Parameters.Add("@communicationValue", System.Data.SqlDbType.NVarChar).Value = contactCommunicationListData.communicationValue;

            connectionManager();
            int returnIntValue = command.ExecuteNonQuery();
            connectionManager();
            return returnIntValue;
        }

        public int deleteRecordById(Guid Id)
        {
            command = new SqlCommand("deleteRecordByIdComm", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add("@ID", System.Data.SqlDbType.UniqueIdentifier).Value = Id;

            connectionManager();
            int returnIntValue = command.ExecuteNonQuery();
            connectionManager();
            return returnIntValue;
        }

        public SqlDataReader getAllRecords(Guid systemUserId)
        {
            command = new SqlCommand("getAllRecordCommunication", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add("@systemUserId", System.Data.SqlDbType.UniqueIdentifier).Value = systemUserId;

            connectionManager();
            return command.ExecuteReader();
        }

        public SqlDataReader getRecordById(Guid systemUserId, Guid Id)
        {
            command = new SqlCommand("getRecordByIdCommunication", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add("@systemUserId", System.Data.SqlDbType.UniqueIdentifier).Value = systemUserId;
            command.Parameters.Add("@Id", System.Data.SqlDbType.UniqueIdentifier).Value = Id;

            connectionManager();
            return command.ExecuteReader();
        }
    }
}
