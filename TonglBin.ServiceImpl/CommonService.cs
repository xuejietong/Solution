using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TonglBin.IService;
using TonglBin.Business;
using TonglBin.Model;

namespace TonglBin.ServiceImpl
{
    public class CommonService : ICommonService
    {
        public String GetData(int value)
        {
            return value.ToString() + ".";
        }

        public Int32 InserTest(Users user)
        {
            CommonBusiness comBusiness = new CommonBusiness();
            return comBusiness.InsertTest(user);
        }
    }
}
