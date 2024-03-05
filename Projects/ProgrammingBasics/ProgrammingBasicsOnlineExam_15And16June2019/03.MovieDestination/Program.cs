using System;

namespace _03.MovieDestination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int daysCount = int.Parse(Console.ReadLine());
            int dailyExpendituresForFilming = 0;

            switch (season)
            {
                case "Winter":  if (destination == "Dubai")
                        dailyExpendituresForFilming = 45_000;
                    
                    else if (destination == "Sofia")
                        dailyExpendituresForFilming = 17_000;
                    
                    else if (destination == "London")
                        dailyExpendituresForFilming = 24_000;
                break;
                case "Summer": if (destination == "Dubai")
                        dailyExpendituresForFilming = 40_000;
                    
                    else if (destination == "Sofia")
                        dailyExpendituresForFilming = 12_500;
                    
                    else if (destination == "London")
                        dailyExpendituresForFilming = 20_250;
                    
                break;
            }

            double costForFilming = dailyExpendituresForFilming * daysCount;

            switch (destination)
            {
                case "Dubai": costForFilming *= 0.70; break;
                case "Sofia": costForFilming *= 1.25; break;
            }

            if (movieBudget >= costForFilming)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {movieBudget - costForFilming:f2} leva left!");
            }
            else if (movieBudget < costForFilming)
            {
                Console.WriteLine($"The director needs {costForFilming - movieBudget:f2} leva more!");
            }
        }
    }
}
