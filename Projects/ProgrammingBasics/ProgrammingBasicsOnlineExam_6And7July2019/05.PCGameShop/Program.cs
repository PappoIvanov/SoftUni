using System;
using System.Runtime;

namespace _05.PCGameShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gameCounts = int.Parse(Console.ReadLine());
            int hearthstoneCounter = 0, forniteCounter = 0, overwatchCounter = 0, othersCounter = 0;

            for (int i = 0; i < gameCounts; i++)
            {
                string gameName = Console.ReadLine();

                switch (gameName)
                {
                    case "Hearthstone": hearthstoneCounter++; break;
                    case "Fornite": forniteCounter++; break;
                    case "Overwatch": overwatchCounter++; break;
                    default: othersCounter++; break;
                }
            }

            Console.WriteLine($"Hearthstone - {(double)hearthstoneCounter / gameCounts * 100:f2}%");
            Console.WriteLine($"Fornite - {(double)forniteCounter / gameCounts * 100:f2}%");
            Console.WriteLine($"Overwatch - {1.0 * overwatchCounter / gameCounts * 100:f2}%");
            Console.WriteLine($"Others - {1.0 * othersCounter / gameCounts * 100:f2}%");
        }
    }
}
