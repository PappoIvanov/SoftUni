using System;

namespace _02.AddBags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal priceOfHeavyLuggage = decimal.Parse(Console.ReadLine());
            double weightOfLuggage = double.Parse(Console.ReadLine());
            int daysToGo = int.Parse(Console.ReadLine());
            int countOfLuggage = int.Parse(Console.ReadLine());

            if (weightOfLuggage < 10)
            {
                priceOfHeavyLuggage *= 0.20m;
            }
            else if (weightOfLuggage <= 20)
            {
                priceOfHeavyLuggage *= 0.50m;
            }
            
            switch (daysToGo)
            {
                case > 30: priceOfHeavyLuggage *= 1.10m; break;
                case < 7: priceOfHeavyLuggage *= 1.40m; break;
                case <= 30: priceOfHeavyLuggage *= 1.15m; break;
            }

            decimal totalSum = countOfLuggage * priceOfHeavyLuggage;

            Console.WriteLine($"The total price of bags is: {totalSum:f2} lv.");
        }
    }
}
