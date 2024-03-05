using System;

namespace _05.CareOfPuppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodBothKilos = int.Parse(Console.ReadLine());
            int foodAmoundInGrams = foodBothKilos * 1000, amoundOfEatenFood = 0;
            string command = Console.ReadLine();

            while (command != "Adopted")
            {
                int daiyEatenFood = int.Parse(command);

                amoundOfEatenFood += daiyEatenFood;

                command = Console.ReadLine();
            }

            if (foodAmoundInGrams >= amoundOfEatenFood)
            {
                int leftovers = foodAmoundInGrams - amoundOfEatenFood;
                Console.WriteLine($"Food is enough! Leftovers: {leftovers} grams.");
            }
            else if (foodAmoundInGrams < amoundOfEatenFood)
            {
                int neededFood = amoundOfEatenFood - foodAmoundInGrams;
                Console.WriteLine($"Food is not enough. You need {neededFood} grams more.");
            }
        }
    }
}
