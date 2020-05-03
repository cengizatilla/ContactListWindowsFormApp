using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.ContactList.Operation.databaseLogicLayer
{
    public class databaseLogicLayerBase: IDisposable
    {
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataReader reader;

        public databaseLogicLayerBase()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionSQLDB"].ConnectionString);
        }

        public void connectionWizard()
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
