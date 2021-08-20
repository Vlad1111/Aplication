using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Units.Excanges
{
    public class OpenExchangerates : Exchange
    {
        public string disclaimer;
        public string license;
        public int timestamp;
        public string Base;
        public Dictionary<string, double> rates;

        /// <summary>
        /// Returns the exchange rate
        /// </summary>
        /// <returns>
        ///     Returns a double with the value of the echange if the exchange is correc
        ///     If the exchange is not correct, it will throw an Exception
        /// </returns>
        public override double getExchange()
        {
            if (rates != null && rates.ContainsKey("EUR"))
                return rates["EUR"];
            throw new Exception("The rates does not contains the needed value");
        }
    }
}
