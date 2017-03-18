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
    public class DapperDataHelp<T> where T : class, new()
    {
        //数据库连接字符串
        private static string dbConnString;
        //到数据源的已打开连接
        private static IDbConnection connection;
        //初始化实例，静态只读
        private static readonly DapperDataHelp<T> instance = new DapperDataHelp<T>();

        /// <summary>
        /// 初始化静态字段
        /// </summary>
        static DapperDataHelp()
        {
            dbConnString = ConfigurationManager.ConnectionStrings["TonglBinConn"].ToString();
            connection = new SqlConnection(dbConnString);
        }

        /// <summary>
        /// 单例模式，私有构造函数，防止被调用者初始化
        /// </summary>
        private DapperDataHelp() { }

        /// <summary>
        /// 唯一获得实例方法
        /// </summary>
        /// <returns>DapperDataHelp实例</returns>
        public static DapperDataHelp<T> GetDapperInstance()
        {
            return instance;
        }

        //
        // 摘要:
        //     Execute parameterized SQL
        //
        // 返回结果:
        //     Number of rows affected
        public Int32 Execute(string sql, T obj)
        {
            return connection.Execute(sql, obj);
        }

        //
        // 摘要:
        //     Execute parameterized SQL
        //
        // 返回结果:
        //     Number of rows affected
        public Int32 Execute(string sql, List<T> objs)
        {
            return connection.Execute(sql, objs);
        }

        //
        // 摘要:
        //     Executes a query, returning the data typed as per T
        //
        // 返回结果:
        //     A sequence of data of the supplied type; if a basic type (int, string, etc) is
        //     queried then the data from the first column in assumed, otherwise an instance
        //     is created per row, and a direct column-name===member-name mapping is assumed
        //     (case insensitive).
        public List<T> Query(string sql, T obj)
        {
            List<T> t = new List<T>();
            var result = connection.Query<T>(sql, obj);
            if (result.Count() > 0)
            {
                t = result.ToList<T>();
            }
            return t;
        }
    }
}
