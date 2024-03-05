namespace _05.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int countOfTournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int pointsDuringTheRankingYear = 0;
            int finalsCounter = 0;


            for (int numberOfCycles = 1; numberOfCycles <= countOfTournaments; numberOfCycles++)
            {
                string rankingOfTournaments = Console.ReadLine();
                switch (rankingOfTournaments)
                {
                    case "W": pointsDuringTheRankingYear += 2000; finalsCounter++; break;
                    case "F": pointsDuringTheRankingYear += 1200; break;
                    case "SF": pointsDuringTheRankingYear += 720; break;
                }
            }

            Console.WriteLine($"Final points: {startingPoints + pointsDuringTheRankingYear}");
            Console.WriteLine($"Average points: {pointsDuringTheRankingYear / countOfTournaments}");
            Console.WriteLine($"{1.0 * finalsCounter / countOfTournaments * 100:f2}%");
        }
    }
}
