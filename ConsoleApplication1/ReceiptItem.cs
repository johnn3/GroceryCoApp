using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ReceiptItem
    {
        private string _name;
        private int _quantity;
        private decimal _price;

        public ReceiptItem(string name, decimal price)
        {
            _name = name.ToUpper();
            _price = price;
            _quantity = 1;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public decimal GetPrice()
        {
            return _price;
        }

        public decimal GetTotalPrice()
        {
            return (_price*_quantity);
        }

        public void AddOneToQuantityAndCost()
        {
            _quantity++;
        }
    }
}
