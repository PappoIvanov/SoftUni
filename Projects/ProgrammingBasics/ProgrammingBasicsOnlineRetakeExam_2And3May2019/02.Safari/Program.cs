using System;

namespace _02.Safari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();
            int tourGuidePrice = 100;

            decimal fuelSum = (decimal)fuelQuantity * 2.10m;
            decimal totalSum = fuelSum + tourGuidePrice;

            switch (dayOfWeek)
            {
                case "Saturday": totalSum *= 0.90m; break;
                case "Sunday": totalSum *= 0.80m; break;
            }

            if (budget >= totalSum) { Console.WriteLine($"Safari time! Money left: {budget - totalSum:f2} lv."); }
            else if (budget < totalSum) { Console.WriteLine($"Not enough money! Money needed: {totalSum - budget:f2} lv."); }
        }
    }
}