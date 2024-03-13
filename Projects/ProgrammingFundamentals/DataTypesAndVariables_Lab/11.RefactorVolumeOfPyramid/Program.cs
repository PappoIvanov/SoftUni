using System;

namespace _11.RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main()
        {
            double lenght = double.Parse(Console.ReadLine());
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double volume = (lenght * widht * height) / 3;
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:f2}");
        }
    }
}
