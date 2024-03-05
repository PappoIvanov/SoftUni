using System;

namespace _04.Club
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double targetIncome = double.Parse(Console.ReadLine());
            double currentTarget = targetIncome;
            bool isParty = false;
            double totalIncome = 0;

            while (currentTarget > 0)
            {
                string cocktailName = Console.ReadLine();

                if (cocktailName == "Party!") 
                { 
                    isParty = true; 
                    Console.WriteLine($"We need {currentTarget:f2} leva more.");
                    Console.WriteLine($"Club income - {targetIncome - currentTarget:f2} leva.");
                    break; }
                double priceOfCocktail = cocktailName.Length;
                int countOfCocktails = int.Parse(Console.ReadLine());
                double sumOfCocktails = priceOfCocktail * countOfCocktails;
                if (sumOfCocktails % 2 != 0 ) { sumOfCocktails *= 0.75; }

                currentTarget -= sumOfCocktails;
                totalIncome += sumOfCocktails;

                sumOfCocktails = 0;
                priceOfCocktail = 0;

            }

            if (!isParty)
            {
                Console.WriteLine("Target acquired.");
                Console.WriteLine($"Club income - {totalIncome:f2} leva.");
            }
        }
    }
}
