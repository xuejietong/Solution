using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TonglBin.IService;

namespace TonglBin.ServiceImpl
{
    public class CommonService : ICommonService
    {
        public String GetData(int value)
        {
            return value.ToString() + ".";
        }
    }
}
