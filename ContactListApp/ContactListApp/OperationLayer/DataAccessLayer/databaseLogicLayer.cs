using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp.OperationLayer.DataAccessLayer
{
    public class databaseLogicLayer : IDisposable
    {
        public SqlConnection connection { get; set; }
        public SqlCommand command { get; set; }
        public SqlDataReader reader { get; set; }

        public databaseLogicLayer()
        {
            //  string connectionString = connectionManager(@"DESKTOP-74LQRA6\SQLEXPRESS", "contactListAppDB", "sa", "1");
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionSetting"].ToString());
        }

        string connectionManager(string datasource, string initialCatalog, string userName, string password)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = datasource;
            builder.InitialCatalog = initialCatalog;
            builder.UserID = userName;
            builder.Password = password;
            return builder.ConnectionString;
        }

        public void connectionManager()
        {
            if (connection.State == System.Data.ConnectionState.Open) connection.Close();
            else connection.Open();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
