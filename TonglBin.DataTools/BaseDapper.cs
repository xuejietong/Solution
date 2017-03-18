using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace TonglBin.DataTools
{
    public class BaseDapper
    {
        //数据库连接字符串
        protected string dbConnString;
        //到数据源的已打开连接
        protected IDbConnection connection;

        /// <summary>
        /// 初始化字段
        /// </summary>
        protected BaseDapper()
        {
            dbConnString = ConfigurationManager.ConnectionStrings["TonglBinConn"].ToString();
            connection = new SqlConnection(dbConnString);
        }
    }
}
