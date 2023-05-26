using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MiloserdovExam
{
    public class DataBase
    {
        const string ConnectionString = @"Server = DESKTOP-390KCDU\SQLEXPRESS;Initial Catalog=CarDealership;Integrated Security = true";

        SqlConnection sqlConnection = new SqlConnection(ConnectionString);

        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
