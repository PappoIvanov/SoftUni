using System;

namespace _01.SeriesCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int SeasonsCount = int.Parse(Console.ReadLine());
            int episodesCount = int.Parse(Console.ReadLine());
            double timeOfEpisode = double.Parse(Console.ReadLine());

            double fullTimeEpisode = timeOfEpisode * 1.20;
            double lastEpisodesFullTime = SeasonsCount * 10;
            double sumOfTimeOfAllEpisodes = (fullTimeEpisode * episodesCount) * SeasonsCount + lastEpisodesFullTime;

            Console.WriteLine($"Total time needed to watch the {movieName} series is {Math.Floor(sumOfTimeOfAllEpisodes)} minutes.");
        }
    }
}
