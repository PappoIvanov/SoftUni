using System;

namespace _04.Renovation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hightOfWall = int.Parse(Console.ReadLine());
            int lenghtOfWall = int.Parse(Console.ReadLine());
            int percentOfNonPaintableSquare = int.Parse(Console.ReadLine());

            int squareOfWall = hightOfWall * lenghtOfWall * 4, litersOfPaint = 0;
            double wallToBePainted = Math.Ceiling(squareOfWall - (1.0 * squareOfWall * percentOfNonPaintableSquare / 100));

            bool paintLeft = false;

            string command = Console.ReadLine();

            while (command != "Tired!")
            {
                
                litersOfPaint = int.Parse(command);

                if (litersOfPaint > wallToBePainted && wallToBePainted - litersOfPaint <= 0)
                {
                    paintLeft = true;
                    break;
                }
                wallToBePainted -= litersOfPaint;

                if (wallToBePainted <= 0) { break; }

                command = Console.ReadLine();
            }

            if (command == "Tired!") { Console.WriteLine($"{wallToBePainted} quadratic m left."); }

            if (paintLeft)
            {
                if (litersOfPaint > wallToBePainted)  
                { Console.WriteLine($"All walls are painted and you have {litersOfPaint - wallToBePainted} l paint left!"); }
                
            }
            if (wallToBePainted <= 0)
            { Console.WriteLine("All walls are painted! Great job, Pesho!"); }
        }
    }
}
