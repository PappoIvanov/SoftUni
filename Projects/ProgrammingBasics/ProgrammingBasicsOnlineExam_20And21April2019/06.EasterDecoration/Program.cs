using System;

namespace _06.EasterDecoration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int clientsCount = int.Parse(Console.ReadLine());
            int counterOfProducts = 0;
            decimal sumOfProducts = 0;
            decimal totalSumAmount = 0;

            for (int numberOfCycles = 0; numberOfCycles < clientsCount; numberOfCycles++)
            {
                counterOfProducts = 0;
                sumOfProducts = 0;

                string product = Console.ReadLine();

                while (product != "Finish")
                {
                    switch (product)
                    {
                        case "basket": sumOfProducts += 1.50m; counterOfProducts++; break;
                        case "wreath": sumOfProducts += 3.80m; counterOfProducts++; break;
                        case "chocolate bunny": sumOfProducts += 7.00m; counterOfProducts++; break;
                    }

                    product = Console.ReadLine();
                }

                if (counterOfProducts % 2 == 0) { sumOfProducts *= 0.80m; }
                Console.WriteLine($"You purchased {counterOfProducts} items for {sumOfProducts:f2} leva.");

                totalSumAmount += sumOfProducts;

            }

            Console.WriteLine($"Average bill per client is: {totalSumAmount / clientsCount:f2} leva.");
        }
    }
}