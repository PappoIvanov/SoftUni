using System;

namespace _04.CarToGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string typeOfCarClass = "";
            string carModel = "";

            if (budget <= 100)
            {
                switch (season)
                {
                    case "Summer":
                        budget *= 0.35;
                        Console.WriteLine("Economy class");
                        Console.WriteLine($"Cabrio - {budget:f2}");
                        break;
                    case "Winter":
                        budget *= 0.65;
                        Console.WriteLine("Economy class");
                        Console.WriteLine($"Jeep - {budget:f2}");
                        break;
                }
            }
            else if (budget <= 500)
            {
                switch (season)
                {
                    case "Summer":
                        budget *= 0.45;
                        Console.WriteLine("Compact class");
                        Console.WriteLine($"Cabrio - {budget:f2}");
                        break;
                    case "Winter":
                        budget *= 0.80;
                        Console.WriteLine("Compact class");
                        Console.WriteLine($"Jeep - {budget:f2}");
                        break;
                }
            }
            else  if (budget > 500) 
            {
                switch (season)
                {
                    case "Summer":
                        budget *= 0.90;
                        Console.WriteLine("Luxury class");
                        Console.WriteLine($"Jeep - {budget:f2}");
                        break;
                    case "Winter":
                        budget *= 0.90;
                        Console.WriteLine("Luxury class");
                        Console.WriteLine($"Jeep - {budget:f2}");
                        break;
                }
            }
        }
    }
}
