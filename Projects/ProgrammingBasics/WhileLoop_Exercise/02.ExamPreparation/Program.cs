using System;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badCratesNumber = int.Parse(Console.ReadLine());
            string taskName = Console.ReadLine();
            string lastTask = "";
            int badGrades = 0;
            double gradeSum = 0;
            int taskCounter = 0;

            while (true)
            {
                if (taskName == "Enough")
                {
                    break;
                }

                int gradeOfTask = int.Parse(Console.ReadLine());
                lastTask = taskName;
                taskCounter++;
                gradeSum += gradeOfTask;

                if (gradeOfTask <= 4)
                {
                    badGrades++;
                }
                if (badGrades >= badCratesNumber)
                {
                    break;
                }

                taskName = Console.ReadLine();
            }

            if (taskName == "Enough")
            {
                Console.WriteLine($"Average score: {gradeSum / taskCounter:f2}");
                Console.WriteLine($"Number of problems: {taskCounter}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
            else
            {
                Console.WriteLine($"You need a break, {badGrades} poor grades."); 
            }

        }
    }
}
