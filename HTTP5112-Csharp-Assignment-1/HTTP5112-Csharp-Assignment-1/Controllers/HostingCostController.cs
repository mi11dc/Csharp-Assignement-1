using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Csharp_Assignment_1.Controllers
{
    public class HostingCostController : ApiController
    {
        // GET api/HostingCost/id
        public IEnumerable<string> Get(double id)
        {
            // Convert no of days into fortnights where 1 fortnight = 14 days
            double DaystoFN = Math.Floor(id / 14) + 1;

            // price for all fortnights
            double PriceforFN = Math.Round(DaystoFN * 5.50, 2);

            // HST on price for all fortnights
            double HSTonPrice = Math.Round(PriceforFN * 13 / 100, 2);

            // Total price with HST
            double TotalPrice = Math.Round(PriceforFN + HSTonPrice, 2);

            // Return 3 strings as array
            string[] ArrayOfString = new string[]
            {
                String.Concat(DaystoFN, " fortnights at $", PriceforFN, "/FN"),
                String.Concat("HST 13% = $", HSTonPrice, " CAD"),
                String.Concat("Total = $", TotalPrice, " CAD")
            };
            return ArrayOfString;
        }
    }
}