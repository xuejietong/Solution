using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TonglBin.ServiceImpl;

namespace TonglBin.ServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (System.ServiceModel.ServiceHost host = new System.ServiceModel.ServiceHost(typeof(CommonService)))
            {
                host.Opened += delegate
                {
                    foreach (var endpoint in host.Description.Endpoints)
                    {
                        Console.WriteLine(DateTime.Now.ToString() + " Service is running at " + endpoint.Address);
                    }
                };
                host.Open();
                Console.ReadKey();
            }
        }
    }
}
