using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Csharp_Assignment_1.Controllers
{
    public class GreetingController : ApiController
    {
        // GET api/Greeting/id
        public string Get(int id)
        {
            return "Greetings to {id} people!".Replace("{id}", id.ToString());
        }

        // POST api/Greeting
        public string Post()
        {
            return "Hello World!";
        }
    }
}