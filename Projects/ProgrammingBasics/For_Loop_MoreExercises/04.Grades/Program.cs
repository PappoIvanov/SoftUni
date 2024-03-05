using System;

namespace _04.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            int groupTopOfStudents = 0;
            int groupOfGoodStudents = 0;
            int groupOfAverageStudents = 0;
            int groupOfBadStudents = 0;
            double sumOfAllGrades = 0;

            for (int i = 1; i <= countOfStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade <= 2.99)
                {
                    groupOfBadStudents++;
                    sumOfAllGrades += grade;
                }
                else if (grade <= 3.99)
                {
                    groupOfAverageStudents++;
                    sumOfAllGrades += grade;
                }
                else if (grade <= 4.99)
                {
                    groupOfGoodStudents++;
                    sumOfAllGrades += grade;
                }
                else if (grade >= 5.00)
                {
                    groupTopOfStudents++;
                    sumOfAllGrades += grade;
                }
            }

            Console.WriteLine($"Top students: {(double)groupTopOfStudents / countOfStudents * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(double)groupOfGoodStudents / countOfStudents * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(double)groupOfAverageStudents / countOfStudents * 100:f2}%");
            Console.WriteLine($"Fail: {(double)groupOfBadStudents / countOfStudents * 100:f2}%");
            Console.WriteLine($"Average: {sumOfAllGrades / countOfStudents:f2}");
        }
    }
}
