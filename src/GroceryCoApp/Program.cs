using System;
using System.Collections.Generic;

namespace GroceryCoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string filepath;

            Console.WriteLine("Welcome to GroceryCo self-checkout.");
            Console.WriteLine("Please enter the filepath of your grocery list: ");
            filepath = Console.ReadLine();

            //while (true)
            //{    
            //}

            Console.ReadKey();
        }

        private static GroceryItemStock GetGroceryItemStock()
        {
            Dictionary<string, decimal> itemsAndPrices = 
                new Dictionary<string, decimal>(){
                    { "APPLE", 0.50m },
                    { "ORANGE", 0.70m },
                    { "BANANA", 0.82m } };
            GroceryItemStock groceryItemStock = new GroceryItemStock(itemsAndPrices);
            return groceryItemStock;
        }
    }
}
