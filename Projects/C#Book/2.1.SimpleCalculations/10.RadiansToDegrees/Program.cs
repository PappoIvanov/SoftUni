﻿using System;

namespace _10.RadiansToDegrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double degrees = Math.Round(radians * 180 / Math.PI);
            Console.WriteLine(degrees);
        }
    }
}
