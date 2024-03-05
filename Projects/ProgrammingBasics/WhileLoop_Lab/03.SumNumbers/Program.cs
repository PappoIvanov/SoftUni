using System;

namespace _03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            while (true)
            {
                int nextNumber = int.Parse(Console.ReadLine());
                sum += nextNumber;

                if (sum >= firstNumber)
                {
                    Console.WriteLine(sum);
                    break;
                }
            }
        }
    }
}
