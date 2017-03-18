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
            ////Insert
            //List<Users> users = new List<Users>();
            //Users user1 = new Users();
            //user1.UserName = "ZZB1";
            //user1.Email = "abcde@qq.com";
            //user1.Address = "北京";
            //Users user2 = new Users();
            //user2.UserName = "ZZB2";
            //user2.Email = "abcde@qq.com";
            //user2.Address = "北京";
            //users.Add(user1);users.Add(user2);
            //string sql = "Insert into Users values (@UserName, @Email, @Address)";
            //DapperDataHelp<Users>.Execute(sql, user);

            ////Query
            //Users user = new Users();
            //user.UserName = "ZZB";
            //string sql = "select * from Users where UserName=@UserName";
            //DapperDataHelp<Users> dapperHelp = DapperDataHelp<Users>.GetDapperInstance();
            //List<Users> users = dapperHelp.Query(sql, user);

            ////Update
            //Users user = new Users();
            //user.UserId = 9;
            //user.UserName = "TongXuejie";
            //string sql = "update Users set UserName=@UserName where UserID=@UserID";
            //DapperDataHelp<Users> dapperHelp = DapperDataHelp<Users>.GetDapperInstance();
            //Int32 cnt = dapperHelp.Execute(sql, user);

            ////Delete
            //Users user = new Users();
            //user.UserId = 9;
            //string sql = "delete Users where UserID=@UserID";
            //DapperDataHelp<Users> dapperHelp = DapperDataHelp<Users>.GetDapperInstance();
            //Int32 cnt = dapperHelp.Execute(sql, user);
        }
    }
}
