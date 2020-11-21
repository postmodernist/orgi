using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Decadence_DAL.Interfaces;

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
                    connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

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
