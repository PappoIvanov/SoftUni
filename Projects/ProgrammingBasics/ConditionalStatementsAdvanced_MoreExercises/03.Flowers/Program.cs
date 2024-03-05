using System;

namespace _03.Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chrysantemumsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int tulipsCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char holiday = char.Parse(Console.ReadLine());
            int arrangement = 2;
            double priceOfBouquet = 0;
            int countOfFlowers = chrysantemumsCount + rosesCount + tulipsCount;

            if (season == "Winter" || season == "Autumn")
            {
                priceOfBouquet = chrysantemumsCount * 3.75 + rosesCount * 4.50 + tulipsCount * 4.15;
                if (holiday == 'Y')
                {
                    priceOfBouquet *= 1.15;
                }

                if (rosesCount >= 10 && season == "Winter")
                {
                    priceOfBouquet *= 0.9;
                }

                if (countOfFlowers > 20)
                {
                    priceOfBouquet *= 0.8;
                }
            }
            else if (season == "Spring" || season == "Summer")
            {
                priceOfBouquet = chrysantemumsCount * 2.00 + rosesCount * 4.10 + tulipsCount * 2.50;

                if (holiday == 'Y')
                {
                    priceOfBouquet *= 1.15;
                }

                if (tulipsCount > 7 && season == "Spring")
                {
                    priceOfBouquet *= 0.95;
                }

                if (countOfFlowers > 20)
                {
                    priceOfBouquet *= 0.8;
                }
            }

            Console.WriteLine($"{priceOfBouquet + arrangement:f2}");
        }
    }
}
