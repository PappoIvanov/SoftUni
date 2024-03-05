using System;

namespace _04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int sumOfSteps = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Going home")
                {
                    int spepsInARow = int.Parse(Console.ReadLine());
                    sumOfSteps += spepsInARow;

                    if (sumOfSteps >= 10_000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{sumOfSteps - 10_000} steps over the goal!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{10_000 - sumOfSteps} more steps to reach goal.");
                        break;
                    }
                }

                int stepsInARow = int.Parse(command);
                sumOfSteps += stepsInARow;

                if (sumOfSteps >= 10_000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{sumOfSteps - 10_000} steps over the goal!");
                    break;
                }
            }
        }
    }
}
