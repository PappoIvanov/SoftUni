using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (i == 0 || i == number - 1)
                    {
                        Console.Write("*");
                    }
                    else 
                    { 
                        Console.Write("*");
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
