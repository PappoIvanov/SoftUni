﻿using System;

namespace _03.PassedOrFailed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gradeInput = double.Parse(Console.ReadLine());

            if (gradeInput > 2.99)
            {
                Console.WriteLine("Passed!");
            }
            else { Console.WriteLine("Failed!"); }
        }
    }
}
