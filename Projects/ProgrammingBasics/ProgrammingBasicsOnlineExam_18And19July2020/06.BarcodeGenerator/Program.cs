using System;

namespace _06.BarcodeGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int firstDigitFirstNumber = firstNumber / 1000;
            int secondDigitFirstNumber = firstNumber / 100 % 10;
            int thirdDigitFirstNumber = firstNumber / 10 % 10;
            int fourthDigitFirstNumber = firstNumber % 10;

            int firstDigitSecondNumber = secondNumber / 1000;
            int secondDigitSecondNumber = secondNumber / 100 % 10;
            int thirdDigitSecondNumber = secondNumber / 10 % 10;
            int fourthDigitSecondNumber = secondNumber % 10;

            for (int i = firstDigitFirstNumber; i <= firstDigitSecondNumber; i++)
            {
                for (int j = secondDigitFirstNumber; j <= secondDigitSecondNumber; j++)
                {
                    for (int k = thirdDigitFirstNumber; k <= thirdDigitSecondNumber; k++)
                    {
                        for(int l = fourthDigitFirstNumber; l <= fourthDigitSecondNumber; l++)
                        {
                            if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && l % 2 != 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
