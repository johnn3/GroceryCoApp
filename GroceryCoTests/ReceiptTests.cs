using NUnit.Framework;
using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Tests
{
    [TestFixture()]
    public class ReceiptTests
    {
        [Test()]
        public void ReceiptTest()
        {
            Dictionary<string, decimal> sample =
    new Dictionary<string, decimal>(){
                    { "APPLE", 0.50m },
                    { "ORANGE", 0.70m },
                    { "BANANA", 0.82m } };
            PriceCatalog catalog = new PriceCatalog(sample);
            Receipt model = new Receipt(catalog);
            Assert.IsNotNull(model);
        }

        [Test()]
        public void CheckReceiptItemTestWithAddOrUpdate()
        {
            Dictionary<string, decimal> sample =
                new Dictionary<string, decimal>(){
                    { "APPLE", 0.50m },
                    { "ORANGE", 0.70m },
                    { "BANANA", 0.82m } };
            PriceCatalog catalog = new PriceCatalog(sample);
            Receipt model = new Receipt(catalog);
            model.AddOrUpdateItem("APPLE");
            model.AddOrUpdateItem("ORANGE");
            Assert.AreEqual(model.CheckReceiptItem("APPLE"), true);
            Assert.AreEqual(model.CheckReceiptItem("ApPLE"), true);
        }

        [Test()]
        public void GetQuantityOfItemTest()
        {
            Dictionary<string, decimal> sample =
                new Dictionary<string, decimal>(){
                    { "APPLE", 0.50m },
                    { "ORANGE", 0.70m },
                    { "BANANA", 0.82m } };
            PriceCatalog catalog = new PriceCatalog(sample);
            Receipt model = new Receipt(catalog);
            model.AddOrUpdateItem("APPLE");
            model.AddOrUpdateItem("APPLE");
            model.AddOrUpdateItem("ORANGE");
            Assert.AreEqual(model.GetQuantityOfItem("APPLE"), 2);
            Assert.AreEqual(model.GetQuantityOfItem("ApPLE"), 2);
            Assert.AreEqual(model.GetQuantityOfItem("Orange"), 1);
            Assert.AreEqual(model.GetQuantityOfItem("Orange?"), 0);
        }

        [Test()]
        public void GetPriceOfItemTest()
        {
            Dictionary<string, decimal> sample =
                new Dictionary<string, decimal>(){
                    { "APPLE", 0.50m },
                    { "ORANGE", 0.70m },
                    { "BANANA", 0.82m } };
            PriceCatalog catalog = new PriceCatalog(sample);
            Receipt model = new Receipt(catalog);
            model.AddOrUpdateItem("APPLE");
            model.AddOrUpdateItem("APPLE");
            model.AddOrUpdateItem("ORANGE");
            Assert.AreEqual(model.GetPriceOfItem("APPLE"), 0.50m);
            Assert.AreEqual(model.GetPriceOfItem("OrangE"), 0.70m);
            Assert.AreEqual(model.GetPriceOfItem("Orange?"), 0.00m);
        }

        [Test]
        public void GetTotalTest()
        {
            Dictionary<string, decimal> sample =
                new Dictionary<string, decimal>(){
                    { "APPLE", 0.50m },
                    { "ORANGE", 0.70m },
                    { "BANANA", 0.82m } };
            PriceCatalog catalog = new PriceCatalog(sample);
            Receipt model = new Receipt(catalog);
            model.AddOrUpdateItem("APPLE");
            model.AddOrUpdateItem("APPLE");
            Assert.AreEqual(model.GetTotal(), 1.00m);
            model.AddOrUpdateItem("ORANGE");
            Assert.AreEqual(model.GetTotal(), 1.70m);
        }

        [Test()]
        public void GetTotalPriceOfItemTest()
        {
            Dictionary<string, decimal> sample =
                new Dictionary<string, decimal>(){
                    { "APPLE", 0.50m },
                    { "ORANGE", 0.70m },
                    { "BANANA", 0.82m } };
            PriceCatalog catalog = new PriceCatalog(sample);
            Receipt model = new Receipt(catalog);
            model.AddOrUpdateItem("APPLE");
            model.AddOrUpdateItem("APPLE");
            model.AddOrUpdateItem("ORANGE");
            Assert.AreEqual(model.GetTotalPriceOfItem("APPLE"), 1.00m);
            Assert.AreEqual(model.GetTotalPriceOfItem("ApPLE"), 1.00m);
            Assert.AreEqual(model.GetTotalPriceOfItem("OrangE"), 0.70m);
            Assert.AreEqual(model.GetTotalPriceOfItem("Orange?"), 0.00m);
        }

        [Test()]
        public void GetReceiptItemNamesTest()
        {
            Dictionary<string, decimal> sample =
                new Dictionary<string, decimal>(){
                    { "APPLE", 0.50m },
                    { "ORANGE", 0.70m },
                    { "BANANA", 0.82m } };
            PriceCatalog catalog = new PriceCatalog(sample);
            Receipt model = new Receipt(catalog);
            model.AddOrUpdateItem("APPLE");
            model.AddOrUpdateItem("APPLE");
            model.AddOrUpdateItem("ORANGE");
            List<string> testOut = model.GetReceiptItemNames();
            Assert.IsNotNull(testOut);
            Assert.AreEqual(testOut[0], "APPLE");
        }
    }
}