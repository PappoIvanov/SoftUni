using System;

namespace _05.BestPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            int mostGoals = int.MinValue;
            string bestScorrer = "";
            bool hettric = false;
            
            while (playerName != "END")
            {
                int currentGoals = int.Parse(Console.ReadLine());

                if (currentGoals > mostGoals)
                {
                    mostGoals = currentGoals;
                    bestScorrer = playerName;
                }
                if (currentGoals >= 3) { hettric = true; }

                if (currentGoals >= 10) { break; }

                playerName = Console.ReadLine();
            }

            Console.WriteLine($"{bestScorrer} is the best player!");

            if (hettric)
                Console.WriteLine($"He has scored {mostGoals} goals and made a hat-trick !!!");
            
            else if (!hettric)
                Console.WriteLine($"He has scored {mostGoals} goals.");

        }
    }
}
