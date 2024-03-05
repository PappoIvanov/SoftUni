using System;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int form = 1;
            double averageGrade = 0;
            int badGrades = 0;

            while (form <= 12)
            {
                if (badGrades == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {form} grade");
                    break;
                }

                double grade = double.Parse(Console.ReadLine());

                if (grade < 4)
                {
                    badGrades++;
                    continue;
                }

                averageGrade += grade;
                form++;
            }

            if (form > 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade / 12:f2}");
            }
        }
    }
}
