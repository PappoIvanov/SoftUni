using System;

namespace _07_SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < group; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
