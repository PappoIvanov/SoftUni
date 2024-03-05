using System;

namespace _05.DivisionWithoutReminder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            int devidedByTwoCounter = 0;
            int devidedByThreeCounter = 0;
            int devidedByFourCounter = 0;

            for (int i = 0; i < countOfNumbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber % 2 == 0) { devidedByTwoCounter++; }
                if (currentNumber % 3 == 0) { devidedByThreeCounter++; }
                if (currentNumber % 4 == 0) { devidedByFourCounter++; }
            }

            Console.WriteLine($"{(double)devidedByTwoCounter / countOfNumbers * 100:f2}%");
            Console.WriteLine($"{(double)devidedByThreeCounter / countOfNumbers * 100:f2}%");
            Console.WriteLine($"{(double)devidedByFourCounter / countOfNumbers * 100:f2}%");
        }
    }
}