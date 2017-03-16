using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TonglBin.DataAccess;
using TonglBin.IDataAccess;

namespace TonglBin.Business
{
    public class CommonBusiness
    {
        public Int32 InsertTest()
        {
            ICommonDataAccess comDataAccess = new CommonDataAccess();
            return comDataAccess.InserTest();
        }
    }
}
