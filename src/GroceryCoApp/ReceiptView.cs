using System;

namespace GroceryCoApp
{
    public class ReceiptView
    {
        public ReceiptView(){
        }

        public void PrintItem(int quantity, string itemName, decimal cost){
            Console.WriteLine(quantity +" "+itemName+" "+cost);
        }
    }
}
