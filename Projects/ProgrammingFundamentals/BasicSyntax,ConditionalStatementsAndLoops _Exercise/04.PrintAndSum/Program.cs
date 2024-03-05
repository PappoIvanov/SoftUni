using System;

namespace _04.PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int currentNumber = startNumber; currentNumber <= endNumber; currentNumber++)
            {
                sum += currentNumber;
                Console.Write(currentNumber + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
