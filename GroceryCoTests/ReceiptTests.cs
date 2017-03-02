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
        public void CheckReceiptItemTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void AddOrUpdateItemTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetQuantityOfItemTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetPriceOfItemTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetTotalPriceOfItemTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetReceiptItemNamesTest()
        {
            Assert.Fail();
        }
    }
}