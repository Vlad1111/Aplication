using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Units.Excanges
{
    public class CurrencyLayer : Exchange
    {
        public bool success;
        public string terms;
        public string privacy;
        public int timestamp;
        public string source;
        public Dictionary<string, double> quotes;

        /// <summary>
        /// Returns the exchange rate
        /// </summary>
        /// <returns>
        ///     Returns a double with the value of the echange if the exchange is correc
        ///     If the exchange is not correct, it will throw an Exception
        /// </returns>
        public override double getExchange()
        {
            if (quotes != null && quotes.ContainsKey("USDEUR"))
                return quotes["USDEUR"];
            throw new Exception("The quotes does not contains the needed value");
        }
    }
}
