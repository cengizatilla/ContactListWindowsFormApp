using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.ContactList.Entities.contactComm;

namespace Udemy.ContactList.Operation.databaseLogicLayer
{
    public class contactCommDatabaseLogicLayer:databaseLogicLayerBase
    {
        public int addNewComm(contactComms data)
        {
            int resultInt = 0;

            command = new System.Data.SqlClient.SqlCommand("addNewContactComm", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = data.id;
            command.Parameters.Add("@contactId", SqlDbType.UniqueIdentifier).Value = data.contactId;
            command.Parameters.Add("@commType", SqlDbType.Int).Value = data.commType;
            command.Parameters.Add("@commValue", SqlDbType.NVarChar).Value = data.commValue;
            command.Parameters.Add("@createDate", SqlDbType.DateTime).Value = data.createDate;

            connectionWizard();
            resultInt = command.ExecuteNonQuery();
            connectionWizard();
            return resultInt;
        }

        public SqlDataReader getContactAllComm(Guid contactId)
        {
            command = new SqlCommand("getAllRecordsContactComm", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@contactId", SqlDbType.UniqueIdentifier).Value = contactId;

            connectionWizard();
            return command.ExecuteReader();
        }

        public SqlDataReader getContactCommId(Guid contactCommId)
        {
            command = new SqlCommand("getRecordByIdContactComm", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = contactCommId;

            connectionWizard();
            return command.ExecuteReader();
        }

        public int updateContactComm(contactComms data)
        {
            int resultInt = 0;

            command = new SqlCommand("updateContactComms", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = data.id;
            command.Parameters.Add("@commType", SqlDbType.Int).Value = data.commType;
            command.Parameters.Add("@commValue", SqlDbType.NVarChar).Value = data.commValue;

            connectionWizard();
            resultInt = command.ExecuteNonQuery();
            connectionWizard();
            return resultInt;
        }

        public int deleteContactComm(Guid commId)
        {
            int resultInt = 0;

            command = new SqlCommand("deleteContactComms", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = commId;

            connectionWizard();
            resultInt = command.ExecuteNonQuery();
            connectionWizard();
            return resultInt;
        }
    }
}
