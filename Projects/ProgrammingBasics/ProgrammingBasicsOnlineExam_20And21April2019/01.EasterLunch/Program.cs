using System;

namespace _01.EasterLunch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal cakePrice = 3.20m;
            decimal boxOfEggsPrice = 4.35m;
            decimal cookiesPrice = 5.40m;
            decimal paintForEggsPrice = 12 * 0.15m;

            int cakesCount = int.Parse(Console.ReadLine());
            int boxesOfEggsCount = int.Parse(Console.ReadLine());
            int KilosCookiesCount = int.Parse(Console.ReadLine());

            decimal totalSum = cakePrice * cakesCount + boxOfEggsPrice * boxesOfEggsCount + paintForEggsPrice * boxesOfEggsCount + cookiesPrice * KilosCookiesCount;
            Console.WriteLine(totalSum);
        }
    }
}
