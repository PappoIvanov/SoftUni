using System;

namespace _04.BackIn30Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int afterThirty = minutes + 30;
            if (afterThirty > 60)
            {
                hours++;
                if (hours == 24)
                {
                    hours = 0;
                }
                afterThirty = afterThirty % 60;
                Console.WriteLine($"{hours}:{afterThirty:d2}");
            }
            else
            {
                Console.WriteLine($"{hours}:{afterThirty:d2}");
            }
        }
    }
}
