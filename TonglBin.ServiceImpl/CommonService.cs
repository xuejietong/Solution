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
        private CommonBusiness comBusiness = new CommonBusiness();

        public IList<Users> GetUsers()
        {
            return comBusiness.GetUsers();
        }

        public Int32 InserTest(Users user)
        {
            return comBusiness.InsertTest(user);
        }
    }
}
