using System;

namespace _01.ChangeBureau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bitcoinsCount = int.Parse(Console.ReadLine());
            decimal chinesJuanasCount = decimal.Parse(Console.ReadLine());
            decimal commissionOfBureau = decimal.Parse(Console.ReadLine());

            decimal chinesJuanasInDollars = chinesJuanasCount * 0.15m;
            decimal chinesJuanasInLevas = chinesJuanasInDollars * 1.76m;
            decimal juanasInEuro = chinesJuanasInLevas / 1.95m;

            decimal bitcoinsInEuro = (bitcoinsCount * 1168) / 1.95m;

            decimal sumOfEuro = bitcoinsInEuro + juanasInEuro;

            sumOfEuro -=  sumOfEuro * commissionOfBureau / 100m;
            Console.WriteLine($"{sumOfEuro:f2}");
        }
    }
}
