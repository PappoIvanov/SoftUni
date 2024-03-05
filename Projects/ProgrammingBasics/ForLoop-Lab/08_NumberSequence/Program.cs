using System;

namespace _08_NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;

            for (int i = 1; i <= group; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < minNumber)
                    minNumber = number;

                if (number > maxNumber) 
                    maxNumber = number;
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
