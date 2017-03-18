using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using TonglBin.Web.CommonServiceReference;
using TonglBin.Model;

namespace TonglBin.Web.ServiceAction
{
    public abstract class CommonServiceAction
    {
        public static IList<Users> GetUsers()
        {
            using (CommonServiceClient comServiceClient = new CommonServiceClient())
            {
                return comServiceClient.GetUsers();
            }
        }

        public static IList<Users> GetUsersRemote()
        {
            using (RemoteCommonServiceReference.CommonServiceClient comRemoteServiceClient = new RemoteCommonServiceReference.CommonServiceClient())
            {
                return comRemoteServiceClient.GetUsers();
            }
        }

        public static Int32 InserTest(Users user)
        {
            using (CommonServiceClient comServiceClient = new CommonServiceClient())
            {
                return comServiceClient.InserTest(user);
            }
        }
    }
}