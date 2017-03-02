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
            Dictionary<string, decimal> sample =
                new Dictionary<string, decimal>(){
                    { "APPLE", 0.50m },
                    { "ORANGE", 0.70m },
                    { "BANANA", 0.82m } };
            PriceCatalog catalog = new PriceCatalog(sample);
            Receipt model = new Receipt(catalog);
            ReceiptView view = new ReceiptView();
            ReceiptController controller = new ReceiptController(view, model);
            Assert.IsNotNull(controller);
        }

        [Test()]
        public void CheckReceiptForItemTest()
        {
            Dictionary<string, decimal> sample =
                new Dictionary<string, decimal>(){
                    { "APPLE", 0.50m },
                    { "ORANGE", 0.70m },
                    { "BANANA", 0.82m } };
            PriceCatalog catalog = new PriceCatalog(sample);
            ReceiptView view = new ReceiptView();
            Receipt model = new Receipt(catalog);
            model.AddOrUpdateItem("APPLE");
            ReceiptController controller = new ReceiptController(view, model);
            Assert.AreEqual(controller.CheckReceiptForItem("APPLE"), true);
            Assert.AreEqual(controller.CheckReceiptForItem("APasd"), false);
        }

        [Test()]
        public void AddOrUpdateReceiptTest()
        {
            Dictionary<string, decimal> sample =
                new Dictionary<string, decimal>(){
                    { "APPLE", 0.50m },
                    { "ORANGE", 0.70m },
                    { "BANANA", 0.82m } };
            PriceCatalog catalog = new PriceCatalog(sample);
            ReceiptView view = new ReceiptView();
            Receipt model = new Receipt(catalog);
            model.AddOrUpdateItem("APPLE");
            ReceiptController controller = new ReceiptController(view, model);
            Assert.AreEqual(controller.GetPriceOfReceiptItem("APPLE"), 0.50m);
        }

        [Test()]
        public void GetQuantityOfReceiptItemTest()
        {
            Dictionary<string, decimal> sample =
                new Dictionary<string, decimal>(){
                    { "APPLE", 0.50m },
                    { "ORANGE", 0.70m },
                    { "BANANA", 0.82m } };
            PriceCatalog catalog = new PriceCatalog(sample);
            ReceiptView view = new ReceiptView();
            Receipt model = new Receipt(catalog);
            model.AddOrUpdateItem("APPLE");
            model.AddOrUpdateItem("APPLE");
            ReceiptController controller = new ReceiptController(view, model);
            Assert.AreEqual(controller.GetQuantityOfReceiptItem("APPLE"), 2);
        }

        [Test()]
        public void GetPriceOfReceiptItemTest()
        {
            Dictionary<string, decimal> sample =
                new Dictionary<string, decimal>(){
                    { "APPLE", 0.50m },
                    { "ORANGE", 0.70m },
                    { "BANANA", 0.82m } };
            PriceCatalog catalog = new PriceCatalog(sample);
            ReceiptView view = new ReceiptView();
            Receipt model = new Receipt(catalog);
            model.AddOrUpdateItem("APPLE");
            ReceiptController controller = new ReceiptController(view, model);
            Assert.AreEqual(controller.GetPriceOfReceiptItem("APPLE"), 0.50m);
        }

        [Test()]
        public void GetReceiptTotalPriceOfItemTest()
        {
            Dictionary<string, decimal> sample =
                new Dictionary<string, decimal>(){
                    { "APPLE", 0.50m },
                    { "ORANGE", 0.70m },
                    { "BANANA", 0.82m } };
            PriceCatalog catalog = new PriceCatalog(sample);
            ReceiptView view = new ReceiptView();
            Receipt model = new Receipt(catalog);
            model.AddOrUpdateItem("APPLE");
            model.AddOrUpdateItem("APPLE");
            ReceiptController controller = new ReceiptController(view, model);
            Assert.AreEqual(controller.GetReceiptTotalPriceOfItem("APPLE"), 1.00m);
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
            ReceiptView view = new ReceiptView();
            Receipt model = new Receipt(catalog);
            model.AddOrUpdateItem("APPLE");
            ReceiptController controller = new ReceiptController(view, model);
            Assert.AreEqual(controller.GetReceiptItemNames()[0], "APPLE");
        }
    }
}