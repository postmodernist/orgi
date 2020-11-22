using System.Configuration;
using Decadence_DAL.Interfaces;
using System.Data;
using System.Data.SqlClient;



namespace Decadence_DAL.Infrastucture
{
    public class ConnectionFactory : IConnectionFactory
    {
        private static string _connectionString;
        public IDbConnection GetConnection
        {
            get
            {
                SqlConnection connection;
                if (!string.IsNullOrEmpty(_connectionString))
                    connection = new SqlConnection(_connectionString);
                else
                    connection = new SqlConnection("Server=192.168.56.101;Database=Decadence;User ID=sa;Password=bravoSIX_RED");

                connection.Open();

                return connection;
            }
        }

        public void SetConnection(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
