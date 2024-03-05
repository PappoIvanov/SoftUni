using System;

namespace _02.Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            //int x2 = 2, x3 = 3, x6 = 6, x7 = 7, x10 = 10;

            //if (number % 2 == 0 || number % 3 == 0 || number % 6 == 0 || number % 7 == 0 || number % 10 == 0)
            //{
            //    Console.WriteLine($"The number is divisible by {number}");
            //}
            //else { Console.WriteLine("Not divisible"); }

            if (number % 10 == 0) 
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if (number % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (number % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else { Console.WriteLine("Not divisible"); }

        }
    }
}
