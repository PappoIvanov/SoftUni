using System;
using System.ComponentModel.Design;

namespace _03.TravelAgency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string package = Console.ReadLine();
            string vipDiscount = Console.ReadLine();
            int daysCount = int.Parse(Console.ReadLine());

            decimal priceDaily = 0, totalSum = 0;

            if (daysCount > 7) { daysCount--; }

            if (daysCount <= 1) { Console.WriteLine("Days must be positive number!"); }
            else
            {
                if (city == "Bansko" || city == "Borovets")
                {
                    switch (package)
                    {
                        case "noEquipment":
                            priceDaily = 80.00m;
                            switch (vipDiscount) { case "yes": priceDaily *= 0.95m; break; }
                            break;
                        case "withEquipment":
                            priceDaily = 100.00m;
                            switch (vipDiscount) { case "yes": priceDaily *= 0.90m; break; }
                            break;
                        default: Console.WriteLine("Invalid input!"); break;
                    }
                }
                else if (city == "Varna" || city == "Burgas")
                {
                    switch (package)
                    {
                        case "noBreakfast":
                            priceDaily = 100.00m;
                            switch (vipDiscount) { case "yes": priceDaily *= 0.93m; break; }
                            break;
                        case "withBreakfast":
                            priceDaily = 130.00m;
                            switch (vipDiscount) { case "yes": priceDaily *= 0.88m; break; }
                            break;
                        default: Console.WriteLine("Invalid input!"); break;
                    }
                }
                else { Console.WriteLine("Invalid input!"); return; }

                totalSum = priceDaily * daysCount;
                Console.WriteLine($"The price is {totalSum:f2}lv! Have a nice time!");
            }
        }
    }
}
