using System;
using System.Runtime.InteropServices;

namespace _11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplicationNumber = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier > 10)
            {
                int result = multiplicationNumber * multiplier;
                Console.WriteLine($"{multiplicationNumber} X {multiplier} = {result}");
            }
            else if (multiplier <= 10)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    int result = 0;
                    result = multiplicationNumber * i;
                    Console.WriteLine($"{multiplicationNumber} X {i} = {result}");
                }
            }
        }
    }
}
