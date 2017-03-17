using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TonglBin.DataTools
{
    public class DapperDataHelp<T> where T : class
    {
        private static string dbConnString = string.Empty;

        static DapperDataHelp()
        {
            dbConnString = ConfigurationManager.ConnectionStrings["TonglBinConn"].ToString();
        }

        public static Int32 Execute(string sql, T obj)
        {
            IDbConnection connection = new SqlConnection(dbConnString);
            Int32 result = connection.Execute(sql, obj);
            return result;
        }
    }
}
