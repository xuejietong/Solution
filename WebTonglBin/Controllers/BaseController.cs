using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebTonglBin.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            string s1 = string.Empty;
            string s2 = string.Empty;
            if (s1.Equals(s2))
            {
                Console.WriteLine("==");
            }
            else
            {
                Console.WriteLine("!=");
            }
        }
    }
}