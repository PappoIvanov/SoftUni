using System;

namespace _02.MovieDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filmingTime = int.Parse(Console.ReadLine());
            int sceneCount = int.Parse(Console.ReadLine());
            int sceneDuration = int.Parse(Console.ReadLine());

            double preparationTime = filmingTime * 0.15;
            double sumOfSceneDuration = (double)sceneCount * (double)sceneDuration + preparationTime;
            
            if (sumOfSceneDuration <= filmingTime)
            {
                double leftTime = Math.Round(filmingTime - sumOfSceneDuration);
                Console.WriteLine($"You managed to finish the movie on time! You have {leftTime} minutes left!");
            }
            else if (sumOfSceneDuration > filmingTime)
            {
                double neededTime = Math.Round(sumOfSceneDuration - filmingTime);
                Console.WriteLine($"Time is up! To complete the movie you need {neededTime} minutes.");
            }
        }
    }
}
