using System;

namespace _01.BirthdayParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal rentOfHall = decimal.Parse(Console.ReadLine());

            decimal cakePrice = rentOfHall * 0.20m;
            decimal drinksPrice = cakePrice * 0.55m;
            decimal animator = rentOfHall / 3;

            decimal sumOfAll = rentOfHall + cakePrice + drinksPrice + animator;

            Console.WriteLine(sumOfAll);
        }
    }
}
