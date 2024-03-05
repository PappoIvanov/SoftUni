using System;

namespace _08.TriangleOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = number - 1;

            for (int row = 1; row <= number; row++)
            {
                for (int column = 1; column <= number - counter; column++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();
                counter--;
            }
        }
    }
}
