using System;
using System.Data;

namespace Diamonds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int left = (number - 1) / 2;
            int right = number / 2;

            for (int rows = 0; rows < (number - 1) / 2; rows++)
            {
                for (int col = 0; col < number; col++)
                {
                    if (col == left ||  col == right)
                    {
                        Console.Write("*");
                    }
                    else { Console.Write("-"); }
                }
                Console.WriteLine();
                left--;
                right++;
            }

            if (number > 1)
            {
                Console.Write("*");
                Console.Write(new string('-', number - 2));
                Console.Write("*");
                Console.WriteLine();
            }
            else if (number <= 1) { Console.Write("*"); }
            

            left = 1;
            right = number - 2;
            for (int rows = 0; rows < (number - 1) / 2; rows++)
            {
                for (int col = 0; col < number; col++)
                {
                    if (col == left || col == right)
                    {
                        Console.Write("*");
                    }
                    else { Console.Write("-"); }
                }
                Console.WriteLine();
                left++;
                right--;
            }
        }
    }
}
