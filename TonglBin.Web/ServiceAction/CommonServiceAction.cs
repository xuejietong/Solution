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
        public static String GetData(int value)
        {
            using (CommonServiceClient csc=new CommonServiceClient())
            {
                return csc.GetData(value);
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