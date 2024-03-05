using System;

namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            double budgetJohn = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            // Calculations
            
            double totalLightSabersPrice = lightsaberPrice * Math.Ceiling(countOfStudents * 1.10);
            double totalRobesPrice = robePrice * countOfStudents;

            int beltCounter = countOfStudents / 6;

            double totalBeltsPrice = beltPrice * (countOfStudents - beltCounter);
            double sumOfEquipment = totalLightSabersPrice + totalRobesPrice + totalBeltsPrice;

            // Output
            if (budgetJohn >= sumOfEquipment)
            {
                Console.WriteLine($"The money is enough - it would cost {sumOfEquipment:f2}lv.");
            }
            else if (budgetJohn < sumOfEquipment)
            {
                double neededMoney = sumOfEquipment - budgetJohn;
                Console.WriteLine($"John will need {neededMoney:f2}lv more.");
            }
        }
    }
}
