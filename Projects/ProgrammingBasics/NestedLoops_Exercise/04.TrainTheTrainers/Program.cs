using System;

namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfJudges = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();
            double grades = 0, gradesOfAllPresentation = 0;
            int countOfAllGrades = 0;


            while (presentationName != "Finish")
            {
                double gradeForCurrentPresentation = 0;

                for (int i = 1; i <= countOfJudges; i++)
                {
                    grades = double.Parse(Console.ReadLine());

                    gradeForCurrentPresentation += grades;
                    gradesOfAllPresentation += grades;
                    countOfAllGrades++;

                }

                Console.WriteLine($"{presentationName} - {gradeForCurrentPresentation / countOfJudges:f2}.");
                presentationName = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {gradesOfAllPresentation / countOfAllGrades:f2}.");
        }
    }
}
