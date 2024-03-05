using System;

namespace _01.PoolDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            decimal entryTax = decimal.Parse(Console.ReadLine());
            decimal loungePrice = decimal.Parse(Console.ReadLine());
            decimal umbrellaPrice = decimal.Parse(Console.ReadLine());

            double countOfLounge = Math.Ceiling(peopleCount * 0.75);
            double countOfUmbrella = Math.Ceiling(peopleCount / 2.0);

            decimal totalAmount = (decimal)countOfLounge * loungePrice + (decimal)countOfUmbrella * umbrellaPrice + entryTax * peopleCount;

            Console.WriteLine($"{totalAmount:f2} lv.");

        }
    }
}
