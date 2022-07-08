using Oracle.ManagedDataAccess.Client;
namespace GlobalDatabaseConnector.Database
{
    // Concrete Creator
    public class OracleFactory : DbFactory
    {
        // Factory Method
        public override DbConnector CreateConnector(string dataSource, string user, string password, string DBName = "", long port = 1521)
        {
            string connectionString = new OracleConnectionStringBuilder()
            {
                Password = password,
                UserID = user,
                DataSource = $"(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={dataSource})(PORT={port}))(CONNECT_DATA=(SERVICE_NAME={DBName})))",
                
            }.ConnectionString;
            return new OracleDbConnector(connectionString);
        }
    }
}