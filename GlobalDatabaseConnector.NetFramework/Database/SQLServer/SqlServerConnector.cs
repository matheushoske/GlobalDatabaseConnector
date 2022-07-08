using System;
using System.Data;
using System.Data.SqlClient;

namespace GlobalDatabaseConnector.Database
{
    // Concrete Product
    public class SqlServerConnector : DbConnector
    {
        public SqlServerConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override IDbConnection Connect()
        {
            Console.WriteLine("Conectando ao banco SQL Server...");
            var connection = new SqlConnection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}