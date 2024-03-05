using System;

namespace _05.CharacterSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string output = Console.ReadLine();

            for (int i = 0; i < output.Length; i++)
            {
                char letter = output[i];

                Console.WriteLine(letter);
            }
        }
    }
}
