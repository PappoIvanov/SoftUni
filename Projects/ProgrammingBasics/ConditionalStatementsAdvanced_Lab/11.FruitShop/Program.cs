using System;

namespace _11.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double priceOfProduct = 0;

            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                switch (product)
                {
                    case "banana": priceOfProduct = 2.50; Console.WriteLine($"{quantity * priceOfProduct:f2}"); break;
                    case "apple": priceOfProduct = 1.20; Console.WriteLine($"{quantity * priceOfProduct:f2}"); break;
                    case "orange": priceOfProduct = 0.85; Console.WriteLine($"{quantity * priceOfProduct:f2}"); break;
                    case "grapefruit": priceOfProduct = 1.45; Console.WriteLine($"{quantity * priceOfProduct:f2}"); break;
                    case "kiwi": priceOfProduct = 2.70; Console.WriteLine($"{quantity * priceOfProduct:f2}"); break;
                    case "pineapple": priceOfProduct = 5.50; Console.WriteLine($"{quantity * priceOfProduct:f2}"); break;
                    case "grapes": priceOfProduct = 3.85; Console.WriteLine($"{quantity * priceOfProduct:f2}"); break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                switch (product)
                {
                    case "banana": priceOfProduct = 2.70; Console.WriteLine($"{quantity * priceOfProduct:f2}"); break;
                    case "apple": priceOfProduct = 1.25; Console.WriteLine($"{quantity * priceOfProduct:f2}"); break;
                    case "orange": priceOfProduct = 0.90; Console.WriteLine($"{quantity * priceOfProduct:f2}"); break;
                    case "grapefruit": priceOfProduct = 1.60; Console.WriteLine($"{quantity * priceOfProduct:f2}"); break;
                    case "kiwi": priceOfProduct = 3.00; Console.WriteLine($"{quantity * priceOfProduct:f2}"); break;
                    case "pineapple": priceOfProduct = 5.60; Console.WriteLine($"{quantity * priceOfProduct:f2}"); break;
                    case "grapes": priceOfProduct = 4.20; Console.WriteLine($"{quantity * priceOfProduct:f2}"); break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else { Console.WriteLine("error"); }
        }
    }
}
