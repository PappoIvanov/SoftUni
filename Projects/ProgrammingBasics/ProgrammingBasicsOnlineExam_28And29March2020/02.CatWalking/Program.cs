using System;

namespace _02.CatWalking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutesOfWalking = int.Parse(Console.ReadLine());
            int countsOfWalking = int.Parse(Console.ReadLine());
            int calloriesTaken = int.Parse(Console.ReadLine());

            int burnedCalloriesPerWalking = minutesOfWalking * 5;
            int sumOfBurnedcallories = burnedCalloriesPerWalking * countsOfWalking;
            double targetOfBurnedCallories = calloriesTaken * 0.50;

            if (sumOfBurnedcallories >= targetOfBurnedCallories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {sumOfBurnedcallories}.");
            }
            else if (sumOfBurnedcallories < targetOfBurnedCallories)
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {sumOfBurnedcallories}.");
            }

        }
    }
}
