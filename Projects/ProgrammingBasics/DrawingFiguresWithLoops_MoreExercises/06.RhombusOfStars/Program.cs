using System;

namespace _06.RhombusOfStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int colsCount = 1;

            for (int row = 1; row <= number - 1; row++)
            {
                Console.WriteLine(new string(' ', number - colsCount));
                for (int column = 0; column < colsCount; column++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                colsCount++;
            }

            for (int column = 1; column <= number; column++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();

            colsCount = number - 1;
            for (int row = 1; row < number - 1; row++)
            {
                Console.Write(new string(' ', number - colsCount));
                for (int column = 0; column < colsCount; column++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
                colsCount--;
            }
        }
    }
}
