using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp.OperationLayer.DataAccessLayer
{
    public sealed class systemUserDatabaseLogicLayer : databaseLogicLayer
    {
        public Guid checkSystemUser(string username, string password)
        {

            command = new System.Data.SqlClient.SqlCommand("checkSystemUser", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add("@username", System.Data.SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@password", System.Data.SqlDbType.NVarChar).Value = password;

            connectionManager();
            object returnValueObject = command.ExecuteScalar();
            connectionManager();

            return returnValueObject == null ? Guid.Empty :  (Guid)returnValueObject;

        }


        public SqlDataReader getUserInformation(Guid systemUserId)
        {
            command = new SqlCommand("getUserInformation", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add("@userId", System.Data.SqlDbType.UniqueIdentifier).Value = systemUserId;

            connectionManager();
            return command.ExecuteReader();
        }
    }
}
