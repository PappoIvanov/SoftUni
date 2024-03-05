using System;

namespace _04.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfGroups = int.Parse(Console.ReadLine());
            double musalaClimbers = 0, montBlancClimbers = 0, kilimanjaroClimbers = 0, k2Climbers = 0, everestClimbers = 0;
            int totalAmountOfClimbers = 0;

            for (int i = 0; i < countOfGroups; i++)
            {
                int numberOfClimbers = int.Parse(Console.ReadLine());

                switch (numberOfClimbers)
                {
                    case <= 5: musalaClimbers += numberOfClimbers; break;
                    case <= 12: montBlancClimbers += numberOfClimbers; break;
                    case <= 25: kilimanjaroClimbers += numberOfClimbers; break;
                    case <= 40: k2Climbers += numberOfClimbers; break;
                    case > 40: everestClimbers += numberOfClimbers; break;
                }
                totalAmountOfClimbers += numberOfClimbers;
            }

            Console.WriteLine($"{musalaClimbers / totalAmountOfClimbers * 100:f2}%");
            Console.WriteLine($"{montBlancClimbers / totalAmountOfClimbers * 100:f2}%");
            Console.WriteLine($"{kilimanjaroClimbers / totalAmountOfClimbers * 100:f2}%");
            Console.WriteLine($"{k2Climbers / totalAmountOfClimbers * 100:f2}%");
            Console.WriteLine($"{everestClimbers / totalAmountOfClimbers * 100:f2}%");
        }
    }
}
