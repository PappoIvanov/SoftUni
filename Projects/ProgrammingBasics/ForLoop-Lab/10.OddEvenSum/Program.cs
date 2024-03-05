using System;

namespace _10.OddEvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < groups; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i %2 == 0)
                {
                    sum1 += number;
                }
                else
                {
                    sum2 += number;
                }
            }

            if (sum1 == sum2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum1}");
            }
            else
            {
                int difference = Math.Abs(sum1 - sum2);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {difference}");
            }
        }
    }
}
