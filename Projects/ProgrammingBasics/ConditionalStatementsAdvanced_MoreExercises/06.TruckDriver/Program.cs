using System;

namespace _06.TruckDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            decimal kilometersPerMonth = decimal.Parse(Console.ReadLine());
            decimal payment = 0;

            switch (season)
            {
                case "Spring": 
                    if (kilometersPerMonth <= 5000) payment = kilometersPerMonth * 0.75m * 4;

                    else if (kilometersPerMonth <= 10_000) payment = kilometersPerMonth * 0.95m * 4;
                    
                    else if (kilometersPerMonth <= 20_000) payment = kilometersPerMonth * 1.45m * 4;
                    break;
                case "Summer":
                    if (kilometersPerMonth <= 5000) payment = kilometersPerMonth * 0.90m * 4;

                    else if (kilometersPerMonth <= 10_000) payment = kilometersPerMonth * 1.10m * 4;

                    else if (kilometersPerMonth <= 20_000) payment = kilometersPerMonth * 1.45m * 4;
                    break;
                case "Autumn":
                    if (kilometersPerMonth <= 5000) payment = kilometersPerMonth * 0.75m * 4;

                    else if (kilometersPerMonth <= 10_000) payment = kilometersPerMonth * 0.95m * 4;

                    else if (kilometersPerMonth <= 20_000) payment = kilometersPerMonth * 1.45m * 4;
                    break;
                case "Winter":
                    if (kilometersPerMonth <= 5000) payment = kilometersPerMonth * 1.05m * 4;

                    else if (kilometersPerMonth <= 10_000) payment = kilometersPerMonth * 1.25m * 4;

                    else if (kilometersPerMonth <= 20_000) payment = kilometersPerMonth * 1.45m * 4;
                    break;
            }

            Console.WriteLine($"{payment * 0.90m:f2}");
        }
    }
}
