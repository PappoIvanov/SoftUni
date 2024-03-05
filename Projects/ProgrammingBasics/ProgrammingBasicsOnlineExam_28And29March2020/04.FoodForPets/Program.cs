using System;

namespace _04.FoodForPets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysEating = int.Parse(Console.ReadLine());
            double amountOfFood = double.Parse(Console.ReadLine());
            double currentFoodEaten = 0, amountOfBiscuits = 0;
            int allFoodEatenByDog = 0, allFoodEatenByCat = 0;


            for (int i = 1; i <= daysEating; i++)
            {
                int dogFoodEaten = int.Parse(Console.ReadLine());
                int catFoodEaten = int.Parse(Console.ReadLine());

                int dailyFoodEaten = 0;
                dailyFoodEaten = dogFoodEaten + catFoodEaten;
                currentFoodEaten += dailyFoodEaten;
                allFoodEatenByDog += dogFoodEaten;
                allFoodEatenByCat += catFoodEaten;

                if (i % 3 == 0)
                {
                    
                    double biscuits = (dailyFoodEaten * 0.10);
                    amountOfBiscuits += biscuits;
                }
            }

            Console.WriteLine($"Total eaten biscuits: {Math.Round(amountOfBiscuits)}gr.");
            Console.WriteLine($"{currentFoodEaten / amountOfFood * 100:f2}% of the food has been eaten.");
            Console.WriteLine($"{allFoodEatenByDog / currentFoodEaten * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{allFoodEatenByCat / currentFoodEaten * 100:f2}% eaten from the cat.");
        }
    }
}
