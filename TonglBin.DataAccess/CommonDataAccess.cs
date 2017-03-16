using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TonglBin.IDataAccess;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace TonglBin.DataAccess
{
    public class CommonDataAccess : ICommonDataAccess
    {
        public Int32 InserTest()
        {
            IDbConnection connection = new SqlConnection("Data Source=.;Initial Catalog=DbTonglBin;Integrated Security=True;MultipleActiveResultSets=True");
            string sql = "Insert into Users values (@UserName, @Email, @Address)";
            var user = new { UserName = "Xuejie,Tong", Email = "xuejietong@gmail.com", Address = "北京" };
            Int32 result = connection.Execute(sql, user);
            return result;
        }
    }
}
