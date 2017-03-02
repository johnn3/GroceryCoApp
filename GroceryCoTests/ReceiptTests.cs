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
            Receipt test = new Receipt();
            Assert.IsNotNull(test);
        }

        [Test()]
        public void CheckReceiptItemTestWithAddOrUpdate()
        {
            Receipt test = new Receipt();
            test.AddOrUpdateItem("APPLE", 0.50m);
            test.AddOrUpdateItem("ORANGE", 0.70m);
            Assert.AreEqual(test.CheckReceiptItem("APPLE"), true);
            Assert.AreEqual(test.CheckReceiptItem("ApPLE"), true);
        }

        [Test()]
        public void GetQuantityOfItemTest()
        {
            Receipt test = new Receipt();
            test.AddOrUpdateItem("APPLE", 0.50m);
            test.AddOrUpdateItem("APPLE", 0.50m);
            test.AddOrUpdateItem("ORANGE", 0.70m);
            Assert.AreEqual(test.GetQuantityOfItem("APPLE"), 2);
            Assert.AreEqual(test.GetQuantityOfItem("ApPLE"), 2);
            Assert.AreEqual(test.GetQuantityOfItem("Orange"), 1);
            Assert.AreEqual(test.GetQuantityOfItem("Orange?"), 0);
        }

        [Test()]
        public void GetPriceOfItemTest()
        {
            Receipt test = new Receipt();
            test.AddOrUpdateItem("APPLE", 0.50m);
            test.AddOrUpdateItem("APPLE", 0.50m);
            test.AddOrUpdateItem("ORANGE", 0.70m);
            Assert.AreEqual(test.GetPriceOfItem("APPLE"), 0.50m);
            Assert.AreEqual(test.GetPriceOfItem("OrangE"), 0.70m);
            Assert.AreEqual(test.GetPriceOfItem("Orange?"), 0.00m);
        }

        [Test()]
        public void GetTotalPriceOfItemTest()
        {
            Receipt test = new Receipt();
            test.AddOrUpdateItem("APPLE", 0.50m);
            test.AddOrUpdateItem("APPLE", 0.50m);
            test.AddOrUpdateItem("ORANGE", 0.70m);
            Assert.AreEqual(test.GetTotalPriceOfItem("APPLE"), 1.00m);
            Assert.AreEqual(test.GetTotalPriceOfItem("ApPLE"), 1.00m);
            Assert.AreEqual(test.GetTotalPriceOfItem("OrangE"), 0.70m);
            Assert.AreEqual(test.GetTotalPriceOfItem("Orange?"), 0.00m);
        }

        [Test()]
        public void GetReceiptItemNamesTest()
        {
            Receipt test = new Receipt();
            test.AddOrUpdateItem("APPLE", 0.50m);
            test.AddOrUpdateItem("ORANGE", 0.70m);
            List<string> testOut = test.GetReceiptItemNames();
            Assert.IsNotNull(testOut);
            Assert.AreEqual(testOut[0], "APPLE");
        }
    }
}