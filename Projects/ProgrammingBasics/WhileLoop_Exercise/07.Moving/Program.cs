using System;

namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int volumeOfRoom = lenght * width * height;

            while (true)
            {
                string command = Console.ReadLine();

                if (command != "Done")
                {
                    int box = int.Parse(command);
                    volumeOfRoom -= box;

                    if (volumeOfRoom <= 0)
                    {
                        Console.WriteLine($"No more free space! You need {Math.Abs(volumeOfRoom)} Cubic meters more.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"{volumeOfRoom} Cubic meters left.");
                    break;
                }
            }

        }
    }
}
