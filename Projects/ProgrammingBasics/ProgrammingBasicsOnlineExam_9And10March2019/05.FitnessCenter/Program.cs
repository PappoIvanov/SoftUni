using System;

namespace _05.FitnessCenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfVisitors = int.Parse(Console.ReadLine());
            int backWorkoutCounter = 0;
            int chestWorkoutCounter = 0;
            int legsWorkoutCounter = 0;
            int absWorkoutCounter = 0;
            int shakeProteinClients = 0;
            int barProteinClients = 0;
            int countOfAthletes = 0;
            int countOfClients = 0;

            for (int numberOfCycles = 1; numberOfCycles <= countOfVisitors; numberOfCycles++)
            {
                string typeOfWorkout = Console.ReadLine();

                switch (typeOfWorkout)
                {
                    case "Back": backWorkoutCounter++; countOfAthletes++; break;
                    case "Chest": chestWorkoutCounter++; countOfAthletes++; break;
                    case "Legs": legsWorkoutCounter++; countOfAthletes++; break;
                    case "Abs": absWorkoutCounter++; countOfAthletes++; break;
                    case "Protein shake": shakeProteinClients++; countOfClients++; break;
                    case "Protein bar": barProteinClients++; countOfClients++; break;
                }
            }

            Console.WriteLine($"{backWorkoutCounter} - back");
            Console.WriteLine($"{chestWorkoutCounter} - chest");
            Console.WriteLine($"{legsWorkoutCounter} - legs");
            Console.WriteLine($"{absWorkoutCounter} - abs");
            Console.WriteLine($"{shakeProteinClients} - protein shake");
            Console.WriteLine($"{barProteinClients} - protein bar");
            Console.WriteLine($"{1.0 * countOfAthletes / countOfVisitors * 100:f2}% - work out");
            Console.WriteLine($"{1.0 * countOfClients / countOfVisitors * 100:f2}% - protein");
        }
    }
}
