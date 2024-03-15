using System;

namespace BOLLO
{

    class GSTCalc
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Nau Mai blah ki tō GST Calculator!");

                Console.Write("Enter product name: ");
                string productName = Console.ReadLine();

                Console.Write("Enter quantity: ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter product cost: ");
                double cost = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Select option:");
                Console.WriteLine("1. + GST");
                Console.WriteLine("2. GST is already included");

                int choice = Convert.ToInt32(Console.ReadLine());

                double totalCost;

                if (choice == 1)
                {
                    totalCost = cost * 1.15;
                    Console.WriteLine("Product: " + productName);
                    Console.WriteLine("Quantity: " + quantity);
                    Console.WriteLine("Original Cost: $" + cost);
                    Console.WriteLine($"Total Cost (GST included): $" + totalCost * quantity);
                }
                if (choice == 2)
                {
                    totalCost = cost / 1.15;

                    Console.WriteLine("Product: " + productName);
                    Console.WriteLine("Quantity: " + quantity);
                    Console.WriteLine("Original Cost: $" + cost);
                    Console.WriteLine($"Total Cost: $" + totalCost * quantity);


                    Console.WriteLine("Thank You!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input");

            }
        }
    }
}


