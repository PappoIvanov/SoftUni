using System;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double vacationPrice = 0;

            if (budget <= 100)
            {
                switch (season)
                {
                    case "summer": vacationPrice = budget * 0.3;
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine($"{"Camp"} - {vacationPrice:f2}"); break;
                    case "winter": vacationPrice = budget * 0.70;
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine($"{"Hotel"} - {vacationPrice:f2}"); break;
                }
            }
            else if (budget <= 1000)
            {
                switch (season)
                {
                    case "summer": vacationPrice = budget * 0.4;
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine($"{"Camp"} - {vacationPrice:f2}"); break;
                    case "winter": vacationPrice = budget * 0.80;
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine($"{"Hotel"} - {vacationPrice:f2}"); break;
                }
            }
            else if (budget > 1000)
            {
                vacationPrice = budget * 0.90;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"{"Hotel"} - {vacationPrice:f2}");
            }
        }
    }
}
