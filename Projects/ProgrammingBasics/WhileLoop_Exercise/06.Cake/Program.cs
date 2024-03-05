using System;

namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeA = int.Parse(Console.ReadLine());
            int sizeB = int.Parse(Console.ReadLine());
            int sumOfPieces = sizeA * sizeB;

            while (true)
            {
                string command = Console.ReadLine();

                if (command != "STOP")
                {
                    int pieceSize = int.Parse(command);
                    sumOfPieces -= pieceSize;

                    if (sumOfPieces <= 0)
                    {
                        Console.WriteLine($"No more cake left! You need {Math.Abs(sumOfPieces)} pieces more.");
                        break;
                    }
                }
                else
                {
                    if (sumOfPieces > 0)
                    {
                        Console.WriteLine($"{sumOfPieces} pieces are left.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"No more cake left! You need {Math.Abs(sumOfPieces)} pieces more.");
                        break;
                    }
                }

            }

        }
    }
}
