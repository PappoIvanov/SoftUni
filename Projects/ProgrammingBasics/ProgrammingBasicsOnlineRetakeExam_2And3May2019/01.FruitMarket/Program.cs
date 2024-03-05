using System;

namespace _01.FruitMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal strawberriesPrice = decimal.Parse(Console.ReadLine());
            double bananasWeight = double.Parse(Console.ReadLine());
            double orangesWeight = double.Parse(Console.ReadLine());
            double raspberryWeight = double.Parse(Console.ReadLine());
            double strawberriesWeight = double.Parse(Console.ReadLine());

            decimal raspberryPrice = strawberriesPrice * 0.50m;
            decimal orangesPrice = raspberryPrice * 0.60m;
            decimal bananasPrice = raspberryPrice * 0.20m;

            decimal neededMoney = strawberriesPrice * (decimal)strawberriesWeight + bananasPrice * (decimal)bananasWeight + orangesPrice * (decimal)orangesWeight + raspberryPrice * (decimal)raspberryWeight;
            Console.WriteLine($"{neededMoney:f2}");
        }
    }
}