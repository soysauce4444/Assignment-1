using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// This method takes an integer id and adds 10 to it.
        /// </summary>
        /// <example> GET api/AddTen/10 -> 20 </example>
        /// <example> GET api/AddTen/5 -> 25 </example>
        /// <param name="id">Integer id</param>
        /// <returns> id + 10 </returns>
        // GET api/AddTen/id
        public int GetAddTen(int id)
        {
            return id + 10;
        }
    }
}
