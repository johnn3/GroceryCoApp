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
        private PriceCatalog _catalog;
        private decimal _total;
        public Receipt(PriceCatalog catalog)
        {
            _catalog = catalog;
            _receipt = new SortedDictionary<string, ReceiptItem>();
            _total = 0.00m;
        }

        public bool CheckReceiptItem(string name)
        {
            return _receipt.ContainsKey(name.ToUpper());
        }

        public void AddOrUpdateItem(string name)
        {
            ReceiptItem value;
            name = name.ToUpper();

            if (_catalog.CheckStock(name))
            {
                if (_receipt.TryGetValue(name, out value))

                {
                    _receipt[name].AddOneToQuantityAndCost();
                }

                else
                {
                    _receipt.Add(name, new ReceiptItem(name, _catalog.GetItemPrice(name)));
                }
                _total = _total + _catalog.GetItemPrice(name);
            }
        }

        public int GetQuantityOfItem(string name)
        {
            ReceiptItem value;
            name = name.ToUpper();

            if (_receipt.TryGetValue(name, out value))
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
            name = name.ToUpper();

            if (_receipt.TryGetValue(name, out value))
            {
                return _receipt[name].GetPrice();
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
            name = name.ToUpper();

            if (_receipt.TryGetValue(name, out value))
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
