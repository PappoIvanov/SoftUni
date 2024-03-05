using System;

namespace _01.Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string typeOfAge = "";

           if (age >= 0 && age <= 2)
            {
                typeOfAge = "baby";
            }
           else if (age >= 3 && age <= 13)
            {
                typeOfAge = "child";
            }
           else if (age >= 14 && age <= 19)
            {
                typeOfAge = "teenager";
            }
           else if (age >= 20 && age <= 65)
            {
                typeOfAge = "adult";
            }
           else if (age >= 66)
            {
                typeOfAge = "elder";
            }

            Console.WriteLine(typeOfAge);
        }
    }
}
