using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TonglBin.IDataAccess;
using System.Data;
using System.Data.SqlClient;
using TonglBin.DataTools;
using TonglBin.Model;
using Dapper;

namespace TonglBin.DataAccess
{
    public class CommonDataAccess : BaseDapper, ICommonDataAccess
    {
        public Int32 InserTest(Users user)
        {
            string sql = "Insert into Users values (@UserName, @Email, @Address)";
            return connection.Execute(sql, user);
        }

        public IList<Users> GetUsers()
        {
            IList<Users> t = new List<Users>();
            if (redisClient.ContainsKey("AllUsers"))
            {
                t = redisClient.Get<List<Users>>("AllUsers");
            }
            else
            {
                string sql = "select * from Users";
                var result = connection.Query<Users>(sql);
                if (result.Count() > 0)
                {
                    t = result.ToList<Users>();
                    var timeOut = new TimeSpan(0, 0, 20, 0);
                    redisClient.Add("AllUsers", t, timeOut);
                }
            }
            return t;
        }
    }
}
