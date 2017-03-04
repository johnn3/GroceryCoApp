using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ReceiptView
    {
        public ReceiptView() { }

        public void PrintReceiptItemDetail(int quantity, string name, decimal price)
        {
            Console.WriteLine(quantity.ToString() + " "+ name + " " +  price.ToString()
                + " " + (quantity*price).ToString());
        }

        public void PrintReceiptEndTotal(decimal total)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Total:");
            Console.WriteLine(total.ToString());
        }
    }
}
