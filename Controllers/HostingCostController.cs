using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// This method takes an integer number of days and returns 3 strings
        /// in an array: the cost of the stay, the cost of the tax, and
        /// the total cost including the tax. These values are calculated based
        /// on a fixed cost of $5.50/fortnight, and a tax rate of 13%.A fortnight
        /// is defined as 13 days, and the value used in the calculation is
        /// the next highest integer.
        /// </summary>
        /// <param name="days">integer number of days</param>
        /// <example> GET api/HostingCost/0 ->
        /// "1 fortnights at $5.50/FN = $5.50",
        /// "HST 13% = $0.72 CAD",
        /// "Total = $6.22 CAD"
        /// </example>
        /// <returns>
        /// [fortnights at $5.50/FN = $Cost,
        /// HST 13% = $HST CAD,
        /// Total = $(Cost + HST)CAD]
        /// </returns>
        [Route("api/HostingCost/{days}")]
        public IEnumerable<string> GETHostingCost(int days)
        {
            int fortNights = (int)Math.Ceiling((double)(days + 1) / 14);
            double Cost = (fortNights * 5.50); 
            double HST = 0.13 * fortNights * 5.50;

            return new string[] { fortNights + " fortnights at $5.50/FN = $" + Cost.ToString("F"),
                                "HST 13% = $" + HST.ToString("F") + " CAD",
                                "Total = $" + (Cost + HST).ToString("F") + " CAD"} ;
        }        
    }
}
