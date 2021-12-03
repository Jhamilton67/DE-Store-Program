using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper; 

namespace DataClassLibary.DataAccess
{
    public class DE_StoreDA
    {//Get connections connects the database connection string to the program 
        public static string GetConnectionString(string ConnectionName = "DE-StroreDB")
        {
            return ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString;
        }
        //my Method that helps load the data from the database 
        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection db = new SqlConnection(GetConnectionString()))
            {
                return db.Query<T>(sql).ToList();
            }
        }
        //the Method that helps save the data from the database
        public static int SaveData<T>(string sql, T Data)
        {
            using (IDbConnection db = new SqlConnection(GetConnectionString()))
            {
                return db.Execute(sql, Data);
            }
        }
    }
}
