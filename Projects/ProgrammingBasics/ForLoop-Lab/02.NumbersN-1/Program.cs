﻿using System;

namespace _02.NumbersN_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = number ; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
