using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using TonglBin.Web.CommonServiceReference;

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
    }
}