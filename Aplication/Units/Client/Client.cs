using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Aplication.Units.Client
{
    public class Client
    {
        private static readonly System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();

        /// <summary>
        /// preprocess a jsno string for deserilization
        /// </summary>
        /// <param name="json">
        ///     the json nedded to preprocess
        /// </param>
        /// <returns>
        ///     Returns a string with the corect json string
        /// </returns>
        public static string preprocesJson(string json)
        {
            int acol = json.IndexOf('{');
            json = json.Substring(acol);
            return json;
        }

        /// <summary>
        /// Get a GET query respound
        /// </summary>
        /// <param name="query">
        ///     The GET query
        /// </param>
        /// <returns>
        ///     A string with the resounse of the GET
        /// </returns>
        public string getResoult(string query)
        {
            var response = client.GetStringAsync(query);
            var responseString = response.Result;
            //Console.WriteLine("RESPONSE:");
            //Console.WriteLine(responseString);
            //Console.WriteLine();
            return responseString;
        }
    }
}
