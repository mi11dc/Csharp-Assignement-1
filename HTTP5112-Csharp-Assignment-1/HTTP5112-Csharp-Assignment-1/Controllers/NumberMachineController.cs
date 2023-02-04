using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Csharp_Assignment_1.Controllers
{
    public class NumberMachineController : ApiController
    {
        // GET api/NumberMachine/id
        public int Get(int id)
        {
            id += 5;
            id -= 10;
            id *= 20;
            id /= 2;
            return id;
        }
    }
}