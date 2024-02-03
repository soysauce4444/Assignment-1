using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// This method takes an integer id and returns 4 operations done on it:
        /// add one, subtract one, id squared, and the modulus of 2
        /// (remainder when id is divided by 2).
        /// </summary>
        /// <example> GET api/NumberMachine/3 -> 4, 2, 9, 1 </example>
        /// <example> GET api/NumberMachine/10 -> 11, 9, 100, 0 </example>
        /// <param name="id">Integer id</param>
        /// <returns> [id + 1, id - 1, id * id, id % 2] </returns>
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id + 1, id - 1, id * id, id % 2 };
        }
    }
}
