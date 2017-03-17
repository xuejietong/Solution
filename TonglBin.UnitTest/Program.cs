using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TonglBin.DataTools;
using TonglBin.Model;

namespace TonglBin.UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Users user = new Users();
            user.UserName = "ZZB";
            user.Email = "abcde@qq.com";
            user.Address = "北京";
            string sql = "Insert into Users values (@UserName, @Email, @Address)";
            DapperDataHelp<Users>.Execute(sql, user);
        }
    }
}
