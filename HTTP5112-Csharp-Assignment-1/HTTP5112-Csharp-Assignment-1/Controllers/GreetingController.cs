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
        /// <summary>
        /// API will return string as Greetings to any numeric value which is passed in parameter id in route "api/Greeting/id".
        /// GET api/Greeting/id
        /// </summary>
        /// <param name="id">any numeric value</param>
        /// <returns>returns string as greetings to number of people.</returns>
        public string Get(int id)
        {
            return "Greetings to {id} people!".Replace("{id}", id.ToString());
        }

        /// <summary>
        /// API will return string as hello world.
        /// POST api/Greeting
        /// </summary>
        /// <param name="id">no parameter required</param>
        /// <returns>returns string as hello world.</returns>
        public string Post()
        {
            return "Hello World!";
        }
    }
}