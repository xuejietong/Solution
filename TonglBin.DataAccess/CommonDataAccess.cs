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

namespace TonglBin.DataAccess
{
    public class CommonDataAccess : ICommonDataAccess
    {
        public Int32 InserTest(Users user)
        {
            string sql = "Insert into Users values (@UserName, @Email, @Address)";
            return DapperDataHelp<Users>.Execute(sql, user);
        }
    }
}
