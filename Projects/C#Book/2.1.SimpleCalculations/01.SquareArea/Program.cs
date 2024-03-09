using System;

namespace _01.SquareArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            var a = int.Parse(Console.ReadLine());
            var area = a * a;
            Console.Write("Square area = ");
            Console.WriteLine(area);
        }
    }
}
