using System;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheActor = Console.ReadLine();
            double pointsOfTheAcademy = double.Parse(Console.ReadLine());
            int countsOfJudges = int.Parse(Console.ReadLine());
            double judgesPoints = 0;
            double amountOfPoints = 0;

            for (int i = 1; i <= countsOfJudges; i++)
            {
                string nameOfTheJudge = Console.ReadLine();
                double pointOfTheJudge = double.Parse(Console.ReadLine());
                judgesPoints += (nameOfTheJudge.Length) * pointOfTheJudge / 2;
                amountOfPoints = pointsOfTheAcademy + judgesPoints;

                if (amountOfPoints > 1250.5)
                    break;
            }

            if (amountOfPoints <= 1250.5)
            {
                double neededPoints = 1250.5 - amountOfPoints;
                Console.WriteLine($"Sorry, {nameOfTheActor} you need {neededPoints:f1} more!");
            }
            else
            {
                Console.WriteLine($"Congratulations, {nameOfTheActor} got a nominee for leading role with {amountOfPoints:f1}!");
            }
        }
    }
}
