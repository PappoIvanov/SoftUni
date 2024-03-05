using System;

namespace _02.EnglishNameOfTheLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            number %= 10;

            Console.WriteLine(number == 0 ? "zero" : number == 1 ? "one" : number == 2 ? "two" : number == 3 ? "three" : number == 4 ? "four" :
                number == 5 ? "five" : number == 6 ? "six" : number == 7 ? "seven" : number == 8 ? "eight" : "nine");
        }
    }
}
