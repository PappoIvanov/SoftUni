using System;

namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lylisAge = int.Parse(Console.ReadLine());
            double washingMashinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int sum = 0;
            int moneyAsPresent = 0;
            int moneyForNextEvenBirthday = 10;

            for (int i = 1; i <= lylisAge; i++)
            {
                if (i % 2 == 0)
                {
                    moneyAsPresent += moneyForNextEvenBirthday - 1;
                    moneyForNextEvenBirthday += 10;
                }
                else
                {
                    sum += toyPrice;
                }
            }

            int amountOfSum = sum + moneyAsPresent;

            if (amountOfSum >= washingMashinePrice)
            {
                double moneyLeft = amountOfSum - washingMashinePrice;
                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }
            else
            {
                double neededMoney = washingMashinePrice - amountOfSum;
                Console.WriteLine($"No! {neededMoney:f2}");
            }
        }
    }
}
