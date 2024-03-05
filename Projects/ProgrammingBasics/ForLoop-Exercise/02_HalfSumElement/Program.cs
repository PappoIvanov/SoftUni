using System;

namespace _02_HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            int biggest = int.MinValue;
            int sum = 0;

            for (int i = 1; i <= group; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;

                if (number > biggest)
                    biggest = number;
            }

            if (sum - biggest == biggest)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {biggest}");
            }
            else
            {
                int sumOfTheOtherNumbers = sum - biggest;
                int difference = sumOfTheOtherNumbers - biggest;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(difference)}");
            }
        }
    }
}
