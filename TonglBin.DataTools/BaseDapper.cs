using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ServiceStack.Redis;

namespace TonglBin.DataTools
{
    public class BaseDapper
    {
        //数据库连接字符串
        private string dbConnString;
        //到数据源的已打开连接
        protected IDbConnection connection;
        //Redis Host
        private String redisHost;
        //Redis Port
        private Int32 redisPort;
        //Redis Client
        protected RedisClient redisClient;

        /// <summary>
        /// 初始化字段
        /// </summary>
        protected BaseDapper()
        {
            //MSSQL
            dbConnString = ConfigurationManager.ConnectionStrings["TonglBinConn"].ToString();
            connection = new SqlConnection(dbConnString);
            //Redis
            redisHost = ConfigurationManager.AppSettings["TonglBinRedisConn"].ToString();
            redisPort = Int32.Parse(ConfigurationManager.AppSettings["TonglBinRedisPort"]);
            redisClient = new RedisClient(redisHost, redisPort);
        }
    }
}
