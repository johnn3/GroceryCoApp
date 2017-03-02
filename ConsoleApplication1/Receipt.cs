using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Receipt
    {
        private SortedDictionary<string, ReceiptItem> _receipt;
        private decimal _total;
        public Receipt()
        {
            _receipt = new SortedDictionary<string, ReceiptItem>();
            _total = 0.00m;
        }

        public bool CheckReceiptItem(string name)
        {
            return _receipt.ContainsKey(name.ToUpper());
        }

        public void AddOrUpdateItem(string name, decimal price)
        {
            ReceiptItem value;

            if (_receipt.TryGetValue(name.ToUpper(), out value))
            {
                _receipt[name].AddOneToQuantityAndCost();
            }

            else
            {
                _receipt.Add(name, new ReceiptItem(name.ToUpper(), price));
            }
            _total = _total + price;
        }

        public int GetQuantityOfItem(string name)
        {
            ReceiptItem value;

            if (_receipt.TryGetValue(name.ToUpper(), out value))
            {
                return _receipt[name.ToUpper()].GetQuantity();
            }

            else
            {
               return 0;
            }
        }

        public decimal GetPriceOfItem(string name)
        {
            ReceiptItem value;

            if (_receipt.TryGetValue(name.ToUpper(), out value))
            {
                return _receipt[name.ToUpper()].GetPrice();
            }

            else
            {
                return 0.0m;
            }
        }

        public decimal GetTotal()
        {
            return _total;
        }

        public decimal GetTotalPriceOfItem(string name)
        {
            ReceiptItem value;

            if (_receipt.TryGetValue(name.ToUpper(), out value))
            {
                return _receipt[name.ToUpper()].GetTotalPrice();
            }

            else
            {
                return 0.0m;
            }
        }

        public List<string> GetReceiptItemNames()
        {
            return _receipt.Keys.ToList();
        }
    }
}
