using System;

namespace _05.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = "";
            string hosting = "";

            if (budget <= 1000)
            {
                hosting = "Camp";
                switch (season)
                {
                    case "Summer": budget *= 0.65m; place = "Alaska";
                        Console.WriteLine($"{place} - {hosting} - {budget:f2}");
                        break;
                    case "Winter": budget *= 0.45m; place = "Morocco";
                        Console.WriteLine($"{place} - {hosting} - {budget:f2}");
                        break;
                }
            }
            else if (budget <= 3000)
            {
                hosting = "Hut";
                switch (season)
                {
                    case "Summer":
                        budget *= 0.80m; place = "Alaska";
                        Console.WriteLine($"{place} - {hosting} - {budget:f2}");
                        break;
                    case "Winter":
                        budget *= 0.60m; place = "Morocco";
                        Console.WriteLine($"{place} - {hosting} - {budget:f2}");
                        break;
                }
            }
            else if (budget > 3000)
            {
                hosting = "Hotel";
                switch (season)
                {
                    case "Summer":
                        budget *= 0.90m; place = "Alaska";
                        Console.WriteLine($"{place} - {hosting} - {budget:f2}");
                        break;
                    case "Winter":
                        budget *= 0.90m; place = "Morocco";
                        Console.WriteLine($"{place} - {hosting} - {budget:f2}");
                        break;
                }
            }
        }
    }
}
