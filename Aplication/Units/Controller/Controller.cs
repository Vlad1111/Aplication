using Aplication.Units.Client;
using Aplication.Units.Excanges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Units.Controller
{
    public class Controller
    {
        private Client.Client client;
        public Controller(Client.Client client) => this.client = client;

        /// <summary>
        /// Get the exchange for the variant 1
        /// </summary>
        /// <returns></returns>
        public Exchange getVlaue1()
        {
            string rez = client.getResoult(Providers.p1);
            return Exchange.parseJson<CurrencyLayer>(rez);
        }

        /// <summary>
        /// Get the exchange for the variant 2
        /// </summary>
        /// <returns></returns>
        public Exchange getVlaue2()
        {
            string rez = client.getResoult(Providers.p2);
            return Exchange.parseJson<CurrencyLayer>(rez);
        }
    }
}
