using System;

namespace _02.GodzillaVs.Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal budgetOfMovie = decimal.Parse(Console.ReadLine());
            int statitsCount = int.Parse(Console.ReadLine());
            decimal costumePrice = decimal.Parse(Console.ReadLine());

            decimal decorPrice = budgetOfMovie * 0.1m;
            decimal sumOfCostumes = costumePrice * statitsCount;

            switch (statitsCount) { case > 150: sumOfCostumes *= 0.9m; break; }

            decimal totalSum = decorPrice + sumOfCostumes;

            if (budgetOfMovie >= totalSum)
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {budgetOfMovie - totalSum:f2} leva left.");
            }
            else if (budgetOfMovie < totalSum) 
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {totalSum - budgetOfMovie:F2} leva more.");
            }
        }
    }
}
