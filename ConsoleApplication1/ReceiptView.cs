using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ReceiptView
    {
        public ReceiptView() { }

        public void PrintReceiptItemDetail(int quantity, string name, decimal price)
        {
            Console.WriteLine(String.Format("{0,4}", quantity.ToString()) 
                +" "+ String.Format("{0,8}", name)+ " "+ String.Format("{0,-5}",price.ToString()));
        }
    }
}
