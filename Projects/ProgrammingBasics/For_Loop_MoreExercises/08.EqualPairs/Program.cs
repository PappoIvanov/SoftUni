using System;

namespace _08.EqualPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pairs = int.Parse(Console.ReadLine());
            int sumOfPair = 0;
            //int maxValue = int.MinValue;
            //int minValue = int.MaxValue;
            int previousPair = 0;
            int lastPair = 0;

            for (int i = 0; i < pairs; i++)
            {
                previousPair = sumOfPair;
                sumOfPair = 0;
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());

                sumOfPair = firstNumber + secondNumber;
                lastPair = sumOfPair;


                //if (sumOfPair > maxValue) { maxValue = sumOfPair; }
                //if (sumOfPair < minValue) { minValue = sumOfPair; }
            }

            if (lastPair == previousPair)
            {
                Console.WriteLine($"Yes, value={lastPair}");
            }
            else if (lastPair > previousPair && previousPair != 0)
            {
                Console.WriteLine($"No, maxdiff={lastPair - previousPair}");
            }
            else if (lastPair < previousPair)
            {
                Console.WriteLine($"No, maxdiff={previousPair - lastPair}");
            }
             else if (lastPair == lastPair)
            {
                Console.WriteLine($"Yes, value={lastPair}");
            }
        }
    }
}