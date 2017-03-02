using System;
using System.Collections.Generic;

namespace GroceryCoApp
{
    public class GroceryItemStock
    {
        private Dictionary<string, decimal> _itemStock;
        
        public GroceryItemStock(Dictionary<string, decimal> itemStock)
        {
            _itemStock = itemStock;
        }

        public bool CheckStock(string item)
        {
            return _itemStock.ContainsKey(item);
        }
    
        public decimal GetItemPrice(string item){
            decimal value;

            if (_itemStock.TryGetValue(item, out value))
            {
                    return value;
            }

            return 0.00m;
        }
   }
}
