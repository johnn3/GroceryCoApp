using ConsoleApplication1;
using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace ConsoleApplication1.Tests
{
    [TestFixture()]
    public class PriceCatalogTests
    {
        [Test()]
        public void PriceCatalogTest()
        {
            Dictionary<string, decimal> sample =
    new Dictionary<string, decimal>(){
                    { "APPLE", 0.50m },
                    { "ORANGE", 0.70m },
                    { "BANANA", 0.82m } };
            PriceCatalog test = new PriceCatalog(sample);
            Assert.IsNotNull(test);
        }

        [Test()]
        public void CheckStockTest()
        {
            Dictionary<string, decimal> sample =
new Dictionary<string, decimal>(){
                    { "APPLE", 0.50m },
                    { "ORANGE", 0.70m },
                    { "BANANA", 0.82m } };
            PriceCatalog test = new PriceCatalog(sample);
            Assert.AreEqual(test.CheckStock("APPLE"), true);
            Assert.AreEqual(true, test.CheckStock("APPLE"));
            Assert.AreEqual(false, test.CheckStock("PINEAPPLE"));
            Assert.AreEqual(test.CheckStock("PINEAPPLE"), false);
        }

        [Test()]
        public void GetItemPriceTest()
        {
            Dictionary<string, decimal> sample =
new Dictionary<string, decimal>(){
                    { "APPLE", 0.50m },
                    { "ORANGE", 0.70m },
                    { "BANANA", 0.82m } };
            PriceCatalog test = new PriceCatalog(sample);
            Assert.AreEqual(test.GetItemPrice("APPLE"), 0.50m);
            Assert.AreEqual(0.50m, test.GetItemPrice("APPLE"));
            Assert.AreEqual(0.00m, test.GetItemPrice("PINEAPPLE"));
            Assert.AreEqual(test.GetItemPrice("PINEAPPLE"), 0.00m);
        }

        public void SetItemPriceTest()
        {
            Dictionary<string, decimal> sample =
    new Dictionary<string, decimal>(){
                    { "APPLE", 0.50m },
                    { "ORANGE", 0.70m },
                    { "BANANA", 0.82m } };
            PriceCatalog test = new PriceCatalog(sample);
            test.SetItemPrice("APPLE", 0.60m);
            Assert.AreEqual(test.GetItemPrice("APPLE"), 0.60m);
        }
    }
}
