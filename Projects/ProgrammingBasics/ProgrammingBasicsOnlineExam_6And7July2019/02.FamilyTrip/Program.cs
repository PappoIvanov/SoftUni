using System;

namespace _02.FamilyTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int nightsCount = int.Parse(Console.ReadLine());
            decimal pricePerNight = decimal.Parse(Console.ReadLine());
            int additionalExpenditurePercentage = int.Parse(Console.ReadLine());

            if (nightsCount > 7)
            {
                pricePerNight *= 0.95m;
            }

            decimal sumForAdditionalExpenditures = budget * additionalExpenditurePercentage / 100;
            decimal allNightsSum = nightsCount * pricePerNight;
            decimal totalSum = allNightsSum + sumForAdditionalExpenditures;

            if (budget >= totalSum)
            {
                decimal moneyLeft = budget - totalSum;
                Console.WriteLine($"Ivanovi will be left with {moneyLeft:f2} leva after vacation.");
            }
            else if (budget < totalSum)
            {
                decimal neededMoney = Math.Abs(budget - totalSum);
                Console.WriteLine($"{neededMoney:f2} leva needed.");
            }
        }
    }
}
