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
    public class ReceiptControllerTests
    {
        [Test()]
        public void ReceiptControllerTest()
        {
            ReceiptView view = new ReceiptView();
            Receipt model = new Receipt();
            ReceiptController controller = new ReceiptController(view, model);
            Assert.IsNotNull(controller);
        }

        [Test()]
        public void CheckReceiptForItemTest()
        {
            ReceiptView view = new ReceiptView();
            Receipt model = new Receipt();
            model.AddOrUpdateItem("APPLE", 0.01m);
            ReceiptController controller = new ReceiptController(view, model);
            Assert.AreEqual(controller.CheckReceiptForItem("APPLE"), true);
            Assert.AreEqual(controller.CheckReceiptForItem("APasd"), false);
        }

        [Test()]
        public void AddOrUpdateReceiptTest()
        {
            ReceiptView view = new ReceiptView();
            Receipt model = new Receipt();
            model.AddOrUpdateItem("APPLE", 0.01m);
            ReceiptController controller = new ReceiptController(view, model);
            Assert.AreEqual(controller.GetPriceOfReceiptItem("APPLE"), 0.01m);
        }

        [Test()]
        public void GetQuantityOfReceiptItemTest()
        {
            ReceiptView view = new ReceiptView();
            Receipt model = new Receipt();
            model.AddOrUpdateItem("APPLE", 0.01m);
            model.AddOrUpdateItem("APPLE", 0.01m);
            ReceiptController controller = new ReceiptController(view, model);
            Assert.AreEqual(controller.GetQuantityOfReceiptItem("APPLE"), 2);
        }

        [Test()]
        public void GetPriceOfReceiptItemTest()
        {
            ReceiptView view = new ReceiptView();
            Receipt model = new Receipt();
            model.AddOrUpdateItem("APPLE", 0.01m);
            ReceiptController controller = new ReceiptController(view, model);
            Assert.AreEqual(controller.GetPriceOfReceiptItem("APPLE"), 0.01m);
        }

        [Test()]
        public void GetReceiptTotalPriceOfItemTest()
        {
            ReceiptView view = new ReceiptView();
            Receipt model = new Receipt();
            model.AddOrUpdateItem("APPLE", 0.01m);
            model.AddOrUpdateItem("APPLE", 0.01m);
            ReceiptController controller = new ReceiptController(view, model);
            Assert.AreEqual(controller.GetReceiptTotalPriceOfItem("APPLE"), 0.02m);
        }

        [Test()]
        public void GetReceiptItemNamesTest()
        {
            ReceiptView view = new ReceiptView();
            Receipt model = new Receipt();
            model.AddOrUpdateItem("APPLE", 0.01m);
            ReceiptController controller = new ReceiptController(view, model);
            Assert.AreEqual(controller.GetReceiptItemNames()[0], "APPLE");
        }
    }
}