using System;

namespace _10.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplicatedNumber = int.Parse(Console.ReadLine());

            for (int multiplicator = 1; multiplicator <= 10; multiplicator++)
            {
                int result = 0;
                result = multiplicatedNumber * multiplicator;
                Console.WriteLine($"{multiplicatedNumber} X {multiplicator} = {result}");
            }
        }
    }
}
