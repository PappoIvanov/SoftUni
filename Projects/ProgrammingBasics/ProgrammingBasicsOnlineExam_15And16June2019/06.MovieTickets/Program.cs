using System;

namespace _06.MovieTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());


            //Calculations
            // Да се отпечатват буквите отговарящи на конкретния аскии код от цифра а1 до цифра а2 - 1 включително
            for (char symbolOne = (char)a1; symbolOne <= a2 - 1; symbolOne++)
            {
                for (int symbolTwo = 1; symbolTwo <= n - 1; symbolTwo++)
                {
                    for (int symbolThree = 1; symbolThree <= n / 2 - 1; symbolThree++)
                    {
                        if (symbolOne % 2 != 0 && (symbolTwo + symbolThree + symbolOne) % 2 != 0)
                        {
                            Console.WriteLine($"{symbolOne}-{symbolTwo}{symbolThree}{(int)symbolOne}");
                        }
                    }
                }
            }
        }
    }
}
