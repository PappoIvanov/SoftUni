using System;

namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupOfClimbers = int.Parse(Console.ReadLine());
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            int group4 = 0;
            int group5 = 0;
            int countOfClimbers = 0;

            for (int i = 1; i <= groupOfClimbers; i++)
            {
                int numberOfClimbers = int.Parse(Console.ReadLine());

                if (numberOfClimbers <= 5)
                {
                    group1 += numberOfClimbers;
                    countOfClimbers += numberOfClimbers;
                }
                else if (numberOfClimbers > 5 && numberOfClimbers <= 12)
                {
                    group2 += numberOfClimbers;
                    countOfClimbers += numberOfClimbers;
                }
                else if (numberOfClimbers > 12 && numberOfClimbers <= 25)
                {
                    group3 += numberOfClimbers;
                    countOfClimbers += numberOfClimbers;
                }
                else if (numberOfClimbers > 25 && numberOfClimbers <= 40)
                {
                    group4 += numberOfClimbers;
                    countOfClimbers += numberOfClimbers;
                }
                else if (numberOfClimbers > 40)
                {
                    group5 += numberOfClimbers;
                    countOfClimbers += numberOfClimbers;
                }
            }

            Console.WriteLine($"{(double)group1 / countOfClimbers * 100:f2}%");
            Console.WriteLine($"{(double)group2 / countOfClimbers * 100:f2}%");
            Console.WriteLine($"{(double)group3 / countOfClimbers * 100:f2}%");
            Console.WriteLine($"{(double)group4 / countOfClimbers * 100:f2}%");
            Console.WriteLine($"{(double)group5 / countOfClimbers * 100:f2}%");
        }
    }
}
