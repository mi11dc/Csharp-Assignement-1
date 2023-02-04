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
        /// <summary>
        /// API contains 4 operations as add, subtract, multiply and divide a value which is passed in parameter id in route "api/NumberMachine/id".
        /// GET api/NumberMachine/id
        /// </summary>
        /// <param name="id">any numeric value</param>
        /// <returns>numeric value after processing 4 operations, which are addition with 5, subtraction with 10, multiplication with 20, and division with 2.</returns>
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