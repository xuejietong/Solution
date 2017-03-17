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
        public Int32 InsertTest(Users user)
        {
            ICommonDataAccess comDataAccess = new CommonDataAccess();
            return comDataAccess.InserTest(user);
        }
    }
}
