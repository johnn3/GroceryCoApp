using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ReceiptController
    {
        private Receipt _model;
        private ReceiptView _view;

        public ReceiptController(ReceiptView view, Receipt model)
        {
            _model = model;
            _view = view;
        }

        public bool CheckReceiptForItem(string name)
        {
            return _model.CheckReceiptItem(name);
        }


        public void AddOrUpdateReceipt(string name, decimal price)
        {
            _model.AddOrUpdateItem(name, price);
        }


        public int GetQuantityOfReceiptItem(string name)
        {
            return _model.GetQuantityOfItem(name);
        }


        public decimal GetPriceOfReceiptItem(string name)
        {
            return _model.GetPriceOfItem(name);
        }


        public decimal GetReceiptTotalPriceOfItem(string name)
        {
            return _model.GetTotalPriceOfItem(name);
        }

        public List<string> GetReceiptItemNames()
        {
            return _model.GetReceiptItemNames();
        }

        public void PrintReceiptItem(string name)
        {
            _view.PrintReceiptItemDetail(_model.GetQuantityOfItem(name),
                name, _model.GetPriceOfItem(name));
        }

        public void PrintReceiptTotal()
        {
            _view.PrintReceiptEndTotal(_model.GetTotal());
        }

    }
}
