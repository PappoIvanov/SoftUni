using System;

namespace _06.VetParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfDays = int.Parse(Console.ReadLine());
            int countOfHours = int.Parse(Console.ReadLine());
            double payment = 0;
            double totalPayment = 0;


            for (int i = 1; i <= countOfDays; i++) 
            {
                switch (i)
                {
                    case 1:
                        for (int j = 1; j <= countOfHours; j++)
                        {
                            if (j % 2 == 0) { payment += 1.25; }
                            else { payment += 1.0; }
                        }
                        Console.WriteLine($"Day: 1 - {payment:f2} leva");
                        totalPayment += payment;
                        payment = 0;
                        break;
                    case 2:
                        for (int j = 1;j <= countOfHours; j++)
                        {
                            if (j % 2 == 0) { payment += 1; }
                            else { payment += 2.50; }
                        }
                        Console.WriteLine($"Day: 2 - {payment:f2} leva");
                        totalPayment += payment;
                        payment = 0;
                        break;
                    case 3:
                        for (int j = 1;j <=countOfHours; j++)
                        {
                            if (j % 2 == 0) { payment += 1.25; }
                            else { payment += 1.0; }
                        }
                        Console.WriteLine($"Day: 3 - {payment:f2} leva");
                        totalPayment += payment;
                        payment = 0;
                        break;
                    case 4:
                        for (int j = 1;j <=countOfHours; j++)
                        {
                            if (j % 2 == 0) { payment += 1; }
                            else { payment += 2.50; }
                        }
                        Console.WriteLine($"Day: 4 - {payment:f2} leva");
                        totalPayment += payment;
                        payment = 0;
                        break;
                    case 5:
                        for (int j = 1; j <=countOfHours; j++)
                        {
                            if (j % 2 == 0) { payment += 1.25; }
                            else { payment += 1.0; }
                        }
                        Console.WriteLine($"Day: 5 - {payment:f2} leva");
                        totalPayment += payment;
                        payment = 0;
                        break;
                }
            }

            Console.WriteLine($"Total: {totalPayment:f2} leva");
        }
    }
}