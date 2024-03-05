using System;

namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOftournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            int pointsFromTournaments = 0;
            int finalPoints = 0;
            int wonTournaments = 0;

            for (int i = 1; i <= countOftournaments; i++)
            {
                string position = Console.ReadLine();

                switch (position)
                {
                    case "W": pointsFromTournaments += 2000; wonTournaments += 1; break;
                    case "F": pointsFromTournaments += 1200; break;
                    case "SF": pointsFromTournaments += 720; break;
                }
            }

            Console.WriteLine($"Final points: {startingPoints + pointsFromTournaments}");
            Console.WriteLine($"Average points: {Math.Floor((double)pointsFromTournaments / countOftournaments)}");
            Console.WriteLine($"{(double)wonTournaments / countOftournaments * 100:f2}%");
        }
    }
}
