using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.ContactList.Entities.contact;

namespace Udemy.ContactList.Operation.databaseLogicLayer
{
    public class contactDatabaseLogicLayer : databaseLogicLayerBase
    {
        public int addNewContact(contacts data)
        {
            command = new System.Data.SqlClient.SqlCommand("addNewContact", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = data.id;
            command.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = data.firstName;
            command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = data.lastName;
            command.Parameters.Add("@company", SqlDbType.NVarChar).Value = data.company;
            command.Parameters.Add("@title", SqlDbType.NVarChar).Value = data.title;
            command.Parameters.Add("@systemUserId", SqlDbType.UniqueIdentifier).Value = data.systemUserId;
            command.Parameters.Add("@createDate", SqlDbType.DateTime).Value = data.createDate;
            command.Parameters.Add("@personelNote", SqlDbType.NVarChar).Value = data.personelNote;

            connectionWizard();
            int resultInt = command.ExecuteNonQuery();
            connectionWizard();

            return resultInt;

        }

        public SqlDataReader getAllRecordsBySystemUserId(Guid systemUserId)
        {
            command = new SqlCommand("getAllRecordsContact", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@systemUserId", SqlDbType.UniqueIdentifier).Value = systemUserId;

            connectionWizard();
            return command.ExecuteReader();
        }

        public SqlDataReader getRecordByContactId(Guid systemUserId, Guid contactId)
        {
            command = new SqlCommand("getRecordByIdContact", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@systemUserId", SqlDbType.UniqueIdentifier).Value = systemUserId;
            command.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = contactId;

            connectionWizard();
            return command.ExecuteReader();
        }

        public int deleteRecordByID(Guid contactId)
        {
            int resultInt = 0;

            command = new SqlCommand("deleteContact", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = contactId;

            connectionWizard();
            resultInt = command.ExecuteNonQuery();
            connectionWizard();
            return resultInt;
        }

        public int updateContact(contacts data)
        {
            int resultInt = 0;

            command = new SqlCommand("updateContact", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = data.id;
            command.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = data.firstName;
            command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = data.lastName;
            command.Parameters.Add("@company", SqlDbType.NVarChar).Value = data.company;
            command.Parameters.Add("@title", SqlDbType.NVarChar).Value = data.title;
            command.Parameters.Add("@personelNote", SqlDbType.NVarChar).Value = data.personelNote;

            connectionWizard();
            resultInt = command.ExecuteNonQuery();
            connectionWizard();
            return resultInt;
        }
    }
}
