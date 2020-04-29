using ContactListApp.OperationLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp.OperationLayer.Services
{
    public class systemUserService
    {
        SqlDataReader reader;

        public Guid checkSystemUser(string username, string password)
        {
            Guid systemUserId = Guid.Empty;
            using (DataAccessLayer.systemUserDatabaseLogicLayer systemUserDatabaseLogicLayer = new DataAccessLayer.systemUserDatabaseLogicLayer())
            {
                systemUserId = systemUserDatabaseLogicLayer.checkSystemUser(username, password);
            }

            return systemUserId;
        }

        public systemUser getUserInformation(Guid systemUserId)
        {
            systemUser systemUserType = null;
            using (DataAccessLayer.systemUserDatabaseLogicLayer systemUserDatabaseLogicLayer = new DataAccessLayer.systemUserDatabaseLogicLayer())
            {
                reader = systemUserDatabaseLogicLayer.getUserInformation(systemUserId);
                while (reader.Read())
                {
                    systemUserType = new systemUser();
                    systemUserType.Id = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0);
                    systemUserType.userName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    systemUserType.creationDate = reader.IsDBNull(2) ? DateTime.MinValue : reader.GetDateTime(2);
                }
                reader.Close();
                systemUserDatabaseLogicLayer.connectionManager();
            }
            return systemUserType;
        }
    }
}
