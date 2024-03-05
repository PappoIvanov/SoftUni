using System;

namespace _01.ReadText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();

            while (words != "Stop")
            {
                Console.WriteLine(words);

                words = Console.ReadLine();
            }
        }
    }
}
