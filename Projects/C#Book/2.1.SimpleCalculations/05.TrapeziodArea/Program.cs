using System;

namespace _05.TrapeziodArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = (a + b) * h / 2.0;
            Console.WriteLine("Trapezoid area = " + area);
        }
    }
}
