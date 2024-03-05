using System;

namespace _04.Sequence2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int i = 1;

            while (i <= number)
            {

               Console.WriteLine(i);

                i = i * 2 + 1;
            }
        }
    }
}
