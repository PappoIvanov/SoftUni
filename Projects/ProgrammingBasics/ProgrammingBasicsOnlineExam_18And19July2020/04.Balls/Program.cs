using System;

namespace _04.Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int totalPoints = 0;
            int redBalls = 0, orangeBalls = 0, yellowBalls = 0, whiteBalls = 0, otherColors = 0, blackBalls = 0;

            for (int i = 0; i < number; i++)
            {
                string colorType = Console.ReadLine();

                switch (colorType)
                {
                    case "red": totalPoints += 5; redBalls++; break;
                    case "orange": totalPoints += 10; orangeBalls++; break;
                    case "yellow": totalPoints += 15; yellowBalls++; break;
                    case "white": totalPoints += 20; whiteBalls++; break;
                    case "black": Math.Abs(totalPoints /= 2); blackBalls++; break;
                        default: otherColors++; break;
                }
            }

            Console.WriteLine($"Total points: {totalPoints}");
            Console.WriteLine($"Red balls: {redBalls}");
            Console.WriteLine($"Orange balls: {orangeBalls}");
            Console.WriteLine($"Yellow balls: {yellowBalls}");
            Console.WriteLine($"White balls: {whiteBalls}");
            Console.WriteLine($"Other colors picked: {otherColors}");
            Console.WriteLine($"Divides from black balls: {blackBalls}");

        }
    }
}
