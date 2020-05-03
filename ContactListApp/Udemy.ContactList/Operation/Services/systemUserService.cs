using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.ContactList.Entities.systemUser;
using Udemy.ContactList.Operation.databaseLogicLayer;

namespace Udemy.ContactList.Operation.Services
{
    public class systemUserService
    { 
        public systemUserService()
        {

        }

        public systemUsers checkSystemUser(string userName, string password)
        {
            systemUsers systemUserData = new systemUsers();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password)) return null;

            using (systemUserDatabaseLogicLayer systemUserDatabase = new systemUserDatabaseLogicLayer())
            {
                SqlDataReader reader = systemUserDatabase.checkSystemUser(new systemUsers()
                {
                    userName = userName,
                    password = password
                });

                while (reader.Read())
                {
                    systemUserData.id = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0);
                    systemUserData.userName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    systemUserData.password = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                }
                reader.Close();
                systemUserDatabase.connectionWizard();
            }

            return systemUserData;

        }
    }
}
