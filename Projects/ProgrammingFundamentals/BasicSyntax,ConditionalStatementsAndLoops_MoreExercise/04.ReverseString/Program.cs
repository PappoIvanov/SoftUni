using System;

namespace _04.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reversInput = "";

            for (int symbol = input.Length - 1; symbol >= 0; symbol--)
            {
                reversInput += input[symbol];
            }
            Console.WriteLine(reversInput);
        }
    }
}
