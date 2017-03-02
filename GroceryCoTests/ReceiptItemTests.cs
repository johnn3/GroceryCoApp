using NUnit.Framework;

namespace ConsoleApplication1.Tests
{
    [TestFixture()]
    public class ReceiptItemTests
    {
        [Test()]
        public void ReceiptItemTest()
        {
            ReceiptItem testItem = new ReceiptItem("Orange", 0.70m);
            Assert.IsNotNull(testItem);
        }

        [Test()]
        public void GetNameTest()
        {
            ReceiptItem testItem = new ReceiptItem("Orange", 0.70m);
            Assert.AreEqual(testItem.GetName(), "ORANGE");
            Assert.AreEqual("ORANGE", testItem.GetName());
        }

        [Test()]
        public void GetPriceTest()
        {
            ReceiptItem testItem = new ReceiptItem("Orange", 0.70m);
            Assert.AreEqual(testItem.GetPrice(), 0.70m);
            Assert.AreEqual(0.70m, testItem.GetPrice());
        }

        [Test()]
        public void GetQuantityTest()
        {
            ReceiptItem testItem = new ReceiptItem("Orange", 0.70m);
            Assert.AreEqual(testItem.GetQuantity(), 1);
            Assert.AreEqual(1,testItem.GetQuantity());
        }

        [Test()]
        public void AddOneToQuantityAndCostTest()
        {
            ReceiptItem testItem = new ReceiptItem("Orange", 0.70m);
            testItem.AddOneToQuantityAndCost();
            Assert.AreEqual(testItem.GetQuantity(), 2);
            Assert.AreEqual(2, testItem.GetQuantity());
        }
    }
}