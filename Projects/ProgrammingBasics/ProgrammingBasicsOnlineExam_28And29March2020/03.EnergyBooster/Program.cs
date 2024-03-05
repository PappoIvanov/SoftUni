using System;

namespace _03.EnergyBooster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string package = Console.ReadLine();
            int countOfPackages = int.Parse(Console.ReadLine());

            decimal packagePrice = 0;

            switch (fruit)
            {
                case "Watermelon": switch (package)
                    {
                        case "small": packagePrice = 2 * 56; break;
                        case "big": packagePrice = 5 * 28.70m; break;
                    } break;
                case "Mango": switch (package)
                    {
                        case "small": packagePrice = 2 * 36.66m; break;
                        case "big": packagePrice = 5 * 19.60m; break;
                    } break;
                case "Pineapple": switch (package)
                    {
                        case "small": packagePrice = 2 * 42.10m; break;
                        case "big": packagePrice = 5 * 24.80m; break;
                    } break;
                case "Raspberry": switch (package)
                    {
                        case "small": packagePrice = 2 * 20; break;
                        case "big": packagePrice = 5 * 15.20m; break;
                    } break;
            }

            decimal sumOfPackage = packagePrice * countOfPackages;
            if (sumOfPackage > 1000) { sumOfPackage *= 0.50m; }
            else if (sumOfPackage >= 400) { sumOfPackage *= 0.85m; }

            Console.WriteLine($"{sumOfPackage:f2} lv.");
        }
    }
}
