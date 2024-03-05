using System;

namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalSum = 0;
            string payment = Console.ReadLine();

            while (payment != "NoMoreMoney")
            {
                double currentPayment = double.Parse(payment);

                if (currentPayment < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {currentPayment:f2}");

                totalSum += currentPayment;
                payment = Console.ReadLine();
            }

                Console.WriteLine($"Total: {totalSum:f2}");
        }
    }
}
