using System;

namespace _03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupOfNumbers = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 1; i <= groupOfNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                    p1 += 1;
                else if (number >= 200 && number < 400)
                    p2 += 1;
                else if (number >= 400 && number < 600)
                    p3 += 1;
                else if (number >= 600 && number < 800)
                    p4 += 1;
                else if (number >= 800)
                    p5 += 1;
            }

            Console.WriteLine($"{(double)p1 / groupOfNumbers * 100:f2}%");
            Console.WriteLine($"{(double)p2 / groupOfNumbers * 100:f2}%");
            Console.WriteLine($"{(double)p3 / groupOfNumbers * 100:f2}%");
            Console.WriteLine($"{(double)p4 / groupOfNumbers * 100:f2}%");
            Console.WriteLine($"{(double)p5 / groupOfNumbers * 100:f2}%");
        }
    }
}
