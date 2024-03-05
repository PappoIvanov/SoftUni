using System;

namespace _02.BikeRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juniorCyclists = int.Parse(Console.ReadLine());
            int seniorCyclists = int.Parse(Console.ReadLine());
            string typeOfRace = Console.ReadLine();
            double tax = 0;
            int countOfCyclists = juniorCyclists + seniorCyclists;

            switch (typeOfRace)
            {
                case "trail": tax = (juniorCyclists * 5.50 + seniorCyclists * 7) * 0.95; break;
                case "cross-country": tax = (juniorCyclists * 8 + seniorCyclists * 9.50) * 0.95;
                    if (countOfCyclists >= 50) 
                        tax *= 0.75;
                    break;
                case "downhill": tax = (juniorCyclists * 12.25 + seniorCyclists * 13.75) * 0.95; break;
                case "road": tax = (juniorCyclists * 20 + seniorCyclists * 21.50) * 0.95; break;
            }
            Console.WriteLine($"{tax:f2}");
        }
    }
}
