using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TonglBin.DataAccess;
using TonglBin.IDataAccess;
using TonglBin.Model;

namespace TonglBin.Business
{
    public class CommonBusiness
    {
        private ICommonDataAccess comDataAccess = new CommonDataAccess();

        public Int32 InsertTest(Users user)
        {
            return comDataAccess.InserTest(user);
        }

        public IList<Users> GetUsers()
        {
            return comDataAccess.GetUsers();
        }
    }
}
