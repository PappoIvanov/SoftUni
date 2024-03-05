using System;

namespace _07.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                int quantity = int.Parse(Console.ReadLine());
                sum += quantity;
            }

            Console.WriteLine(sum);
        }
    }
}
