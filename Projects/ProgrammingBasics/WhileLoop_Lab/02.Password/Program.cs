using System;

namespace _02.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string username = Console.ReadLine();
            //string password = Console.ReadLine();

            //string newPassword = Console.ReadLine();

            //while (newPassword != password)
            //{
            //    newPassword = Console.ReadLine();

            //    if (newPassword == username)
            //    {
            //        break;
            //    }
            //}

            //Console.WriteLine($"Welcome {username}!");


            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != password)
            {
                input = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {username}!");
        }
    }
}
