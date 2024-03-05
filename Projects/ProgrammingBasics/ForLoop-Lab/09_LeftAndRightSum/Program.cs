using System;
using System.Reflection;

namespace _09_LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 1; i <= group; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum1 += number;
            }
            for (int i = 1; i <= group; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum2 += number;
            }

            if (sum1 != sum2)
            {
                int difference = Math.Abs(sum1 - sum2);
                Console.WriteLine($"No, diff = {difference}");
            }
            else
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
        }
    }
}
