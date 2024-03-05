using System;

namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //145 = 1 * 1 + (1 * 2 * 3 * 4) + (1 * 2 * 3 * 4 * 5) = 1 + 24 + 120 = 145;

            int number = int.Parse(Console.ReadLine());
            int numberCoppy = number;
            int currentDigit = 0, sum = 0, currentFactorial = 0;

            while (number > 0)
            {
                int factorial = 1;
                currentDigit = number % 10;
                number /= 10;

                for (int i = 2; i <= currentDigit; i++)
                {
                    factorial = factorial * i;
                }
                sum += factorial;

            }
            Console.WriteLine(sum == numberCoppy ? "yes" : "no");
        }
    }
}
