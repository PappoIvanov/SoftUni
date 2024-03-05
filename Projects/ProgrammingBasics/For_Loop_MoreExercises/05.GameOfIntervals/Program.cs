using System;

namespace _05.GameOfIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPlays = int.Parse(Console.ReadLine());
            double result = 0;
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            int group4 = 0;
            int group5 = 0;
            int group6 = 0;

            for (int i = 1; i <= countOfPlays; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > 50 || number < 0)
                {
                    result /= 2;
                    group6++;
                }
                else if (number <= 9)
                {
                    result += number * 0.2;
                    group1++;
                }
                else if (number <= 19)
                {
                    result += number * 0.3;
                    group2++;
                }
                else if (number <= 29)
                {
                    result += number * 0.4;
                    group3++;
                }
                else if (number <= 39)
                {
                    result += 50;
                    group4++;
                }
                else if (number <= 50)
                {
                    result += 100;
                    group5++;
                }
                
            }

            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {(double)group1 / countOfPlays * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {(double)group2 / countOfPlays * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {(double)group3 / countOfPlays * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {(double)group4 / countOfPlays * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {(double)group5 / countOfPlays * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {(double)group6 / countOfPlays * 100:f2}%");
        }
    }
}
