using System;

namespace _03.CoffeeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfDring = Console.ReadLine();
            string sugar = Console.ReadLine();
            int countOfDrings = int.Parse(Console.ReadLine());
            decimal priceOfDring = 0;

            switch (typeOfDring)
            {
                case "Espresso": 
                    if (sugar == "Without") { priceOfDring = 0.90m; }
                    else if (sugar == "Normal") { priceOfDring = 1.00m; }
                    else if (sugar == "Extra") { priceOfDring = 1.20m; } break;
                case "Cappuccino": 
                    if (sugar == "Without") { priceOfDring = 1.00m; }
                    else if (sugar == "Normal") { priceOfDring = 1.20m; }
                    else if (sugar == "Extra") { priceOfDring = 1.60m; } break;
                case "Tea": 
                    if (sugar == "Without") { priceOfDring = 0.50m; }
                    else if (sugar == "Normal") { priceOfDring = 0.60m; }
                    else if (sugar == "Extra") { priceOfDring = 0.70m; } break;
            }

            decimal totalSum = priceOfDring * countOfDrings;

            switch (sugar) { case "Without": totalSum *= 0.65m; break; }
            if (typeOfDring == "Espresso" && countOfDrings >= 5) { totalSum *= 0.75m; }
            if (totalSum > 15) { totalSum *= 0.80m; }

            Console.WriteLine($"You bought {countOfDrings} cups of {typeOfDring} for {totalSum:f2} lv.");

        }
    }
}
