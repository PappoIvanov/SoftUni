using System;

namespace _09.CelsiusToFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var celsius = double.Parse(Console.ReadLine());
            var fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine(Math.Round(fahrenheit, 2));
        }
    }
}
