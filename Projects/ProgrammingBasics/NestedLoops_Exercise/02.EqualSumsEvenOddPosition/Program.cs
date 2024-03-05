using System;

namespace _02.EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                int currentNumber = i;
                int oddDigitsSum = 0; int evenDigitsSum = 0;
                bool isEven = true;

                while (currentNumber > 0)
                {
                    int lastDigit = currentNumber % 10;

                    if (isEven) { evenDigitsSum += lastDigit; }
                    else { oddDigitsSum += lastDigit; }

                    isEven = !isEven;
                    currentNumber /= 10;
                }
                if (oddDigitsSum == evenDigitsSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
