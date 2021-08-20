using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Units.Excanges
{
    public abstract class Exchange
    {
        /// <summary>
        /// parse a json for a given Exchange
        /// </summary>
        /// <typeparam name="T">
        ///     the Exchange type
        /// </typeparam>
        /// <param name="json">
        ///     the json nedded to be parse
        /// </param>
        /// <returns>
        ///     Returns the Exchange from the json given
        /// </returns>
        public static T parseJson<T>(string json) where T: Exchange
        {
            json = Client.Client.preprocesJson(json);
            T deserializedProduct = JsonConvert.DeserializeObject<T>(json);
            return deserializedProduct;
        }

        /// <summary>
        /// Returns the exchange rate
        /// </summary>
        /// <returns>
        ///     Returns a double with the value of the echange
        /// </returns>
        public abstract double getExchange();
    }
}
