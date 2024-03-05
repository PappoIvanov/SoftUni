using System;

namespace _02.HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int sum = 0;

            for (int i = 0; i < countOfNumbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;

                if (maxNumber < currentNumber)
                {
                    maxNumber = currentNumber;
                }
            }

            if ((sum - maxNumber) == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                int difference = Math.Abs((sum - maxNumber) - maxNumber);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {difference}");
            }
        }
    }
}
