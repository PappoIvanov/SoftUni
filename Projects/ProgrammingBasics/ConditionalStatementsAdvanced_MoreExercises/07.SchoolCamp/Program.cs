using System;

namespace _07.SchoolCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeOfGroup = Console.ReadLine();
            int studentsCount = int.Parse(Console.ReadLine());
            int nightsCount = int.Parse(Console.ReadLine());
            decimal sum = 0;

            switch (season)
            {
                case "Winter": 
                    switch (typeOfGroup)
                    {
                        case "girls": sum = studentsCount * 9.60m * nightsCount; 
                            if (studentsCount >= 50)
                            {
                                sum *= 0.5m;
                                Console.WriteLine($"Gymnastics {sum:f2} lv.");
                            }
                            else if (studentsCount >= 20)
                            {
                                sum *= 0.85m;
                                Console.WriteLine($"Gymnastics {sum:f2} lv.");
                            }
                            else if (studentsCount >= 10)
                            {
                                sum *= 0.95m;
                                Console.WriteLine($"Gymnastics {sum:f2} lv.");
                            }
                            else Console.WriteLine($"Gymnastics {sum:f2} lv.");
                            break;

                        case "boys":
                            sum = studentsCount * 9.60m * nightsCount;
                            if (studentsCount >= 50)
                            {
                                sum *= 0.5m;
                                Console.WriteLine($"Judo {sum:f2} lv.");
                            }
                            else if (studentsCount >= 20)
                            {
                                sum *= 0.85m;
                                Console.WriteLine($"Judo {sum:f2} lv.");
                            }
                            else if (studentsCount >= 10)
                            {
                                sum *= 0.95m;
                                Console.WriteLine($"Judo {sum:f2} lv.");
                            }
                            else Console.WriteLine($"Judo {sum:f2} lv.");
                            break;

                        case "mixed":
                            sum = studentsCount * 10.00m * nightsCount;
                            if (studentsCount >= 50)
                            {
                                sum *= 0.5m;
                                Console.WriteLine($"Ski {sum:f2} lv.");
                            }
                            else if (studentsCount >= 20)
                            {
                                sum *= 0.85m;
                                Console.WriteLine($"Ski {sum:f2} lv.");
                            }
                            else if (studentsCount >= 10)
                            {
                                sum *= 0.95m;
                                Console.WriteLine($"Ski {sum:f2} lv.");
                            }
                            else Console.WriteLine($"Ski {sum:f2} lv.");
                            break;
                    } break;

                case "Spring":
                    switch (typeOfGroup)
                    {
                        case "girls":
                            sum = studentsCount * 7.20m * nightsCount;
                            if (studentsCount >= 50)
                            {
                                sum *= 0.5m;
                                Console.WriteLine($"Athletics {sum:f2} lv.");
                            }
                            else if (studentsCount >= 20)
                            {
                                sum *= 0.85m;
                                Console.WriteLine($"Athletics {sum:f2} lv.");
                            }
                            else if (studentsCount >= 10)
                            {
                                sum *= 0.95m;
                                Console.WriteLine($"Athletics {sum:f2} lv.");
                            }
                            else Console.WriteLine($"Athletics {sum:f2} lv.");
                            break;

                        case "boys":
                            sum = studentsCount * 7.20m * nightsCount;
                            if (studentsCount >= 50)
                            {
                                sum *= 0.5m;
                                Console.WriteLine($"Tennis {sum:f2} lv.");
                            }
                            else if (studentsCount >= 20)
                            {
                                sum *= 0.85m;
                                Console.WriteLine($"Tennis {sum:f2} lv.");
                            }
                            else if (studentsCount >= 10)
                            {
                                sum *= 0.95m;
                                Console.WriteLine($"Tennis {sum:f2} lv.");
                            }
                            else Console.WriteLine($"Tennis {sum:f2} lv.");
                            break;

                        case "mixed":
                            sum = studentsCount * 9.50m * nightsCount;
                            if (studentsCount >= 50)
                            {
                                sum *= 0.5m;
                                Console.WriteLine($"Cycling {sum:f2} lv.");
                            }
                            else if (studentsCount >= 20)
                            {
                                sum *= 0.85m;
                                Console.WriteLine($"Cycling {sum:f2} lv.");
                            }
                            else if (studentsCount >= 10)
                            {
                                sum *= 0.95m;
                                Console.WriteLine($"Cycling {sum:f2} lv.");
                            }
                            else Console.WriteLine($"Cycling {sum:f2} lv.");
                            break;
                    } break;
                    
                case "Summer":
                    switch (typeOfGroup)
                    {
                        case "girls":
                            sum = studentsCount * 15.00m * nightsCount;
                            if (studentsCount >= 50)
                            {
                                sum *= 0.5m;
                                Console.WriteLine($"Volleyball {sum:f2} lv.");
                            }
                            else if (studentsCount >= 20)
                            {
                                sum *= 0.85m;
                                Console.WriteLine($"Volleyball {sum:f2} lv.");
                            }
                            else if (studentsCount >= 10)
                            {
                                sum *= 0.95m;
                                Console.WriteLine($"Volleyball {sum:f2} lv.");
                            }
                            else Console.WriteLine($"Volleyball {sum:f2} lv.");
                            break;

                        case "boys":
                            sum = studentsCount * 15.00m * nightsCount;
                            if (studentsCount >= 50)
                            {
                                sum *= 0.5m;
                                Console.WriteLine($"Football {sum:f2} lv.");
                            }
                            else if (studentsCount >= 20)
                            {
                                sum *= 0.85m;
                                Console.WriteLine($"Football {sum:f2} lv.");
                            }
                            else if (studentsCount >= 10)
                            {
                                sum *= 0.95m;
                                Console.WriteLine($"Football {sum:f2} lv.");
                            }
                            else Console.WriteLine($"Football {sum:f2} lv.");
                            break;

                        case "mixed":
                            sum = studentsCount * 20.00m * nightsCount;
                            if (studentsCount >= 50)
                            {
                                sum *= 0.5m;
                                Console.WriteLine($"Swimming {sum:f2} lv.");
                            }
                            else if (studentsCount >= 20)
                            {
                                sum *= 0.85m;
                                Console.WriteLine($"Swimming {sum:f2} lv.");
                            }
                            else if (studentsCount >= 10)
                            {
                                sum *= 0.95m;
                                Console.WriteLine($"Swimming {sum:f2} lv.");
                            }
                            else Console.WriteLine($"Swimming {sum:f2} lv.");
                            break;
                    } break;
            }

        }
    }
}
