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
        // GET api/AddTen/id
        public int Get(int id)
        {
            return (id + 10);
        }
    }
}