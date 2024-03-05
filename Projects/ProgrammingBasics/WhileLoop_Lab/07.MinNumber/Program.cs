using System;

namespace _07.MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int lowestNumber = int.MaxValue;

            while (number != "Stop")
            {
                int currentNumber = int.Parse(number);

                if (currentNumber < lowestNumber)
                {
                    lowestNumber = currentNumber;
                }

                number = Console.ReadLine();
            }

            Console.WriteLine(lowestNumber);
        }
    }
}
