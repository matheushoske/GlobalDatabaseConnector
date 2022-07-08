using System;

using System.Data;
using MySql.Data.MySqlClient;

namespace GlobalDatabaseConnector.Database
{
    // Concrete Product
    public class MySQLDbConnector : DbConnector
    {
        public MySQLDbConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override IDbConnection Connect()
        {
            Console.WriteLine("Conectando ao banco MySQL...");
            var connection = new MySqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }
    }
}