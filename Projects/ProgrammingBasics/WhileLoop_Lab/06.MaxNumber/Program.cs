using System;

namespace _06.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int biggestNumber = int.MinValue;

            while (number != "Stop")
            {
                int currentNumber = int.Parse(number);

                if (currentNumber > biggestNumber)
                {
                    biggestNumber = currentNumber;
                }

                number = Console.ReadLine();
            }

            Console.WriteLine(biggestNumber);
        }
    }
}
