
using System.Data;
namespace GlobalDatabaseConnector.Database
{
    // Abstract Product
    public abstract class DbConnector
    {
        protected DbConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected string ConnectionString { get; set; }
        public abstract IDbConnection Connect();
    }
}