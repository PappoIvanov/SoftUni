using System;

namespace _06.FavoriteMovie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int sumOfDigits = 0, movieCounter = 0, mostPointsMovie = int.MinValue;
            string currentMovieName = "";

            while (movieName != "STOP")
            {
                movieCounter++;
                if (movieCounter == 7)
                {
                    Console.WriteLine("The limit is reached.");
                    Console.WriteLine($"The best movie for you is {currentMovieName} with {mostPointsMovie} ASCII sum.");
                    break;
                }

                for (int i = 0; i < movieName.Length; i++)
                {
                    int nameDigits = movieName.Length;

                    char currentSymbol = movieName[i];
                    int currentSymbolAsciiValue = (int)currentSymbol;

                    if (currentSymbol >= 'a' && currentSymbol <= 'z')
                    {
                        currentSymbolAsciiValue -= 2 * nameDigits;
                    }
                    else if (currentSymbol >= 'A' && currentSymbol <= 'Z')
                    {
                        currentSymbolAsciiValue -= nameDigits;
                    }

                    sumOfDigits += currentSymbolAsciiValue;
                }

                if (sumOfDigits > mostPointsMovie)
                {
                    mostPointsMovie = sumOfDigits;
                    currentMovieName = movieName;
                }

                movieName = Console.ReadLine();

                if (movieName == "STOP")
                {
                    Console.WriteLine($"The best movie for you is {currentMovieName} with {mostPointsMovie} ASCII sum.");
                }

                sumOfDigits = 0;
            }
        }
    }
}
