using System;

namespace _05.EasterEggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPaintedEggs = int.Parse(Console.ReadLine());
            int redEggsCounter = 0;
            int orangeEggsCounter = 0;
            int blueEggsCounter = 0;
            int greenEggsCounter = 0;
            string maxEggsPaint = "";

            for (int numberOfCycles = 0; numberOfCycles < countOfPaintedEggs; numberOfCycles++)
            {
                string typeOfPaint = Console.ReadLine();

                switch (typeOfPaint)
                {
                    case "red": redEggsCounter++; break;
                    case "orange": orangeEggsCounter++; break;
                    case "blue": blueEggsCounter++; break;
                    case "green": greenEggsCounter++; break;
                }
            }

            Console.WriteLine($"Red eggs: {redEggsCounter}");
            Console.WriteLine($"Orange eggs: {orangeEggsCounter}");
            Console.WriteLine($"Blue eggs: {blueEggsCounter}");
            Console.WriteLine($"Green eggs: {greenEggsCounter}");

            if (redEggsCounter > orangeEggsCounter && redEggsCounter > blueEggsCounter && redEggsCounter > greenEggsCounter)
                Console.WriteLine($"Max eggs: {redEggsCounter} -> red");

            else if (orangeEggsCounter > redEggsCounter && orangeEggsCounter > blueEggsCounter && orangeEggsCounter > greenEggsCounter)
                Console.WriteLine($"Max eggs: {orangeEggsCounter} -> orange");
            
            else if (blueEggsCounter > redEggsCounter && blueEggsCounter > orangeEggsCounter && blueEggsCounter > greenEggsCounter)
                Console.WriteLine($"Max eggs: {blueEggsCounter} -> blue");
            
            else if (greenEggsCounter > redEggsCounter && greenEggsCounter > orangeEggsCounter && greenEggsCounter > blueEggsCounter)
                Console.WriteLine($"Max eggs: {greenEggsCounter} -> green");
        }
    }
}