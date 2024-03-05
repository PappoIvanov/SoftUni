using System;

namespace _06.BasketballTournament
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nameOfTournament = Console.ReadLine();
            int currentMatch = 0;
            bool endOfTournament = false;
            int wonMatches = 0;
            int lostMatches = 0;
            int playedMatches = 0;

            while (nameOfTournament != "End of tournaments")
            {
                int countOfMatches = int.Parse(Console.ReadLine());

                while (countOfMatches > 0)
                {
                    int DesisTeamPoints = int.Parse(Console.ReadLine());
                    int RivalsTeamPoints = int.Parse(Console.ReadLine());
                    currentMatch++;
                    

                    if (DesisTeamPoints > RivalsTeamPoints)
                    {
                        wonMatches++;
                        playedMatches++;
                        Console.WriteLine($"Game {currentMatch} of tournament {nameOfTournament}: win with {DesisTeamPoints - RivalsTeamPoints} points.");
                    }
                    else if (RivalsTeamPoints > DesisTeamPoints)
                    {
                        lostMatches++;
                        playedMatches++;
                        Console.WriteLine($"Game {currentMatch} of tournament {nameOfTournament}: lost with {RivalsTeamPoints - DesisTeamPoints} points.");
                    }

                    countOfMatches--;
                }

                currentMatch = 0;
                nameOfTournament = Console.ReadLine();
            }

            endOfTournament = true;

            if (endOfTournament)
            {
                Console.WriteLine($"{(double)wonMatches / playedMatches * 100:f2}% matches win");
                Console.WriteLine($"{(double)lostMatches / playedMatches * 100:f2}% matches lost");
            }
        }
    }
}
