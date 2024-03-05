using System;

namespace _08.EqualPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool numberRead = false;
            int lastPrintedNumber = 0;

            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write($"{++lastPrintedNumber} ");

                    if (lastPrintedNumber == number)
                    {
                        numberRead = true;
                        break;
                    }
                }

                if (numberRead)
                {
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}
