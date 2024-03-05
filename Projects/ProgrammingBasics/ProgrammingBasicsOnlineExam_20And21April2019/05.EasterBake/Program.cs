using System;

namespace _05.EasterBake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int easterCakesCount = int.Parse(Console.ReadLine());
            int sugarWeightInGrams = 0;
            int flourWeightInGrams = 0;
            int biggestSugarWeightUsage = int.MinValue;
            int biggestFlourWeightUsage = int.MinValue;

            for (int numberOfCycles = 0; numberOfCycles < easterCakesCount; numberOfCycles++)
            {
                int currentSugarWeight = int.Parse(Console.ReadLine());
                int currentFlourWeight = int.Parse(Console.ReadLine());

                if (currentSugarWeight > biggestSugarWeightUsage) { biggestSugarWeightUsage = currentSugarWeight; }
                if (currentFlourWeight > biggestFlourWeightUsage) { biggestFlourWeightUsage = currentFlourWeight; }

                sugarWeightInGrams += currentSugarWeight;
                flourWeightInGrams += currentFlourWeight;
            }

            double packagesOfSugar = Math.Ceiling(1.0 * sugarWeightInGrams / 950);
            double packagesOfFlour = Math.Ceiling(1.0 * flourWeightInGrams / 750);

            Console.WriteLine($"Sugar: {packagesOfSugar}");
            Console.WriteLine($"Flour: {packagesOfFlour}");
            Console.WriteLine($"Max used flour is {biggestFlourWeightUsage} grams," +
                $" max used sugar is {biggestSugarWeightUsage} grams.");
        }
    }
}