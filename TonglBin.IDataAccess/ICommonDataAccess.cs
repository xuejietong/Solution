using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TonglBin.Model;

namespace TonglBin.IDataAccess
{
    public interface ICommonDataAccess
    {
        Int32 InserTest(Users user);

        List<Users> GetUsers();
    }
}
