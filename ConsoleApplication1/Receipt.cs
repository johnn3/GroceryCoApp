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
        public Receipt()
        {
            _receipt = new SortedDictionary<string, ReceiptItem>();
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
        }

        public int GetQuantityOfItem(string name)
        {
            ReceiptItem value;

            if (_receipt.TryGetValue(name.ToUpper(), out value))
            {
                return _receipt[name].GetQuantity();
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
                return _receipt[name].GetPrice();
            }

            else
            {
                return 0.0m;
            }
        }

        public decimal GetTotalPriceOfItem(string name)
        {
            ReceiptItem value;

            if (_receipt.TryGetValue(name.ToUpper(), out value))
            {
                return _receipt[name].GetTotalPrice();
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
