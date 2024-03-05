using System;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string correctPass = "";


            for (int currentSymbol = username.Length - 1; currentSymbol >= 0; currentSymbol--)
            {
                correctPass += username[currentSymbol];
            }

            string password = Console.ReadLine();
            int tries = 0;

            while (password != correctPass)
            {
                tries++;

                if (tries == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }

                Console.WriteLine("Incorrect password. Try again.");

                password = Console.ReadLine();
            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}
