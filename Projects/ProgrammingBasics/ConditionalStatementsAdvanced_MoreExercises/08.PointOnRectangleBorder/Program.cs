﻿using System;

namespace _08.PointOnRectangleBorder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if (x1 < x2 && y1 < y2)
            {
                if (x1 == x && y2 >= y && y >= y1 || x2 == x && y2 >= y && y >= y1)
                {
                    Console.WriteLine("Border");
                }
                else if (y1 == y && x2 >= x && x >= x1 || y2 == y && x2 >= x && x >= x1)
                {
                    Console.WriteLine("Border");
                }
                else
                {
                    Console.WriteLine("Inside / Outside");
                }
            }
        }
    }
}
