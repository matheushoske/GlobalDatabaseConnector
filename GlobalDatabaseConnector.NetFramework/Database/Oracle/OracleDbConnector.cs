using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace GlobalDatabaseConnector.Database
{
    // Concrete Product
    public class OracleDbConnector : DbConnector
    {
        public OracleDbConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override IDbConnection Connect()
        {
            Console.WriteLine("Conectando ao banco Oracle...");
            var connection = new OracleConnection(ConnectionString);
            connection.Open();
            return connection;
        }
    }
}