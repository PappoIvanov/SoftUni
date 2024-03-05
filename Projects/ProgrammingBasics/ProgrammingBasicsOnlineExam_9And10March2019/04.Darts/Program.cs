using System;
using System.Data;

namespace _04.Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playersName = Console.ReadLine();
            double startingPoints = 301;
            string text = Console.ReadLine();
            int goodShotsCounter = 0;
            int badShotsCounter = 0;
            bool playerWonTheGame = false;
            bool playerRetired = false;

            while (text != "Retire")
            {
                double newPoints = double.Parse(Console.ReadLine());

                switch (text)
                {
                    case "Single":
                        if (startingPoints >= newPoints)
                        {
                            goodShotsCounter++;
                            startingPoints -= newPoints;
                            if (startingPoints == 0)
                            { Console.WriteLine($"{playersName} won the leg with {goodShotsCounter} shots."); playerWonTheGame = true; break; }
                        }
                        else
                        {
                            badShotsCounter++;
                            text = Console.ReadLine();
                            if (text == "Retire")
                            {
                                Console.WriteLine($"{playersName} retired after {badShotsCounter} unsuccessful shots.");
                                playerRetired = true; break;
                            }
                            continue;
                        } break;
                    case "Double":
                        newPoints = newPoints * 2;
                        if (startingPoints >= newPoints)
                        {
                            goodShotsCounter++;
                            startingPoints -= newPoints;
                            if (startingPoints == 0)
                            { Console.WriteLine($"{playersName} won the leg with {goodShotsCounter} shots."); playerWonTheGame = true; break; }
                        }
                        else
                        {
                            badShotsCounter++;
                            text = Console.ReadLine();
                            if (text == "Retire")
                            {
                                Console.WriteLine($"{playersName} retired after {badShotsCounter} unsuccessful shots.");
                                playerRetired = true; break;
                            }
                            continue;
                        } break;
                    case "Triple":
                        newPoints = newPoints * 3;
                        if (startingPoints >= newPoints)
                        {
                            goodShotsCounter++;
                            startingPoints -= newPoints;
                            if (startingPoints == 0)
                            { Console.WriteLine($"{playersName} won the leg with {goodShotsCounter} shots."); playerWonTheGame = true; break; }
                        }
                        else
                        {
                            badShotsCounter++;
                            text = Console.ReadLine();
                            if (text == "Retire")
                            {
                                Console.WriteLine($"{playersName} retired after {badShotsCounter} unsuccessful shots.");
                                playerRetired = true; break;
                            }
                            continue;
                        } break;

                }

                if (playerWonTheGame) break;

                if (playerRetired) break;

                text = Console.ReadLine();
            }
        }
    }
}