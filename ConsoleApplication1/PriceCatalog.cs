using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class PriceCatalog
    {
        private Dictionary<string, decimal> _itemStock;

        public PriceCatalog(Dictionary<string, decimal> itemStock)
        {
            _itemStock = itemStock;
        }

        public bool CheckStock(string item)
        {
            return _itemStock.ContainsKey(item);
        }

        public decimal GetItemPrice(string item)
        {
            decimal value;

            if (_itemStock.TryGetValue(item, out value))
            {
                return value;
            }

            return 0.00m;
        }
    }
}