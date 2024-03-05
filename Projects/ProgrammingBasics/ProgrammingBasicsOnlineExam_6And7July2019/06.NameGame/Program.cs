using System;

namespace _06.NameGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            int maxPoints = 0;
            string winner = "";

            while (playerName != "Stop")
            {
                int currentPoints = 0;

                for (int i = 0; i < playerName.Length; i++)
                {
                    int number = int.Parse(Console.ReadLine());
                    
                    if (number == playerName[i])
                    {
                        currentPoints += 10;
                    }
                    else
                    {
                        currentPoints += 2;
                    }

                }

                if (currentPoints >= maxPoints)
                {
                    maxPoints = currentPoints;
                    winner = playerName;
                }

                playerName = Console.ReadLine();
            }

            Console.WriteLine($"The winner is {winner} with {maxPoints} points!");
        }
    }
}
