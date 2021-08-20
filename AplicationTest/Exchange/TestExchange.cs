using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Aplication.Units.Excanges;

namespace AplicationTest.Exchange
{
    /// <summary>
    /// Summary description for Exchange
    /// </summary>
    [TestClass]
    public class TestExchange
    {
        [TestMethod]
        public void TestParse1()
        {
            string json = "json" +
                "{" +
                "\"success\": true," +
                "\"terms\": \"https://currencylayer.com//terms\"," +
                "\"privacy\": \"https://currencylayer.com//privacy\"," +
                "\"timestamp\": 1507639147," +
                "\"source\": \"USD\"," +
                "\"quotes\":" +
                "   {" +
                "       \"USDETB\": 23.410168," +
                "       \"USDEUR\": 0.847802," +
                "       \"USDFJD\": 2.052013," +
                "       \"USDFKP\": 0.757298" +
                "   }" +
                "}";
            var rez1 = Aplication.Units.Excanges.Exchange.parseJson<CurrencyLayer>(json);

            Assert.AreEqual(rez1.getExchange(), 0.847802);
        }

        [TestMethod]
        public void TestParse2()
        {
            string json = "json" +
                    "{" +
                    "    \"disclaimer\": \"Usage subject to terms: https://openexchangerates.org/terms\"," +
                    "    \"license\": \"https://openexchangerates.org/license\"," +
                    "    \"timestamp\": 1507640400," +
                    "    \"base\": \"USD\"," +
                    "    \"rates\": " +
                    "    {" +
                    "        \"ETB\": 23.66," +
                    "        \"EUR\": 0.848383," +
                    "        \"FJD\": 2.056501," +
                    "        \"FKP\": 0.758728," +
                    "        \"GBP\": 0.758728," +
                    "        \"GEL\": 2.475408," +
                    "        \"GGP\": 0.758728" +
                    "    }" +
                    "}";
            var rez1 = Aplication.Units.Excanges.Exchange.parseJson<OpenExchangerates>(json);

            Assert.AreEqual(rez1.getExchange(), 0.848383);
        }
    }
}
