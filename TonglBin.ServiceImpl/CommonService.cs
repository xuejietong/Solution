using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TonglBin.IService;
using TonglBin.Business;

namespace TonglBin.ServiceImpl
{
    public class CommonService : ICommonService
    {
        public String GetData(int value)
        {
            return value.ToString() + ".";
        }

        public Int32 InserTest()
        {
            CommonBusiness cb = new CommonBusiness();
            return cb.InsertTest();
        }
    }
}
