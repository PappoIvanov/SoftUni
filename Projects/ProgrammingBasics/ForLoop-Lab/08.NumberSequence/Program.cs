using System;

namespace _08.NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            for (int i = 0; i < number; i++)
            {
                int writenNumber = int.Parse(Console.ReadLine());

                if (writenNumber > maxNumber)
                {
                    maxNumber = writenNumber;
                }

                if (writenNumber < minNumber)
                {
                    minNumber = writenNumber;
                }
            }

            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
