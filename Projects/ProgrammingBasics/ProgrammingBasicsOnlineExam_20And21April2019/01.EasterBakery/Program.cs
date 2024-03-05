using System;

namespace _01.EasterBakery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal priceOfFlour = decimal.Parse(Console.ReadLine());
            decimal flourWeight = decimal.Parse(Console.ReadLine());
            decimal sugarWeight = decimal.Parse(Console.ReadLine());
            decimal countOfEggsBoxes = decimal.Parse(Console.ReadLine());
            decimal countOfYeastPackages = decimal.Parse(Console.ReadLine());

            decimal sugarPrice = priceOfFlour * 0.75m;
            decimal eggsBoxPrice = priceOfFlour * 1.10m;
            decimal yeastPackagePrice = sugarPrice * 0.20m;

            decimal totalSum = priceOfFlour * flourWeight + sugarPrice * sugarWeight + eggsBoxPrice * countOfEggsBoxes + yeastPackagePrice * countOfYeastPackages;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
