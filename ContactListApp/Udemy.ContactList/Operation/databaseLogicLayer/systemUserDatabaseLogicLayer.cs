using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.ContactList.Entities.systemUser;

namespace Udemy.ContactList.Operation.databaseLogicLayer
{
    public class systemUserDatabaseLogicLayer:databaseLogicLayerBase
    {
        public SqlDataReader checkSystemUser(systemUsers data)
        {

            command = new System.Data.SqlClient.SqlCommand("checkSystemUser", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add("@userName", SqlDbType.NVarChar).Value = data.userName;
            command.Parameters.Add("@passwords", SqlDbType.NVarChar).Value = data.password;

            connectionWizard();

            return command.ExecuteReader();


        }
    }
}
