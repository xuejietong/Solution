using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TonglBin.Model;

namespace TonglBin.IService
{
    [ServiceContract(Namespace = "http://192.168.1.109:8000/")]
    public interface ICommonService
    {
        [OperationContract]
        IList<Users> GetUsers();

        [OperationContract]
        Int32 InserTest(Users user);
    }
}
