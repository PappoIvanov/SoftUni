using System;
using System.Reflection.PortableExecutable;

namespace _06.EasterCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int easterCakesCount = int.Parse(Console.ReadLine());
            int sumOfGrades = 0;
            string chefsName = "";
            int lastShefsGrade = 0;
            string lastChefsName = "";
            int biggestGrade = int.MinValue;

            for (int numberOfCycles = 1; numberOfCycles <= easterCakesCount; numberOfCycles++)
            {
                chefsName = Console.ReadLine();
                string gradeOfCake = Console.ReadLine();

                while (gradeOfCake != "Stop")
                {
                    
                    int realGradeOfCake = int.Parse(gradeOfCake);
                    sumOfGrades += realGradeOfCake;

                    gradeOfCake = Console.ReadLine();
                }

                Console.WriteLine($"{chefsName} has {sumOfGrades} points.");

                if (sumOfGrades > lastShefsGrade)
                {
                    Console.WriteLine($"{chefsName} is the new number 1!");
                    lastChefsName = chefsName;
                    if (biggestGrade < sumOfGrades) { biggestGrade = sumOfGrades; }
                }
                lastShefsGrade = sumOfGrades;

                sumOfGrades = 0;
            }

            Console.WriteLine($"{lastChefsName} won competition with {biggestGrade} points!");
        }
    }
}