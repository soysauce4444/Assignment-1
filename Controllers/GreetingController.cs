using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// This method returns the string "Hello World!"
        /// </summary>
        /// <example> POST api/Greeting -> "Hello World!" </example>
        /// <returns>"Hello World!</returns>
        public IEnumerable<string> Post()
        {
            return new string[] { "Hello World!" };
        }
    }
}
