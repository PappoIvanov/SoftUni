using System;

namespace _05.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal oddMoney = decimal.Parse(Console.ReadLine());
            decimal oddMoneyLeft = oddMoney;
            int coinsCounter = 0;

            while (oddMoneyLeft > 0)
            {
                if (oddMoneyLeft >= 2)
                {
                    oddMoneyLeft -= 2;
                }
                else if (oddMoneyLeft >= 1)
                {
                    oddMoneyLeft -= 1;
                }
                else if (oddMoneyLeft >= 0.5m)
                {
                    oddMoneyLeft -= 0.5m;
                }
                else if (oddMoneyLeft >= 0.2m)
                {
                    oddMoneyLeft -= 0.2m;
                }
                else if (oddMoneyLeft >= 0.1m)
                {
                    oddMoneyLeft -= 0.1m;
                }
                else if (oddMoneyLeft >= 0.05m)
                {
                    oddMoneyLeft -= 0.05m;
                }
                else if (oddMoneyLeft >= 0.02m)
                {
                    oddMoneyLeft -= 0.02m;
                }
                else
                {
                    oddMoneyLeft -= 0.01m;
                }

                coinsCounter++;
            }

            Console.WriteLine(coinsCounter);
        }
    }
}
