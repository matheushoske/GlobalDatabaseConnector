using System;

namespace GlobalDatabaseConnector.Database
{
    // Abstract Creator
    public abstract class DbFactory
    {
        // Factory Method
        public abstract DbConnector CreateConnector(string dataSource, string user, string password, string DBName = "", long port = 0);

        public static DbFactory Database(DataBase dataBase)
        {
            if(dataBase == DataBase.SqlServer)
                return new SqlFactory();
            if(dataBase == DataBase.Oracle)
                return new OracleFactory();
            if(dataBase == DataBase.MySQL)
                return new MySQLFactory();

            throw new ApplicationException("Unrecognized Database.");
        }
    }
}