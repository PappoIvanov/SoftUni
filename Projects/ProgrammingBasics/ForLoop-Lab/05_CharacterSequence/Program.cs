using System;

namespace _05_CharacterSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                char symbol = word[i];
                Console.WriteLine(symbol);
            }
        }
    }
}
