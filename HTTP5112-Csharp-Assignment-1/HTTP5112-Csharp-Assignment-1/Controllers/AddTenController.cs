using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace HTTP5112_Csharp_Assignment_1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// API will add 10 to any value which is passed in parameter id in route "api/AddTen/id".
        /// GET api/AddTen/id
        /// </summary>
        /// <param name="id">any numeric value</param>
        /// <returns>numeric value which passed as parameter + 10</returns>
        public int Get(int id)
        {
            return (id + 10);
        }
    }
}