using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// This method takes an integer id and returns its square.
        /// </summary>
        /// <param name="id">integer id</param>
        /// <example> GET api/Square/5 -> 25 </example>
        /// <returns> id * id </returns>
        // GET api/square/id
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id * id };
        }
    }
}
