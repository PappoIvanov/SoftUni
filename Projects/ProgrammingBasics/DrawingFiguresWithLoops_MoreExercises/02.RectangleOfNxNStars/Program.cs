using System;

namespace _02.RectangleOfNxNStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
