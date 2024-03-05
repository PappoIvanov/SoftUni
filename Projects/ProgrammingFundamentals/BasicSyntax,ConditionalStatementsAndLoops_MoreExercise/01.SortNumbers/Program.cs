using System;

namespace _01.SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x1 = 0, x2 = 0, x3 = 0;

            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int maxNumber = 0, mediumNumber = 0, minNumber = 0;

            if (x1 >= x2 && x1 >= x3)
            {
                Console.WriteLine(x1);
                if (x2 >= x3) 
                { 
                    Console.WriteLine(x2);
                    Console.WriteLine(x3);
                }
                else if (x3 > x2) 
                { 
                    Console.WriteLine(x3);
                    Console.WriteLine(x2);
                }
            }
            if (x2 >= x1 && x2 >= x3)
            {
                Console.WriteLine(x2);
                if (x1 >= x3) 
                { 
                    Console.WriteLine(x1);
                    Console.WriteLine(x3);
                }
                else if (x3 > x1) 
                { 
                    Console.WriteLine(x3);
                    Console.WriteLine(x1);
                }
            }
            if (x3 >= x2 && x3 >= x1)
            {
                Console.WriteLine(x3);
                if (x1 >= x2)
                {
                    Console.WriteLine(x1);
                    Console.WriteLine(x2);
                }
                else if (x2 > x1)
                {
                    Console.WriteLine(x2);
                    Console.WriteLine(x1);
                }
            }
        }
    }
}
