using System.Data.SqlClient;

namespace GlobalDatabaseConnector.Database
{
    // Concrete Creator
    public class SqlFactory : DbFactory
    {
        // Factory Method
        public override DbConnector CreateConnector(string dataSource, string user, string password, string DBName, long port = 1433)
        {
            string connectionString = new SqlConnectionStringBuilder()
            {
                DataSource = dataSource,
                InitialCatalog = DBName,
                UserID = user,
                Password = password,
                
                
            }.ConnectionString;
            return new SqlServerConnector(connectionString);
        }
    }
}