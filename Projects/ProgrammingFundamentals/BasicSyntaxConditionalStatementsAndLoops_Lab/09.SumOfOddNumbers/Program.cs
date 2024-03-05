using System;

namespace _09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endOfCycle = int.Parse(Console.ReadLine());
            int oddSum = 0, oddNumbers = 1;

            while (endOfCycle > 0)
            {
                if (oddNumbers % 2 != 0)
                {
                    Console.WriteLine(oddNumbers);
                    oddSum += oddNumbers;
                }
                oddNumbers += 2;
                endOfCycle--;
            }

            Console.WriteLine("Sum: " + oddSum);
        }
    }
}

//for (int startingNumber = 1; startingNumber <= endOfCycle; startingNumber += 2)
//{
//    if (startingNumber % 2 != 0)
//    {
//        Console.WriteLine(startingNumber);
//        oddSum += startingNumber;
//    }
//}