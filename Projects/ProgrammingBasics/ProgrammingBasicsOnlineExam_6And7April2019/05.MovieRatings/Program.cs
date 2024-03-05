using System;

namespace _05.MovieRatings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfMovies = int.Parse(Console.ReadLine());
            double maxMovieRating = double.MinValue;
            double minMovieRating = double.MaxValue;
            string bestMovieName = "";
            string worstMovieName = "";
            double averageRating = 0;

            for (int numberOfCycles = 0; numberOfCycles < countOfMovies; numberOfCycles++)
            {
                string movieName = Console.ReadLine();
                double movieRating = double.Parse(Console.ReadLine());
                averageRating += movieRating;

                if (movieRating > maxMovieRating)
                {
                    bestMovieName = movieName;
                    maxMovieRating = movieRating;
                }
                if (movieRating < minMovieRating)
                {
                    worstMovieName = movieName;
                    minMovieRating = movieRating;
                }

            }

            Console.WriteLine($"{bestMovieName} is with highest rating: {maxMovieRating:F1}");
            Console.WriteLine($"{worstMovieName} is with lowest rating: {minMovieRating:F1}");
            Console.WriteLine($"Average rating: {averageRating / countOfMovies:f1}");
        }
    }
}
