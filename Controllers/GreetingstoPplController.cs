using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    public class GreetingstoPplController : ApiController
    {
        /// <summary>
        /// This method takes an integer id and returns a customized greeting 
        /// to an integer id number of people. 
        /// </summary>
        /// <param name="id">integer id</param>
        /// <example> GET api/GreetingstoPpl/3 -> "Greetings to 3 people!" </example>
        /// <example> GET api/GreetingstoPpl/0 -> "Greetings to 0 people!" </example>
        /// <returns>"[Greetings to " + id + " people!"]</returns>
        public IEnumerable<string> Get(int id)
        {
            return new string[] { "Greetings to " + id + " people!" };
        }
    }
}
