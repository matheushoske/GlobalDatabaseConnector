
using MySql.Data.MySqlClient;

namespace GlobalDatabaseConnector.Database
{
    // Concrete Creator
    public class MySQLFactory : DbFactory
    {
        // Factory Method
        public override DbConnector CreateConnector(string dataSource, string user, string password, string DBName = "", long port = 3306)
        {
            string connectionString = new MySqlConnectionStringBuilder() 
            {
                Server = dataSource,
                Database = DBName,
                Port = (uint)port,
                UserID = user,
                Password = password
                

            }.ConnectionString;
            return new MySQLDbConnector(connectionString);
        }
    }
}