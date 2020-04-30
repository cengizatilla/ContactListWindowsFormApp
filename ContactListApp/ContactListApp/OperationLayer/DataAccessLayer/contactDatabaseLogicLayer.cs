using ContactListApp.OperationLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp.OperationLayer.DataAccessLayer
{
    public class contactDatabaseLogicLayer: databaseLogicLayer
    {
        public int addNewRecord(contact contactData)
        {
            command = new System.Data.SqlClient.SqlCommand("addNewContact", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add("@Id", System.Data.SqlDbType.UniqueIdentifier).Value = contactData.Id;
            command.Parameters.Add("@company", System.Data.SqlDbType.NVarChar).Value = contactData.company;
            command.Parameters.Add("@title", System.Data.SqlDbType.NVarChar).Value = contactData.title;
            command.Parameters.Add("@firstname", System.Data.SqlDbType.NVarChar).Value = contactData.firstname;
            command.Parameters.Add("@lastname", System.Data.SqlDbType.NVarChar).Value = contactData.lastname;
            command.Parameters.Add("@personelNote", System.Data.SqlDbType.NVarChar).Value = contactData.personelNote;
            command.Parameters.Add("@systemUserId", System.Data.SqlDbType.UniqueIdentifier).Value = contactData.systemUserId;
            command.Parameters.Add("@creationDate", System.Data.SqlDbType.DateTime).Value = contactData.creationDate;

            connectionManager();
            int returnValueInt = command.ExecuteNonQuery();
            connectionManager();

            return returnValueInt;
        }

        public int updateRecord(contact contactData)
        {
            command = new System.Data.SqlClient.SqlCommand("updateContact", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add("@Id", System.Data.SqlDbType.UniqueIdentifier).Value = contactData.Id;
            command.Parameters.Add("@company", System.Data.SqlDbType.NVarChar).Value = contactData.company;
            command.Parameters.Add("@title", System.Data.SqlDbType.NVarChar).Value = contactData.title;
            command.Parameters.Add("@firstname", System.Data.SqlDbType.NVarChar).Value = contactData.firstname;
            command.Parameters.Add("@lastname", System.Data.SqlDbType.NVarChar).Value = contactData.lastname;
            command.Parameters.Add("@personelNote", System.Data.SqlDbType.NVarChar).Value = contactData.personelNote;

            connectionManager();
            int returnValueInt = command.ExecuteNonQuery();
            connectionManager();
            return returnValueInt;
        }

        public SqlDataReader getContactListBySystemUserId(Guid systemUserId)
        {
            command = new SqlCommand("getContactListBySystemUserId", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add("@systemUserId", System.Data.SqlDbType.UniqueIdentifier).Value = systemUserId;

            connectionManager();
            return command.ExecuteReader();
        }

        public SqlDataReader getContactDetails(Guid contactId, Guid currentSystemUser)
        {
            command = new SqlCommand("getContactDetails", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add("@systemUserId", System.Data.SqlDbType.UniqueIdentifier).Value = currentSystemUser;
            command.Parameters.Add("@Id", System.Data.SqlDbType.UniqueIdentifier).Value = contactId;

            connectionManager();
            return command.ExecuteReader();
        }

        public int deleteRecordByContactId(Guid contactId, Guid currentSystemUser)
        {
            command = new SqlCommand("deleteContactByPersonelID", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add("@systemUserId", System.Data.SqlDbType.UniqueIdentifier).Value = currentSystemUser;
            command.Parameters.Add("@personelID", System.Data.SqlDbType.UniqueIdentifier).Value = contactId;

            connectionManager();
            int returnIntValue = command.ExecuteNonQuery();
            connectionManager();
            return returnIntValue;
        }
    }
}
