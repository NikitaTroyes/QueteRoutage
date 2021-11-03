
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueteRoutage.Controllers
{
   
    public class HelloController : Controller
    {
        public String SayHello1()

        {
            return "Hello !";
        }

        public String YellHello1()
        {
            return "HELLO !";
        }

        [Route("/Say")]
        public String SayHello()
        {
            return "Hello !";
        }

        [Route("/Yell")]
        public String YellHello()
        {
            return "HELLO !";
        }
    }
}
