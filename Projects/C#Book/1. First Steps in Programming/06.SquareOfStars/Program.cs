using System;

namespace _06.SquareOfStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', number));

            for (int rows = 0; rows < number - 2; rows++)
            {
                Console.Write(new string('*', 1));
                Console.Write(new string(' ', number - 2));
                Console.Write(new string('*', 1));
                Console.WriteLine();
            }
            Console.WriteLine(new string('*', number));
        }
    }
}
