using System;

namespace _08.TriangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            Console.WriteLine((a * h) / 2);
        }
    }
}
