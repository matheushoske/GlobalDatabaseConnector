using System;
using System.Data;
using GlobalDatabaseConnector.Database;

namespace Example
{
    internal class Example
    {
        public static void Execute()
        {
            IDbConnection cn = DbFactory.Database(DataBase.MySQL)
                                 .CreateConnector("localhost","user","password","database")
                                 .Connect();


            using (var cmd = cn.CreateCommand()) {
                cmd.CommandText = "select * from table";
                using (var reader = cmd.ExecuteReader()) { 
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write(reader[i]);
                            Console.Write(" | ");
                        }
                        Console.Write("\n");
                    }
                }
            }
        }
    }
}