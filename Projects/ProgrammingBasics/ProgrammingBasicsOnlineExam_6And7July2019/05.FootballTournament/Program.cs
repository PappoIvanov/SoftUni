using System;

namespace _05.FootballTournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string footbalTeam = Console.ReadLine();
            int countOfGames = int.Parse(Console.ReadLine());
            int amountOfPoints = 0, winsCounter = 0, drawsCounter = 0, lossesCounter = 0;

            if (countOfGames < 1) { Console.WriteLine($"{footbalTeam} hasn't played any games during this season."); }
            else
            {
                for (int i = 0; i < countOfGames; i++)
                {
                    char gameResult = char.Parse(Console.ReadLine());

                    switch (gameResult)
                    {
                        case 'W': amountOfPoints += 3; winsCounter++; break;
                        case 'D': amountOfPoints += 1; drawsCounter++; break;
                        case 'L': amountOfPoints += 0; lossesCounter++; break;

                    }
                }
                Console.WriteLine($"{footbalTeam} has won {amountOfPoints} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {winsCounter}");
                Console.WriteLine($"## D: {drawsCounter}");
                Console.WriteLine($"## L: {lossesCounter}");
                Console.WriteLine($"Win rate: {1.0 * winsCounter / countOfGames * 100:f2}%");
            }
        }
    }
}
