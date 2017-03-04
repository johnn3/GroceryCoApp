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
            Dictionary<string, decimal> itemsAndPrices =
                new Dictionary<string, decimal>(){
                    { "APPLE", 0.50m },
                    { "ORANGE", 0.70m },
                    { "BANANA", 0.82m }
                };
            return new PriceCatalog(itemsAndPrices);
        }

        private static void CheckOut(string filepath)
        {
            PriceCatalog catalog = GetPriceCatalog() ;
            Receipt model = new Receipt(catalog);
            ReceiptView view = new ReceiptView();
            ReceiptController controller = new ReceiptController(view, model);

            string[] lines = System.IO.File.ReadAllLines(filepath);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
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
                try
                {   // Open the text file using a stream reader.
                    CheckOut(filepath);
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
