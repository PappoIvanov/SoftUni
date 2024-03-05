using System;

namespace _06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            double numberTwo = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            double sum = 0;

            switch (symbol)
            {
                case '+': sum = numberOne + numberTwo;
                    if (sum % 2 == 0) Console.WriteLine($"{numberOne} + {numberTwo} = {sum} - even");
                    else { Console.WriteLine($"{numberOne} + {numberTwo} = {sum} - odd"); } break;

                case '-': sum = (numberOne - numberTwo);
                    if (sum % 2 == 0) Console.WriteLine($"{numberOne} - {numberTwo} = {sum} - even");
                    else { Console.WriteLine($"{numberOne} - {numberTwo} = {sum} - odd"); } break;

                case '*': sum = numberOne * numberTwo;
                    if (sum % 2 == 0) Console.WriteLine($"{numberOne} * {numberTwo} = {sum} - even");
                    else { Console.WriteLine($"{numberOne} * {numberTwo} = {sum} - odd"); } break;

                case '/': sum = numberOne / numberTwo;
                    if (numberTwo == 0) Console.WriteLine($"Cannot divide {numberOne} by zero");
                    else { Console.WriteLine($"{numberOne} / {numberTwo} = {sum:f2}"); } break;

                case '%':
                    sum = numberOne % numberTwo;
                    if (numberTwo == 0) Console.WriteLine($"Cannot divide {numberOne} by zero");
                    else { Console.WriteLine($"{numberOne} % {numberTwo} = {sum}"); }
                    break;
            }
        }
    }
}
