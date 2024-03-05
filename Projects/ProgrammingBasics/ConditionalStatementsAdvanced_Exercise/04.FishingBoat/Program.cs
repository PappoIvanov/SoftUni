using System;

namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double boatPrice = 0;

            switch (season)
            {
                case "Spring": boatPrice = 3000;

                    if (fishermen <= 6)
                        boatPrice *= 0.9;
                    else if (fishermen <= 11)
                        boatPrice *= 0.85;
                    else if (fishermen >= 12)
                        boatPrice *= 0.75;

                    if (fishermen % 2 == 0)
                        boatPrice *= 0.95;

                    if (budget >= boatPrice) Console.WriteLine($"Yes! You have {budget - boatPrice:f2} leva left.");
                    else Console.WriteLine($"Not enough money! You need {boatPrice - budget:f2} leva.");

                    break;
                case "Summer": boatPrice = 4200;

                    if (fishermen <= 6)
                        boatPrice *= 0.9;
                    else if (fishermen <= 11)
                        boatPrice *= 0.85;
                    else if (fishermen >= 12)
                        boatPrice *= 0.75;

                    if (fishermen % 2 == 0)
                        boatPrice *= 0.95;

                    if (budget >= boatPrice) Console.WriteLine($"Yes! You have {budget - boatPrice:f2} leva left.");
                    else Console.WriteLine($"Not enough money! You need {boatPrice - budget:f2} leva.");

                    break;
                case "Autumn":
                    boatPrice = 4200;

                    if (fishermen <= 6)
                        boatPrice *= 0.9;
                    else if (fishermen <= 11)
                        boatPrice *= 0.85;
                    else if (fishermen >= 12)
                        boatPrice *= 0.75;

                    if (budget >= boatPrice) Console.WriteLine($"Yes! You have {budget - boatPrice:f2} leva left.");
                    else Console.WriteLine($"Not enough money! You need {boatPrice - budget:f2} leva.");

                    break;
                case "Winter":
                    boatPrice = 2600;

                    if (fishermen <= 6)
                        boatPrice *= 0.9;
                    else if (fishermen <= 11)
                        boatPrice *= 0.85;
                    else if (fishermen >= 12)
                        boatPrice *= 0.75;

                    if (fishermen % 2 == 0)
                        boatPrice *= 0.95;

                    if (budget >= boatPrice) Console.WriteLine($"Yes! You have {budget - boatPrice:f2} leva left.");
                    else Console.WriteLine($"Not enough money! You need {boatPrice - budget:f2} leva.");

                    break;
            }
        }
    }
}
