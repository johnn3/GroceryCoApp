using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ReceiptItem
    {
        private string _name;
        private int _quantity;
        private decimal _price;
        private decimal _total = 0.00m;

        public ReceiptItem(string name, int quantity, decimal price)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }

        public string GetName()
        {
            return _name;
        }

        public decimal GetPrice()
        {
            return _price;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public void AddOneToQuantityAndCost()
        {
            _total = _total + _price;
            _quantity++;
        }
    }
}
