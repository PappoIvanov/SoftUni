using System;

namespace _07.FootballLeague
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int countOfFans = int.Parse(Console.ReadLine());
            int aSector = 0;
            int bSector = 0;
            int vSector = 0;
            int gSector = 0;

            for (int i = 0; i < countOfFans; i++)
            {
                string sector = Console.ReadLine();

                switch (sector)
                {
                    case "A": aSector++; break;
                    case "B": bSector++; break;
                    case "V": vSector++; break;
                    case "G": gSector++; break;
                }
            }

            Console.WriteLine($"{(double)aSector / countOfFans * 100:f2}%");
            Console.WriteLine($"{(double)bSector / countOfFans * 100:f2}%");
            Console.WriteLine($"{(double)vSector / countOfFans * 100:f2}%");
            Console.WriteLine($"{(double)gSector / countOfFans * 100:f2}%");
            Console.WriteLine($"{(double)countOfFans / stadiumCapacity * 100:f2}%");
        }
    }
}
