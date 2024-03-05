using System;

namespace _04.TriangleOfDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int rows = 0; rows < number; rows++)
            {
                for (int columns = 0; columns <= rows; columns++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
