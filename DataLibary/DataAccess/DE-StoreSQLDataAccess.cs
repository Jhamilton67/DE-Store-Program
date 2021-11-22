using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DataLibary.DataAccess
{
    public static class DE_StoreSQLDataAccess
    {
        public static string GetConnectionString(string ConnectionName = "DE-StoreData")
        {
            return ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString;
        }

        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection db = new SqlConnection(GetConnectionString()))
            {
                return db.Query<T>(sql).ToList();
            }
        }

        public static int SaveData<T>(string sql, T Data)
        {
            using (IDbConnection db = new SqlConnection(GetConnectionString()))
            {
                return db.Execute(sql, Data);
            }
        }
    }
}
