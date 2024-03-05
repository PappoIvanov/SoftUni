using System;

namespace _05.SquareFrame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            Console.Write("+ ");
            for (int i = 0; i < number - 2; i++)
            {
                Console.Write("- ");
            }
            Console.Write("+");
            Console.WriteLine();
            for (int i = 0;i < number - 2; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < number - 2; j++)
                {
                    Console.Write("- ");
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.Write("+ ");
            for (int i = 0; i < number - 2; i++)
            {
                Console.Write("- ");
            }
            Console.Write("+");
        }
    }
}
