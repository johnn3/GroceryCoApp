using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //CHANGE THIS TO SOMETHING THAT CAN BE READ FROM FILE
        private static PriceCatalog GetPriceCatalog()
        {
            string filepath =
                @"c:\users\ni\documents\visual studio 2015\Projects\GroceryCoApp\StoreStock.txt";
            Dictionary<string, decimal> itemsAndPrices = new Dictionary<string, decimal>(); 
            string[] lines = System.IO.File.ReadAllLines(filepath);

            foreach (string line in lines)
            {
                string[] item = line.Split(' ');
                if (item.Length != 2)
                {
                    continue;
                }
                itemsAndPrices.Add(item[0], System.Convert.ToDecimal(item[1]));
            }
            return new PriceCatalog(itemsAndPrices);
        }

        private static void CheckOut(string filepath, PriceCatalog catalog)
        {
            Receipt model = new Receipt(catalog);
            ReceiptView view = new ReceiptView();
            ReceiptController controller = new ReceiptController(view, model);

            string[] lines = System.IO.File.ReadAllLines(filepath);
            foreach (string line in lines){
                controller.AddOrUpdateReceipt(line.Trim());
            }

            controller.PrintReceipt();
        }

        static void Main(string[] args)
        {
            string filepath;

            Console.WriteLine("Welcome to GroceryCo self-checkout.");
            Console.WriteLine("Please enter the filepath of your grocery list : ");
            filepath = Console.ReadLine();

            while (true)
            {
                try {
                    PriceCatalog catalog = GetPriceCatalog();
                    CheckOut(filepath, catalog);
                }
                catch (Exception e)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Please enter the filepath of your grocery list : ");
                filepath = Console.ReadLine();
            }
        }
    }
}
