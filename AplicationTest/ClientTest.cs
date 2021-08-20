using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Aplication.Units.Client;

namespace AplicationTest
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void TestPreprocess()
        {
            string json = "json" +
                "{" +
                "\"data\":10" +
                "}";

            string retJson = Client.preprocesJson(json);
            Assert.AreEqual(retJson, "{\"data\":10}");
        }
    }
}
