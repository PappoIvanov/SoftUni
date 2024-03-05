using System;

namespace _04.MovieStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double currentBudget = budget;
            double actorsSalary = 0;
            bool isACRION = false;

            string actorsName = Console.ReadLine();

            while (actorsName != "ACTION")
            {
                int digitsOfName = actorsName.Length;

                if (digitsOfName > 15) { actorsSalary = currentBudget * 0.20; }
                else { actorsSalary = double.Parse(Console.ReadLine()); }
                
                if (currentBudget < actorsSalary)
                {
                Console.WriteLine($"We need {actorsSalary - currentBudget:f2} leva for our actors.");
                isACRION = true;
                break;
                }

                currentBudget -= actorsSalary;

                actorsName = Console.ReadLine();
               
            }

            if (currentBudget > 0 && !isACRION)
            {
                Console.WriteLine($"We are left with {currentBudget:f2} leva.");
            }
        }
    }
}
