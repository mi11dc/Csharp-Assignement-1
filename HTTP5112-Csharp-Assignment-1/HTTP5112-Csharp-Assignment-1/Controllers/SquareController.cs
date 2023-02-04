using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Csharp_Assignment_1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// API will multiply a value in same value which is passed in parameter id in route "api/Square/id".
        /// GET api/Square/id
        /// </summary>
        /// <param name="id">any numeric value</param>
        /// <returns>numeric value which passed as parameter * numeric value which is passed as parameter</returns>
        public int Get(int id)
        {
            return (id * id);
        }
    }
}