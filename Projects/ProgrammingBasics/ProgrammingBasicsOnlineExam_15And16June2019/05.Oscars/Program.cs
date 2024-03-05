using System;

namespace _05.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorsName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int countOfJudges = int.Parse(Console.ReadLine());
            double nameLenght = 0, amountOfPoints = academyPoints;
            bool needMorePoints = false;

            while (countOfJudges > 0)
            {
                double currentPointsForTheActor = 0;
                string judgeName = Console.ReadLine();
                nameLenght = judgeName.Length;

                double judgePoints = double.Parse(Console.ReadLine());

                currentPointsForTheActor = judgePoints * nameLenght / 2;

                amountOfPoints += currentPointsForTheActor;

                if (amountOfPoints >= 1250.5) 
                { 
                    Console.WriteLine($"Congratulations, {actorsName} got a nominee for leading role with {amountOfPoints:f1}!"); 
                    needMorePoints = true;
                    break; 
                }

                countOfJudges--;
            }

            if (!needMorePoints)
            {
                double neededPoints = 1250.5 - amountOfPoints;
                Console.WriteLine($"Sorry, {actorsName} you need {neededPoints:f1} more!");
            }
            
        }
    }
}
